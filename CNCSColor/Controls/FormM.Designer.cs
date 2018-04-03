namespace CNCSColor.Controls
{
    partial class FormM
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
            this.titleBar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.navigationBar = new System.Windows.Forms.Panel();
            this.navigation4 = new CNCSColor.Controls.ButtonM();
            this.navigation3 = new CNCSColor.Controls.ButtonM();
            this.navigation2 = new CNCSColor.Controls.ButtonM();
            this.navigation1 = new CNCSColor.Controls.ButtonM();
            this.logo = new CNCSColor.Controls.ButtonM();
            this.titleMin = new CNCSColor.Controls.ButtonM();
            this.titleMax = new CNCSColor.Controls.ButtonM();
            this.titleClose = new CNCSColor.Controls.ButtonM();
            this.titleBar.SuspendLayout();
            this.navigationBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleBar.Controls.Add(this.title);
            this.titleBar.Controls.Add(this.logo);
            this.titleBar.Controls.Add(this.titleMin);
            this.titleBar.Controls.Add(this.titleMax);
            this.titleBar.Controls.Add(this.titleClose);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(969, 44);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(38, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(101, 22);
            this.title.TabIndex = 4;
            this.title.Text = "CNCSColor";
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.navigationBar.Controls.Add(this.navigation4);
            this.navigationBar.Controls.Add(this.navigation3);
            this.navigationBar.Controls.Add(this.navigation2);
            this.navigationBar.Controls.Add(this.navigation1);
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar.Location = new System.Drawing.Point(0, 44);
            this.navigationBar.Margin = new System.Windows.Forms.Padding(0);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(969, 48);
            this.navigationBar.TabIndex = 1;
            this.navigationBar.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationBar_Paint);
            // 
            // navigation4
            // 
            this.navigation4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navigation4.AutoSize = true;
            this.navigation4.BackColor = System.Drawing.Color.Transparent;
            this.navigation4.BackColorLeave = System.Drawing.Color.Transparent;
            this.navigation4.BackColorM = System.Drawing.Color.Transparent;
            this.navigation4.BackColorMove = System.Drawing.Color.Transparent;
            this.navigation4.BackColorSelected = System.Drawing.Color.WhiteSmoke;
            this.navigation4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigation4.FontM = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navigation4.ImageLeave = null;
            this.navigation4.ImageM = null;
            this.navigation4.ImageMove = null;
            this.navigation4.Location = new System.Drawing.Point(425, 5);
            this.navigation4.Name = "navigation4";
            this.navigation4.Selected = false;
            this.navigation4.Size = new System.Drawing.Size(135, 38);
            this.navigation4.TabIndex = 8;
            this.navigation4.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navigation4.TextColorLeave = System.Drawing.SystemColors.ButtonHighlight;
            this.navigation4.TextColorMove = System.Drawing.Color.MistyRose;
            this.navigation4.TextColorSelected = System.Drawing.Color.Black;
            this.navigation4.TextM = "辅助功能";
            this.navigation4.ButtonClick += new System.EventHandler(this.navigation4_ButtonClick);
            // 
            // navigation3
            // 
            this.navigation3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navigation3.AutoSize = true;
            this.navigation3.BackColor = System.Drawing.Color.Transparent;
            this.navigation3.BackColorLeave = System.Drawing.Color.Transparent;
            this.navigation3.BackColorM = System.Drawing.Color.Transparent;
            this.navigation3.BackColorMove = System.Drawing.Color.Transparent;
            this.navigation3.BackColorSelected = System.Drawing.Color.WhiteSmoke;
            this.navigation3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigation3.FontM = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navigation3.ImageLeave = null;
            this.navigation3.ImageM = null;
            this.navigation3.ImageMove = null;
            this.navigation3.Location = new System.Drawing.Point(284, 5);
            this.navigation3.Name = "navigation3";
            this.navigation3.Selected = false;
            this.navigation3.Size = new System.Drawing.Size(135, 38);
            this.navigation3.TabIndex = 7;
            this.navigation3.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navigation3.TextColorLeave = System.Drawing.SystemColors.ButtonHighlight;
            this.navigation3.TextColorMove = System.Drawing.Color.MistyRose;
            this.navigation3.TextColorSelected = System.Drawing.Color.Black;
            this.navigation3.TextM = "数据管理";
            this.navigation3.ButtonClick += new System.EventHandler(this.navigation3_ButtonClick);
            // 
            // navigation2
            // 
            this.navigation2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navigation2.AutoSize = true;
            this.navigation2.BackColor = System.Drawing.Color.Transparent;
            this.navigation2.BackColorLeave = System.Drawing.Color.Transparent;
            this.navigation2.BackColorM = System.Drawing.Color.Transparent;
            this.navigation2.BackColorMove = System.Drawing.Color.Transparent;
            this.navigation2.BackColorSelected = System.Drawing.Color.WhiteSmoke;
            this.navigation2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigation2.FontM = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navigation2.ImageLeave = null;
            this.navigation2.ImageM = null;
            this.navigation2.ImageMove = null;
            this.navigation2.Location = new System.Drawing.Point(143, 5);
            this.navigation2.Name = "navigation2";
            this.navigation2.Selected = false;
            this.navigation2.Size = new System.Drawing.Size(135, 38);
            this.navigation2.TabIndex = 6;
            this.navigation2.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navigation2.TextColorLeave = System.Drawing.SystemColors.ButtonHighlight;
            this.navigation2.TextColorMove = System.Drawing.Color.MistyRose;
            this.navigation2.TextColorSelected = System.Drawing.Color.Black;
            this.navigation2.TextM = "外部取色";
            this.navigation2.ButtonClick += new System.EventHandler(this.navigation2_ButtonClick);
            // 
            // navigation1
            // 
            this.navigation1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navigation1.AutoSize = true;
            this.navigation1.BackColor = System.Drawing.Color.Transparent;
            this.navigation1.BackColorLeave = System.Drawing.Color.Transparent;
            this.navigation1.BackColorM = System.Drawing.Color.WhiteSmoke;
            this.navigation1.BackColorMove = System.Drawing.Color.Transparent;
            this.navigation1.BackColorSelected = System.Drawing.Color.WhiteSmoke;
            this.navigation1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigation1.FontM = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navigation1.ImageLeave = null;
            this.navigation1.ImageM = null;
            this.navigation1.ImageMove = null;
            this.navigation1.Location = new System.Drawing.Point(2, 5);
            this.navigation1.Name = "navigation1";
            this.navigation1.Selected = true;
            this.navigation1.Size = new System.Drawing.Size(135, 38);
            this.navigation1.TabIndex = 5;
            this.navigation1.TextColor = System.Drawing.Color.Black;
            this.navigation1.TextColorLeave = System.Drawing.SystemColors.ButtonHighlight;
            this.navigation1.TextColorMove = System.Drawing.Color.MistyRose;
            this.navigation1.TextColorSelected = System.Drawing.Color.Black;
            this.navigation1.TextM = "色彩搭配";
            this.navigation1.ButtonClick += new System.EventHandler(this.navigation1_ButtonClick);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackColorLeave = System.Drawing.Color.Transparent;
            this.logo.BackColorM = System.Drawing.Color.Transparent;
            this.logo.BackColorMove = System.Drawing.Color.Transparent;
            this.logo.BackColorSelected = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.FontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logo.ImageLeave = null;
            this.logo.ImageM = global::CNCSColor.Properties.Resources.CNCSColor28;
            this.logo.ImageMove = null;
            this.logo.Location = new System.Drawing.Point(4, 6);
            this.logo.Name = "logo";
            this.logo.Selected = false;
            this.logo.Size = new System.Drawing.Size(28, 32);
            this.logo.TabIndex = 3;
            this.logo.TextColor = System.Drawing.Color.Black;
            this.logo.TextColorLeave = System.Drawing.Color.Transparent;
            this.logo.TextColorMove = System.Drawing.Color.Transparent;
            this.logo.TextColorSelected = System.Drawing.Color.Transparent;
            this.logo.TextM = "";
            // 
            // titleMin
            // 
            this.titleMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleMin.AutoSize = true;
            this.titleMin.BackColor = System.Drawing.Color.Transparent;
            this.titleMin.BackColorLeave = System.Drawing.Color.Transparent;
            this.titleMin.BackColorM = System.Drawing.Color.Transparent;
            this.titleMin.BackColorMove = System.Drawing.Color.Transparent;
            this.titleMin.BackColorSelected = System.Drawing.Color.Transparent;
            this.titleMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titleMin.FontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleMin.ImageLeave = global::CNCSColor.Properties.Resources.title_bar_min1;
            this.titleMin.ImageM = global::CNCSColor.Properties.Resources.title_bar_min1;
            this.titleMin.ImageMove = global::CNCSColor.Properties.Resources.title_bar_min2;
            this.titleMin.Location = new System.Drawing.Point(865, 6);
            this.titleMin.Name = "titleMin";
            this.titleMin.Selected = false;
            this.titleMin.Size = new System.Drawing.Size(28, 32);
            this.titleMin.TabIndex = 2;
            this.titleMin.TextColor = System.Drawing.Color.Black;
            this.titleMin.TextColorLeave = System.Drawing.Color.Transparent;
            this.titleMin.TextColorMove = System.Drawing.Color.Transparent;
            this.titleMin.TextColorSelected = System.Drawing.Color.Transparent;
            this.titleMin.TextM = "";
            this.titleMin.ButtonClick += new System.EventHandler(this.titleMin_ButtonClick);
            // 
            // titleMax
            // 
            this.titleMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleMax.AutoSize = true;
            this.titleMax.BackColor = System.Drawing.Color.Transparent;
            this.titleMax.BackColorLeave = System.Drawing.Color.Transparent;
            this.titleMax.BackColorM = System.Drawing.Color.Transparent;
            this.titleMax.BackColorMove = System.Drawing.Color.Transparent;
            this.titleMax.BackColorSelected = System.Drawing.Color.Transparent;
            this.titleMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titleMax.FontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleMax.ImageLeave = global::CNCSColor.Properties.Resources.title_bar_max1;
            this.titleMax.ImageM = global::CNCSColor.Properties.Resources.title_bar_max1;
            this.titleMax.ImageMove = global::CNCSColor.Properties.Resources.title_bar_max2;
            this.titleMax.Location = new System.Drawing.Point(899, 6);
            this.titleMax.Name = "titleMax";
            this.titleMax.Selected = false;
            this.titleMax.Size = new System.Drawing.Size(28, 32);
            this.titleMax.TabIndex = 1;
            this.titleMax.TextColor = System.Drawing.Color.Black;
            this.titleMax.TextColorLeave = System.Drawing.Color.Transparent;
            this.titleMax.TextColorMove = System.Drawing.Color.Transparent;
            this.titleMax.TextColorSelected = System.Drawing.Color.Transparent;
            this.titleMax.TextM = "";
            this.titleMax.ButtonClick += new System.EventHandler(this.titleMax_ButtonClick);
            // 
            // titleClose
            // 
            this.titleClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleClose.AutoSize = true;
            this.titleClose.BackColor = System.Drawing.Color.Transparent;
            this.titleClose.BackColorLeave = System.Drawing.Color.Transparent;
            this.titleClose.BackColorM = System.Drawing.Color.Transparent;
            this.titleClose.BackColorMove = System.Drawing.Color.Transparent;
            this.titleClose.BackColorSelected = System.Drawing.Color.Transparent;
            this.titleClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titleClose.FontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleClose.ImageLeave = global::CNCSColor.Properties.Resources.title_bar_close1;
            this.titleClose.ImageM = global::CNCSColor.Properties.Resources.title_bar_close1;
            this.titleClose.ImageMove = global::CNCSColor.Properties.Resources.title_bar_close2;
            this.titleClose.Location = new System.Drawing.Point(933, 6);
            this.titleClose.Name = "titleClose";
            this.titleClose.Selected = false;
            this.titleClose.Size = new System.Drawing.Size(28, 32);
            this.titleClose.TabIndex = 0;
            this.titleClose.TextColor = System.Drawing.Color.Black;
            this.titleClose.TextColorLeave = System.Drawing.Color.Transparent;
            this.titleClose.TextColorMove = System.Drawing.Color.Transparent;
            this.titleClose.TextColorSelected = System.Drawing.Color.Transparent;
            this.titleClose.TextM = "";
            this.titleClose.ButtonClick += new System.EventHandler(this.titleClose_ButtonClick);
            // 
            // FormM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 581);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormM";
            this.Load += new System.EventHandler(this.IrregularForm_Load);
            this.LocationChanged += new System.EventHandler(this.ShadowForm_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.FormM_SizeChanged);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.navigationBar.ResumeLayout(false);
            this.navigationBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private Controls.ButtonM titleClose;
        private Controls.ButtonM titleMin;
        private Controls.ButtonM titleMax;
        private Controls.ButtonM logo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel navigationBar;
        private Controls.ButtonM navigation1;
        private Controls.ButtonM navigation3;
        private Controls.ButtonM navigation2;
        private Controls.ButtonM navigation4;
    }
}