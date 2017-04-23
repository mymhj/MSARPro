using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;

namespace SuperMap_Plugin_FirstSample
{
    class MyCtrlAction : CtrlAction
    {
        override public void Run()
        {
            //To do your work.
            //Example:

            IBaseItem baseItem = this.Caller;
            if (baseItem != null)
            {
                String itemType = baseItem.GetType().ToString().Replace("SuperMap.Desktop.", "");
                MessageBox.Show(String.Format("This is a \"{0}\"!", itemType));
            }

        }
    }
}
