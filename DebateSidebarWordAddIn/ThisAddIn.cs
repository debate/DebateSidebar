using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools;
using System;
using System.Diagnostics;
using Application = Microsoft.Office.Interop.Word.Application;

namespace DebateSidebarWordAddIn
{
    public partial class ThisAddIn
    {
        //global objects
        public bool isSettingsOpen;
        public Document speechDoc;

        //startup and document events
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            try
            {
                Application.DocumentOpen += Application_DocumentOpen;
                ((ApplicationEvents4_Event)Application).NewDocument += Application_NewDocument;

                // first doc
                if (Globals.ThisAddIn.Application.Documents.Count > 0 && Properties.Settings.Default.Enabled)
                {
                    Globals.ThisAddIn.Application.ActiveWindow.WindowState = WdWindowState.wdWindowStateMaximize;
                    Globals.ThisAddIn.Application.ActiveWindow.View.Type = WdViewType.wdWebView;
                    addTaskbar();
                }

                Hotkeys.Setup();

            }
            catch (Exception err) { Debug.WriteLine(err); }

        }

        private void Application_NewDocument(Document document)
        {

            if (Globals.ThisAddIn.Application.ActiveProtectedViewWindow != null)
                Globals.ThisAddIn.Application.ActiveProtectedViewWindow.Edit();

            if (document.ActiveWindow == null || !document.ActiveWindow.Visible)
                return;

            if (!Properties.Settings.Default.Enabled)
                return;

            // addTemplate();

            foreach (CustomTaskPane c in Globals.ThisAddIn.CustomTaskPanes)
                if (c != null && c.Window != null && c.Window.Equals(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow))
                    return;

            addTaskbar();



        }

        private void Application_DocumentOpen(Document document)
        {
            if (Globals.ThisAddIn.Application.ActiveProtectedViewWindow != null)
                Globals.ThisAddIn.Application.ActiveProtectedViewWindow.Edit();

            if (document.ActiveWindow == null || !document.ActiveWindow.Visible)
                return;

            foreach (CustomTaskPane c in Globals.ThisAddIn.CustomTaskPanes)
                if (c != null && c.Window != null && c.Window.Equals(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow))
                    return;

            if (Properties.Settings.Default.Enabled)
            {
                //addTemplate();
                addTaskbar(document);
            }
        }

        //taskbar & template
        public void addTemplate()
        {
            Application a = Globals.ThisAddIn.Application;
            Properties.Settings s = Properties.Settings.Default;
            a.ActiveWindow.View.Type = WdViewType.wdWebView;


            if (s.OpenTemplate.Length > 0)
            {
                a.ActiveDocument.set_AttachedTemplate(s.OpenTemplate);
            }

        }

        public void addTaskbar(Document doc = null)
        {
            if (doc == null)
                doc = Globals.ThisAddIn.Application.ActiveDocument;

            doc.ActiveWindow.DocumentMap = false;

            CustomTaskPane CTP = CustomTaskPanes.Add(new Sidebar(), " ", doc.ActiveWindow);
            CTP.Width = Math.Max(300, Properties.Settings.Default.PanelWidth);
            CTP.DockPosition = Properties.Settings.Default.PanelPosition;

            CTP.DockPositionChanged += CTP_DockPositionChanged;

            CTP.Visible = !doc.ActiveWindow.Caption.Contains("Speech");

        }

        private void CTP_DockPositionChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PanelWidth = ((CustomTaskPane)sender).Width;
            Properties.Settings.Default.PanelPosition = ((CustomTaskPane)sender).DockPosition;
            Properties.Settings.Default.Save();
        }

        //vsto
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