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
        int[] avers;
        int flg;
        string listname = "allData";
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
                int date = reader.GetInt32("date");
                int allDefinite = reader.GetInt32("allDefinite");
                int newDefinite = reader.GetInt32("newDefinite");
                int allCure = reader.GetInt32("allCure");
                int newCure = reader.GetInt32("newCure");
                int allDeath = reader.GetInt32("allDeath");
                int newDeath = reader.GetInt32("newDeath");
                int nowSuspected = reader.GetInt32("nowSuspected");
                int newSuspected = reader.GetInt32("newSuspected");
                int nowDanger = reader.GetInt32("nowDanger");
                int newDanger = reader.GetInt32("newDanger");
                Dates dates = new Dates();
                string datestr = dates.getDateStr(date);
                Console.WriteLine(datestr);
                listView1.Items.Add(datestr);
                listView1.Items[flg].SubItems.Add(allDefinite.ToString());
                listView1.Items[flg].SubItems.Add(newDefinite.ToString());
                listView1.Items[flg].SubItems.Add(allCure.ToString());
                listView1.Items[flg].SubItems.Add(newCure.ToString());
                listView1.Items[flg].SubItems.Add(allDeath.ToString());
                listView1.Items[flg].SubItems.Add(newDeath.ToString());
                listView1.Items[flg].SubItems.Add(nowSuspected.ToString());
                listView1.Items[flg].SubItems.Add(newSuspected.ToString());
                listView1.Items[flg].SubItems.Add(nowDanger.ToString());
                listView1.Items[flg].SubItems.Add(newDanger.ToString());
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
                int date = reader.GetInt32("date");
                int allDefinite = reader.GetInt32("allDefinite");
                int newDefinite = reader.GetInt32("newDefinite");
                int allCure = reader.GetInt32("allCure");
                int newCure = reader.GetInt32("newCure");
                int allDeath = reader.GetInt32("allDeath");
                int newDeath = reader.GetInt32("newDeath");
                int nowSuspected = reader.GetInt32("nowSuspected");
                int newSuspected = reader.GetInt32("newSuspected");
                int nowDanger = reader.GetInt32("nowDanger");
                int newDanger = reader.GetInt32("newDanger");
                total[0] = total[0] + allDefinite;
                total[1] = total[1] + newDefinite;
                total[2] = total[2] + allCure;
                total[3] = total[3] + newCure;
                total[4] = total[4] + allDeath;
                total[5] = total[5] + newDeath;
                total[6] = total[6] + nowSuspected;
                total[7] = total[7] + newSuspected;
                total[8] = total[8] + newDanger;
                total[9] = total[9] + nowDanger;
                Dates dates = new Dates();
                string datestr = dates.getDateStr(date);
                Console.WriteLine(datestr);
                listView1.Items.Add(datestr);
                listView1.Items[flg].SubItems.Add(allDefinite.ToString());
                listView1.Items[flg].SubItems.Add(newDefinite.ToString());
                listView1.Items[flg].SubItems.Add(allCure.ToString());
                listView1.Items[flg].SubItems.Add(newCure.ToString());
                listView1.Items[flg].SubItems.Add(allDeath.ToString());
                listView1.Items[flg].SubItems.Add(newDeath.ToString());
                listView1.Items[flg].SubItems.Add(nowSuspected.ToString());
                listView1.Items[flg].SubItems.Add(newSuspected.ToString());
                listView1.Items[flg].SubItems.Add(nowDanger.ToString());
                listView1.Items[flg].SubItems.Add(newDanger.ToString());
                flg = flg + 1;
            }
            avers = new int[10];
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

        private void keyPoint_Click(object sender, EventArgs e)
        {

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
            try
            {
                m1 = int.Parse(month1.Text);
                m2 = int.Parse(month2.Text);
                d1 = int.Parse(day1.Text);
                d2 = int.Parse(day2.Text);
                Dates dates = new Dates();
                int days1=dates.getStrDate(m1, d1);
                int days2 = dates.getStrDate(m2, d2);

                //判断日期是否合理
                if(days1==0 || days2 == 0)
                {
                    MessageBox.Show("数据错误", "错误提示");
                    return;
                }
                
                if (days2 - days1 > 0)
                {
                    string sqlstr= "select* from allData where date >= '" + days1.ToString() + "'"+"&"+"date <= '"+ days2.ToString()+"'";
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
    }
}
