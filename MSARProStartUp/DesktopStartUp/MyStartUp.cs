using SuperMap.Data;
using SuperMap.Desktop;
using SuperMap.Desktop.UI;
using SuperMap.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Application = SuperMap.Desktop.Application;

namespace DesktopStartUp
{
    static class DesktopStartUp
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
                Application.ActiveApplication = new Application();

                //Application.ActiveApplication.

                //To do your work.
                //
              Application.ActiveApplication.PluginManager.PluginLoaded +=new SuperMap.Desktop.PluginLoadedEventHandler(PluginManager_PluginLoaded);
                // += new SuperMap.Desktop.PluginLoadedEventHandler(PluginManager_PluginLoaded); ;

                Application.ActiveApplication.SplashForm.Show();
                Application.ActiveApplication.Initialize();  
                Application.ActiveApplication.SplashForm.Hide();
                WorkspaceControl workspaceControl = SuperMap.Desktop.Application.ActiveApplication.MainForm.DockBarManager[typeof(WorkspaceControlManager)].Control as WorkspaceControl;
                if (workspaceControl != null)
                {
                    //string path = @"D:\Program Files (x86)\SuperMap\SuperMap iDesktop 7C\Bin\Default.smwu";
                    //    //@"\Default.smwu";
                    //string mm = @"\Default.smwu";
                    //WorkspaceConnectionInfo conInfo1 = new WorkspaceConnectionInfo(path);
                    //bool dd = workspaceControl.WorkspaceTree.Workspace.Open(conInfo1);
                    DatasourceConnectionInfo dataSourceConnectionInfo = new DatasourceConnectionInfo();
                    dataSourceConnectionInfo.Server = @"..\Default.udd";
                    dataSourceConnectionInfo.Alias = "dafault";
                    Datasource targetDatasource;
                    bool isExist = File.Exists(dataSourceConnectionInfo.Server);
                    if (isExist)
                    {
                        targetDatasource = workspaceControl.WorkspaceTree.Workspace.Datasources.Open(dataSourceConnectionInfo);
                       
                        //targetDatasource = workspaceControl.WorkspaceTree.Workspace.Datasources[dataSourceConnectionInfo.Alias];
                    }
                    else
                    {
                        targetDatasource = workspaceControl.WorkspaceTree.Workspace.Datasources.Create(dataSourceConnectionInfo);

                    }
                }
                Application.ActiveApplication.Run();
                Application.ActiveApplication.Exit();
            }
            catch (Exception ex)
            {

            }
        }

        static void MainForm_Loaded(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        static void PluginManager_PluginLoaded(object sender, PluginLoadedEventArgs e)
        {
            try
            {
                //获取插件信息，判断如果是高级插件，则不加载
                String currentPluginName = e.Plugin.PluginInfo.Name;
                if (currentPluginName == "Frame")
                {

                    //MessageBox.Show("ok");
                   
                    return;
                }
            }
            catch (Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.Message, InfoType.Exception);
                Application.ActiveApplication.Output.Output(ex.StackTrace, InfoType.Exception);
            }
        }

    }
}
