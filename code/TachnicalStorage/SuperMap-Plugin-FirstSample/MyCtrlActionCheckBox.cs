using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;

namespace SuperMap_Plugin_FirstSample
{
    class MyCtrlActionCheckBox : CtrlAction
    {
        override public void Run()
        {
            //To do your work.
            //Example:

            IDockBar myDockBar = SuperMap.Desktop.Application.ActiveApplication.MainForm.DockBarManager[typeof(MyControl)];
            CheckState state = this.Check();
            myDockBar.Visible = (state == CheckState.Checked) ? false : true;
        }

        public override CheckState Check()
        {
            CheckState state = CheckState.Checked;
            Boolean isDockBarVisible = SuperMap.Desktop.Application.ActiveApplication.MainForm.DockBarManager[typeof(MyControl)].Visible;
            if (!isDockBarVisible)
            {
                state = CheckState.Unchecked;
            }
            return state;
        }
    }
}
