using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;
using Font = System.Drawing.Font;

namespace DebateSidebarWordAddIn
{
    public partial class Sidebar : UserControl
    {
        private Application a = Globals.ThisAddIn.Application;
        private List<TreeNode> foundNodes = new List<TreeNode>();
        private int foundNodesIndex;
        private string foundNodesTerm = "";
        private TreeNode selNode;
        private bool afterExpandSkip = true;
        public int indexLastTime, indexLevel = 1;


        private TreeNode currentNode;

        public Sidebar()
        {
            InitializeComponent();
        }

        //on SELECTION  change only REINDEX TAGS OF ALL AFTERWARDS ENTRIES 

        //update doc map to currently selected heading as the user scrolls
        public void treeDocMap_ChangeSelected(Selection s)
        {
            Range r = a.ActiveDocument.Range(a.ActiveDocument.Content.Start, s.Start);

            int indexH1 = 0, indexH2 = 0, indexH3 = 0, indexH4 = 0;
         
            int i = r.Paragraphs.Count;


            a.StatusBar = "Paragraph #"+i.ToString()+"   Card #"+ indexH4;
            foreach (TreeNode n in treeDoc.Nodes)
                removeBG(n);

            TreeNode n3Current = new TreeNode();
            TreeNode n4Current = new TreeNode();

            foreach (TreeNode n1 in treeDoc.Nodes)
                foreach (TreeNode n2 in n1.Nodes) {
                    foreach (TreeNode n3 in n2.Nodes)
                        if (Convert.ToInt32(n3.Tag) < i+1)
                            n3Current = n3;
                        else
                            break;

                    n3Current.BackColor = Color.LightBlue;


                    foreach (TreeNode n4 in n3Current.Nodes)
                        if (Convert.ToInt32(n4.Tag) < i+1)
                            n4Current = n4;
                        else
                            break;


                    //auto-update heading in doc map
                    if (s.Paragraphs.First.OutlineLevel != WdOutlineLevel.wdOutlineLevelBodyText)
                    {

                        ensureNodeTextCorrect(n4Current);
                        ensureNodeTextCorrect(n4Current.NextVisibleNode);
                        ensureNodeTextCorrect(n4Current.PrevVisibleNode);





                    }


                    n4Current.BackColor = Color.LightCyan;
                    if (n4Current.IsVisible != null)
                    {
                        n4Current.EnsureVisible();
                        treeDoc.Nodes[0].EnsureVisible();
                    }



                }
        }

        private void ensureNodeTextCorrect(TreeNode n) {
            n.Text = a.ActiveDocument.Paragraphs[Convert.ToInt32(n.Tag) + 1].Range.Text.ToString();
        }


        private void removeBG(TreeNode n)
        {
            n.BackColor = Color.White;
            foreach (TreeNode nChildren in n.Nodes)
                removeBG(nChildren);
        }


        //search helper function
        private bool findDocNode(TreeNode rootNode, int i)
    {
        

        foreach (TreeNode n in rootNode.Nodes)
            if (findDocNode(n, i) )
                return true;

        return false;
    }


