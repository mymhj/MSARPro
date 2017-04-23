using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;

namespace SuperMap_Plugin_FirstSample
{
    public class DesktopPlugin : Plugin
    {
        public DesktopPlugin(PluginInfo pluginInfo)
            : base(pluginInfo)
        {

        }

        public override Boolean Initialize()
        {
            return true;
        }

        public override Boolean ExitInstance()
        {
            return true;
        }
    }
}
