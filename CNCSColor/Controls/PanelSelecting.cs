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
        private int shadowWidth = 15;
        public PanelSelecting()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); //支持背景透明
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            this.SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
            
        }
        private void PanelSelecting_Load(object sender, EventArgs e)
        {
            init();
        }
        private void init()
        {
            this.panelShow.Left = shadowWidth;
            this.panelShow.Width = this.Width - shadowWidth;
            this.panelSelectd.Left = shadowWidth;
            this.panelSelectd.Width = this.Width - shadowWidth;
            this.panelButton.Left = shadowWidth;
            this.panelButton.Width = this.Width - shadowWidth;
        }
        private void ShowButtonM_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            SolidBrush brush = new SolidBrush(Color.Red);
            AddAllRoundStyle(g, ShowButtonM.ClientRectangle, 15, brush);
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

        private void PanelSelecting_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                   new Point(shadowWidth, this.Height/2),
                   new Point(0, this.Height/2),
                   Color.FromArgb(100, 20, 20, 20),
                   this.BackColor );
            g.FillRectangle(linGrBrush, 0, 0, shadowWidth, this.Height);
        }

   
    }
}