    //regex the document xml for headings paragraphs
    //much faster than looping for each paragraph or using find 
    public void populateDoc()
        {

            int max = 4;
            TreeNode node = new TreeNode();
            string docx = a.ActiveDocument.Content.WordOpenXML;

            treeDoc.Nodes.Clear();

            int pStart = 0;
            Macros.EscToggle = false;

            
            MatchCollection headings = Regex.Matches(docx, 
                "w:val=\"Heading(?:(?!</w:p>).)*</w:p>", RegexOptions.Multiline);
            int pCount = headings.Count;
            int headingsIndex = 0;


            foreach (Match m in headings)
            {

                string h = m.ToString();


                int l = h.Contains("Heading1") ? 
                    1 : h.Contains("Heading2") ? 
                    2 : h.Contains("Heading3") ? 3 : 4;

                //paragraph count 

                string i = (Regex.Matches(docx.Substring(0, docx.IndexOf(h, pStart)), "<w:p( |>)").Count - 1).ToString();
                
                //need to distinct start index of each paragraph
                //cannot simply assume each paragraph has unique text 
                pStart = docx.IndexOf(h);
                string t = "";
                foreach (Match mt in Regex.Matches(h, "<w:t(>| xml:space=\"preserve\">)(?:(?!</w:t>).)*</w:t>"))
                    t += mt.ToString().Substring(5, mt.ToString().Length - 11).Replace("xml:space=\"preserve\">", "");


                if (t.Length > 1)
                {
                    if (l == 1)
                    {
                        node = treeDoc.Nodes.Add("", t, 1);

                        node.NodeFont = new Font("Tahoma", (float)10, FontStyle.Bold, GraphicsUnit.Point);
                        node.ForeColor = Color.Black;   

                        node.Tag = i;
                    }
                    else if (l == 2 && max >= 2)
                    {
                        if (treeDoc.Nodes.Count == 0)
                            treeDoc.Nodes.Add("");


                        node = treeDoc.Nodes[treeDoc.Nodes.Count - 1].Nodes.Add("", t, 2);

                        node.NodeFont = new Font("Tahoma", (float)10, new FontStyle(), GraphicsUnit.Point);
                        node.ForeColor = Color.Black;


                        node.Tag = i;
                    }
                    else if (l == 3 && max >= 3)
                    {
                        if (treeDoc.Nodes.Count == 0)
                            treeDoc.Nodes.Add("");

                        if (treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode == null)
                            treeDoc.Nodes[treeDoc.Nodes.Count - 1].Nodes.Add("");


                        node = treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode.Nodes.Add(t);


                        node.NodeFont = new Font("Tahoma", (float)9.0, GraphicsUnit.Point);
                        node.ForeColor = Color.Black;


                        node.Tag = i;
                    }
                    else if (l == 4 && max >= 4)
                    {
                        if (treeDoc.Nodes.Count == 0)
                            treeDoc.Nodes.Add("");

                        if (treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode == null)
                            treeDoc.Nodes[treeDoc.Nodes.Count - 1].Nodes.Add("");


                        if (treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode.LastNode == null)
                            treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode.Nodes.Add("");


                        node = treeDoc.Nodes[treeDoc.Nodes.Count - 1].LastNode.LastNode.Nodes.Add(t);

                        node.NodeFont = new Font("Arial", (float)8.0, GraphicsUnit.Point);
                        node.ForeColor = Color.Gray;
                        node.Tag = i;

                    }
                }


                // Flow in Speech COLORS show in Doc Map
                if (h.Contains("*"))
                {
                    node.NodeFont = new Font("Verdana", (float)9.0, GraphicsUnit.Point);

                    node.ForeColor = Color.Gold;

                }


                a.StatusBar = ((int)(100 * ++headingsIndex / pCount)).ToString() + "% indexed [ESC to Stop]";
                System.Windows.Forms.Application.DoEvents();
                if (Macros.EscToggle) break;
            }

            a.StatusBar = ""; 


            //default expand to index
            setIndexLevel(3);


            if (treeDoc.TopNode != null)
                treeDoc.Nodes[0].EnsureVisible();
        }


        //expands to specific headings level 1-4 in Doc Map
        public void setIndexLevel(int indexLevel)
        {

            treeDoc.CollapseAll();

            if (indexLevel == 2)
                foreach (TreeNode n in treeDoc.Nodes)
                {
                    n.Expand();

                }

            if (indexLevel == 3)
            {
                foreach (TreeNode n in treeDoc.Nodes)
                {
                    n.Expand();
                    foreach (TreeNode n2 in n.Nodes)
                        n2.Expand();
                }
            }

            if (indexLevel == 4)
                treeDoc.ExpandAll();

            if (treeDoc.TopNode != null)
                treeDoc.Nodes[0].EnsureVisible();
        }
        private void treeDoc_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            selNode = e.Node;
        }

        private void treeDoc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                selNode = e.Node;
                int tag = Convert.ToInt32(e.Node.Tag)+1;
                TreeNode nextNode = e.Node.NextVisibleNode;
                int startIndex = tag > 1 ? a.ActiveDocument.Paragraphs[tag].Range.Start : 0;

                int endIndex = nextNode != null && Convert.ToInt32(nextNode.Tag) > 0
                    ? a.ActiveDocument.Paragraphs[Convert.ToInt32(nextNode.Tag) + 1].Range.Start
                    : a.ActiveDocument.Paragraphs[tag ].Range.End;

                if (nextNode == null)
                    endIndex = a.ActiveDocument.Content.End;

                if (endIndex < startIndex || endIndex > a.ActiveDocument.Content.End)
                    endIndex = a.ActiveDocument.Paragraphs[tag].Range.End;

                //select text after clicking on DocMap
                    Range r = a.ActiveDocument.Range(startIndex, endIndex);

