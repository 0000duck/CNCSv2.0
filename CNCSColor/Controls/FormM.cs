using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y.Utils.WindowsUtils.APIUtils;

namespace CNCSColor.Controls
{
    public partial class FormM : Form
    {
        #region 阴影
        //private Point _MouseLocation;
        //internal Point MouseLocation { get { return _MouseLocation; } }
        internal int ShadowWidth = 15;
        private ShadowForm Skin;
        #endregion
        public FormM()
        {
            this.OnlyOne += new EventHandler(this.navigation_OnlyOne); 
            InitializeComponent();
            ShowInTaskbar = false;
        }  

        /// <summary>
        /// 是否允许最大化
        /// </summary>
        private bool maxVisible = true;
        [Description("是否允许最大化")]
        public bool MaxVisible
        {
            get { return maxVisible; }
            set
            {
                maxVisible = value;
                if (!maxVisible)
                {
                    this.titleMin.Location = new System.Drawing.Point(titleMax.Location.X, 6);
                    titleMax.Visible = false;
                }
            }
        }
        /// <summary>
        /// 窗体标题
        /// </summary>
        private string titleText;
        [Description("窗体标题")]
        public string TitleText
        {
            get { return titleText; }
            set { titleText = value; }
        }
        /// <summary>
        /// 窗体标题是否显示
        /// </summary>
        private bool titleVisible = true;
        [Description("窗体标题是否显示")]
        public bool TitleVisible
        {
            get { return titleVisible; }
            set
            {
                titleVisible = value;
                title.Visible = titleVisible;
            }
        }
        /// <summary>
        /// 窗口默认大小
        /// FormSize.NORMAL OR FormSize.MAX
        /// </summary>
        private FormSize defaultFormSize = FormSize.NORMAL;
        [Description("窗口默认大小")]
        public FormSize DefaultFormSize
        {
            get { return defaultFormSize; }
            set
            {
                defaultFormSize = value;
                if (defaultFormSize == FormSize.MAX)
                {
                    //防止遮挡任务栏
                    this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                    this.WindowState = FormWindowState.Maximized;
                    //重置最大化图标
                    this.titleMax.ImageLeave = global::CNCSColor.Properties.Resources.title_bar_max3;
                    this.titleMax.ImageM = global::CNCSColor.Properties.Resources.title_bar_max3;
                    this.titleMax.ImageMove = global::CNCSColor.Properties.Resources.title_bar_max4;
                }
            }
        }

