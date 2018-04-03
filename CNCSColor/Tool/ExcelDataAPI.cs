using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCSColor.Tool
{
    class ExcelDataAPI
    {
        public static DataSet ExcelDataSet;
        public static string[,,] HLC = new string[161, 101, 51];
        public static string[,,] RGB = new string[161, 101, 51];
        public static List<List<string>> Page2HLC = new List<List<string>>();
        public static string[,,] RGB2HLC = new string[256, 256, 256];
        public static string[,,] RGB2xyz = new string[256, 256, 256];
        static ExcelDataAPI()
        {
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            try
            {
                ExcelDataSet = GetExcelData(dir.FullName + @"\DataPart.xlsx");
                MessageBox.Show("Obtain local Excel!");
                InitRGB();
                InitHLC();
                InitPage();
                InitRGB2HLC();
                InitRGB2xyz();
                MessageBox.Show("Init success!");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed obtain local Excel!");
                throw;
            }
        }
        /// <summary>
        /// 读取Excel
        /// </summary>
        /// <param name="str"></param>
        /// <returns>返回Excel数据的dataset</returns>
        private static DataSet GetExcelData(string str)
        {
            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str + ";Extended Properties='Excel 8.0;HDR=NO;IMEX=1';";
            OleDbConnection myConn = new OleDbConnection(strCon);
            string strCom = " SELECT * FROM [Sheet1$]";
            myConn.Open();
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            DataSet myDataSet = new DataSet();
            myCommand.Fill(myDataSet, "[Sheet1$]");
            myConn.Close();
            return myDataSet;
        }
        /// <summary>
        /// 初始化xyz->RGB
        /// </summary>
        private static void InitRGB()
        {
            for (int i = 1; i < 3501; i++)
            {
                string[] cncs_num = ExcelDataSet.Tables[0].Rows[i][0].ToString().Split(' ');

                int x = Convert.ToInt16(cncs_num[0]);
                int y = Convert.ToInt16(cncs_num[1]);
                int z = Convert.ToInt16(cncs_num[2]);
                RGB[x, y, z] = ExcelDataSet.Tables[0].Rows[i][1] + "," + ExcelDataSet.Tables[0].Rows[i][2] + "," + ExcelDataSet.Tables[0].Rows[i][3];
            }
        }
        /// <summary>
        /// 初始化xyz->HLC
        /// </summary>
        private static void InitHLC()
        {
            for (int i = 1; i < 3501; i++)
            {
                string[] cncs_num = ExcelDataSet.Tables[0].Rows[i][0].ToString().Split(' ');
                int x = Convert.ToInt16(cncs_num[0]);
                int y = Convert.ToInt16(cncs_num[1]);
                int z = Convert.ToInt16(cncs_num[2]);
                HLC[x, y, z] = ExcelDataSet.Tables[0].Rows[i][4] + "," + ExcelDataSet.Tables[0].Rows[i][5] + "," + ExcelDataSet.Tables[0].Rows[i][6];
            }
        }
        /// <summary>
        /// 初始化page->HLC
        /// </summary>
        private static void InitPage()
        {
            for (int i = 0; i < 63; i++)
            {
                List<string> temp = new List<string>();
                Page2HLC.Add(temp);
            }
            for (int i = 1; i < 3501; i++)
            {
                int page = Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][12]);
                string item = i + "," + ExcelDataSet.Tables[0].Rows[i][4] + "," + ExcelDataSet.Tables[0].Rows[i][5] + "," + ExcelDataSet.Tables[0].Rows[i][6];
                //Console.WriteLine("page:"+ page+ "|"+ item);
                Page2HLC.ElementAt(page - 1).Add(item);
            }
        }
        /// <summary>
        /// 初始化RGB->HLC
        /// </summary>
        private static void InitRGB2HLC()
        {
            for (int i = 1; i < 3501; i++)
            {

                int r = Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][1]);
                int g = Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][2]);
                int b = Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][3]);
                RGB2HLC[r, g, b] = ExcelDataSet.Tables[0].Rows[i][4] + "," + ExcelDataSet.Tables[0].Rows[i][5] + "," + ExcelDataSet.Tables[0].Rows[i][6];
            }
        }
        /// <summary>
        /// 初始化RGB->HLC
        /// </summary>
        private static void InitRGB2xyz()
        {
            for (int i = 1; i < 3501; i++)
            {

                int r = Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][1]);
                int g = Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][2]);
                int b = Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][3]);
                RGB2xyz[r, g, b] = ExcelDataSet.Tables[0].Rows[i][0].ToString();
            }
        }


        #region 邻近色
        /// <summary>
        /// 获取距相应编号HLC邻近的9个颜色（包括其本身）
        /// </summary>
        /// <param name="hlc"></param>
        /// <returns></returns>
        public static double[,] NeiborColors(int[] hlc)
        {
            double[,] neiborColor = new double[9, 2];
            for (int i = 0; i < 9; i++)
            {
                neiborColor[i, 0] = 0;
                neiborColor[i, 1] = double.PositiveInfinity;
            }
            //计算neiborcolor
            for (int i = 1; i < 3501; i++)
            {
                double distance = EuclidDistance(hlc, i);
                if (distance < neiborColor[8, 1])
                {
                    neiborColor = UpdateNeiborColor(neiborColor, i, distance);

                }
            }
            //
            return neiborColor;
        }
        //(hlc[0] - Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][9]+161)%161
        /// <summary>
        /// 计算距离
        /// </summary>
        /// <param name="hlc"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private static double EuclidDistance(int[] hlc, int i)
        {
            double thetaHue = hlc[0] - Convert.ToDouble(ExcelDataSet.Tables[0].Rows[i][15]);
            //将0与160连成圈
            if (thetaHue > 80)
            {
                thetaHue = thetaHue - 160;
            }
            else if (thetaHue < -80)
            {
                thetaHue = thetaHue + 160;
            }
            double distance = Math.Sqrt(Math.Pow(thetaHue, 2) + Math.Pow(hlc[1] - Convert.ToDouble(ExcelDataSet.Tables[0].Rows[i][16]), 2) + Math.Pow(hlc[2] - Convert.ToDouble(ExcelDataSet.Tables[0].Rows[i][17]), 2));
            return distance;
        }
        /// <summary>
        /// 根据距离更新邻近色队列
        /// </summary>
        /// <param name="neibor"></param>
        /// <param name="row"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        private static double[,] UpdateNeiborColor(double[,] neibor, int row, double distance)
        {
            for (int i = 7; i >= 0; i--)
            {
                if (distance < neibor[i, 1])
                {
                    neibor[i + 1, 1] = neibor[i, 1];
                    neibor[i + 1, 0] = neibor[i, 0];
                    neibor[i, 1] = distance;
                    neibor[i, 0] = row;
                }
            }
            return neibor;
        }
        /// <summary>
        /// 获取距相应编号RGB邻近的9个颜色（包括其本身）
        /// </summary>
        /// <param name="rgb"></param>
        /// <returns></returns>
        public static double[,] NeiborColorsRGB(int[] rgb)
        {
            double[,] neiborColor = new double[9, 2];
            for (int i = 0; i < 9; i++)
            {
                neiborColor[i, 0] = 0;
                neiborColor[i, 1] = double.PositiveInfinity;
            }
            //计算neiborcolor
            for (int i = 1; i < 3501; i++)
            {
                double distance = EuclidDistanceRGB(rgb, i);
                if (distance < neiborColor[8, 1])
                {
                    neiborColor = UpdateNeiborColor(neiborColor, i, distance);

                }
            }
            //
            return neiborColor;
        }
        private static double EuclidDistanceRGB(int[] rgb, int i)
        {
            int thetaR = rgb[0] - Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][7]);

            double distance = Math.Sqrt(Math.Pow(thetaR, 2) + Math.Pow(rgb[1] - Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][8]), 2) + Math.Pow(rgb[2] - Convert.ToInt16(ExcelDataSet.Tables[0].Rows[i][9]), 2));
            return distance;
        }
        /// <summary>
        /// 获取距相应编号Lab邻近的9个颜色（包括其本身）
        /// </summary>
        /// <param name="lab"></param>
        /// <returns></returns>
        public static double[,] NeiborColorsLab(double[] lab)
        {
            double[,] neiborColor = new double[9, 2];
            for (int i = 0; i < 9; i++)
            {
                neiborColor[i, 0] = 0;
                neiborColor[i, 1] = double.PositiveInfinity;
            }
            //计算neiborcolor
            for (int i = 1; i < 3501; i++)
            {
                double distance = EuclidDistanceLab(lab, i);
                if (distance < neiborColor[8, 1])
                {
                    neiborColor = UpdateNeiborColor(neiborColor, i, distance);
                }
            }
            //
            return neiborColor;
        }
        private static double EuclidDistanceLab(double[] lab, int i)
        {
            double thetaR = lab[0] - Convert.ToDouble(ExcelDataSet.Tables[0].Rows[i][10]);

            double distance = Math.Sqrt(Math.Pow(thetaR, 2) + Math.Pow(lab[1] - Convert.ToDouble(ExcelDataSet.Tables[0].Rows[i][11]), 2) + Math.Pow(lab[2] - Convert.ToDouble(ExcelDataSet.Tables[0].Rows[i][12]), 2));
            return distance;
        }
        #endregion
    }
}
