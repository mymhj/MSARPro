using SuperMap.Desktop;
using System;
using System.Collections.Generic;
using System.Text;

using SuperMap.UI;
using SuperMap.Desktop;
using SuperMap.Data;
using SuperMap.Desktop.UI;
using System.Windows.Forms;
using SuperMap.Data.Conversion;

namespace DesktopPluginMSARPro
{
    internal class LoadImageCtrlAction : CtrlAction
    {
        public LoadImageCtrlAction()
            : base()
        {

        }

        public LoadImageCtrlAction(IBaseItem caller, IForm formClass)
            : base(caller, formClass)
        {

        }

        public override void Run()
        {
            try
            {
              ////  WorkspaceConnectionInfo conInfo = new WorkspaceConnectionInfo(@"D:\Program Files (x86)\SuperMap\SuperMap iDesktop 7C\SampleData\World\World.smwu");
              //  WorkspaceControl workspaceControl
              //      = SuperMap.Desktop.Application.ActiveApplication.MainForm.DockBarManager[typeof(WorkspaceControlManager)].Control as WorkspaceControl;
              //  if (workspaceControl != null)
              //  {
              //      workspaceControl.ResourcesNodeVisible = false;
              //      workspaceControl.LayoutsNodeVisible = false;
              //      //workspaceControl.WorkspaceTree.Workspace.Open(conInfo);
              //     WorkspaceConnectionInfo conInfo1 = new WorkspaceConnectionInfo(@"..\..\Default.smwu");

              //      //workspaceControl.WorkspaceTree.Workspace.Create(conInfo1);
              //      //workspaceControl.WorkspaceTree.Workspace.Close();
              //      //workspaceControl.WorkspaceTree.Workspace.Dispose();
              //      bool dd= workspaceControl.WorkspaceTree.Workspace.Open(conInfo1);
              //      workspaceControl.WorkspaceTree.Workspace.Datasources.Create()
              //      //workspaceControl.Update();
              //      //workspaceControl.WorkspaceTree.WorkspaceNode.Nodes.Add("dafsaf");
              //     // workspaceControl.WorkspaceTree.Update();
              //  }

               // System.Windows.Forms.MessageBox.Show("LoadImageCtrlAction");
                //IFormMap activeMapForm = Application.ActiveForm as IFormMap;
                //MapControl activeMap = activeMapForm.MapControl;
                
               //IFormManager dd=  Application.ActiveApplication.MainForm.FormManager;
               //for (int i = 0; i < dd.Count; i++)
               //{ 

               //}


                 WorkspaceControl workspaceControl= SuperMap.Desktop.Application.ActiveApplication.MainForm.DockBarManager[typeof(WorkspaceControlManager)].Control as WorkspaceControl;
                 Datasource targetDatasource;

                 DatasourceConnectionInfo dataSourceConnectionInfo = new DatasourceConnectionInfo();
                 dataSourceConnectionInfo.Server = @"..\..\Default";

                if (workspaceControl != null)
                 {
                     workspaceControl.ResourcesNodeVisible = false;
                     workspaceControl.LayoutsNodeVisible = false;


                     Form1 form1 = new Form1();
                     form1.Show();

                     try {
                        bool isExist= workspaceControl.WorkspaceTree.Workspace.Datasources.Contains(dataSourceConnectionInfo.Alias);
                        if (isExist)
                        {
                            targetDatasource = workspaceControl.WorkspaceTree.Workspace.Datasources[dataSourceConnectionInfo.Alias];
                        }
                        else
                        {
                            targetDatasource = workspaceControl.WorkspaceTree.Workspace.Datasources.Open(dataSourceConnectionInfo);
                        }
                       
                     }
                     catch (Exception ex1)
                     {
                        targetDatasource= workspaceControl.WorkspaceTree.Workspace.Datasources.Create(dataSourceConnectionInfo);
                     }

                     OpenFileDialog ofd = new OpenFileDialog();
                     ofd.Filter = "影像文件(*.tif)|*.*";
                     ofd.ValidateNames = true;
                     ofd.CheckPathExists = true;
                     ofd.CheckFileExists = true;
                     ofd.ShowHelp = true;
                     //ofd.HelpRequest += ofd_HelpRequest;
                     if (ofd.ShowDialog() == DialogResult.OK)
                     {
                         string strFileName = ofd.FileName;
                         //其他代码

                           

                         DataImport m_dataImport = new DataImport();
                         m_dataImport.ImportSettings.Clear();



                         //ImportSettingIMG imgSetting = new ImportSettingIMG();
                         //imgSetting.ImportMode = ImportMode.Overwrite;
                         //imgSetting.SourceFilePath = @"..\..\SampleData\DataExchange\ImgImport\Multibands.img";
                         //imgSetting.TargetDatasource = m_desDatasource;
                         //imgSetting.MultiBandImportMode = MultiBandImportMode.MultiBand;

                         //m_dataImport.ImportSettings.Add(imgSetting);
                         //m_dataImport.Run();

                         //DatasetImage importResult = m_desDatasource.Datasets["Multibands"] as DatasetImage;
                         //LayerSettingImage layerSetting = new LayerSettingImage();
                         //layerSetting.DisplayBandIndexes = new Int32[] { 3, 2, 1 };
                         //layerSetting.DisplayColorSpace = ColorSpaceType.RGB;

                         
                         ImportSettingTIF importSetingTif = new ImportSettingTIF();
                         
                         importSetingTif.ImportMode = ImportMode.Overwrite;
                         importSetingTif.SourceFilePath = strFileName;
                         PrjCoordSys prgCoord= importSetingTif.GetSourcePrjCoordSys();
                         Charset pCharset = importSetingTif.SourceFileCharset ;
                         

                         ImportDataInfos importDataInfoTif = importSetingTif.GetTargetDataInfos("");
                        
                         importSetingTif.SetTargetDataInfos(importDataInfoTif);
                         
                         //ImportDataInfoTIF importDataInfoTif1 = null;

                         importSetingTif.TargetDatasource = targetDatasource;
                         
                         m_dataImport.ImportSettings.Add(importSetingTif);
                        


                         m_dataImport.Run();
         
              
                 }

                }
                  
            }
            catch (Exception ex)
            {
                SuperMap.Desktop.Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        }

        void ofd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("我自己定义的帮助信息：）"); 
        }

        public override Boolean Enable()
        {
            Boolean enable = false;
            try
            {
                //IFormMap MapForm = Application.ActiveForm as IFormMap;
                //if (MapForm != null)
                    return true;
            }
            catch
            {

            }
            return enable;
        }

        public override System.Windows.Forms.CheckState Check()
        {
            System.Windows.Forms.CheckState checkState = System.Windows.Forms.CheckState.Unchecked;
            try
            {

            }
            catch
            {

            }

            return checkState;
        }
    }
}

