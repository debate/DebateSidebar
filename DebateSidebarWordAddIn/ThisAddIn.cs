using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Word;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;
using Document = Microsoft.Office.Interop.Word.Document;

namespace DebateSidebarWordAddIn
{
    public partial class ThisAddIn
    {
        //global objects
        //global objects
        public bool isSettingsOpen;
        public Document speechDoc;

        public Sidebar Sidebar;
        private static Application a = Globals.ThisAddIn.Application;


        //startup and document events
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            // try{
            if(a.Documents.Count > 0)
            {
                Microsoft.Office.Tools.Word.Document vstoDoc =
                Globals.Factory.GetVstoObject(a.ActiveDocument);
                vstoDoc.SelectionChange -= new SelectionEventHandler(ThisDocument_SelectionChange);
                vstoDoc.SelectionChange += new SelectionEventHandler(ThisDocument_SelectionChange);
            }


            Application.DocumentOpen += Application_DocumentOpen;
                ((ApplicationEvents4_Event)Application).NewDocument += Application_NewDocument;

                // first doc
                if (a.Documents.Count > 0 && Properties.Settings.Default.Enabled)
                {
                    a.ActiveWindow.WindowState = WdWindowState.wdWindowStateMaximize;
                    a.ActiveWindow.View.Type = WdViewType.wdWebView;
                addSidebar();
                }

                Hotkeys.Setup();

          //  }
          //  catch (Exception err) { Debug.WriteLine(err); }

        }
        private void ThisDocument_SelectionChange(object sender, SelectionEventArgs e)
        {
           

            foreach (CustomTaskPane CTP in Globals.ThisAddIn.CustomTaskPanes)
                if (CTP != null && CTP.Window != null
                    && CTP.Window.Equals(a.ActiveDocument.ActiveWindow))
                    if (CTP.Visible)
                        ((Sidebar)CTP.Control).treeDocMap_ChangeSelected(e.Selection);

            
        }

        private void Application_NewDocument(Document document)
        {

            if (a.ActiveDocument != null)
            {
                Microsoft.Office.Tools.Word.Document vstoDoc =
                Globals.Factory.GetVstoObject(a.ActiveDocument);
                vstoDoc.SelectionChange -= new SelectionEventHandler(ThisDocument_SelectionChange);
                vstoDoc.SelectionChange += new SelectionEventHandler(ThisDocument_SelectionChange);
            }

            if (a.ActiveProtectedViewWindow != null)
                a.ActiveProtectedViewWindow.Edit();

            if (document.ActiveWindow == null || !document.ActiveWindow.Visible)
                return;

            if (!Properties.Settings.Default.Enabled)
                return;

            foreach (CustomTaskPane c in CustomTaskPanes)
                if (c != null && c.Window != null && c.Window.Equals(a.ActiveDocument.ActiveWindow))
                    return;

            addSidebar();
            addTemplate();



        }

        private void Application_DocumentOpen(Document document)
        {
            if (a.ActiveDocument != null)
            {
                Microsoft.Office.Tools.Word.Document vstoDoc =
                Globals.Factory.GetVstoObject(a.ActiveDocument);
                vstoDoc.SelectionChange -= new SelectionEventHandler(ThisDocument_SelectionChange);
                vstoDoc.SelectionChange += new SelectionEventHandler(ThisDocument_SelectionChange);
            }


            if (a.ActiveProtectedViewWindow != null)
                a.ActiveProtectedViewWindow.Edit();

            if (document.ActiveWindow == null || !document.ActiveWindow.Visible)
                return;

            foreach (CustomTaskPane c in CustomTaskPanes)
                if (c != null && c.Window != null && c.Window.Equals(a.ActiveDocument.ActiveWindow))
                    return;

          
            addTemplate();
            addSidebar();
        }


        public void addTemplate()
        {
            Properties.Settings s = Properties.Settings.Default;
            a.ActiveWindow.View.Type = WdViewType.wdWebView;


            if (true) //s.OpenTemplate.Length > 0)
            {
               string ss = "D:\\Debate\\Debate.dotm";
                //option for simple template or use heading 1 macros

                a.ActiveDocument.set_AttachedTemplate(ss);
            }

        }

        public void addSidebar(Document doc = null)
        {
            if (doc == null)
                doc = a.ActiveDocument;

            doc.ActiveWindow.DocumentMap = false;


            CustomTaskPane CTP = CustomTaskPanes.Add(new Sidebar(), doc.Name, doc.ActiveWindow);
            CTP.Width = Math.Max(300, Properties.Settings.Default.PanelWidth);
            CTP.DockPosition = Properties.Settings.Default.PanelPosition;

            CTP.DockPositionChanged += CTP_DockPositionChanged;

            CTP.Visible = true; 

        }

        private void CTP_DockPositionChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PanelWidth = ((CustomTaskPane)sender).Width;
            Properties.Settings.Default.PanelPosition = ((CustomTaskPane)sender).DockPosition;
            Properties.Settings.Default.Save();
        }

        //vsto generated
        private void InternalStartup()
        {
            Startup += ThisAddIn_Startup;
            Shutdown += ThisAddIn_Shutdown;
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            try
            {
                GC.Collect();
                Hotkeys.Dispose();
            }
            catch (Exception err) { Debug.WriteLine(err); }
        }
    }
}