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
            this.BodyPanelFirst = new System.Windows.Forms.Panel();
            this.BodyPanelFirstSub1 = new System.Windows.Forms.Panel();
            this.BodyPanelFirstSub2 = new System.Windows.Forms.Panel();
            this.BodyPanelSecond = new System.Windows.Forms.Panel();
            this.BodyPanelThird = new System.Windows.Forms.Panel();
            this.BodyPanelFourth = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BodyPanelFirst.SuspendLayout();
            this.BodyPanelFirstSub1.SuspendLayout();
            this.BodyPanelFirstSub2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplay1
            // 
            this.panelDisplay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDisplay1.BackgroundImage")));
            this.panelDisplay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDisplay1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDisplay1.Location = new System.Drawing.Point(0, 0);
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
            this.panelSelecting1.Btn1TextM = "搭配";
            this.panelSelecting1.Btn2TextM = "储存";
            this.panelSelecting1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSelecting1.Location = new System.Drawing.Point(1641, 0);
            this.panelSelecting1.Name = "panelSelecting1";
            this.panelSelecting1.ShowRGB = "48,35,42";
            this.panelSelecting1.Size = new System.Drawing.Size(279, 988);
            this.panelSelecting1.TabIndex = 2;
            this.panelSelecting1.Button1Click += new System.EventHandler(this.panelSelecting1_Button1Click);
            this.panelSelecting1.Button2Click += new System.EventHandler(this.panelSelecting1_Button2Click);
            // 
            // BodyPanelFirst
            // 
            this.BodyPanelFirst.Controls.Add(this.BodyPanelFirstSub1);
            this.BodyPanelFirst.Controls.Add(this.BodyPanelFirstSub2);
            this.BodyPanelFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanelFirst.Location = new System.Drawing.Point(0, 92);
            this.BodyPanelFirst.Name = "BodyPanelFirst";
            this.BodyPanelFirst.Size = new System.Drawing.Size(1920, 988);
            this.BodyPanelFirst.TabIndex = 3;
            // 
            // BodyPanelFirstSub1
            // 
            this.BodyPanelFirstSub1.Controls.Add(this.panelSelecting1);
            this.BodyPanelFirstSub1.Controls.Add(this.panelDisplay1);
            this.BodyPanelFirstSub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanelFirstSub1.Location = new System.Drawing.Point(0, 0);
            this.BodyPanelFirstSub1.Name = "BodyPanelFirstSub1";
            this.BodyPanelFirstSub1.Size = new System.Drawing.Size(1920, 988);
            this.BodyPanelFirstSub1.TabIndex = 3;
            // 
            // BodyPanelFirstSub2
            // 
            this.BodyPanelFirstSub2.Controls.Add(this.button1);
            this.BodyPanelFirstSub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanelFirstSub2.Location = new System.Drawing.Point(0, 0);
            this.BodyPanelFirstSub2.Name = "BodyPanelFirstSub2";
            this.BodyPanelFirstSub2.Size = new System.Drawing.Size(1920, 988);
            this.BodyPanelFirstSub2.TabIndex = 5;
            // 
            // BodyPanelSecond
            // 
            this.BodyPanelSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanelSecond.Location = new System.Drawing.Point(0, 92);
            this.BodyPanelSecond.Name = "BodyPanelSecond";
            this.BodyPanelSecond.Size = new System.Drawing.Size(1920, 988);
            this.BodyPanelSecond.TabIndex = 4;
            // 
            // BodyPanelThird
            // 
            this.BodyPanelThird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanelThird.Location = new System.Drawing.Point(0, 92);
            this.BodyPanelThird.Name = "BodyPanelThird";
            this.BodyPanelThird.Size = new System.Drawing.Size(1920, 988);
            this.BodyPanelThird.TabIndex = 5;
            // 
            // BodyPanelFourth
            // 
            this.BodyPanelFourth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanelFourth.Location = new System.Drawing.Point(0, 92);
            this.BodyPanelFourth.Name = "BodyPanelFourth";
            this.BodyPanelFourth.Size = new System.Drawing.Size(1920, 988);
            this.BodyPanelFourth.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.BodyPanelFirst);
            this.Controls.Add(this.BodyPanelSecond);
            this.Controls.Add(this.BodyPanelThird);
            this.Controls.Add(this.BodyPanelFourth);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MaxVisible = false;
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Form1";
            this.NavigationClick += new System.EventHandler(this.Form1_NavigationClick);
            this.Controls.SetChildIndex(this.BodyPanelFourth, 0);
            this.Controls.SetChildIndex(this.BodyPanelThird, 0);
            this.Controls.SetChildIndex(this.BodyPanelSecond, 0);
            this.Controls.SetChildIndex(this.BodyPanelFirst, 0);
            this.BodyPanelFirst.ResumeLayout(false);
            this.BodyPanelFirstSub1.ResumeLayout(false);
            this.BodyPanelFirstSub2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PanelDisplay panelDisplay1;
        private Controls.PanelSelecting panelSelecting1;
        private System.Windows.Forms.Panel BodyPanelFirst;
        private System.Windows.Forms.Panel BodyPanelFirstSub1;
        private System.Windows.Forms.Panel BodyPanelSecond;
        private System.Windows.Forms.Panel BodyPanelFirstSub2;
        private System.Windows.Forms.Panel BodyPanelThird;
        private System.Windows.Forms.Panel BodyPanelFourth;
        private System.Windows.Forms.Button button1;
    }
}

