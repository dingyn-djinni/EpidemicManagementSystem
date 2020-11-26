/*
 * name：疫情管理系统登陆界面
 * description：登陆界面，用户可以注册账号并登录，管理员可使用管理员账号登陆
 * date:2020.11.23
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

    public partial class Form1 : Form
    {
        private string password;
        
        public Form1()
        {
            InitializeComponent();
            Config.level = 0;
        }
        
        //数据库访问函数,用于寻找用户
        public int sqlSearchUser(string inputId)
        {
            
            try
            {
                
                string sql = "select * from userlist where id='" + inputId + "'";
                MySqlDataReader reader = Config.sqlSearch(sql);//执行查询
                if (reader == null)
                {
                    return 0;
                }
                try
                {
                    reader.Read();
                    password = reader.GetString("password");
                    Config.level = reader.GetInt32("level");
                    return 1; //返回为1，说明找到用户名
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return 2; //返回为2，未找到用户名
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }

        }

        // 在此输入用户学号
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // 在此输入用户密码
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void login_Click(object sender, EventArgs e)
        {
            //用户名不能超过12的字符
            if (textBox1.Text.Length >= 12 )
            {
                MessageBox.Show("用户名不能过长", "错误提示");
                return;
            }
            if (textBox2.Text.Length<6 || textBox2.Text.Length > 16)
            {
                MessageBox.Show("密码长度必须为6-16位", "错误提示");
                return;
            }
            if (sqlSearchUser(textBox1.Text) == 0)
            {
                MessageBox.Show("未正确连接数据库，请检查网络连接后再次尝试", "错误提示");
                return;
            }
            else if(sqlSearchUser(textBox1.Text) == 2)
            {
                MessageBox.Show("未找到此用户", "错误提示");
                return;
            }
            //如果是管理员，则设定等级为1
            if (MD5Helper.EncryptString(textBox2.Text) == password && Config.level==1)
            {
                Config.id = textBox1.Text;
                MessageBox.Show("管理员登录", "登录提示");
                chooselist c1 = new chooselist();
                //Hide函数用于隐藏窗体，但不会真正退出
                this.Hide();
                c1.ShowDialog();
                this.Close();
            }
            else if(MD5Helper.EncryptString(textBox2.Text) == password && Config.level == 0)
            {
                Config.id = textBox1.Text;
                MessageBox.Show("欢迎访问", "登录提示");
                searchForms c1 = new searchForms();
                //Hide函数用于隐藏窗体，但不会真正退出
                this.Hide();
                c1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "登录提示");
                //this.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //用户注册，只能注册普通用户
        private void register_Click(object sender, EventArgs e)
        {
            register c1 = new register();
            this.Hide();
            c1.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
