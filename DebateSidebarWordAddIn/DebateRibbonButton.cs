using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Ribbon;

namespace DebateSidebarWordAddIn
{
    public partial class DebateRibbonButton
    {
        private void bDebatePanelSwitch_Click(object sender, RibbonControlEventArgs e)
        {
            foreach (CustomTaskPane CTP in Globals.ThisAddIn.CustomTaskPanes)
                if (CTP != null && CTP.Window != null
                    && CTP.Window.Equals(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow))
                {

                    CTP.Visible = !CTP.Visible;

                    if (CTP.Visible)
                        ((Sidebar)CTP.Control).populateDoc();
                    return;
                }



            Globals.ThisAddIn.addSidebar();

        }

        private void groupDebate_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
        
                new Settings().ShowDialog();
        }
    }
}
