/*
 * name：疫情管理系统管理员输入界面
 * description：管理员通过此界面录入信息
 * date:2020.11.24
 * author:Shijie Wang; Yuning Ding
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
    public partial class inputFormsNew : Form
    {
        int basedate; //基准日期
        int[] changedatalist;
        
        public inputFormsNew()
        {
            InitializeComponent();
            textBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string province; //省份
            string city;  //城市
            string sqlstr = "select* from cityList where name='" + provinceName.Text + "'";
            int[] datalist = new int[11];
            for(int i = 0; i < 11; i++)
            {
                datalist[i] = 0;
            }
            int[] inputdata;
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            if (reader.Read())
            {
                province = reader.GetString("province");
                city = reader.GetString("city");
                int date = int.Parse(textBox1.Text);
                sqlstr = "select* from " + city+" where date="+(date-1).ToString();
                reader = Config.sqlSearch(sqlstr);
                if(reader.Read())
                {
                    datalist = Config.setData(reader);
                }
                inputdata = datalist;
                
                try
                {
                    inputdata[0] = date;
                    inputdata[2] = int.Parse(newDefinite.Text);
                    inputdata[4] = int.Parse(newCure.Text);
                    inputdata[6] = int.Parse(newDeath.Text);
                    inputdata[8] = int.Parse(newSuspected.Text);
                    inputdata[10] = int.Parse(newDanger.Text);
                    
                    for(int i = 0; i < 5; i++)
                    {
                        inputdata[i * 2 + 1] = datalist[i * 2 + 1] + inputdata[i * 2 + 2];
                        if(inputdata[i * 2 + 1] < 0)
                        {
                            MessageBox.Show("数据不合法", "提示");
                            return;
                        }
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("错误输入", "提示");
                    return;
                }
                sqlstr = "insert into " + city + " (date,allDefinite,newDefinite,allCure,newCure,allDeath,newDeath,nowSuspected,newSuspected,nowDanger,newDanger) values (";
                for(int i = 0; i < 10; i++)
                {
                    sqlstr = sqlstr + inputdata[i] + ",";
                }
                sqlstr = sqlstr + inputdata[10] + ")";
                Console.WriteLine(sqlstr);
                if (Config.sqlExcuteChange(sqlstr) == 1)
                {  
                    textBox1.Text = (inputdata[0] + 1).ToString();
                    basedate = inputdata[0];
                    changedatalist = inputdata;
                    //这个地方出错需要回滚，需要加强鲁棒性
                    updateProvince(province,basedate,changedatalist);
                    updateAll(basedate, changedatalist);
                    MessageBox.Show("添加成功", "提示");
                    return;
                }
                else
                {
                    MessageBox.Show("数据库未正常连接", "提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("数据错误", "提示");
                return;
            }
        }

        //用于查询地区
        private void provinceName_TextChanged(object sender, EventArgs e)
        {
            int date = 0;
            string sqlstr = "select* from cityList where name='" + provinceName.Text+"'";
            string province; //省份
            string city;  //城市
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            if (reader.Read())
            {
                province = reader.GetString("province");
                city= reader.GetString("city");
                sqlstr = "select* from " + city;
                reader = Config.sqlSearch(sqlstr);
                while (reader.Read())
                {
                    date = reader.GetInt32("date");
                }
                Dates dates = new Dates();
                textBox1.Text = (date+1).ToString();
                nextDate.Text = dates.getDateStr(date + 1);

            }
            else
            {
                return;
            }

        }

        //更新省级数据
        private void updateProvince(string province,int basedate,int[] changedatalist)
        {
            int[] datalist = new int[11];
            string sqlstr = "select* from " + province + " where date>=" + basedate.ToString();
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            //如果可以搜索到当天，需要更新数据
            if (reader.Read())
            {
                datalist = Config.setData(reader);
                for(int i = 0; i < 5; i++)
                {
                    datalist[i * 2 + 1] = datalist[i * 2 + 1] + changedatalist[i * 2 + 2];
                    datalist[i * 2 + 2] = datalist[i * 2 + 2] + changedatalist[i * 2 + 2];
                }
                sqlstr = "update " + province + " set ";
                sqlstr=sqlstr+ "allDefinite = " + datalist[1]+",";
                sqlstr = sqlstr + "newDefinite = " + datalist[2] + ",";
                sqlstr = sqlstr + "allCure = " + datalist[3] + ",";
                sqlstr = sqlstr + "newCure = " + datalist[4] + ",";
                sqlstr = sqlstr + "allDeath = " + datalist[5] + ",";
                sqlstr = sqlstr + "newDeath = " + datalist[6] + ",";
                sqlstr = sqlstr + "nowSuspected = " + datalist[7] + ",";
                sqlstr = sqlstr + "newSuspected = " + datalist[8] + ",";
                sqlstr = sqlstr + "nowDanger  = " + datalist[9] + ",";
                sqlstr = sqlstr + "newDanger = " + datalist[10];
                sqlstr = sqlstr + " where date=" + datalist[0];
                Console.WriteLine(sqlstr);
                Config.sqlExcuteChange(sqlstr);
                while (reader.Read())
                {
                    datalist = Config.setData(reader);
                    for (int i = 0; i < 5; i++)
                    {
                        datalist[i * 2 + 1] = datalist[i * 2 + 1] + changedatalist[i * 2 + 2];
                        datalist[i * 2 + 2] = datalist[i * 2 + 2] ;
                    }
                    sqlstr = "update " + province + " set ";
                    sqlstr = sqlstr + "allDefinite = " + datalist[1] + ",";
                    sqlstr = sqlstr + "newDefinite = " + datalist[2] + ",";
                    sqlstr = sqlstr + "allCure = " + datalist[3] + ",";
                    sqlstr = sqlstr + "newCure = " + datalist[4] + ",";
                    sqlstr = sqlstr + "allDeath = " + datalist[5] + ",";
                    sqlstr = sqlstr + "newDeath = " + datalist[6] + ",";
                    sqlstr = sqlstr + "nowSuspected = " + datalist[7] + ",";
                    sqlstr = sqlstr + "newSuspected = " + datalist[8] + ",";
                    sqlstr = sqlstr + "nowDanger  = " + datalist[9] + ",";
                    sqlstr = sqlstr + "newDanger = " + datalist[10];
                    sqlstr = sqlstr + " where date=" + datalist[0];
                    Console.WriteLine(sqlstr);
                    Config.sqlExcuteChange(sqlstr);
                }
                
            }
            // 如果不能搜索到当天，需要插入数据
            else
            {
                sqlstr = "select* from " + province + " where date=" + (basedate-1).ToString();
                reader = Config.sqlSearch(sqlstr);
                //有初始数据时
                if (reader.Read())
                {
                    datalist = Config.setData(reader);
                    datalist[0] = datalist[0] + 1;
                    for (int i = 0; i < 5; i++)
                    {
                        datalist[i * 2 + 1] = datalist[i * 2 + 1] + changedatalist[i * 2 + 2];
                        datalist[i * 2 + 2] = changedatalist[i * 2 + 2];
                    }
                    sqlstr = "insert into " + province + " (date,allDefinite,newDefinite,allCure,newCure,allDeath,newDeath,nowSuspected,newSuspected,nowDanger,newDanger) values (";
                    for (int i = 0; i < 10; i++)
                    {
                        sqlstr = sqlstr + datalist[i] + ",";
                    }
                    sqlstr = sqlstr + datalist[10] + ")";
                    if (Config.sqlExcuteChange(sqlstr) == 1)
                    {

                    }
                }
                //没有初始数据时
                else
                {
                    sqlstr = "insert into " + province + " (date,allDefinite,newDefinite,allCure,newCure,allDeath,newDeath,nowSuspected,newSuspected,nowDanger,newDanger) values (";
                    for (int i = 0; i < 10; i++)
                    {
                        sqlstr = sqlstr + changedatalist[i] + ",";
                    }
                    sqlstr = sqlstr + changedatalist[10] + ")";
                    if (Config.sqlExcuteChange(sqlstr) == 1)
                    {
                        
                    }
                    
                }
            }

        }

        //更新全国数据
        private void updateAll(int basedate, int[] changedatalist)
        {

            int[] datalist = new int[11];
            string sqlstr = "select* from " + "allData" + " where date>=" + basedate.ToString();
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            //如果可以搜索到当天，需要更新数据
            if (reader.Read())
            {
                datalist = Config.setData(reader);
                for (int i = 0; i < 5; i++)
                {
                    datalist[i * 2 + 1] = datalist[i * 2 + 1] + changedatalist[i * 2 + 2];
                    datalist[i * 2 + 2] = datalist[i * 2 + 2] + changedatalist[i * 2 + 2];
                }
                sqlstr = "update " + "allData" + " set ";
                sqlstr = sqlstr + "allDefinite = " + datalist[1] + ",";
                sqlstr = sqlstr + "newDefinite = " + datalist[2] + ",";
                sqlstr = sqlstr + "allCure = " + datalist[3] + ",";
                sqlstr = sqlstr + "newCure = " + datalist[4] + ",";
                sqlstr = sqlstr + "allDeath = " + datalist[5] + ",";
                sqlstr = sqlstr + "newDeath = " + datalist[6] + ",";
                sqlstr = sqlstr + "nowSuspected = " + datalist[7] + ",";
                sqlstr = sqlstr + "newSuspected = " + datalist[8] + ",";
                sqlstr = sqlstr + "nowDanger  = " + datalist[9] + ",";
                sqlstr = sqlstr + "newDanger = " + datalist[10];
                sqlstr = sqlstr + " where date=" + datalist[0];
                Console.WriteLine(sqlstr);
                Config.sqlExcuteChange(sqlstr);
                while (reader.Read())
                {
                    datalist = Config.setData(reader);
                    for (int i = 0; i < 5; i++)
                    {
                        datalist[i * 2 + 1] = datalist[i * 2 + 1] + changedatalist[i * 2 + 2];
                        datalist[i * 2 + 2] = datalist[i * 2 + 2];
                    }
                    sqlstr = "update " + "allData" + " set ";
                    sqlstr = sqlstr + "allDefinite = " + datalist[1] + ",";
                    sqlstr = sqlstr + "newDefinite = " + datalist[2] + ",";
                    sqlstr = sqlstr + "allCure = " + datalist[3] + ",";
                    sqlstr = sqlstr + "newCure = " + datalist[4] + ",";
                    sqlstr = sqlstr + "allDeath = " + datalist[5] + ",";
                    sqlstr = sqlstr + "newDeath = " + datalist[6] + ",";
                    sqlstr = sqlstr + "nowSuspected = " + datalist[7] + ",";
                    sqlstr = sqlstr + "newSuspected = " + datalist[8] + ",";
                    sqlstr = sqlstr + "nowDanger  = " + datalist[9] + ",";
                    sqlstr = sqlstr + "newDanger = " + datalist[10];
                    sqlstr = sqlstr + " where date=" + datalist[0];
                    Console.WriteLine(sqlstr);
                    Config.sqlExcuteChange(sqlstr);
                }

            }
            // 如果不能搜索到当天，需要插入数据
            else
            {
                sqlstr = "select* from " + "allData" + " where date=" + (basedate - 1).ToString();
                reader = Config.sqlSearch(sqlstr);
                //有初始数据时
                if (reader.Read())
                {
                    datalist = Config.setData(reader);
                    datalist[0] = datalist[0] + 1;
                    for (int i = 0; i < 5; i++)
                    {
                        datalist[i * 2 + 1] = datalist[i * 2 + 1] + changedatalist[i * 2 + 2];
                        datalist[i * 2 + 2] = changedatalist[i * 2 + 2];
                    }
                    sqlstr = "insert into " + "allData" + " (date,allDefinite,newDefinite,allCure,newCure,allDeath,newDeath,nowSuspected,newSuspected,nowDanger,newDanger) values (";
                    for (int i = 0; i < 10; i++)
                    {
                        sqlstr = sqlstr + datalist[i] + ",";
                    }
                    sqlstr = sqlstr + datalist[10] + ")";
                    if (Config.sqlExcuteChange(sqlstr) == 1)
                    {

                    }
                }
                //没有初始数据时
                else
                {
                    sqlstr = "insert into " + "allData" + " (date,allDefinite,newDefinite,allCure,newCure,allDeath,newDeath,nowSuspected,newSuspected,nowDanger,newDanger) values (";
                    for (int i = 0; i < 10; i++)
                    {
                        sqlstr = sqlstr + changedatalist[i] + ",";
                    }
                    sqlstr = sqlstr + changedatalist[10] + ")";
                    if (Config.sqlExcuteChange(sqlstr) == 1)
                    {

                    }

                }
            }
        }

        private void inputFormsNew_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //退出程序
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newDefinite_TextChanged(object sender, EventArgs e)
        {

        }

        private void newSuspected_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
