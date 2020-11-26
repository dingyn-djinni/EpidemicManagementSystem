/*
 * name：疫情管理系统客户端
 * description：用户进入管理系统后显示的界面，可以实现多种查询
 * date:2020.11.24
 * author:Yuning Ding
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
using MySql.Data.MySqlClient;

namespace ELAB_Information
{

    public partial class searchForms : Form
    {
        int[] avers; //用于记录平均值
        int flg;    //记录输出行数
        string listname = "allData"; //记录当前表单名字
        
        public void initView()
        {
            //listView1.Items.Clear();
            listView1.Columns.Add("日期");
            listView1.Columns.Add("累计确诊");
            listView1.Columns.Add("新增确诊");
            listView1.Columns.Add("累计治愈");
            listView1.Columns.Add("新增治愈");
            listView1.Columns.Add("累计死亡");
            listView1.Columns.Add("新增死亡");
            listView1.Columns.Add("现有疑似");
            listView1.Columns.Add("累计疑似");
            listView1.Columns.Add("现有危重");
            listView1.Columns.Add("累计危重");
            listView1.View = System.Windows.Forms.View.Details;
        }

        //更新表单时用
        public int updateView(string sqlstr)
        {
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            flg = 0;
            if (reader == null){
                MessageBox.Show("未找到数据", "错误提示");
                return 0;
            }
            listView1.Items.Clear();
            while (reader.Read())
            {
                int[] data = new int[11];
                data = setData(reader);
                Dates dates = new Dates();
                string datestr = dates.getDateStrNew(data[0]);
                Console.WriteLine(datestr);
                listView1.Items.Add(datestr);
                for(int i = 1; i < 11; i++)
                {
                    listView1.Items[flg].SubItems.Add(data[i].ToString());
                }
                flg = flg + 1;
            }
            
            return 1;
        }

        //专门为平均值准备的查询
        public int updateViewForAver(string sqlstr)
        {
            int[] total = new int[10];
            for(int i = 0; i < 10; i++)
            {
                total[i] = 0;
            }
            MySqlDataReader reader = Config.sqlSearch(sqlstr);

            flg = 0;
            if (reader == null)
            {
                MessageBox.Show("未找到数据", "错误提示");
                return 0;
            }
            listView1.Items.Clear();
            while (reader.Read())
            {
                int[] data = new int[11];
                data = setData(reader);
                for(int i = 0; i < 10; i++)
                {
                    total[i] = total[i] + data[i+1];
                    
                }
                
                Dates dates = new Dates();
                string datestr = dates.getDateStrNew(data[0]);
                Console.WriteLine(datestr);
                listView1.Items.Add(datestr);
                for (int i = 1; i < 11; i++)
                {
                    listView1.Items[flg].SubItems.Add(data[i].ToString());
                }
                flg = flg + 1;
            }
            avers = new int[10]; //avers数组，用于记录平均数
            for(int i = 0; i < 10; i++)
            {
                avers[i]=total[i]/flg;
            }
            return 1;
        }

        //初始化时从全国表单中读取所有信息
        public searchForms()
        {
            InitializeComponent();
            initView();
            string sqlstr = "select * from "+listname;
            updateView(sqlstr);
            if (Config.level == 1)
            {
                button3.Text = "返回";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchForms_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //按照省份查找
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sqlstr = "select * from provinceList where name='" + name + "'";
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            if (reader == null)
            {
                MessageBox.Show("数据错误", "错误提示");
                return;
            }

            if (reader.Read())
            {
                string province = reader.GetString("province");
                listname = province;
                sqlstr = "select * from " + province;
                updateView(sqlstr);
            }
            else
            {
                MessageBox.Show("未找到数据", "错误提示");
            }
        }

        //点击显示全国数据
        private void allData_Click(object sender, EventArgs e)
        {
            listname = "allData";
            string sqlstr = "select * from " + listname;
            if (updateView(sqlstr) == 1)
            {
  
            }

        }

        //数组转储数据
        private int[] setData( MySqlDataReader reader)
        {
            int[] m = new int[11]; 
            m[0] = reader.GetInt32("date");
            m[1] = reader.GetInt32("allDefinite");
            m[2] = reader.GetInt32("newDefinite");
            m[3] = reader.GetInt32("allCure");
            m[4] = reader.GetInt32("newCure");
            m[5] = reader.GetInt32("allDeath");
            m[6] = reader.GetInt32("newDeath");
            m[7] = reader.GetInt32("nowSuspected");
            m[8] = reader.GetInt32("newSuspected");
            m[9] = reader.GetInt32("nowDanger");
            m[10] = reader.GetInt32("newDanger");
            return m;
        }
        //点击查看拐点信息（写到这里才想起来C#有list，之前一直都在郁闷为什么C#没有vector)
        private void keyPoint_Click(object sender, EventArgs e)
        {
            string sqlstr = "select * from allData";
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            if (reader == null)
            {
                MessageBox.Show("数据错误", "错误提示");
                return;
            }

            int check1 = 0;
            int check2 = 0;
            int tmp = 0;
            int[] maybeData = new int[11];
            listView1.Items.Clear();
            flg = 0;
            while (reader.Read())
            {
                if (reader.GetInt32("newDefinite") > tmp)
                {
                    check1 = check1 + 1;
                    if (check1 >= 5)
                    {
                        maybeData=setData(reader);
                    }
                }
                else if(reader.GetInt32("newDefinite") == tmp)
                {

                }
                else
                {
                    if (check1 >=5)
                    {
                        
                        check2 = check2 + 1;
                        check1 = 5;
                    }
                    else
                    {
                        check1 = 0;
                        check2 = 0;
                    }
                }
                tmp=reader.GetInt32("newDefinite");
                if (check1 >= 5 && check2 >= 5)
                {
                    Console.WriteLine(maybeData[0]);
                    listView1.Items.Add(maybeData[0].ToString());
                    for (int i = 0; i < 11; i++)
                    {
                        listView1.Items[flg].SubItems.Add(maybeData[i].ToString());
                    }
                    flg = flg + 1;
                    check1 = 0;
                    check2 = 0;
                }
            }
            


        }

        private void startdates_TextChanged(object sender, EventArgs e)
        {

        }

        private void enddates_TextChanged(object sender, EventArgs e)
        {

        }

        //点击生成平均值
        private void averdata_Click(object sender, EventArgs e)
        {
            int m1; //起始月份
            int m2; //终止月份
            int d1; //起始日期
            int d2; //终止日期
            int y1; //起始年份
            int y2; //终止年份
            try
            {
                m1 = int.Parse(month1.Text);
                m2 = int.Parse(month2.Text);
                d1 = int.Parse(day1.Text);
                d2 = int.Parse(day2.Text);
                y1 = int.Parse(yearText1.Text);
                y2 = int.Parse(yearText2.Text);

                Dates dates = new Dates();
                int days1=dates.getStrDateNew(y1,m1, d1);
                int days2 = dates.getStrDateNew(y2,m2, d2);

                //判断日期是否合理
                if(days1==0 || days2 == 0)
                {
                    MessageBox.Show("日期非法", "错误提示");
                    return;
                }
                
                if (days2 - days1 > 0)
                {
                    string sqlstr= "select* from allData where date >= " + days1.ToString() +"&&"+"date <= "+ days2.ToString();
                    Console.WriteLine(sqlstr);
                    if (updateViewForAver(sqlstr) == 1)
                    {
                        listView1.Items.Add("平均数据");
                        for (int i = 0; i < 10; i++)
                        {
                            listView1.Items[flg].SubItems.Add(avers[i].ToString());
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("数据错误", "错误提示");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据错误", "错误提示");
            }
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void month1_TextChanged(object sender, EventArgs e)
        {

        }

        private void day1_TextChanged(object sender, EventArgs e)
        {

        }

        private void month2_TextChanged(object sender, EventArgs e)
        {

        }

        private void day2_TextChanged(object sender, EventArgs e)
        {

        }

        // 图表显示
        private void viewmode_Click(object sender, EventArgs e)
        {
            DataChart c1 = new DataChart();
            c1.ShowDialog();
        }

        //列表排序
        private void ListviewSort()
        {
            for(int i = 0; i < flg; i++)
            {
                int max = 0;
                int idx = 0;
                for(int j = 0; j < flg-i; j++)
                {
                    int tmp = int.Parse(listView1.Items[j].SubItems[1].Text);
                    if (tmp > max)
                    {
                        max = tmp;
                        idx = j;
                    }
                }
                listView1.Items.Add(listView1.Items[idx].SubItems[0].Text);
                for(int p = 0; p < 10; p++)
                {
                    listView1.Items[flg].SubItems.Add(listView1.Items[idx].SubItems[p+1].Text);
                }
                listView1.Items[idx].Remove();
                
            }
        }
        // 按省份进行排序
        private void sort_Click(object sender, EventArgs e)
        {
            List<string[]> provinceList = new List<string[]>();
            string sqlstr = "select * from provinceList";
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            if (reader == null)
            {
                MessageBox.Show("数据错误", "错误提示");
                return;
            }

            while (reader.Read())
            {
                string[] provinceInfo = new string[2];
                provinceInfo[0] = reader.GetString("province");
                provinceInfo[1] = reader.GetString("name");
                provinceList.Add(provinceInfo);
            }
            listView1.Items.Clear();
            flg = 0;
            foreach (string[] provinceInfo in provinceList)
            {
                sqlstr = "select * from "+provinceInfo[0];
                reader = Config.sqlSearch(sqlstr);
                if (reader == null)
                {
                    MessageBox.Show("数据错误", "错误提示");
                    return;
                }

                int[] provinceData = new int[11];
                while (reader.Read())
                {
                    provinceData = setData(reader);
                }
                listView1.Items.Add(provinceInfo[1].ToString());
                for (int i = 1; i < 11; i++)
                {
                    listView1.Items[flg].SubItems.Add(provinceData[i].ToString());
                }
                
                flg = flg + 1;
                
            }
            ListviewSort();
        }

        // 按照城市名称查询
        private void button2_Click(object sender, EventArgs e)
        {
            string name = cityText.Text;
            string sqlstr = "select * from cityList where name='" + name + "'";
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            if (reader == null)
            {
                MessageBox.Show("数据错误", "错误提示");
                return;
            }

            if (reader.Read())
            {
                string city = reader.GetString("province");
                listname = city;
                sqlstr = "select * from " + city;
                updateView(sqlstr);
            }
            else
            {
                MessageBox.Show("未找到数据", "错误提示");
            }
        }

        private void cityText_TextChanged(object sender, EventArgs e)
        {

        }

        //点击后，管理员返回菜单，用户退出
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
