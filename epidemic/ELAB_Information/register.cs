/*
 * name：疫情管理系统注册界面
 * description：注册界面，用户在此界面完成注册
 * date:2020.11.24
 * author:Yuning Ding; Xin Zhao
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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            if (username.Text.Length >= 12)
            {
                MessageBox.Show("用户名不能过长", "错误提示");
                return;
            }
            if(password.Text.Length<6 || password.Text.Length > 16)
            {
                MessageBox.Show("密码长度必须在6-16位", "错误提示");
                return;
            }
            if (password.Text != checkPassword.Text)
            {
                MessageBox.Show("两次密码输入不相同", "错误提示");
                return;
            }
            string sqlstr="select * from userlist where id='" + username.Text + "'";
            MySqlDataReader reader = Config.sqlSearch(sqlstr);
            if (reader.Read())
            {
                MessageBox.Show("用户名存在", "错误提示");
                return;
            }
            else
            {
                string passwordMD5=MD5Helper.EncryptString(password.Text);
                sqlstr = "insert into userlist (id,level,password) values ('";
                sqlstr = sqlstr + username.Text + "',";
                sqlstr = sqlstr + 0.ToString() + ",";
                sqlstr = sqlstr + "'" + passwordMD5 + "')";
                Console.WriteLine(sqlstr);
                if (Config.sqlExcuteChange(sqlstr) == 1)
                {
                    MessageBox.Show("注册成功，即将返回登陆界面", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请检查网络连接", "错误提示");
                    return;
                }
            }

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
