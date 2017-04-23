using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;
using SuperMap.Desktop.UI;

namespace SuperMap_Plugin_FirstSample
{
    public partial class MyControl : UIUserControl
    {
        public ContextMenuStrip myContextMenu;

        public MyControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Right click to show the ContextMenu
        /// </summary>
        private void MyControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SuperMap.Desktop.Application.ActiveApplication.MainForm.ContextMenuManager["myContextMenu"].Show(this, e.X, e.Y);
            }
        }
    }
}
