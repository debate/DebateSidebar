using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools;
using Application = Microsoft.Office.Interop.Word.Application;
using Office = Microsoft.Office.Core;
using Style = Microsoft.Office.Interop.Word.Style;

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
        ((ApplicationEvents4_Event) Application).NewDocument += Application_NewDocument;

        // first doc
        if (Globals.ThisAddIn.Application.Documents.Count > 0 && Properties.Settings.Default.Enabled)
        {
            Globals.ThisAddIn.Application.ActiveWindow.WindowState = WdWindowState.wdWindowStateMaximize;
            Globals.ThisAddIn.Application.ActiveWindow.View.Type = WdViewType.wdWebView;
            addTemplate();
            addTaskbar();
        }

        if (Properties.Settings.Default.Hotkeys)
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

    addTemplate();

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
        addTemplate();
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
        a.ActiveDocument.CopyStylesFromTemplate(s.OpenTemplate);
    }
    else
    {
               
        Document d = a.ActiveDocument;
        Style Normal = d.Styles["Normal"], H1 = d.Styles["Heading 1"], 
            H2 = d.Styles["Heading 2"], H3 = d.Styles["Heading 3"], 
            H4 = d.Styles["Heading 4"];

        if (Normal.Font.Name == s.FontName &&
            Normal.Font.Size == Convert.ToInt32(s.FontSize))
            return;


        Normal.Font.Name = s.FontName;
        Normal.Font.Size = Convert.ToInt32(s.FontSize);
        H1.Font.Size = Convert.ToInt32(s.FontSize) + 15;
        H1.Font.Name = s.FontName;
        H1.Font.Underline = WdUnderline.wdUnderlineSingle;
        H1.Font.Bold = 1;
        H1.Font.Color = WdColor.wdColorBlack;
        H1.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

        if (Properties.Settings.Default.BoxHeading1)
        {
            H1.ParagraphFormat.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
            H1.ParagraphFormat.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
            H1.ParagraphFormat.Borders.OutsideColor = WdColor.wdColorAutomatic;
        }

        H2.Font.Size = Convert.ToInt32(s.FontSize) + 11;
        H2.Font.Name = s.FontName;
        H2.Font.Underline = WdUnderline.wdUnderlineSingle;
        H2.Font.Bold = 1;
        H2.Font.Color = WdColor.wdColorBlack;
        H2.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

        H3.Font.Size = Convert.ToInt32(s.FontSize) + 4;
        H3.Font.Name = s.FontName;
        H3.Font.Underline = WdUnderline.wdUnderlineSingle;
        H3.Font.Bold = 1;
        H3.Font.Color = WdColor.wdColorBlack;
        H3.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

        H4.Font.Size = Convert.ToInt32(s.FontSize);
        H4.Font.Name = s.FontName;
        H4.Font.Bold = 1;
        H4.Font.Color = WdColor.wdColorBlack;
    }
}

public void addTaskbar(Document doc = null)
{
    if (doc == null)
        doc = Globals.ThisAddIn.Application.ActiveDocument;

    doc.ActiveWindow.DocumentMap = false;

    CustomTaskPane CTP = CustomTaskPanes.Add(new Sidebar(), " ", doc.ActiveWindow );
    CTP.Width = Properties.Settings.Default.PanelWidth;
    CTP.DockPosition = Properties.Settings.Default.PanelPosition;

    CTP.DockPositionChanged += CTP_DockPositionChanged;
    
    CTP.Visible = !doc.ActiveWindow.Caption.Contains("Speech");

}

private void CTP_DockPositionChanged(object sender, EventArgs e)
{
    Properties.Settings.Default.PanelWidth = ((CustomTaskPane) sender).Width;
    Properties.Settings.Default.PanelPosition = ((CustomTaskPane) sender).DockPosition;
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
        Hotkeys.Dispose();
    }
    catch (Exception err) { Debug.WriteLine(err); }
}
}
}