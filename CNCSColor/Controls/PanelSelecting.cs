using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CNCSColor.Controls
{
    public partial class PanelSelecting : UserControl
    {
        public PanelSelecting()
        {
            this.ShowRGBChangedEvent += new ValueChangedEventHandler(this.panelShow_ShowRGBChangedEvent);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); //支持背景透明
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            this.SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();

        }
        #region 主体
        /// <summary>
        /// 阴影宽度
        /// </summary>
        private int shadowWidth = 15;
        private void PanelSelecting_Load(object sender, EventArgs e)
        {
            init();
        }
        private void init()
        {
            this.panelMain.Left = shadowWidth; ;
            this.panelMain.Width = this.Width - shadowWidth;
            //this.panelShow.Left = shadowWidth;
            //this.panelShow.Width = this.Width - shadowWidth;
            //this.panelSelected.Left = shadowWidth;
            //this.panelSelected.Width = this.Width - shadowWidth;
            //this.panelSelected.Height=this.Height-this.panelShow.Bottom-
            //this.panelButton.Left = shadowWidth;
            //this.panelButton.Width = this.Width - shadowWidth;
            this.checkMarkBtn.BringToFront();
            this.checkMarkBtn.Left = this.ShowPanel.Width - this.checkMarkBtn.Width;
        }
        private void PanelSelecting_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                   new Point(shadowWidth, this.Height / 2),
                   new Point(0, this.Height / 2),
                   Color.FromArgb(100, 20, 20, 20),
                   this.BackColor);
            g.FillRectangle(linGrBrush, 0, 0, shadowWidth, this.Height);
        }
        #endregion

        #region panelShow
        public event ValueChangedEventHandler ShowRGBChangedEvent;
        /// <summary>
        /// 选中的色块颜色
        /// </summary>
        private string tempRGB;
        private string showRGB = "";
        [Description("选中的色块颜色")]
        public string ShowRGB
        {
            get { return showRGB; }
            set
            {
                if (showRGB != value)
                {
                    showRGB = value;
                    tempRGB = showRGB;
                    CNCSNum.Text = Tool.AuxiliaryAPI.RGB2xyz(tempRGB);
                    if (ShowRGBChangedEvent != null)
                        ShowRGBChangedEvent();
                    ShowPanel.Refresh();
                }
                
            }
        } 

        /// <summary>
        /// 绘制圆角矩形及实时背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            ShowPanel.BackColor = Tool.AuxiliaryAPI.String2RGB(tempRGB);         
            ShowPanel.Region = new Region(RoundStylePath(g, ShowPanel.ClientRectangle, 15));
        }
        private void ShowPanel_BackColorChanged(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Control control in this.panelList.Controls)
            {
                ButtonM temp = (ButtonM)control;
                if (temp.BackColor == ShowPanel.BackColor)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                checkMarkBtn.ImageM = CNCSColor.Properties.Resources.CheckMarkBlack;
                selectedflag = true;
            }
            else
            {
                checkMarkBtn.ImageM = CNCSColor.Properties.Resources.CheckMarkWhite;
                selectedflag = false;
            }
        }
        private void panelShow_ShowRGBChangedEvent()
        {
            SetNeiborColor();
        }
        private void SetNeiborColor()
        {
            if (CNCSNum.Text == "0,0,0"|| CNCSNum.Text == "") return;
            double[,] neiborColor = Tool.AuxiliaryAPI.GetNearColor(CNCSNum.Text,9);
            for (int i = 0; i < 9; i++)
            {
                string[] cncsnum = Tool.ExcelDataAPI.ExcelDataSet.Tables[0].Rows[(int)neiborColor[i, 0]][0].ToString().Split(' ');
                string rgb = Tool.ExcelDataAPI.RGB[Convert.ToInt16(cncsnum[0]), Convert.ToInt16(cncsnum[1]), Convert.ToInt16(cncsnum[2])];

                switch (i)
                {
                    case 0:
                        this.adjacentHBtn1.RGB = rgb;
                        break;
                    case 1:
                        this.adjacentHBtn2.RGB = rgb;
                        break;
                    case 2:
                        this.adjacentHBtn3.RGB = rgb;
                        break;
                    case 3:
                        this.adjacentLBtn1.RGB = rgb;
                        break;
                    case 4:
                        this.adjacentLBtn2.RGB = rgb;
                        break;
                    case 5:
                        this.adjacentLBtn3.RGB = rgb;
                        break;
                    case 6:
                        this.adjacentCBtn1.RGB = rgb;
                        break;
                    case 7:
                        this.adjacentCBtn2.RGB = rgb;
                        break;
                    case 8:
                        this.adjacentCBtn3.RGB = rgb;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 标识是否已经选取当前ShowPanel颜色
        /// </summary>
        private bool selectedflag = false;
        private void checkMarkBtn_ButtonClick(object sender, EventArgs e)
        {

            if(selectedflag)
                MessageBox.Show("该颜色已在列表中！");
            else
            {
                ButtonM btnM = new ButtonM();
                btnM.BackColor = ShowPanel.BackColor;
                btnM.TextM = CNCSNum.Text;
                try
                {
                    string[] HLC = btnM.TextM.Split(' ');
                    if (Convert.ToInt16(HLC[1]) > 80)
                    {
                        btnM.TextColor = Color.Black;
                    }
                    else
                    {
                        btnM.TextColor = Color.White;
                    }
                }
                catch (Exception)
                {
                }
                
                btnM.Size =new Size(panelList.Width-40,40);
                btnM.MouseClick += new MouseEventHandler(ListBtnMRemove_MouseClick);
                panelList.Controls.Add(btnM);
                checkMarkBtn.ImageM = CNCSColor.Properties.Resources.CheckMarkBlack;
                selectedflag = true;
            }

        }

        private void ListBtnMRemove_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                panelList.Controls.Remove((ButtonM)sender);
                ((ButtonM)sender).Dispose();
            }
        }

        /// <summary>
        /// 获得圆角矩形的路径
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rect"></param>
        /// <param name="cornerRadius"></param>
        private GraphicsPath RoundStylePath(Graphics g, Rectangle rect, int cornerRadius)
        {
            //AddTopLeftArc(rect, cornerRadius, path, radiusAdjustment);
            //AddTopRightArc(rect, cornerRadius, path, radiusAdjustment);
            //AddBottomRightArc(rect, cornerRadius, path, radiusAdjustment);
            //AddBottomLeftArc(rect, cornerRadius, path, radiusAdjustment);
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius, rect.Y);//3:rect.Right - cornerRadius * 2
            roundedRect.AddArc(rect.Right - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.X + rect.Width, rect.Y + cornerRadius, rect.X + rect.Width, rect.Bottom - cornerRadius);
            roundedRect.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 360, 90);
            roundedRect.AddLine(rect.Right - cornerRadius, rect.Bottom, rect.X + cornerRadius, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius, rect.X, rect.Y + cornerRadius);
            roundedRect.CloseFigure();
            return roundedRect;
        }

        #region AdjacentBtn 鼠标事件
        private void AdjacentBtn_MouseEnter(object sender, EventArgs e)
        {
            RoundButton roundBtn = (RoundButton)sender;
            tempRGB = roundBtn.RGB;
            CNCSNum.Text = Tool.AuxiliaryAPI.RGB2xyz(tempRGB);
            ShowPanel.Refresh();
        }

        private void AdjacentBtn_MouseLeave(object sender, EventArgs e)
        {
            tempRGB = ShowRGB;
            CNCSNum.Text = Tool.AuxiliaryAPI.RGB2xyz(tempRGB);
            ShowPanel.Refresh();
        }

        private void AdjacentBtn_MouseDown(object sender, MouseEventArgs e)
        {
            RoundButton roundBtn = (RoundButton)sender;
            ShowRGB = roundBtn.RGB;
            CNCSNum.Text = Tool.AuxiliaryAPI.RGB2xyz(tempRGB);
            ShowPanel.Refresh();
        }


        #endregion

        #endregion

        #region panelSelected

        private List<string> selectedTexts = new List<string>();
        [Description("选中的cncsnum字符串列表")]
        public List<string> SelectedTexts
        {
            get { return selectedTexts; }
            set
            {
                 selectedTexts = value;
            }
        }
        private void panelList_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            int cornerRadius = 15;
            Rectangle rect = new Rectangle(panelList.Location.X,panelList.Location.Y-10,panelList.Width-30,panelList.Height-30);
            GraphicsPath graphicsPath = new GraphicsPath();
            GraphicsPath regionPath = new GraphicsPath();

            regionPath.AddArc(panelList.ClientRectangle.X, panelList.ClientRectangle.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            regionPath.AddLine(panelList.ClientRectangle.X + cornerRadius, panelList.ClientRectangle.Y, panelList.ClientRectangle.Right - cornerRadius, panelList.ClientRectangle.Y);//3:panelList.ClientRectangle.Right - cornerRadius * 2
            regionPath.AddArc(panelList.ClientRectangle.Right - cornerRadius * 2, panelList.ClientRectangle.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            regionPath.AddLine(panelList.ClientRectangle.X + panelList.ClientRectangle.Width, panelList.ClientRectangle.Y + cornerRadius, panelList.ClientRectangle.X + panelList.ClientRectangle.Width, panelList.ClientRectangle.Bottom - cornerRadius);
            regionPath.AddArc(panelList.ClientRectangle.Right - cornerRadius * 2, panelList.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 360, 90);
            regionPath.AddLine(panelList.ClientRectangle.Right - cornerRadius, panelList.ClientRectangle.Bottom, panelList.ClientRectangle.X + cornerRadius, panelList.ClientRectangle.Bottom);
            regionPath.AddArc(panelList.ClientRectangle.X, panelList.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            regionPath.AddLine(panelList.ClientRectangle.X, panelList.ClientRectangle.Bottom - cornerRadius, panelList.ClientRectangle.X, panelList.ClientRectangle.Y + cornerRadius);
            panelList.Region = new Region(regionPath);
            graphicsPath.AddPath(regionPath,false);
            graphicsPath.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            graphicsPath.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius, rect.Y);//3:rect.Right - cornerRadius * 2
            graphicsPath.AddArc(rect.Right - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            graphicsPath.AddLine(rect.X + rect.Width, rect.Y + cornerRadius, rect.X + rect.Width, rect.Bottom - cornerRadius);
            graphicsPath.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 360, 90);
            graphicsPath.AddLine(rect.Right - cornerRadius, rect.Bottom, rect.X + cornerRadius, rect.Bottom);
            graphicsPath.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            graphicsPath.AddLine(rect.X, rect.Bottom - cornerRadius, rect.X, rect.Y + cornerRadius);
            graphicsPath.CloseFigure();
            PathGradientBrush pthGrBrush = new PathGradientBrush(graphicsPath);
            //pthGrBrush.CenterColor = Color.FromArgb(100, 20, 20, 20);
            pthGrBrush.CenterColor = Color.FromArgb(255, 20, 20, 20);
            Color[] colors = { this.BackColor }; 
            pthGrBrush.SurroundColors = colors;
            g.FillPath(pthGrBrush, graphicsPath);
        }

        #endregion

        #region panelButton
        /// <summary>
        /// 按钮1的文字提示
        /// </summary>
        private string btn1textM = "搭配";
        [Description("显示的文字")]
        public string Btn1TextM
        {
            get { return btn1textM; }
            set
            {
                btn1textM = value;
                Btn1.Text = btn1textM;
            }
        }
        /// <summary>
        /// 按钮2的文字提示
        /// </summary>
        private string btn2textM = "储存";
        [Description("显示的文字")]
        public string Btn2TextM
        {
            get { return btn2textM; }
            set
            {
                btn2textM = value;
                Btn2.Text = btn2textM;
            }
        }
        /// <summary>
        /// 控件单击事件
        /// </summary>
        public event EventHandler Button1Click;
        public event EventHandler Button2Click;
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (selectedTexts == null)
                selectedTexts = new List<string>();
            if(panelList.Controls.Count>0)
                selectedTexts.Clear();
            else
            {
                MessageBox.Show("列表中不存在已选颜色，无法搭配！");
                return;
            }
            foreach (ButtonM item in panelList.Controls)
            {
                selectedTexts.Add(item.TextM);
            }
            if (Button1Click != null)
                Button1Click(sender,e);
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Button2Click != null)
                Button2Click(sender, e);
        }
        #endregion


    }
}
