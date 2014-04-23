using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using FontStyle = System.Drawing.FontStyle;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using MessageBox = System.Windows.Forms.MessageBox;
using Window = Microsoft.Office.Interop.Word.Window;

namespace DebateSidebarWordAddIn
{
    public partial class MainPanel : UserControl
    {
        public Application a = Globals.ThisAddIn.Application;
        private Document d;

        public MainPanel()
        {
            InitializeComponent();

            d = Globals.ThisAddIn.Application.ActiveDocument;


            if (d.Words.Count < 100000)
            {
                populateDoc();
                Macros.refreshTime = DateTime.Now.Minute*60 + DateTime.Now.Second;
                Macros.refreshDocLevel = 2;
            }


            int hLevels = Convert.ToInt32(Properties.Settings.Default.HeadingLevels);

            if (hLevels <= 3)
            {
                bCollapseHeading3.Visible = false;
                collapseToHeading3ToolStripMenuItem.Visible = false;
                bHeading4.Visible = false;
            }
            if (hLevels <= 2)
            {
                bCollapseHeading2.Visible = false;
                collapseToHeading2ToolStripMenuItem.Visible = false;
                bHeading3.Visible = false;
            }
            if (hLevels <= 1)
            {
                bCollapseHeading1.Visible = false;
                bHeading2.Visible = false;
                bExpandAll.Visible = false;
            }


            if (a.Windows.Count == 1 && a.Windows[1].Caption.Contains("Document1"))
                bFilesShow.PerformClick();


        }

        
        private void bSwitchWindows_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag.ToString() == "new")
                a.Documents.Add();
            else 
                a.Windows.get_Item(e.ClickedItem.Tag).Activate();

        }

        private void DropOnDropDownOpening(object sender, EventArgs eventArgs){
        
            bSwitchWindow.DropDownItems.Clear();
            ToolStripItem newDoc = bSwitchWindow.DropDownItems.Add("New");
            newDoc.Tag = "new";
            bSwitchWindow.DropDownItems.Add(new ToolStripSeparator());
            foreach (Window w in a.Windows)
            {
                
                ToolStripItem wd = bSwitchWindow.DropDownItems.Add(w.Caption);
                if (w.Caption.Contains("Speech "))
                    wd.ForeColor = System.Drawing.Color.Crimson;

                wd.Tag = w.Index;
                if (w.Active)
                    wd.Select();

            }
        }


        private void bCopyUSB_Click(object sender, EventArgs e)
        {
            a.ActiveDocument.Save();
            string msg =  a.ActiveDocument.FullName + " Saved \r\n";
            IEnumerable<DriveInfo> drives = DriveInfo.GetDrives()
                .Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);

            if (drives.Count() == 0)
                return;
            for (var i = 0; i < drives.Count(); i++)
            {
                File.Copy(a.ActiveDocument.FullName, drives.ElementAt(i).Name + a.ActiveDocument.Name, true);
                msg += drives.ElementAt(i).Name + a.ActiveDocument.Name + " Copied \r\n";


            }
                MessageBox.Show(msg);
        }



        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Macros.Underline();
        }

        private void highlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Macros.Highlight();
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            Macros.PasteUnformatted();
        }

        private void bReturns_Click(object sender, EventArgs e)
        {
            Macros.RemoveReturns();
        }

        private void bHeading1_Click(object sender, EventArgs e)
        {
            Macros.Heading1();
        }

      
        private void bHeading2_Click(object sender, EventArgs e)
        {
            Macros.Heading2();
        }
        private void bHeading3_Click(object sender, EventArgs e)
        {
            Macros.Heading3();
        }


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SettingsMenu form = new SettingsMenu();
            form.ShowDialog();

        }

        private void bFilesShow_Click(object sender, EventArgs e)
        {
           

            if (bFilesShow.Checked)
            {
                treeFiles.Show();
                treeDoc.Hide();

                populateTub();
            }
            else
            {

                treeFiles.Hide();
                treeDoc.Show();

            }

            
        }

        private TreeNode selNode ;

        private void treeFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null) 
                return;
            if (e.Node.Tag == "click")
            {
                SettingsMenu form = new SettingsMenu();
                form.ShowDialog();
                return;
            }

            string filename = e.Node.Tag.ToString();

            if(!File.Exists(filename))
                return;

            if (filename.Contains(".doc") || filename.Contains(".rtf"))
            {
                if (a.Windows.Count == 1 && a.Windows[1].Caption.Contains("Document1"))
                    a.Windows[1].Close(WdSaveOptions.wdDoNotSaveChanges);
            
                Document o = a.Documents.Open(filename, AddToRecentFiles: true);
                
                if (o.Words.Count < 100000)
                    populateDoc();
            }
            else
                Process.Start(filename);
        }





       
        public  void populateDoc()
        {
            if (!treeDoc.Visible)
            {
                bFilesShow.PerformClick();
            }

            int level = Convert.ToInt32(Properties.Settings.Default.HeadingLevels);

           

            a.ScreenUpdating = false;
          
            treeDoc.Nodes.Clear();

            TreeNode node = new TreeNode();
            string x = a.ActiveDocument.Content.WordOpenXML;

            //regex the document xml for headings paragraphs
            //much faster than looping for each paragraph or using the find function for each heading level
            foreach (Match m in Regex.Matches(x, "w:val=\"Heading(?:(?!</w:p>).)*</w:p>", RegexOptions.Multiline))
            {
                string h = m.ToString();

                int l = h.Contains("Heading1")
                    ? 1 : h.Contains("Heading2") ? 2 : h.Contains("Heading3") ? 3 : 4;
                
                //p count
                string i = (Regex.Matches(x.Substring(0, x.IndexOf(h)), "<w:p( |>)").Count - 1).ToString();
                
              
                string t = "";
                foreach (Match mt in Regex.Matches(h, "<w:t(>| xml:space=\"preserve\">)(?:(?!</w:t>).)*</w:t>"))
                {
                    t += mt.ToString().Substring(5, mt.ToString().Length - 11).Replace("xml:space=\"preserve\">", "");
                }


                if (t.Length > 1)
                {

                    if (l == 1)
                    {

                        node = treeDoc.Nodes.Add("",t,1);

                        node.NodeFont = new System.Drawing.Font("Tahoma", (float) 10.0, FontStyle.Bold);
                        node.ForeColor = Color.Black;


                        node.Tag = i;

                    }
                    if (l == 2 && level >= 2)
                    {
                        if (treeDoc.Nodes.Count == 0)
                            treeDoc.Nodes.Add("");



                        node = treeDoc.Nodes[treeDoc.Nodes.Count - 1].Nodes.Add("",t,2);

                        node.NodeFont = new System.Drawing.Font("Tahoma", (float) 10.0, new FontStyle());
                        node.ForeColor = Color.Black;


                        node.Tag = i;

                    }
                    if (l == 3 && level >= 3)
                    {
                        if (treeDoc.Nodes.Count == 0)
                            treeDoc.Nodes.Add("");

                        if (treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode == null)
                            treeDoc.Nodes[treeDoc.Nodes.Count - 1].Nodes.Add("");



                        node = treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode.Nodes.Add(t);


                        node.NodeFont = new System.Drawing.Font("Tahoma", (float) 8.0);
                        node.ForeColor = Color.Black;


                        node.Tag = i;
                    }

                    if (l == 4 && level >= 4)
                    {
                        if (treeDoc.Nodes.Count == 0)
                            treeDoc.Nodes.Add("");

                        if (treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode == null)
                            treeDoc.Nodes[treeDoc.Nodes.Count - 1].Nodes.Add("");


                        if (treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode.LastNode == null)
                            treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode.Nodes.Add("");



                        node = treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode.LastNode.Nodes.Add(t);

                        node.NodeFont = new System.Drawing.Font("Tahoma", (float) 8.0);
                        node.ForeColor = Color.Gray;


                        node.Tag = i;
                    }

                }



            }
            a.ScreenUpdating = true;

            if (Properties.Settings.Default.ShowHeading1)
                treeDoc.ExpandAll();
            else
                treeDoc.CollapseAll();
           
            if (treeDoc.TopNode != null)
                treeDoc.TopNode.EnsureVisible();

            treeDoc.PerformLayout();
        }



        private void bRefreshDocMain_ButtonClick(object sender, EventArgs e)
        {
            
            populateDoc();
        }
        
        private void showToHeading3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeDoc.CollapseAll();
            for (int i = 0; i < treeDoc.Nodes.Count; i++)
                treeDoc.Nodes[i].Expand();
            for (int i = 0; i < treeDoc.Nodes.Count; i++)
                for (int j = 0; j < treeDoc.Nodes[i].Nodes.Count; j++)
                    treeDoc.Nodes[i].Nodes[j].Expand();

        }

        private void showToHeading2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeDoc.CollapseAll();
            for (int i = 0; i < treeDoc.Nodes.Count; i++)
                treeDoc.Nodes[i].Expand();

        }

        private void showToHeading1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeDoc.CollapseAll();

        }


        private void showAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            treeDoc.ExpandAll();

        }



        private string lastClick = "";
        private void treeDoc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (DateTime.Now.ToString() == lastClick)
                return;
            
            lastClick = DateTime.Now.ToString();
           
            selNode = e.Node; 
            int startIndex = Convert.ToInt32(e.Node.Tag) > 0 ? a.ActiveDocument.Paragraphs[Convert.ToInt32(e.Node.Tag)+1].Range.Start : 0;

             int endIndex = e.Node.NextVisibleNode != null && Convert.ToInt32(e.Node.NextVisibleNode.Tag) > 0 ? 
                 a.ActiveDocument.Paragraphs[Convert.ToInt32(e.Node.NextVisibleNode.Tag) + 1].Range.Start
                : a.ActiveDocument.Paragraphs[Convert.ToInt32(e.Node.Tag) + 1].Range.End;

            if (endIndex<startIndex || endIndex > a.ActiveDocument.Content.End)
                endIndex = a.ActiveDocument.Paragraphs[Convert.ToInt32(e.Node.Tag) + 1].Range.End;

               
            Range r = a.ActiveDocument.Range(startIndex, endIndex);
            r.Select();
            a.ActiveWindow.ScrollIntoView(r);

            a.ActiveDocument.ActiveWindow.SetFocus();
           
            //shift focus to word document -- SetFocus doesnt work 
            SendKeys.Send("{F6}{F6}{F6}");

        }

    


        public static string SpeechAddName = "";

        private void bSpeechAdd_Click(object sender, EventArgs e)
        {
            Macros.SpeechAdd();


        }

       

        public void populateTub()
        {

           treeFiles.Nodes.Clear();

            string tubpath = Properties.Settings.Default.FilesDirectory;


            if (Directory.Exists(tubpath) == false)
            {
                treeFiles.Nodes.Add("Double click to set Debate Files path").Tag="click";

                return;

            }

            if (a.RecentFiles.Count >= 3)
            {
                treeFiles.Nodes.Add(a.RecentFiles[1].Name).Tag = a.RecentFiles[1].Path + "\\" + a.RecentFiles[1].Name;
                treeFiles.Nodes.Add(a.RecentFiles[2].Name).Tag = a.RecentFiles[1].Path + "\\" + a.RecentFiles[2].Name;
                treeFiles.Nodes.Add(a.RecentFiles[3].Name).Tag = a.RecentFiles[1].Path + "\\" + a.RecentFiles[3].Name;

                treeFiles.Nodes[0].BackColor = System.Drawing.Color.Cornsilk;
                treeFiles.Nodes[1].BackColor = System.Drawing.Color.Cornsilk;
                treeFiles.Nodes[2].BackColor = System.Drawing.Color.Cornsilk;


                treeFiles.Nodes[0].NodeFont = new System.Drawing.Font(DefaultFont, new FontStyle());
                treeFiles.Nodes[1].NodeFont = new System.Drawing.Font(DefaultFont, new FontStyle());
                treeFiles.Nodes[2].NodeFont = new System.Drawing.Font(DefaultFont, new FontStyle());

            }


            var rootDirectoryInfo = new DirectoryInfo(tubpath);

            try{

                foreach (DirectoryInfo directory in rootDirectoryInfo.GetDirectories())
                    treeFiles.Nodes.Add(addNodeTub(directory));

                TreeNode fileNode = new TreeNode();
                foreach (FileInfo file in rootDirectoryInfo.GetFiles())
                {
                    if (file.Name.Contains("~") == false)
                        fileNode = treeFiles.Nodes.Add(file.Name);

                    fileNode.Tag = file.FullName;
                    fileNode.NodeFont = new System.Drawing.Font(DefaultFont, new FontStyle());
                }

            } catch (Exception err) { }


        }


        private static TreeNode addNodeTub(DirectoryInfo directoryInfo)
        {
            try
            {
                TreeNode fileNode = new TreeNode();
                TreeNode directoryNode = new TreeNode(directoryInfo.Name);
                directoryNode.Tag = directoryInfo.FullName + "\\";
                directoryNode.NodeFont = new System.Drawing.Font(DefaultFont, FontStyle.Bold);
                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                    directoryNode.Nodes.Add(addNodeTub(directory));
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    if (file.Name.Contains("~") == false)
                        fileNode = directoryNode.Nodes.Add(file.Name);

                    fileNode.Tag = file.FullName;
                    fileNode.NodeFont = new System.Drawing.Font(DefaultFont, new FontStyle());
                }
                return directoryNode;
            }
            catch (Exception err)
            {
                return new TreeNode();
            }
        }






        private List<TreeNode> foundNodes = new List<TreeNode>();
        private string foundNodesTerm = "";
        private int foundNodesIndex = 0;
        private TreeNode FindNode(TreeNode rootNode, string stringToFind)
        {
            if (rootNode.Text.ToLower().IndexOf(stringToFind.ToLower()) > -1)
                return rootNode;

            foreach (TreeNode n in rootNode.Nodes)
            {
                if (FindNode(n, stringToFind) != null)
                    foundNodes.Add(n);
            }
            return null;
        }




        private void nodeSearch()
        {

            if (bSearchString.Text.Length == 0) return;

            //if already disp results, go to next
            if (bSearchString.Text.Equals(foundNodesTerm))
            {
                foundNodesIndex++;
                if (foundNodesIndex >= foundNodes.Count)
                    foundNodesIndex = 0;


            } // otherwise do new search
            else
            {
                foundNodesTerm = bSearchString.Text;
                foundNodesIndex = 0;
                foundNodes = new List<TreeNode>();

                foreach (TreeNode n in treeFiles.Nodes)
                {
                    if (FindNode(n, bSearchString.Text) != null)
                        foundNodes.Add(n);
                }

            }



            if (foundNodes.Count == 0) return;


            TreeNode r = foundNodes[foundNodesIndex];


            treeFiles.Focus();
            r.EnsureVisible();
            treeFiles.SelectedNode = r;
            treeFiles.Update();
        }


        private void bSearchString_KeyUp(object sender, KeyEventArgs e)
        {
          
            if (e.KeyValue == 13)
            {
                e.SuppressKeyPress = true;

                if (treeFiles.Visible == true)
                {
                    nodeSearch();
                    bSearchString.Select();
                   
                }
                else
                {

                    Find f = a.Selection.Find;
                    f.ClearFormatting();
                    f.Text = bSearchString.Text;
                    f.Wrap = WdFindWrap.wdFindContinue;


                    f.Execute();

                    a.Selection.Range.Select();
            
                }


            }
        }


        private void bReadSpeech_Click(object sender, EventArgs e)
        {
            Macros.ReadSpeech();
        }

        private void autoHightlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Macros.Highlight();
        }

        private void selectSimilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Macros.SelectSimilar();
        }

        private void caselistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Macros.Caselist();
        }

        private void autoUnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Macros.Underline();
        }

        private void minimizeUnreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Macros.MinimizeUnread();
        }

        private void removeFormattingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Macros.RemoveFormatting();
        }


        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            Macros.SendToSpeech();
        }

        private void sendToSpeechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Macros.SendToSpeech();

        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            populateDoc();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeDoc.CollapseAll();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeDoc.ExpandAll();
        }

        private void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeFiles.ExpandAll();
        }

        private void collapseAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeFiles.CollapseAll();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           string filename = treeFiles.SelectedNode.Tag.ToString();
           
            if (!filename.EndsWith("\\"))
                filename = filename.Substring(0, filename.LastIndexOf("\\"));
            if (File.Exists(filename))
                Process.Start(filename);
        }

        private void bFormattingMain_ButtonClick(object sender, EventArgs e)
        {
            Macros.PasteUnformatted();
        }

     
      

        private void bHeading4_Click(object sender, EventArgs e)
        {
            Macros.Heading4();
        }

        private void promoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (selNode.Tag == null) return;


            int startIndex = Convert.ToInt32(selNode.Tag) > 0 ?
                a.ActiveDocument.Paragraphs[Convert.ToInt32(selNode.Tag) + 1].Range.Start : 0;

            int endIndex = a.ActiveDocument.Paragraphs[Convert.ToInt32(selNode.Tag) + 1].Range.End;


            Range r = a.ActiveDocument.Range(startIndex, endIndex);

            if (r.ParagraphFormat.OutlineLevel != WdOutlineLevel.wdOutlineLevel1)
                r.Paragraphs.OutlinePromote();

            populateDoc();
            if (selNode != null)
                selNode.EnsureVisible();

        }

        private void demoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selNode.Tag == null) return;


            int startIndex = Convert.ToInt32(selNode.Tag) > 0 ?
                a.ActiveDocument.Paragraphs[Convert.ToInt32(selNode.Tag) + 1].Range.Start : 0;

            int endIndex = a.ActiveDocument.Paragraphs[Convert.ToInt32(selNode.Tag) + 1].Range.End;


            Range r = a.ActiveDocument.Range(startIndex, endIndex);

            if (r.ParagraphFormat.OutlineLevel == WdOutlineLevel.wdOutlineLevel4)
                r.Paragraphs.OutlineDemoteToBody();
            else
                r.Paragraphs.OutlineDemote();

            populateDoc();
            if (selNode != null)
                selNode.EnsureVisible();
        }

    
        private void bCollapseHeading2_Click(object sender, EventArgs e)
        {
            treeDoc.CollapseAll();
            for (int i = 0; i < treeDoc.Nodes.Count; i++)
                treeDoc.Nodes[i].Expand();
        }

        private void bCollapseHeading3_Click(object sender, EventArgs e)
        {
            treeDoc.CollapseAll();
            for (int i = 0; i < treeDoc.Nodes.Count; i++)
                treeDoc.Nodes[i].Expand();
            for (int i = 0; i < treeDoc.Nodes.Count; i++)
                for (int j = 0; j < treeDoc.Nodes[i].Nodes.Count; j++)
                    treeDoc.Nodes[i].Nodes[j].Expand();

        }

        private void treeDoc_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            selNode = e.Node;
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string timerPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
                + "\\Debate Sidebar Word Addin\\DebateTimer.exe";

            if (File.Exists(timerPath))
                Process.Start(timerPath);

        }

    }
}