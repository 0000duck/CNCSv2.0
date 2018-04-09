using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            
            this.panelSelecting1.Left = this.panelDisplay1.Right;
        }

        /// <summary>
        /// 
        /// </summary>
        private void panelDisplay1_RGBChangedEvent()
        {
            if (panelDisplay1.RGB != "0,0,0")
            {
                panelSelecting1.ShowRGB = panelDisplay1.RGB;
            }
            Console.WriteLine(panelDisplay1.RGB+"/" + panelSelecting1.ShowRGB);
        }

        private void panelSelecting1_Button1Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Text);
            this.BodyPanelFirstSub2.BringToFront();
        }

        private void panelSelecting1_Button2Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Text);
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.BodyPanelFirstSub1.BringToFront();
        }

    }
}
