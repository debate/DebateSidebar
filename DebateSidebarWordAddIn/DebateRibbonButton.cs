using Microsoft.Office.Tools.Ribbon;

namespace DebateSidebarWordAddIn
{
    public partial class DebateRibbonButton
    {
        private void bDebatePanelSwitch_Click(object sender, RibbonControlEventArgs e)
        {
            if (Globals.ThisAddIn.CustomTaskPanes.Count > 0)
            {
                for (int i = 0; i < Globals.ThisAddIn.CustomTaskPanes.Count; i++)
                    if (Globals.ThisAddIn.CustomTaskPanes[i].Window != null
                        &&
                        Globals.ThisAddIn.CustomTaskPanes[i].Window.Equals(
                            Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow))
                    {
                        Globals.ThisAddIn.CustomTaskPanes[i].Visible = !Globals.ThisAddIn.CustomTaskPanes[i].Visible;

                        if (Globals.ThisAddIn.CustomTaskPanes[i].Visible)
                            ((Sidebar) Globals.ThisAddIn.CustomTaskPanes[i].Control).populateDoc();

                        return;
                    }
            }

            Globals.ThisAddIn.addTaskbar();
            Globals.ThisAddIn.addTemplate(Globals.ThisAddIn.Application.ActiveDocument);
        }


        private void groupDebate_DialogLauncherClick_1(object sender, RibbonControlEventArgs e)
        {
            var form = new Settings();
            form.ShowDialog();
        }
    }
}