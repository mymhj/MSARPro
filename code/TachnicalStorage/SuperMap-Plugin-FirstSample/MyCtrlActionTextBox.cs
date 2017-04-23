using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;

namespace SuperMap_Plugin_FirstSample
{
    class MyCtrlActionTextBox : CtrlAction
    {
        override public void Run()
        {
            //To do your work.
            //Example:

            ITextBox baseItem = this.Caller as ITextBox;
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("This Text is: " + baseItem.Text);

        }
    }
}
