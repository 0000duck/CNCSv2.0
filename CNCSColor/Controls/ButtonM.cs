﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCSColor.Controls
{
    public partial class ButtonM : UserControl
    {
        public ButtonM()
        {
            InitializeComponent();
        }
                /// <summary>
        /// 控件的默认图片
        /// </summary>
        private Image imageM = null;
        [Description("控件的默认图片")]
        public Image ImageM
        {
            get { return imageM; }
            set
            {
                imageM = value;
                label.Image = imageM;
            }
        }
        /// <summary>
        /// 光标移动到控件上方显示的图片
        /// </summary>
        private Image imageMove = null;
        [Description("光标移动到控件上方显示的图片")]
        public Image ImageMove
        {
            get { return imageMove; }
            set { imageMove = value; }
        }
        /// <summary>
        /// 光标离开控件显示的图片
        /// </summary>
        private Image imageLeave = null;
        [Description("光标离开控件显示的图片")]
        public Image ImageLeave
        {
            get { return imageLeave; }
            set { imageLeave = value; }
        }
        /// <summary>
        /// 控件的背景色
        /// </summary>
        private Color backColorM = Color.Transparent;
        [Description("控件的背景色")]
        public Color BackColorM
        {
            get { return backColorM; }
            set
            {
                backColorM = value;
                label.BackColor = backColorM;
            }
        }
        /// <summary>
        /// 控件选中背景色
        /// </summary>
        private Color backColorSelected = Color.Transparent;
        [Description("控件选中背景色")]
        public Color BackColorSelected
        {
            get { return backColorSelected; }
            set
            {
                backColorSelected = value;
            }
        }
        /// <summary>
        /// 光标移动到控件上方显示的颜色
        /// </summary>
        private Color backColorMove = Color.Transparent;
        [Description("光标移动到控件上方显示的颜色")]
        public Color BackColorMove
        {
            get { return backColorMove; }
            set { backColorMove = value; }
        }
        /// <summary>
        /// 光标离开控件显示的背景色
        /// </summary>
        private Color backColorLeave = Color.Transparent;
        [Description("光标离开控件显示的背景色")]
        public Color BackColorLeave
        {
            get { return backColorLeave; }
            set { backColorLeave = value; }
        }
        /// <summary>
        /// 控件的文字提示
        /// </summary>
        private string textM = "";
        [Description("显示的文字")]
        public string TextM
        {
            get { return textM; }
            set
            {
                textM = value;
                label.Text = textM;
            }
        }
        /// <summary>
        /// 文字的颜色
        /// </summary>
        private Color textColor = Color.Black;
        [Description("文字的颜色")]
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                label.ForeColor = textColor;
            }
        }
        /// <summary>
        /// 光标移动到控件上方文字的颜色
        /// </summary>
        private Color textColorMove = Color.Transparent;
        [Description("光标移动到控件上方文字的颜色")]
        public Color TextColorMove
        {
            get { return textColorMove; }
            set
            {
                textColorMove = value;
            }
        }
        /// <summary>
        /// 光标离开控件文字的颜色
        /// </summary>
        private Color textColorLeave = Color.Transparent;
        [Description("光标离开控件文字的颜色")]
        public Color TextColorLeave
        {
            get { return textColorLeave; }
            set
            {
                textColorLeave = value;
            }
        }
        /// <summary>
        /// 控件选中文字的颜色
        /// </summary>
        private Color textColorSelected = Color.Transparent;
        
        [Description("控件选中文字的颜色")]
        public Color TextColorSelected
        {
            get { return textColorSelected; }
            set
            {
                textColorSelected = value;
            }
        }
        /// <summary>
        /// 用于显示文本的字体
        /// </summary>
        private Font fontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        [Description("用于显示文本的字体")]
        public Font FontM
        {
            get { return fontM; }
            set
            {
                fontM = value;
                label.Font = fontM;
            }
        }
        /// <summary>
        /// 标记控件是否选中
        /// </summary>
        private bool selected = false;
        [Description("标记控件是否选中")]
        public bool Selected
        {
            get { return selected; }
            set
            {
                if (selected != value)
                {
                    selected = value;
                    label_SelectedChanged();
                    this.Invalidate();
                }
            }
        }
        /// <summary>
        /// 单击事件
        /// </summary>
        public event EventHandler ButtonClick;
        /// <summary>
        /// 单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null)
            {
                ButtonClick(sender, e);
            }
        }
        /// <summary>
        /// 鼠标单击事件
        /// </summary>
        public new event MouseEventHandler MouseClick;
        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            if (MouseClick != null)
                MouseClick(label.Parent, e);
        }
        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (backColorMove != Color.Transparent && !Selected)
            {
                BackColorM = backColorMove;
            }
            if (imageMove != null)
            {
                ImageM = imageMove;
            }
            if (textColorMove != Color.Transparent && !Selected)
            {
                TextColor = textColorMove;
            }
           
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            if (backColorLeave != Color.Transparent && !Selected)
            {
                BackColorM = backColorLeave;
            }
            if (imageLeave != null)
            {
                ImageM = imageLeave;
            }
            if (textColorLeave != Color.Transparent && !Selected)
            {
                TextColor = textColorLeave;
            }
        }
        private void label_SelectedChanged()
        {
            if (Selected)
            {
                if (backColorSelected != Color.Transparent)
                    BackColorM = backColorSelected;
                if (textColorSelected != Color.Transparent)
                {
                    TextColor = textColorSelected;
                }
            }
            else
            {
                BackColorM = backColorLeave;
                TextColor = textColorLeave;
            }
        }
    }
}
