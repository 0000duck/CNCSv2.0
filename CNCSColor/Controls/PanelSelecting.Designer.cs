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
            this.CNCSNum = new System.Windows.Forms.Label();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.checkMarkBtn = new CNCSColor.Controls.ButtonM();
            this.adjacentHBtn3 = new CNCSColor.Controls.RoundButton();
            this.adjacentHBtn2 = new CNCSColor.Controls.RoundButton();
            this.adjacentHBtn1 = new CNCSColor.Controls.RoundButton();
            this.adjacentCBtn3 = new CNCSColor.Controls.RoundButton();
            this.adjacentCBtn2 = new CNCSColor.Controls.RoundButton();
            this.adjacentCBtn1 = new CNCSColor.Controls.RoundButton();
            this.adjacentLBtn3 = new CNCSColor.Controls.RoundButton();
            this.adjacentLBtn2 = new CNCSColor.Controls.RoundButton();
            this.adjacentLBtn1 = new CNCSColor.Controls.RoundButton();
            this.panelSelected = new System.Windows.Forms.Panel();
            this.panelList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelShow.SuspendLayout();
            this.ShowPanel.SuspendLayout();
            this.panelSelected.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.CNCSNum);
            this.panelShow.Controls.Add(this.ShowPanel);
            this.panelShow.Controls.Add(this.adjacentHBtn3);
            this.panelShow.Controls.Add(this.adjacentHBtn2);
            this.panelShow.Controls.Add(this.adjacentHBtn1);
            this.panelShow.Controls.Add(this.adjacentCBtn3);
            this.panelShow.Controls.Add(this.adjacentCBtn2);
            this.panelShow.Controls.Add(this.adjacentCBtn1);
            this.panelShow.Controls.Add(this.adjacentLBtn3);
            this.panelShow.Controls.Add(this.adjacentLBtn2);
            this.panelShow.Controls.Add(this.adjacentLBtn1);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(264, 344);
            this.panelShow.TabIndex = 0;
            // 
            // CNCSNum
            // 
            this.CNCSNum.AutoSize = true;
            this.CNCSNum.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CNCSNum.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CNCSNum.Location = new System.Drawing.Point(89, 64);
            this.CNCSNum.Name = "CNCSNum";
            this.CNCSNum.Size = new System.Drawing.Size(0, 17);
            this.CNCSNum.TabIndex = 0;
            // 
            // ShowPanel
            // 
            this.ShowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPanel.Controls.Add(this.checkMarkBtn);
            this.ShowPanel.Location = new System.Drawing.Point(18, 84);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(225, 215);
            this.ShowPanel.TabIndex = 11;
            this.ShowPanel.BackColorChanged += new System.EventHandler(this.ShowPanel_BackColorChanged);
            this.ShowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowPanel_Paint);
            // 
            // checkMarkBtn
            // 
            this.checkMarkBtn.BackColorLeave = System.Drawing.Color.Transparent;
            this.checkMarkBtn.BackColorM = System.Drawing.Color.Transparent;
            this.checkMarkBtn.BackColorMove = System.Drawing.Color.Transparent;
            this.checkMarkBtn.BackColorSelected = System.Drawing.Color.Transparent;
            this.checkMarkBtn.FontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkMarkBtn.ImageLeave = null;
            this.checkMarkBtn.ImageM = global::CNCSColor.Properties.Resources.CheckMarkWhite;
            this.checkMarkBtn.ImageMove = null;
            this.checkMarkBtn.Location = new System.Drawing.Point(182, 178);
            this.checkMarkBtn.Name = "checkMarkBtn";
            this.checkMarkBtn.Selected = false;
            this.checkMarkBtn.Size = new System.Drawing.Size(43, 37);
            this.checkMarkBtn.TabIndex = 10;
            this.checkMarkBtn.TextColor = System.Drawing.Color.Black;
            this.checkMarkBtn.TextColorLeave = System.Drawing.Color.Transparent;
            this.checkMarkBtn.TextColorMove = System.Drawing.Color.Transparent;
            this.checkMarkBtn.TextColorSelected = System.Drawing.Color.Transparent;
            this.checkMarkBtn.TextM = "";
            this.checkMarkBtn.ButtonClick += new System.EventHandler(this.checkMarkBtn_ButtonClick);
            // 
            // adjacentHBtn3
            // 
            this.adjacentHBtn3.Location = new System.Drawing.Point(151, 305);
            this.adjacentHBtn3.Name = "adjacentHBtn3";
            this.adjacentHBtn3.RGB = "0,0,100";
            this.adjacentHBtn3.Size = new System.Drawing.Size(28, 28);
            this.adjacentHBtn3.TabIndex = 9;
            this.adjacentHBtn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdjacentBtn_MouseDown);
            this.adjacentHBtn3.MouseEnter += new System.EventHandler(this.AdjacentBtn_MouseEnter);
            this.adjacentHBtn3.MouseLeave += new System.EventHandler(this.AdjacentBtn_MouseLeave);
            // 
            // adjacentHBtn2
            // 
            this.adjacentHBtn2.Location = new System.Drawing.Point(117, 305);
            this.adjacentHBtn2.Name = "adjacentHBtn2";
            this.adjacentHBtn2.RGB = "255,255,255";
            this.adjacentHBtn2.Size = new System.Drawing.Size(28, 28);
            this.adjacentHBtn2.TabIndex = 8;
            this.adjacentHBtn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdjacentBtn_MouseDown);
            this.adjacentHBtn2.MouseEnter += new System.EventHandler(this.AdjacentBtn_MouseEnter);
            this.adjacentHBtn2.MouseLeave += new System.EventHandler(this.AdjacentBtn_MouseLeave);
            // 
            // adjacentHBtn1
            // 
            this.adjacentHBtn1.Location = new System.Drawing.Point(83, 305);
            this.adjacentHBtn1.Name = "adjacentHBtn1";
            this.adjacentHBtn1.RGB = "100,0,0";
            this.adjacentHBtn1.Size = new System.Drawing.Size(28, 28);
            this.adjacentHBtn1.TabIndex = 7;
            this.adjacentHBtn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdjacentBtn_MouseDown);
            this.adjacentHBtn1.MouseEnter += new System.EventHandler(this.AdjacentBtn_MouseEnter);
            this.adjacentHBtn1.MouseLeave += new System.EventHandler(this.AdjacentBtn_MouseLeave);
            // 
            // adjacentCBtn3
            // 
            this.adjacentCBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adjacentCBtn3.Location = new System.Drawing.Point(181, 50);
            this.adjacentCBtn3.Name = "adjacentCBtn3";
            this.adjacentCBtn3.RGB = "0,255,255";
            this.adjacentCBtn3.Size = new System.Drawing.Size(28, 28);
            this.adjacentCBtn3.TabIndex = 6;
            this.adjacentCBtn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdjacentBtn_MouseDown);
            this.adjacentCBtn3.MouseEnter += new System.EventHandler(this.AdjacentBtn_MouseEnter);
            this.adjacentCBtn3.MouseLeave += new System.EventHandler(this.AdjacentBtn_MouseLeave);
            // 
            // adjacentCBtn2
            // 
            this.adjacentCBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adjacentCBtn2.Location = new System.Drawing.Point(215, 50);
            this.adjacentCBtn2.Name = "adjacentCBtn2";
            this.adjacentCBtn2.RGB = "255,0,255";
            this.adjacentCBtn2.Size = new System.Drawing.Size(28, 28);
            this.adjacentCBtn2.TabIndex = 5;
            this.adjacentCBtn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdjacentBtn_MouseDown);
            this.adjacentCBtn2.MouseEnter += new System.EventHandler(this.AdjacentBtn_MouseEnter);
            this.adjacentCBtn2.MouseLeave += new System.EventHandler(this.AdjacentBtn_MouseLeave);
            // 
            // adjacentCBtn1
            // 
            this.adjacentCBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adjacentCBtn1.Location = new System.Drawing.Point(215, 16);
            this.adjacentCBtn1.Name = "adjacentCBtn1";
            this.adjacentCBtn1.RGB = "255,255,0";
            this.adjacentCBtn1.Size = new System.Drawing.Size(28, 28);
            this.adjacentCBtn1.TabIndex = 4;
            this.adjacentCBtn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdjacentBtn_MouseDown);
            this.adjacentCBtn1.MouseEnter += new System.EventHandler(this.AdjacentBtn_MouseEnter);
            this.adjacentCBtn1.MouseLeave += new System.EventHandler(this.AdjacentBtn_MouseLeave);
            // 
            // adjacentLBtn3
            // 
            this.adjacentLBtn3.Location = new System.Drawing.Point(52, 50);
            this.adjacentLBtn3.Name = "adjacentLBtn3";
            this.adjacentLBtn3.RGB = "0,0,255";
            this.adjacentLBtn3.Size = new System.Drawing.Size(28, 28);
            this.adjacentLBtn3.TabIndex = 3;
            this.adjacentLBtn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdjacentBtn_MouseDown);
            this.adjacentLBtn3.MouseEnter += new System.EventHandler(this.AdjacentBtn_MouseEnter);
            this.adjacentLBtn3.MouseLeave += new System.EventHandler(this.AdjacentBtn_MouseLeave);
            // 
            // adjacentLBtn2
            // 
            this.adjacentLBtn2.Location = new System.Drawing.Point(18, 50);
            this.adjacentLBtn2.Name = "adjacentLBtn2";
            this.adjacentLBtn2.RGB = "0,255,0";
            this.adjacentLBtn2.Size = new System.Drawing.Size(28, 28);
            this.adjacentLBtn2.TabIndex = 2;
            this.adjacentLBtn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdjacentBtn_MouseDown);
            this.adjacentLBtn2.MouseEnter += new System.EventHandler(this.AdjacentBtn_MouseEnter);
            this.adjacentLBtn2.MouseLeave += new System.EventHandler(this.AdjacentBtn_MouseLeave);
            // 
            // adjacentLBtn1
            // 
            this.adjacentLBtn1.Location = new System.Drawing.Point(18, 16);
            this.adjacentLBtn1.Name = "adjacentLBtn1";
            this.adjacentLBtn1.RGB = "255,0,0";
            this.adjacentLBtn1.Size = new System.Drawing.Size(28, 28);
            this.adjacentLBtn1.TabIndex = 1;
            this.adjacentLBtn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdjacentBtn_MouseDown);
            this.adjacentLBtn1.MouseEnter += new System.EventHandler(this.AdjacentBtn_MouseEnter);
            this.adjacentLBtn1.MouseLeave += new System.EventHandler(this.AdjacentBtn_MouseLeave);
            // 
            // panelSelected
            // 
            this.panelSelected.Controls.Add(this.panelList);
            this.panelSelected.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelected.Location = new System.Drawing.Point(0, 344);
            this.panelSelected.Name = "panelSelected";
            this.panelSelected.Size = new System.Drawing.Size(264, 535);
            this.panelSelected.TabIndex = 1;
            // 
            // panelList
            // 
            this.panelList.AutoScroll = true;
            this.panelList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelList.Location = new System.Drawing.Point(17, 16);
            this.panelList.Name = "panelList";
            this.panelList.Padding = new System.Windows.Forms.Padding(15, 5, 15, 0);
            this.panelList.Size = new System.Drawing.Size(225, 507);
            this.panelList.TabIndex = 1;
            this.panelList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelList_Paint);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.Btn2);
            this.panelButton.Controls.Add(this.Btn1);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButton.Location = new System.Drawing.Point(94, 879);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(170, 109);
            this.panelButton.TabIndex = 2;
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn2.Location = new System.Drawing.Point(78, 58);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(75, 40);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "储存";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn1.Location = new System.Drawing.Point(78, 6);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 40);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "搭配";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelButton);
            this.panelMain.Controls.Add(this.panelSelected);
            this.panelMain.Controls.Add(this.panelShow);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(15, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(264, 988);
            this.panelMain.TabIndex = 3;
            // 
            // PanelSelecting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelMain);
            this.Name = "PanelSelecting";
            this.Size = new System.Drawing.Size(279, 988);
            this.Load += new System.EventHandler(this.PanelSelecting_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSelecting_Paint);
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.ShowPanel.ResumeLayout(false);
            this.panelSelected.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panelSelected;
        private System.Windows.Forms.Panel panelButton;
        private RoundButton adjacentLBtn3;
        private RoundButton adjacentLBtn2;
        private RoundButton adjacentLBtn1;
        private RoundButton adjacentCBtn3;
        private RoundButton adjacentCBtn2;
        private RoundButton adjacentCBtn1;
        private RoundButton adjacentHBtn3;
        private RoundButton adjacentHBtn2;
        private RoundButton adjacentHBtn1;
        private ButtonM checkMarkBtn;
        private System.Windows.Forms.Panel ShowPanel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label CNCSNum;
        private System.Windows.Forms.FlowLayoutPanel panelList;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
    }
}
