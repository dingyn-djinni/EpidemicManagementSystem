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
        //初始化时从全国表单中读取所有信息
        public searchForms()
        {
            InitializeComponent();
            string sqlstr = "select * from allData";
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            int flg = 0;
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
    }
}
