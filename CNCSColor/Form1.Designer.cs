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
            this.panelSelecting1 = new CNCSColor.Controls.PanelSelecting();
            this.BodyPanelFirst = new System.Windows.Forms.Panel();
            this.BodyPanelFirstSub2 = new System.Windows.Forms.Panel();
            this.ruleGroupBox = new System.Windows.Forms.GroupBox();
            this.ruleCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu1 = new CNCSColor.Controls.PanelMenu();
            this.panelSelecting2 = new CNCSColor.Controls.PanelSelecting();
            this.BodyPanelFirstSub1 = new System.Windows.Forms.Panel();
            this.panelDisplay1 = new CNCSColor.Controls.PanelDisplay();
            this.BodyPanelSecond = new System.Windows.Forms.Panel();
            this.BodyPanelThird = new System.Windows.Forms.Panel();
            this.BodyPanelFourth = new System.Windows.Forms.Panel();
            this.BodyPanelFirst.SuspendLayout();
            this.BodyPanelFirstSub2.SuspendLayout();
            this.ruleGroupBox.SuspendLayout();
            this.BodyPanelFirstSub1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelecting1
            // 
            this.panelSelecting1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelSelecting1.Btn1TextM = "搭配";
            this.panelSelecting1.Btn2TextM = "储存";
            this.panelSelecting1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSelecting1.Location = new System.Drawing.Point(1641, 0);
            this.panelSelecting1.Name = "panelSelecting1";
            this.panelSelecting1.SelectedTexts = null;
            this.panelSelecting1.ShowRGB = "0,0,0";
            this.panelSelecting1.Size = new System.Drawing.Size(279, 988);
            this.panelSelecting1.TabIndex = 2;
            this.panelSelecting1.Button1Click += new System.EventHandler(this.panelSelecting1_Button1Click);
            this.panelSelecting1.Button2Click += new System.EventHandler(this.panelSelecting1_Button2Click);
            // 
            // BodyPanelFirst
            // 
            this.BodyPanelFirst.Controls.Add(this.BodyPanelFirstSub2);
            this.BodyPanelFirst.Controls.Add(this.BodyPanelFirstSub1);
            this.BodyPanelFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanelFirst.Location = new System.Drawing.Point(0, 92);
            this.BodyPanelFirst.Name = "BodyPanelFirst";
            this.BodyPanelFirst.Size = new System.Drawing.Size(1920, 988);
            this.BodyPanelFirst.TabIndex = 3;
            // 
            // BodyPanelFirstSub2
            // 
            this.BodyPanelFirstSub2.Controls.Add(this.ruleGroupBox);
            this.BodyPanelFirstSub2.Controls.Add(this.panel5);
            this.BodyPanelFirstSub2.Controls.Add(this.panel4);
            this.BodyPanelFirstSub2.Controls.Add(this.panel3);
            this.BodyPanelFirstSub2.Controls.Add(this.panel2);
            this.BodyPanelFirstSub2.Controls.Add(this.panel1);
            this.BodyPanelFirstSub2.Controls.Add(this.panelMenu1);
            this.BodyPanelFirstSub2.Controls.Add(this.panelSelecting2);
            this.BodyPanelFirstSub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanelFirstSub2.Location = new System.Drawing.Point(0, 0);
            this.BodyPanelFirstSub2.Name = "BodyPanelFirstSub2";
            this.BodyPanelFirstSub2.Size = new System.Drawing.Size(1920, 988);
            this.BodyPanelFirstSub2.TabIndex = 5;
            // 
            // ruleGroupBox
            // 
            this.ruleGroupBox.Controls.Add(this.ruleCheckedListBox);
            this.ruleGroupBox.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ruleGroupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ruleGroupBox.Location = new System.Drawing.Point(190, 41);
            this.ruleGroupBox.Name = "ruleGroupBox";
            this.ruleGroupBox.Size = new System.Drawing.Size(136, 145);
            this.ruleGroupBox.TabIndex = 11;
            this.ruleGroupBox.TabStop = false;
            this.ruleGroupBox.Text = "搭配规则";
            // 
            // ruleCheckedListBox
            // 
            this.ruleCheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.ruleCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ruleCheckedListBox.CheckOnClick = true;
            this.ruleCheckedListBox.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ruleCheckedListBox.FormattingEnabled = true;
            this.ruleCheckedListBox.Items.AddRange(new object[] {
            "。。。",
            "对抗",
            "互补",
            "类比"});
            this.ruleCheckedListBox.Location = new System.Drawing.Point(31, 25);
            this.ruleCheckedListBox.Name = "ruleCheckedListBox";
            this.ruleCheckedListBox.Size = new System.Drawing.Size(75, 120);
            this.ruleCheckedListBox.TabIndex = 2;
            this.ruleCheckedListBox.ThreeDCheckBoxes = true;
            this.ruleCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ruleCheckedListBox_ItemCheck);
            this.ruleCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.ruleCheckedListBox_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(1264, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 926);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(1035, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 926);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Location = new System.Drawing.Point(806, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 926);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(577, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 926);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(348, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 926);
            this.panel1.TabIndex = 3;
            // 
            // panelMenu1
            // 
            this.panelMenu1.CNCSNum = null;
            this.panelMenu1.Location = new System.Drawing.Point(0, 6);
            this.panelMenu1.Name = "panelMenu1";
            this.panelMenu1.Size = new System.Drawing.Size(185, 419);
            this.panelMenu1.TabIndex = 2;
            this.panelMenu1.CNCSNumChangedEvent += new CNCSColor.Controls.ValueChangedEventHandler(this.panelMenu1_CNCSNumChangedEvent);
            this.panelMenu1.TriggerMouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMenu1_TriggerMouseClick);
            // 
            // panelSelecting2
            // 
            this.panelSelecting2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelSelecting2.Btn1TextM = "储存";
            this.panelSelecting2.Btn2TextM = "返回";
            this.panelSelecting2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSelecting2.Location = new System.Drawing.Point(1641, 0);
            this.panelSelecting2.Name = "panelSelecting2";
            this.panelSelecting2.SelectedTexts = null;
            this.panelSelecting2.ShowRGB = "";
            this.panelSelecting2.Size = new System.Drawing.Size(279, 988);
            this.panelSelecting2.TabIndex = 1;
            this.panelSelecting2.Button2Click += new System.EventHandler(this.panelSelecting2_Button2Click);
            // 
            // BodyPanelFirstSub1
            // 
            this.BodyPanelFirstSub1.Controls.Add(this.panelDisplay1);
            this.BodyPanelFirstSub1.Controls.Add(this.panelSelecting1);
            this.BodyPanelFirstSub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanelFirstSub1.Location = new System.Drawing.Point(0, 0);
            this.BodyPanelFirstSub1.Name = "BodyPanelFirstSub1";
            this.BodyPanelFirstSub1.Size = new System.Drawing.Size(1920, 988);
            this.BodyPanelFirstSub1.TabIndex = 3;
            // 
            // panelDisplay1
            // 
            this.panelDisplay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDisplay1.BackgroundImage")));
            this.panelDisplay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDisplay1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDisplay1.Location = new System.Drawing.Point(0, 0);
            this.panelDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.panelDisplay1.Name = "panelDisplay1";
            this.panelDisplay1.RGB = "";
            this.panelDisplay1.Size = new System.Drawing.Size(1638, 988);
            this.panelDisplay1.TabIndex = 0;
            this.panelDisplay1.RGBChangedEvent += new CNCSColor.Controls.ValueChangedEventHandler(this.panelDisplay1_RGBChangedEvent);
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
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "Form1";
            this.Text = "Form1";
            this.NavigationClick += new System.EventHandler(this.Form1_NavigationClick);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.BodyPanelFourth, 0);
            this.Controls.SetChildIndex(this.BodyPanelThird, 0);
            this.Controls.SetChildIndex(this.BodyPanelSecond, 0);
            this.Controls.SetChildIndex(this.BodyPanelFirst, 0);
            this.BodyPanelFirst.ResumeLayout(false);
            this.BodyPanelFirstSub2.ResumeLayout(false);
            this.ruleGroupBox.ResumeLayout(false);
            this.BodyPanelFirstSub1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.PanelDisplay panelDisplay1;
        private Controls.PanelSelecting panelSelecting1;
        private System.Windows.Forms.Panel BodyPanelFirst;
        private System.Windows.Forms.Panel BodyPanelFirstSub1;
        private System.Windows.Forms.Panel BodyPanelSecond;
        private System.Windows.Forms.Panel BodyPanelThird;
        private System.Windows.Forms.Panel BodyPanelFourth;
        private System.Windows.Forms.Panel BodyPanelFirstSub2;
        private System.Windows.Forms.GroupBox ruleGroupBox;
        private System.Windows.Forms.CheckedListBox ruleCheckedListBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Controls.PanelMenu panelMenu1;
        private Controls.PanelSelecting panelSelecting2;

    }
}

