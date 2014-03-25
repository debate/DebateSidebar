using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Office.Tools.Ribbon;

namespace DebateSynergyWordAddIn
{
    public partial class DebateRibbonButton
    {
        private void DebateRibbonButton_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void bDebatePanelSwitch_Click(object sender, RibbonControlEventArgs e)
        {
           
            if (Globals.ThisAddIn.CustomTaskPanes.Count > 0)
            {

                for (int i = 0; i < Globals.ThisAddIn.CustomTaskPanes.Count; i++)
                    if (Globals.ThisAddIn.CustomTaskPanes[i].Window != null
                        && Globals.ThisAddIn.CustomTaskPanes[i].Window.Equals(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow))
                    {


                        Globals.ThisAddIn.CustomTaskPanes[i].Visible = !Globals.ThisAddIn.CustomTaskPanes[i].Visible;

                        if (Globals.ThisAddIn.CustomTaskPanes[i].Visible)
                            ((MainPanel)Globals.ThisAddIn.CustomTaskPanes[i].Control).populateDoc();

                        return;

                    }
            }

            Globals.ThisAddIn.addTaskbar();
            Globals.ThisAddIn.addTemplate(Globals.ThisAddIn.Application.ActiveDocument);

        }

       

        private void groupDebate_DialogLauncherClick_1(object sender, RibbonControlEventArgs e)
        {
            SettingsMenu form = new SettingsMenu();
            form.ShowDialog();
        }
    }
}
