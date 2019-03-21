namespace Jupu
{
    partial class FrmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TslDatabaseSetting = new System.Windows.Forms.ToolStripLabel();
            this.TslDataManagement = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslDatabaseSetting,
            this.TslDataManagement});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1120, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TslDatabaseSetting
            // 
            this.TslDatabaseSetting.Name = "TslDatabaseSetting";
            this.TslDatabaseSetting.Size = new System.Drawing.Size(68, 22);
            this.TslDatabaseSetting.Text = "设置数据库";
            this.TslDatabaseSetting.Click += new System.EventHandler(this.TslDatabaseSetting_Click);
            // 
            // TslDataManagement
            // 
            this.TslDataManagement.Name = "TslDataManagement";
            this.TslDataManagement.Size = new System.Drawing.Size(56, 22);
            this.TslDataManagement.Text = "数据管理";
            this.TslDataManagement.Click += new System.EventHandler(this.TslDataManagement_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 437);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmMain";
            this.Text = "Jupu Stock Analyst";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel TslDatabaseSetting;
        private System.Windows.Forms.ToolStripLabel TslDataManagement;
    }
}

