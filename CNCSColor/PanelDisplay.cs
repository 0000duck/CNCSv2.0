﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CNCSColor
{
    public delegate void RGBChangedEventHandler();
    public partial class PanelDisplay : UserControl
    {
        private Rectangle PointerRect;
        private double deltaX, deltaY;
        private Bitmap bmp;
        Pen pen = new Pen(Color.FromArgb(200, 255, 255, 255), 2);
        /// <summary>
        /// 变换了选择块事件
        /// </summary>
        public event RGBChangedEventHandler RGBChangedEvent;

        /// <summary>
        /// 选中色块的RGB
        /// </summary>
        private string _RGB = "";
        [Description("选中色块的RGB")]
        public string RGB
        {
            get { return _RGB; }
            set
            {
                if (_RGB != value)
                {
                    _RGB = value;
                    if (RGBChangedEvent != null)
                    {
                        RGBChangedEvent();
                    }
                }
                
            }
        }
        public PanelDisplay()
        {
            this.MouseDown += new MouseEventHandler(this.PanelDisplay_MouseDown);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); //支持背景透明
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            InitializeComponent();
            deltaX = this.Width / 63;
            deltaY = this.Height / 76;
        }
        /// <summary>
        /// 大小改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelDisplay_SizeChanged(object sender, EventArgs e)
        {
            deltaX = this.Width / 63;
            deltaY = this.Height / 76;
        }
       
        #region 控件绘制
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            //画pointer 

            //this.PointerRect.Location = new PointF(this.Width / 2 - PointerRadius, this.Height / 2 - PointerRadius);

            PointerRect = new Rectangle(this.PointerRect.Location.X, this.PointerRect.Location.Y, (int)deltaX, (int)deltaY);

            g.DrawRectangle(pen, PointerRect);
            base.OnPaint(e);  //调用ColorWheel_Paint();
            //Console.WriteLine("Onpaint  after base!!");

        }
        #endregion

        /// <summary>
        /// 区域生长法确定坐标点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void PanelDisplay_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        int x = e.Location.X;
        //        int y = e.Location.Y;
        //        bool flagX = false;
        //        bool flagY = false;
        //        string sRgb = getPixel(e.Location.X, e.Location.Y);
        //        int resultX = 0, resultY = 0;
        //        do
        //        {
        //            if (x == 0)
        //            {
        //                resultX = x;
        //                flagX = true;
        //            }
        //            else
        //            {
        //                if (!flagX)
        //                {
        //                    if (getPixel(x - 1, y) != sRgb)
        //                    {
        //                        resultX = x;
        //                        flagX = true;
        //                    }
        //                    else x--;
        //                }

        //            }
        //            if (y == 0)
        //            {
        //                resultY = y;
        //                flagY = true;
        //            }
        //            else
        //            {
        //                if (!flagY)
        //                {
        //                    if (getPixel(x, y - 1) != sRgb)
        //                    {
        //                        resultY = y;
        //                        flagY = true;
        //                    }
        //                    else y--;
        //                }

        //            }
        //            if (flagX && flagY) break;
        //        } while (getPixel(x, y) == sRgb);
        //        this.PointerRect.Location = new Point(resultX, resultY);
        //        this.Invalidate();
        //    }
        //}
        
        /// <summary>
        /// 固定窗口和控件大小后确定坐标点 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            //Console.WriteLine(deltaX+","+deltaY+"/"+this.Size+"/"+(double)this.Height/76);
            int minusX=(int)(e.Location.X % deltaX);
            int minuxY = (int)(e.Location.Y % deltaY);
            RGB = getPixel(e.Location.X,e.Location.Y);
            this.PointerRect.Location = new Point(e.Location.X-minusX, e.Location.Y-minuxY);
            this.Invalidate();
        }

        /// <summary>
        /// 获取（x，y）像素值
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public string getPixel(float x, float y)
        {
            using (bmp = new Bitmap(this.Width, this.Height))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(CNCSColor.Properties.Resources.Display2520x1444, 0, 0, this.Width, this.Height);//可修改
                }
                // Console.WriteLine(x + "," + y);
                Color c = bmp.GetPixel((int)x, (int)y);
                return c.R + "," + c.G + "," + c.B;
            }
        }

        
    }
}
