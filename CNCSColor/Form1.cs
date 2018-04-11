using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCSColor
{

    public partial class Form1 : Controls.FormM
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelSelecting1.Left = this.panelDisplay1.Right;
            panelSelecting1.ShowRGB = panelDisplay1.RGB;
            ruleCheckedListBox.SelectedIndex = 0;
            ruleCheckedListBox.SetItemChecked(0, true);
        }


        /// <summary>
        /// NavigationBar Click事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_NavigationClick(object sender, EventArgs e)
        {
            switch (navigationFlag)
            {
                case 1:
                    this.BodyPanelFirst.BringToFront();
                    break;
                case 2:
                    this.BodyPanelSecond.BringToFront();
                    break;
                case 3:
                    this.BodyPanelThird.BringToFront();
                    break;
                case 4:
                    this.BodyPanelFourth.BringToFront();
                    break;
                default:
                    this.BodyPanelFirst.BringToFront();
                    break;
            }
        }
        #region 色彩搭配

        #region 选色BodyPanelFirstSub1
        /// <summary>
        /// 图片上选色改变
        /// </summary>
        private void panelDisplay1_RGBChangedEvent()
        {
            if (panelDisplay1.RGB != "0,0,0")
            {
                panelSelecting1.ShowRGB = panelDisplay1.RGB;
            }
            //Console.WriteLine(panelDisplay1.RGB + "/" + panelSelecting1.ShowRGB);
        }
        /// <summary>
        /// 跳转到 搭配页面 BodyPanelFirstSub2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelSelecting1_Button1Click(object sender, EventArgs e)
        {
            panelMenu1.ControlsClear();
            panelMenu1.ControlAddByStringList(panelSelecting1.SelectedTexts);
            this.BodyPanelFirstSub2.BringToFront();
            //Console.WriteLine(panelMenu1.CNCSNum+"/"+ruleCheckedListBox.SelectedIndex);
        }
        /// <summary>
        /// 保存方案到云端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelSelecting1_Button2Click(object sender, EventArgs e)
        {
            //save
        }
        #endregion


        #region 搭配 BodyPanelFirstSub2
        /// <summary>
        /// Menu的隐藏和显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelMenu1_TriggerMouseClick(object sender, MouseEventArgs e)
        {
            if (panelMenu1.isFold)
            {
                panelMenu1.Left = 0;
                panelMenu1.isFold = false;

                ruleGroupBox.Left = 190;
            }
            else
            {
                panelMenu1.Left = -135;
                panelMenu1.isFold = true;

                ruleGroupBox.Left = 55;

            }
            panelMenu1.Refresh();
        }
        /// <summary>
        /// CNCSNumChangedEvent
        /// </summary>
        private void panelMenu1_CNCSNumChangedEvent()
        {
            Console.WriteLine(panelMenu1.CNCSNum);
        }

        /// <summary>
        /// 跳转至 选色BodyPanelFirstSub1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelSelecting2_Button2Click(object sender, EventArgs e)
        {
            this.BodyPanelFirstSub1.BringToFront();
        }

        
        private void ruleCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked) return;//取消选中就不用进行以下操作  
            for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
            {
                ((CheckedListBox)sender).SetItemChecked(i, false);//将所有选项设为不选中  
            }
            e.NewValue = CheckState.Checked;//刷新  

        }
        private void ruleCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(ruleCheckedListBox.SelectedIndex + "");
        }





        #endregion

        #endregion

 
    }

}
