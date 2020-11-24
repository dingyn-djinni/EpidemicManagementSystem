using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
namespace ELAB_Information
{
    public partial class DataChart : Form
    {
        //数据列表
        List<int> datalist = new List<int>();
        //记录列表长度
        int flg = 0;
        public DataChart()
        {
            InitializeComponent();
            string sqlstr = "select * from allData";
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            flg = 0;
            while (reader.Read())
            {
                int tmp= reader.GetInt32("allDefinite");
                datalist.Add(tmp);
                flg = flg + 1;
            }
            chartInit();
        }

        //初始化图表，取最后十五天的数据
        private void chartInit()
        {
            
            // 设置曲线的样式
            Series series = chart1.Series[0];
            // 画样条曲线（Spline）
            series.ChartType = SeriesChartType.FastLine;
            // 线宽2个像素
            series.BorderWidth = 2;
            // 线的颜色：红色
            series.Color = System.Drawing.Color.Red;
            // 图示上的文字
            series.LegendText = "累计确诊";

            // 在chart中显示数据
            if (flg >= 15)
            {
                Dates dates = new Dates();
                for(int i = 0; i < 15; i++)
                {
                    series.Points.AddXY(i, datalist[flg-15+i]);
                    
                }
            }
            else
            {
                int x = 0;
                foreach (int v in datalist)
                {
                    series.Points.AddXY(x, v);
                    x++;
                }
            }

            // 设置显示范围
            ChartArea chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 14;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 20;
        }

        private void DataChart_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
