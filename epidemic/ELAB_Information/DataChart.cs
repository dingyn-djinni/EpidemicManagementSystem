/*
 * name：图表视图
 * description：这一页面是图表视图页面，以折线图的形式展示最近十五天的全国疫情走势
 * date:2020.11.24
 * author:Yuning Ding;
 */
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
        List<int[]> datalist = new List<int[]>();
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
                int[] dataArray = new int[5];
                dataArray[0]= reader.GetInt32("allDefinite");
                dataArray[1] = reader.GetInt32("allCure");
                dataArray[2] = reader.GetInt32("allDeath");
                dataArray[3] = reader.GetInt32("nowSuspected");
                dataArray[4] = reader.GetInt32("nowDanger");
                datalist.Add(dataArray);
                flg = flg + 1;
            }
            chartInit();
        }

        private Series InitSeries(int i,string LegendText,Color color)
        {
            // 设置曲线的样式
            Series series = chart1.Series[i];
            // 画样条曲线（Spline）
            series.ChartType = SeriesChartType.FastLine;
            // 线宽2个像素
            series.BorderWidth = 2;
            // 线的颜色：红色
            series.Color = color;
            // 图示上的文字
            series.LegendText = LegendText;

            return series;
        }

        //初始化图表，取最后十五天的数据
        private void chartInit()
        {

            Series[] serieslist = new Series[5];
            serieslist[0] = InitSeries(0, "累计确诊", Color.Red);
            serieslist[1] = InitSeries(1, "累计治愈", Color.Green);
            serieslist[2] = InitSeries(2, "累计死亡", Color.Black);
            serieslist[3] = InitSeries(3, "现有疑似", Color.Yellow);
            serieslist[4] = InitSeries(4, "现有重症", Color.Gray);

            // 在chart中显示数据
            if (flg >= 15)
            {
                Dates dates = new Dates();
                for(int i = 0; i < 15; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        serieslist[j].Points.AddXY(i, datalist[flg - 15 + i][j]);
                    }
           
                }
            }
            else
            {
                int x = 0;
                foreach (int[] v in datalist)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        serieslist[0].Points.AddXY(x, v[j]);
                    }
                    
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
