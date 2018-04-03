namespace CNCSColor.Controls
{
    partial class PanelSelecting
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelShow = new System.Windows.Forms.Panel();
            this.panelSelectd = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.ShowButtonM = new CNCSColor.Controls.ButtonM();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.ShowButtonM);
            this.panelShow.Location = new System.Drawing.Point(38, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(307, 344);
            this.panelShow.TabIndex = 0;
            // 
            // panelSelectd
            // 
            this.panelSelectd.Location = new System.Drawing.Point(38, 344);
            this.panelSelectd.Name = "panelSelectd";
            this.panelSelectd.Size = new System.Drawing.Size(307, 258);
            this.panelSelectd.TabIndex = 1;
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(173, 602);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(172, 121);
            this.panelButton.TabIndex = 2;
            // 
            // ShowButtonM
            // 
            this.ShowButtonM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowButtonM.BackColorLeave = System.Drawing.Color.Transparent;
            this.ShowButtonM.BackColorM = System.Drawing.Color.Transparent;
            this.ShowButtonM.BackColorMove = System.Drawing.Color.Transparent;
            this.ShowButtonM.BackColorSelected = System.Drawing.Color.Transparent;
            this.ShowButtonM.FontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowButtonM.ImageLeave = null;
            this.ShowButtonM.ImageM = null;
            this.ShowButtonM.ImageMove = null;
            this.ShowButtonM.Location = new System.Drawing.Point(18, 64);
            this.ShowButtonM.Name = "ShowButtonM";
            this.ShowButtonM.Selected = false;
            this.ShowButtonM.Size = new System.Drawing.Size(268, 210);
            this.ShowButtonM.TabIndex = 0;
            this.ShowButtonM.TextColor = System.Drawing.Color.Black;
            this.ShowButtonM.TextColorLeave = System.Drawing.Color.Transparent;
            this.ShowButtonM.TextColorMove = System.Drawing.Color.Transparent;
            this.ShowButtonM.TextColorSelected = System.Drawing.Color.Transparent;
            this.ShowButtonM.TextM = "";
            this.ShowButtonM.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowButtonM_Paint);
            // 
            // PanelSelecting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelSelectd);
            this.Controls.Add(this.panelShow);
            this.Name = "PanelSelecting";
            this.Size = new System.Drawing.Size(345, 723);
            this.Load += new System.EventHandler(this.PanelSelecting_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSelecting_Paint);
            this.panelShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panelSelectd;
        private System.Windows.Forms.Panel panelButton;
        private ButtonM ShowButtonM;
    }
}
