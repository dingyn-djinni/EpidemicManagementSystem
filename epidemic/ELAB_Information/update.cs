/*
 * name：管理员更新界面
 * description：用于管理员更新数据
 * date:2020.11.25
 * author:Zian Wang; Yuning Ding
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
    public partial class update : Form
    {
        int[] preDatalist; //用于记录先前数据
        int[] newDatalist; //记录输入数据,从左到右为0-4
        int[] changeDatalist; //记录变化数据
        int basedate; //基准日期
        string cityWord;//cityword:城市数据表名称
        string provinceWord; //省份数据表名称
        public update()
        {
            InitializeComponent();
        }

        //获取数据库现有数据
        private int getPreData()
        {
            try
            {
                int m = int.Parse(month.Text); //月
                int d = int.Parse(day.Text);  //日 
                Dates dates = new Dates();
                int searchDate = dates.getStrDate(m, d);
                basedate = searchDate;
                string name = city.Text;
                string sqlstr = "select* from cityList where name='" + name + "'";
                MySqlDataReader reader = Config.sqlSearch(sqlstr);
                if (reader == null)
                {
                    MessageBox.Show("数据错误", "错误提示");
                    return 0;
                }
                if (reader.Read())
                {
                    cityWord = reader.GetString("city");
                    provinceWord = reader.GetString("province");
                    sqlstr = "select* from " + cityWord + " where date=" + searchDate.ToString();
                    reader = Config.sqlSearch(sqlstr);
                    if (reader.Read())
                    {
                        preDatalist = Config.setData(reader);
                        return 1;
                    }
                    else
                    {
                        MessageBox.Show("该日数据未输入", "错误提示");
                        return 0;
                    }
                }
                else
                {
                    MessageBox.Show("找不到地区", "错误提示");
                    return 0;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确数据", "错误提示");
                return 0;
            }
        }

        //点击更新数据
        private void button1_Click(object sender, EventArgs e)
        {
            if (getPreData()==1)
            {
                newDatalist = new int[5];
                changeDatalist = new int[5];
                try
                {
                    newDatalist[0] = int.Parse(Definite.Text);
                    newDatalist[1] = int.Parse(Cure.Text);
                    newDatalist[2] = int.Parse(Death.Text);
                    newDatalist[3] = int.Parse(Suspected.Text);
                    newDatalist[4] = int.Parse(Danger.Text);
                    for(int i = 0; i < 5; i++)
                    {
                        changeDatalist[i] = newDatalist[i] - preDatalist[2 * i + 2];
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("请正确输入数据", "错误提示");
                    return;
                }
                updateData(cityWord);
                updateData(provinceWord);
                updateData("allData");
                MessageBox.Show("修改成功", "提示");
                return;

            }
            else
            {
                return;
            }
             
           
        }
        
        //更新数据表
        private void updateData(string listName)
        {
            string sqlstr =  "select* from " + listName + " where date>=" + basedate.ToString();
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            if (reader == null)
            {
                MessageBox.Show("数据错误", "错误提示");
                return;
            }
            int[] thisDatalist = new int[11];
            if (reader.Read())
            {
                thisDatalist = Config.setData(reader);
                for(int i = 1; i < 11; i++)
                {
                    thisDatalist[i] = thisDatalist[i] + changeDatalist[(i-1) / 2];
                }
                sqlstr = "update " + listName + " set ";
                sqlstr = sqlstr + "allDefinite = " + thisDatalist[1] + ",";
                sqlstr = sqlstr + "newDefinite = " + thisDatalist[2] + ",";
                sqlstr = sqlstr + "allCure = " + thisDatalist[3] + ",";
                sqlstr = sqlstr + "newCure = " + thisDatalist[4] + ",";
                sqlstr = sqlstr + "allDeath = " + thisDatalist[5] + ",";
                sqlstr = sqlstr + "newDeath = " + thisDatalist[6] + ",";
                sqlstr = sqlstr + "nowSuspected = " + thisDatalist[7] + ",";
                sqlstr = sqlstr + "newSuspected = " + thisDatalist[8] + ",";
                sqlstr = sqlstr + "nowDanger  = " + thisDatalist[9] + ",";
                sqlstr = sqlstr + "newDanger = " + thisDatalist[10];
                sqlstr = sqlstr + " where date=" + thisDatalist[0];
                Console.WriteLine(sqlstr);
                Config.sqlExcuteChange(sqlstr);
            }
            while (reader.Read())
            {
                thisDatalist = Config.setData(reader);
                for(int i = 0; i < 5; i++)
                {
                    thisDatalist[i * 2 + 1] = thisDatalist[i * 2 + 1] + changeDatalist[i];
                }
                sqlstr = "update " + listName + " set ";
                sqlstr = sqlstr + "allDefinite = " + thisDatalist[1] + ",";
                sqlstr = sqlstr + "allCure = " + thisDatalist[3] + ",";
                sqlstr = sqlstr + "allDeath = " + thisDatalist[5] + ",";
                sqlstr = sqlstr + "nowSuspected = " + thisDatalist[7] + ",";
                sqlstr = sqlstr + "nowDanger  = " + thisDatalist[9];
                sqlstr = sqlstr + " where date=" + thisDatalist[0];
                Console.WriteLine(sqlstr);
                Config.sqlExcuteChange(sqlstr);
            }
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        //点击搜索
        private void search_Click(object sender, EventArgs e)
        {
            if (getPreData() == 1)
            {
                Definite.Text = preDatalist[2].ToString();
                Cure.Text = preDatalist[4].ToString();
                Death.Text = preDatalist[6].ToString();
                Suspected.Text = preDatalist[8].ToString();
                Danger.Text = preDatalist[10].ToString();
            }
            else
            {
                return;
            }
            

        }

        private void month_TextChanged(object sender, EventArgs e)
        {

        }

        private void day_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void Definite_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cure_TextChanged(object sender, EventArgs e)
        {

        }

        private void Death_TextChanged(object sender, EventArgs e)
        {

        }

        private void Suspected_TextChanged(object sender, EventArgs e)
        {

        }

        private void Danger_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
