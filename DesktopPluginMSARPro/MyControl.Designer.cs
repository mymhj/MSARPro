namespace DesktopPluginMSARPro
{
    partial class MyControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiButton1 = new SuperMap.Desktop.UI.UIButton();
            this.comboBoxField1 = new SuperMap.Desktop.UI.ComboBoxField();
            this.uiTreeView1 = new SuperMap.Desktop.UI.UITreeView();
            this.uiButton2 = new SuperMap.Desktop.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Location = new System.Drawing.Point(63, 186);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(75, 23);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "uiButton1";
            this.uiButton1.UseVisualStyleBackColor = true;
            // 
            // comboBoxField1
            // 
            this.comboBoxField1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxField1.Dataset = null;
            this.comboBoxField1.FieldTypes = new SuperMap.Data.FieldType[0];
            this.comboBoxField1.FormattingEnabled = true;
            this.comboBoxField1.IncludeSystemFields = true;
            this.comboBoxField1.IsFirstItemEmpty = false;
            this.comboBoxField1.Location = new System.Drawing.Point(86, 255);
            this.comboBoxField1.Name = "comboBoxField1";
            this.comboBoxField1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxField1.SuggestFieldNames = new string[0];
            this.comboBoxField1.TabIndex = 1;
            // 
            // uiTreeView1
            // 
            this.uiTreeView1.Location = new System.Drawing.Point(16, 65);
            this.uiTreeView1.Name = "uiTreeView1";
            this.uiTreeView1.Size = new System.Drawing.Size(121, 97);
            this.uiTreeView1.TabIndex = 2;
            // 
            // uiButton2
            // 
            this.uiButton2.Location = new System.Drawing.Point(172, 113);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(75, 23);
            this.uiButton2.TabIndex = 3;
            this.uiButton2.Text = "uiButton2";
            this.uiButton2.UseVisualStyleBackColor = true;
            // 
            // MyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiTreeView1);
            this.Controls.Add(this.comboBoxField1);
            this.Controls.Add(this.uiButton1);
            this.Name = "MyControl";
            this.Size = new System.Drawing.Size(594, 446);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button button1;
        private SuperMap.Desktop.UI.UIButton uiButton1;
        private SuperMap.Desktop.UI.ComboBoxField comboBoxField1;
        private SuperMap.Desktop.UI.UITreeView uiTreeView1;
        private SuperMap.Desktop.UI.UIButton uiButton2;
    }
}
