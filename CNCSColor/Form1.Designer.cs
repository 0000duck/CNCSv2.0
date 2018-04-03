namespace CNCSColor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelDisplay1 = new CNCSColor.Controls.PanelDisplay();
            this.panelSelecting1 = new CNCSColor.Controls.PanelSelecting();
            this.SuspendLayout();
            // 
            // panelDisplay1
            // 
            this.panelDisplay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDisplay1.BackgroundImage")));
            this.panelDisplay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDisplay1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDisplay1.Location = new System.Drawing.Point(0, 92);
            this.panelDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.panelDisplay1.Name = "panelDisplay1";
            this.panelDisplay1.RGB = "48,35,42";
            this.panelDisplay1.Size = new System.Drawing.Size(1638, 988);
            this.panelDisplay1.TabIndex = 1;
            this.panelDisplay1.RGBChangedEvent += new CNCSColor.Controls.RGBChangedEventHandler(this.panelDisplay1_RGBChangedEvent);
            // 
            // panelSelecting1
            // 
            this.panelSelecting1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelSelecting1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSelecting1.Location = new System.Drawing.Point(1641, 92);
            this.panelSelecting1.Name = "panelSelecting1";
            this.panelSelecting1.Size = new System.Drawing.Size(279, 988);
            this.panelSelecting1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelSelecting1);
            this.Controls.Add(this.panelDisplay1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MaxVisible = false;
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.panelDisplay1, 0);
            this.Controls.SetChildIndex(this.panelSelecting1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PanelDisplay panelDisplay1;
        private Controls.PanelSelecting panelSelecting1;
    }
}

