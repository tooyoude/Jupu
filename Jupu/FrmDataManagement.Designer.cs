namespace Jupu
{
    partial class FrmDataManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDataUpdate = new System.Windows.Forms.Button();
            this.LbStockListUpdate = new System.Windows.Forms.Label();
            this.LbStockKLineDayUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDataUpdate
            // 
            this.BtnDataUpdate.Location = new System.Drawing.Point(24, 23);
            this.BtnDataUpdate.Name = "BtnDataUpdate";
            this.BtnDataUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnDataUpdate.TabIndex = 0;
            this.BtnDataUpdate.Text = "数据更新";
            this.BtnDataUpdate.UseVisualStyleBackColor = true;
            this.BtnDataUpdate.Click += new System.EventHandler(this.BtnDataUpdate_Click);
            // 
            // LbStockListUpdate
            // 
            this.LbStockListUpdate.AutoSize = true;
            this.LbStockListUpdate.Location = new System.Drawing.Point(93, 120);
            this.LbStockListUpdate.Name = "LbStockListUpdate";
            this.LbStockListUpdate.Size = new System.Drawing.Size(131, 12);
            this.LbStockListUpdate.TabIndex = 1;
            this.LbStockListUpdate.Text = "等待更新股票列表 ... ";
            // 
            // LbStockKLineDayUpdate
            // 
            this.LbStockKLineDayUpdate.AutoSize = true;
            this.LbStockKLineDayUpdate.Location = new System.Drawing.Point(93, 165);
            this.LbStockKLineDayUpdate.Name = "LbStockKLineDayUpdate";
            this.LbStockKLineDayUpdate.Size = new System.Drawing.Size(143, 12);
            this.LbStockKLineDayUpdate.TabIndex = 2;
            this.LbStockKLineDayUpdate.Text = "等待更新各股日K数据 ...";
            // 
            // FrmDataManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 428);
            this.Controls.Add(this.LbStockKLineDayUpdate);
            this.Controls.Add(this.LbStockListUpdate);
            this.Controls.Add(this.BtnDataUpdate);
            this.Name = "FrmDataManagement";
            this.Text = "数据管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDataUpdate;
        private System.Windows.Forms.Label LbStockListUpdate;
        private System.Windows.Forms.Label LbStockKLineDayUpdate;
    }
}