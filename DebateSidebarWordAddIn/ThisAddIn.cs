using System;
using System.IO;
using System.Windows;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools;
using Office = Microsoft.Office.Core;

namespace DebateSidebarWordAddIn
{
    public partial class ThisAddIn
    {
        //public objects
        public bool isSettingsOpen = false;
        public Document speechDoc;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            try
            {
                //add to openings
                Application.DocumentOpen += Application_DocumentOpen;
                ((ApplicationEvents4_Event) Application).NewDocument += Application_NewDocument;

                //add to first doc
                if (Globals.ThisAddIn.Application.Documents.Count > 0 && Properties.Settings.Default.Enabled)
                {

                    Globals.ThisAddIn.Application.ActiveWindow.WindowState = WdWindowState.wdWindowStateMaximize;
                    Globals.ThisAddIn.Application.ActiveWindow.View.Type = WdViewType.wdWebView;
                    addTemplate(Globals.ThisAddIn.Application.ActiveDocument);
                    addTaskbar();
                }

                //keyboard hooks
                if (Properties.Settings.Default.Hotkeys)
                    Hotkeys.SetHook();

            }
            catch (Exception err) { }

        }

        private void Application_NewDocument(Document document)
        {
            if (Globals.ThisAddIn.Application.ActiveProtectedViewWindow != null)
                Globals.ThisAddIn.Application.ActiveProtectedViewWindow.Edit();
            if (document.ActiveWindow == null || !document.ActiveWindow.Visible)
                return;

            if (CustomTaskPanes.Count > 0)
                for (int i = 0; i < CustomTaskPanes.Count; i++)
                    if (CustomTaskPanes[i].Window.Equals(document.ActiveWindow))
                        return;

            if (Properties.Settings.Default.Enabled)
            {
                addTemplate(document);
                addTaskbar();
            }
        }

        private void Application_DocumentOpen(Document document)
        {
            if (Globals.ThisAddIn.Application.ActiveProtectedViewWindow != null)
                Globals.ThisAddIn.Application.ActiveProtectedViewWindow.Edit();

            if (document.ActiveWindow == null || !document.ActiveWindow.Visible)
                return;

            if (CustomTaskPanes.Count > 0)
                for (int i = 0; i < CustomTaskPanes.Count; i++)
                    if (CustomTaskPanes[i].Window.Equals(document.ActiveWindow))
                        return;

            if (Properties.Settings.Default.Enabled)
            {
                addTemplate(document);
                addTaskbar();
            }
        }

        public void addTemplate(Document document)
        {
            Properties.Settings s = Properties.Settings.Default;
            Globals.ThisAddIn.Application.ActiveWindow.View.Type = WdViewType.wdWebView;


            if (s.OpenTemplate.Length > 0)
            {
               
                Globals.ThisAddIn.Application.ActiveDocument.set_AttachedTemplate(s.OpenTemplate);
                Globals.ThisAddIn.Application.ActiveDocument.CopyStylesFromTemplate(s.OpenTemplate);
            }
            else
            {
               
                Document d = Globals.ThisAddIn.Application.ActiveDocument;


                if (d.Styles["Normal"].Font.Name == s.FontName &&
                    d.Styles["Normal"].Font.Size == Convert.ToInt32(s.FontSize))
                    return;


                d.Styles["Normal"].Font.Name = s.FontName;
                d.Styles["Normal"].Font.Size = Convert.ToInt32(s.FontSize);
                // d.Styles["Heading 1"].NameLocal = "Pocket";
                d.Styles["Heading 1"].Font.Size = Convert.ToInt32(s.FontSize) + 9;
                d.Styles["Heading 1"].Font.Name = s.FontName;
                d.Styles["Heading 1"].Font.Underline = WdUnderline.wdUnderlineSingle;
                d.Styles["Heading 1"].Font.Bold = 1;
                d.Styles["Heading 1"].Font.Color = WdColor.wdColorBlack;
                d.Styles["Heading 1"].ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                //   d.Styles["Heading 2"]. = "Hat";
                d.Styles["Heading 2"].Font.Size = Convert.ToInt32(s.FontSize) + 5;
                d.Styles["Heading 2"].Font.Name = s.FontName;
                d.Styles["Heading 2"].Font.Underline = WdUnderline.wdUnderlineSingle;
                d.Styles["Heading 2"].Font.Bold = 1;
                d.Styles["Heading 2"].Font.Color = WdColor.wdColorBlack;
                d.Styles["Heading 2"].ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                //     d.Styles["Heading 3"].NameLocal = "Block";
                d.Styles["Heading 3"].Font.Size = Convert.ToInt32(s.FontSize) + 2;
                d.Styles["Heading 3"].Font.Name = s.FontName;
                d.Styles["Heading 3"].Font.Underline = WdUnderline.wdUnderlineSingle;
                d.Styles["Heading 3"].Font.Bold = 1;
                d.Styles["Heading 3"].Font.Color = WdColor.wdColorBlack;
                d.Styles["Heading 3"].ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;


                //     d.Styles["Heading 4"].NameLocal = "Tag";
                d.Styles["Heading 4"].Font.Size = Convert.ToInt32(s.FontSize);
                d.Styles["Heading 4"].Font.Name = s.FontName;
                d.Styles["Heading 4"].Font.Bold = 1;
                d.Styles["Heading 4"].Font.Color = WdColor.wdColorBlack;
            }
        }

        public void addTaskbar()
        {
            Globals.ThisAddIn.Application.ActiveWindow.DocumentMap = false;

            CustomTaskPane CTP = CustomTaskPanes.Add(new Sidebar(), " ");
            CTP.Width = Properties.Settings.Default.PanelWidth;
            CTP.DockPosition = Properties.Settings.Default.PanelPosition;

            CTP.DockPositionChanged += CTP_DockPositionChanged;

            if (Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Caption.Contains("Speech"))
                CTP.Visible = false;
            else
                CTP.Visible = true;
        }

        private void CTP_DockPositionChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PanelWidth = ((CustomTaskPane) sender).Width;
            Properties.Settings.Default.PanelPosition = ((CustomTaskPane) sender).DockPosition;
            Properties.Settings.Default.Save();
        }

        private void InternalStartup()
        {
            Startup += ThisAddIn_Startup;
            Shutdown += ThisAddIn_Shutdown;
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            Hotkeys.ReleaseHook();
        }
    }
}