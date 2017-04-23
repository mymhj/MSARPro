using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;

namespace SuperMap_Plugin_FirstSample
{
    class MyCtrlActionNum : CtrlAction
    {
        override public void Run()
        {
            //To do your work.
            //Example:

            IIntegerUpDown baseItem = this.Caller as IIntegerUpDown;
            SuperMap.Desktop.Application.ActiveApplication.Output.Output("This Number is: " + baseItem.Value.ToString());

        }
    }
}
