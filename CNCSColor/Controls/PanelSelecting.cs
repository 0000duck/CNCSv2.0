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
        public event RGBChangedEventHandler ShowRGBChangedEvent;
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
            if (ShowPanel.BackColor == Color.FromArgb(255, 255, 0, 0))
                checkMarkBtn.ImageM = CNCSColor.Properties.Resources.CheckMarkBlack;
            else
                checkMarkBtn.ImageM = CNCSColor.Properties.Resources.CheckMarkWhite;
            ShowPanel.Region = new Region(RoundStylePath(g, ShowPanel.ClientRectangle, 15));
        }


        private void checkMarkBtn_ButtonClick(object sender, EventArgs e)
        {
            /*
            if ()
                MessageBox.Show("该颜色已在列表中！");
            else
                MessageBox.Show(ShowRGB);
            */
        }

        /// <summary>
        /// 绘制圆角矩形
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rect"></param>
        /// <param name="cornerRadius"></param>
        private void AddAllRoundStyle(Graphics g, Rectangle rect, int cornerRadius, Brush rectBrush)
        {
            //AddTopLeftArc(rect, cornerRadius, path, radiusAdjustment);
            //AddTopRightArc(rect, cornerRadius, path, radiusAdjustment);
            //AddBottomRightArc(rect, cornerRadius, path, radiusAdjustment);
            //AddBottomLeftArc(rect, cornerRadius, path, radiusAdjustment);
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2,180,90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius, rect.Y);//3:rect.Right - cornerRadius * 2
            roundedRect.AddArc(rect.Right - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.X + rect.Width, rect.Y + cornerRadius, rect.X + rect.Width, rect.Bottom - cornerRadius);
            roundedRect.AddArc(rect.Right - cornerRadius * 2, rect.Bottom-cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 360, 90);
            roundedRect.AddLine(rect.Right - cornerRadius, rect.Bottom, rect.X + cornerRadius, rect.Bottom);
            roundedRect.AddArc(rect.X , rect.Bottom - cornerRadius*2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom- cornerRadius, rect.X, rect.Y+ cornerRadius);
            roundedRect.CloseFigure();
            g.FillPath(rectBrush, roundedRect);
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

        #endregion

        #region panelButton

        #endregion


    }
}
