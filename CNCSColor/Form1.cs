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
    }
}