        /// <summary>
        /// 最小化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleMin_ButtonClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// 最大化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleMax_ButtonClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                //重置最大化图标
                this.titleMax.ImageLeave = global::CNCSColor.Properties.Resources.title_bar_max1;
                this.titleMax.ImageM = global::CNCSColor.Properties.Resources.title_bar_max1;
                this.titleMax.ImageMove = global::CNCSColor.Properties.Resources.title_bar_max2;
            }
            else
            {
                //防止遮挡任务栏
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
                //重置最大化图标
                this.titleMax.ImageLeave = global::CNCSColor.Properties.Resources.title_bar_max3;
                this.titleMax.ImageM = global::CNCSColor.Properties.Resources.title_bar_max3;
                this.titleMax.ImageMove = global::CNCSColor.Properties.Resources.title_bar_max4;
            }
        }
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleClose_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 无边框窗体移动、放大、缩小
        const int Guying_HTLEFT = 10;
        const int Guying_HTRIGHT = 11;
        const int Guying_HTTOP = 12;
        const int Guying_HTTOPLEFT = 13;
        const int Guying_HTTOPRIGHT = 14;
        const int Guying_HTBOTTOM = 15;
        const int Guying_HTBOTTOMLEFT = 0x10;
        const int Guying_HTBOTTOMRIGHT = 17;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMLEFT;
                        else m.Result = (IntPtr)Guying_HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)Guying_HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)Guying_HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)Guying_HTBOTTOM;
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }

        }
        private Point mPoint;
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }
        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        public enum FormSize
        {
            NORMAL = 0,//正常大小
            MAX = 1,//最大化
        };

        #region 阴影
        private void IrregularForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Skin = new ShadowForm(this);//创建皮肤层
                ShadowForm_LocationChanged(null, null);
                Skin.BackColor = Color.Red;
                Skin.Show();//显示皮肤层
            }
        }
        #region 减少闪烁
        private void SetStyles()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer, true);
            //强制分配样式重新应用到控件上
            UpdateStyles();
            base.AutoScaleMode = AutoScaleMode.None;
        }
        #endregion
        /// <summary>
        /// 窗体显示状态
        /// </summary>
        /// <param name="value"></param>
        public void Visibility(bool value)
        {
            if (value)
            {
                Show();
                Skin.Show();
            }
            else
            {
                Hide();
                Skin.Hide();
            }
        }
        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    base.OnMouseMove(e);
        //    Console.WriteLine("FormM:"+e.Location);
        //    //_MouseLocation = e.Location;
        //    //if (e.Button == MouseButtons.Left)
        //    //{
        //    //    FormStyleAPI.ReleaseCapture();
        //    //    FormStyleAPI.SendMessage(Handle, FormStyleAPI.WM_NCLBUTTONDOWN, FormStyleAPI.HTCAPTION, 0);
        //    //}
        //}
        private void ShadowForm_LocationChanged(object sender, EventArgs e)
        {
            if (Skin != null)
            {
                Skin.Location = new Point(Left - ShadowWidth, Top - ShadowWidth);
                Skin.DrawShadow();
            }
        }
        private void FormM_SizeChanged(object sender, EventArgs e)
        {
            if (Skin != null)
            {
                Skin.Size = this.Size;
                Skin.Width += (this.ShadowWidth * 2);
                Skin.Height += (this.ShadowWidth * 2);
                Skin.DrawShadow();
            }
        }
        #endregion

        #region navigation 

        /// <summary>
        /// 加阴影
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navigationBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            LinearGradientBrush linGrBrushTop = new LinearGradientBrush(
                   new Point(navigationBar.Width, 0),
                   new Point(navigationBar.Width, ShadowWidth),
                   titleBar.BackColor,
                   Color.FromArgb(100, 20, 20, 20));
            g.FillRectangle(linGrBrushTop, 0, 0, navigationBar.Width, 5);
            //LinearGradientBrush linGrBrushBottom = new LinearGradientBrush(
            //       new Point(navigationBar.Width, 0),
            //       new Point(navigationBar.Width, ShadowWidth),
            //       Color.FromArgb(200, 200, 200, 200),
            //       Color.FromArgb(255, 50, 50, 50));
            //g.FillRectangle(linGrBrushBottom, 0, navigationBar.Height-5, navigationBar.Width, 5);
        }

        public int navigationFlag = 0;
        private event EventHandler OnlyOne;
        public event EventHandler NavigationClick;
        private void navigation4_ButtonClick(object sender, EventArgs e)
        {
            navigationFlag = 4;
            if (OnlyOne != null)
                OnlyOne(sender, e);
            if (NavigationClick != null)
                NavigationClick(sender, e);
        }

        private void navigation3_ButtonClick(object sender, EventArgs e)
        {
            navigationFlag = 3;
            if (OnlyOne != null)
                OnlyOne(sender, e);
            if (NavigationClick != null)
                NavigationClick(sender, e);
        }

        private void navigation2_ButtonClick(object sender, EventArgs e)
        {
            navigationFlag = 2;
            if (OnlyOne != null)
                OnlyOne(sender, e);
            if (NavigationClick != null)
                NavigationClick(sender, e);
        }

        private void navigation1_ButtonClick(object sender, EventArgs e)
        {
            navigationFlag = 1;
            if (OnlyOne != null)
                OnlyOne(sender, e);
            if (NavigationClick != null)
                NavigationClick(sender, e);
        }

        private void navigation_OnlyOne(object sender, EventArgs e)
        {
            switch (navigationFlag)
            {
                case 1:
                    navigation1.Selected = true;
                    navigation2.Selected = false;
                    navigation3.Selected = false;
                    navigation4.Selected = false;
                    break;
                case 2:
                    navigation1.Selected = false;
                    navigation2.Selected = true;
                    navigation3.Selected = false;
                    navigation4.Selected = false;
                    break;
                case 3:
                    navigation1.Selected = false;
                    navigation2.Selected = false;
                    navigation3.Selected = true;
                    navigation4.Selected = false;
                    break;
                case 4:
                    navigation1.Selected = false;
                    navigation2.Selected = false;
                    navigation3.Selected = false;
                    navigation4.Selected = true;
                    break;
                default:
                    navigation1.Selected = false;
                    navigation2.Selected = false;
                    navigation3.Selected = false;
                    navigation4.Selected = false;
                    break;
            }
            navigation1.Invalidate();
            navigation2.Invalidate();
            navigation3.Invalidate();
            navigation4.Invalidate();

        }
        #endregion

    }
}
