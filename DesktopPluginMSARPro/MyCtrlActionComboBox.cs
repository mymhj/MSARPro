using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;

namespace DesktopPluginMSARPro
{
    class MyCtrlActionComboBox : CtrlAction
    {
        override public void Run()
        {
            //To do your work.
            //Example:

            IComboBox baseItem = this.Caller as IComboBox;
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("This ComboBox Select Item: " + baseItem.SelectedIndex);

        }
    }
}