                if (Properties.Settings.Default.SelectAfterDocMap)
                    r.Select();

                a.ActiveWindow.ScrollIntoView(r);

                a.ActiveDocument.ActiveWindow.SetFocus();

                //shift focus to word document -- SetFocus doesnt work 
                //TODO causes bug where it blinks menubar alt keys descriptions

               // SendKeys.Send("{F6}{F6}{F6}");
            }
            catch (Exception err) { Debug.WriteLine(err); }

        }

        private void treeDoc_AfterExpand(object sender, TreeViewEventArgs e)
        {
            //auto expand blanks
            foreach (TreeNode n in e.Node.Nodes)
                if (n.Text.Length < 1)
                    n.Expand();

        }

        //Docs Folder

        // Docs Folder view - populate with filetree by recursion
        //TODO option  to reindex each doc to get a json map of headings to expand in filetree
        public void populateFiles()
        {
            treeFiles.Nodes.Clear();

            string tubpath = Properties.Settings.Default.FilesDirectory;


            if (!Directory.Exists(tubpath))
            {
                treeFiles.Nodes.Add("Double click for Docs Folder").Tag = "click";

                return;
            }


            //show 3  recent files at the top 
            if (a.RecentFiles.Count >= 3)
                for (int i = 0; i < 3; i++)
                {
                    treeFiles.Nodes.Add(a.RecentFiles[i + 1].Name).Tag =
                        a.RecentFiles[i + 1].Path + "\\" + a.RecentFiles[i + 1].Name;
                    treeFiles.Nodes[i].NodeFont = new Font(DefaultFont, FontStyle.Italic);
                }



            DirectoryInfo rootFolder = new DirectoryInfo(tubpath);

            try
            {
                foreach (DirectoryInfo directory in rootFolder.GetDirectories())
                    treeFiles.Nodes.Add(populateFiles_addNode(directory));

                TreeNode fileNode = new TreeNode();
                foreach (FileInfo file in rootFolder.GetFiles())
                {
                    if (file.Name.Contains("~") == false)
                        fileNode = treeFiles.Nodes.Add(file.Name);

                    fileNode.Tag = file.FullName;
                    fileNode.NodeFont = file.Name.Contains("Speech") ?
                        new Font("Tahoma", (float)10.0) : new Font(DefaultFont, new FontStyle());




                }
            }
            catch (Exception err) { Debug.WriteLine(err); }
        }


        // Docs Folder -- recursion helper
        private static TreeNode populateFiles_addNode(DirectoryInfo directoryInfo)
        {
            try
            {
                TreeNode fileNode = new TreeNode();
                TreeNode directoryNode = new TreeNode(directoryInfo.Name);
                directoryNode.Tag = directoryInfo.FullName + "\\";
                directoryNode.NodeFont = new Font(DefaultFont, FontStyle.Bold);
                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                    directoryNode.Nodes.Add(populateFiles_addNode(directory));
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    if (file.Name.Contains("~") == false)
                        fileNode = directoryNode.Nodes.Add(file.Name);

                    fileNode.Tag = file.FullName;
                    fileNode.NodeFont = new Font(DefaultFont, new FontStyle());
                }
                return directoryNode;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
                return new TreeNode();
            }
        }

        //open file from Docs Folder
        private void treeFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //open Settings if folder not set
            if (e.Node.Tag == null)
                return;
            if (e.Node.Tag.ToString() == "click")
            {

                var form = new Settings();
                form.ShowDialog();

                populateFiles();
                populateDoc();
                return;
            }

            string filename = e.Node.Tag.ToString();

            if (!File.Exists(filename))
                return;


            if (filename.Contains(".doc") || filename.Contains(".rtf"))
            {
                if (a.Windows.Count == 1 && a.Windows[1].Caption.Contains("Document1"))
                {
                    a.Windows[1].Close(WdSaveOptions.wdDoNotSaveChanges);

                    a.Documents.Open(filename, AddToRecentFiles: true)
                        .ActiveWindow.ActivePane.Document.ActiveWindow.DocumentMap = false;

                    populateDoc();


                }
                else
                {
                    a.Documents.Open(filename, AddToRecentFiles: true)
                        .ActiveWindow.ActivePane.Document.ActiveWindow.DocumentMap = false;

                }

            }
            else
                Process.Start(filename);
        }


        //MENUBAR BUTTONS


        //reindex the document
        private void bRefresh_Click(object sender, EventArgs e)
        {
            populateDoc();
            indexLastTime = DateTime.Now.Minute * 60 + DateTime.Now.Second;
        }

        // collapse to heading 1 - 4

        private void bCollapse_Click(object sender, EventArgs e)
        {
            if (treeDoc.Visible)
                treeDoc.CollapseAll();
            else
                treeFiles.CollapseAll();

            if (treeDoc.TopNode != null)
                treeDoc.Nodes[0].EnsureVisible();

            indexLevel = 1;
        }

        private void bCollapseHeading2_Click(object sender, EventArgs e)
        {
            afterExpandSkip = true;

            treeDoc.CollapseAll();
            foreach (TreeNode n in treeDoc.Nodes)
                n.Expand();

            if (treeDoc.TopNode != null)
                treeDoc.Nodes[0].EnsureVisible();

            afterExpandSkip = false;
            indexLevel = 2;
        }

        private void bCollapseHeading3_Click(object sender, EventArgs e)
        {
            afterExpandSkip = true;

            treeDoc.CollapseAll();

            foreach (TreeNode n in treeDoc.Nodes)
            {
                n.Expand();
                foreach (TreeNode n2 in n.Nodes)
                    n2.Expand();
            }

            if (treeDoc.TopNode != null)
                treeDoc.Nodes[0].EnsureVisible();

            afterExpandSkip = false;
            indexLevel = 3;
        }


        // toggle between expanding level 3/4
        public void toggleTagView()
        {

            if (indexLevel == 4)
            {


                afterExpandSkip = true;

                treeDoc.CollapseAll();

                foreach (TreeNode n in treeDoc.Nodes)
                {
                    n.Expand();
                    foreach (TreeNode n2 in n.Nodes)
                        n2.Expand();
                }

                if (treeDoc.TopNode != null)
                    treeDoc.Nodes[0].EnsureVisible();

                afterExpandSkip = false;
                indexLevel = 3;



            }
            else
            {
                treeDoc.ExpandAll();


                if (treeDoc.TopNode != null)
                    treeDoc.Nodes[0].EnsureVisible();

                indexLevel = 4;
            }


        }
        private void bExpand_Click(object sender, EventArgs e)
        {

            toggleTagView();



        }

        //MENUBAR Format & Speech


       

        // Search
        //todo ctrl f
        private void bSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                e.SuppressKeyPress = true;
        }

        private void bSearch_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {

                /// FIRST SEARCH FOLDERS
                if (bSearch.Text.Length == 0) return;

                //if already disp results, go to next
                if (bSearch.Text.Equals(foundNodesTerm))
                {
                    foundNodesIndex++;
                    if (foundNodesIndex >= foundNodes.Count)
                        foundNodesIndex = 0;
                } // otherwise do new search
                else
                {
                    foundNodesTerm = bSearch.Text;
                    foundNodesIndex = 0;
                    foundNodes = new List<TreeNode>();

                    foreach (TreeNode n in treeFiles.Nodes)
                    {
                        if (findNode(n, bSearch.Text) != null)
                            foundNodes.Add(n);
                    }
                }

                //IF FOUND IN FILE-TITLES
                if (foundNodes.Count > 0)
                {


                    TreeNode r = foundNodes[foundNodesIndex];


                    treeFiles.Focus();
                    r.EnsureVisible();
                    treeFiles.SelectedNode = r;
                    treeFiles.Update();
                    bSearch.Select();
                    return;
                }


                // SEARCH THE DOC TEXT
                Find f = a.Selection.Find;
                f.ClearFormatting();
                f.Text = bSearch.Text;
                f.Wrap = WdFindWrap.wdFindContinue;

                f.Execute();

                a.Selection.Range.Select();

            }
        }

        //search helper function
        private TreeNode findNode(TreeNode rootNode, string stringToFind)
        {
            if (rootNode.Text.ToLower().IndexOf(stringToFind.ToLower()) > -1)
                return rootNode;

            foreach (TreeNode n in rootNode.Nodes)
                if (findNode(n, stringToFind) != null)
                    foundNodes.Add(n);

            return null;
        }


        //CONTEXT Headings Index

        private void contextRefresh_Click(object sender, EventArgs e)
        {
            populateDoc();
           // populateFiles();
        }

        //changes heading level up by one ancestor 
        private void contextPromote_Click(object sender, EventArgs e)
        {
            if (selNode.Tag == null) return;


            int startIndex = Convert.ToInt32(selNode.Tag) > 0
                ? a.ActiveDocument.Paragraphs[Convert.ToInt32(selNode.Tag) + 1].Range.Start : 0;

            int endIndex = a.ActiveDocument.Paragraphs[Convert.ToInt32(selNode.Tag) + 1].Range.End;


            Range r = a.ActiveDocument.Range(startIndex, endIndex);

            if (r.ParagraphFormat.OutlineLevel != WdOutlineLevel.wdOutlineLevel1)
                r.Paragraphs.OutlinePromote();

            populateDoc();
            if (selNode != null)
                selNode.EnsureVisible();
        }

        //changes heading level to descendant 
        private void contextDemote_Click(object sender, EventArgs e)
        {
            if (selNode.Tag == null) return;


            int startIndex = Convert.ToInt32(selNode.Tag) > 0
                ? a.ActiveDocument.Paragraphs[Convert.ToInt32(selNode.Tag) + 1].Range.Start
                : 0;

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

        //do not show this paragraph in doc map
        private void contextRemove_Click(object sender, EventArgs e)
        {
            if (selNode.Tag == null) return;


            int startIndex = Convert.ToInt32(selNode.Tag) > 0
                ? a.ActiveDocument.Paragraphs[Convert.ToInt32(selNode.Tag) + 1].Range.Start
                : 0;

            int endIndex = a.ActiveDocument.Paragraphs[Convert.ToInt32(selNode.Tag) + 1].Range.End;


            Range r = a.ActiveDocument.Range(startIndex, endIndex);

            r.Paragraphs.OutlineDemoteToBody();

            r.Select();
            a.Selection.set_Style("Normal");
            a.Selection.ClearFormatting();


            populateDoc();
            if (selNode != null)
                selNode.EnsureVisible();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {

            (new Settings()).ShowDialog();
        }

        //resize 2 panel view on resize 
        private void Sidebar_SizeChanged(object sender, EventArgs e)
        {
            int docsFolderHeight = 280;
            Sidebar s = (Sidebar)sender;

            s.treeDoc.Height = s.Size.Height - docsFolderHeight;

        }

        private void treeDoc_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }



        private void contextStarRating_Click(object sender, EventArgs e)
        {

        }


        //CONTEXT MENU OF DOC MAP - open folder

        private void contextFilesFolder_Click(object sender, EventArgs e)
        {
            string filename = treeFiles.SelectedNode.Tag.ToString();

            if (!filename.EndsWith("\\"))
                filename = filename.Substring(0, filename.LastIndexOf("\\"));
            if (Directory.Exists(filename))
                Process.Start(filename);

        }

        private void contextFilesExpand_Click(object sender, EventArgs e)
        {
            bExpand.PerformClick();
        }


        private void Sidebar_Load(object sender, EventArgs e)
        {
            //DocMap automatic on opening takes too long
            if (Properties.Settings.Default.ExpandHeadings)
            {
                populateDoc();
                indexLastTime = DateTime.Now.Minute * 60 + DateTime.Now.Second;
            }
            else
            {
                treeDoc.Nodes.Add("Reindex to show Doc Map").Tag = "refresh";
            }

            populateFiles();
            a.ActiveWindow.DocumentMap = false;
        }


        //MENUBAR Format & Speech

        //handles button click to run the function
        private void FormatMacro_Click(object sender, EventArgs e)
        {
            ;
            string t;
            if (sender.GetType().ToString().Contains("SplitButton"))
                t = ((ToolStripSplitButton)sender).Text;
            else
                t = ((ToolStripMenuItem)sender).Text;

            switch (t)
            {
                case "Underline Mode":
                    Macros.Underline();
                    break;
                case "Highlight Mode":
                    Macros.Highlight();
                    break;
                case "Paste Text":
                    Macros.PasteText();
                    break;
                case "Remove Returns":
                    Macros.RemoveReturns();
                    break;
                case "Heading 1":
                    Macros.Heading1();
                    break;
                case "Heading 2":
                    Macros.Heading2();
                    break;
                case "Heading 3":
                    Macros.Heading3();
                    break;
                case "Heading 4":
                    Macros.Heading4();
                    break;
                case "Minimize Unread":
                    Macros.MinimizeUnread();
                    break;
                case "Remove Formatting":
                    Macros.RemoveFormatting();
                    break;
                case "Settings":
                    (new Settings()).ShowDialog();
                    break;
                case "Speech":
                    (new Manager()).ShowDialog();
                    break;

            }
        }


    }
}