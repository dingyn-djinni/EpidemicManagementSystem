/*
 * project: dlut epidemic management system v1.0
 * description: 一个简单的，基于C#的小型疫情信息管理系统
 * date: 2020.11.26
 * author: Team 0cal(Yuning Ding; Zian Wang; Xin Zhao; Shijie Wang)
 * developer: Yuning Ding; Zian Wang; Xin Zhao; Shijie Wang
 * art designer: Zian Wang; Xin Zhao; Shijie Wang
 * tester: Yuning Ding
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Text;
namespace ELAB_Information
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());
        }
    }

    // config类中记录了数据库交互中会用到的插入、修改、读取数据表中信息，数组转储读取数据函数，记录了登录者的等级信息。
    public class Config
    {
        public static int level;
        public static string id;
        //数据库连接语句，方便修改，（极为不安全,这句话本身应该做加密，普通用户应该使用只读数据库账号连接，对于管理员用户考虑输入数据库密码也不是不可以）
        private const string connectStr = "";
        //对数据库进行各种修改的统一语句
        public static int sqlExcuteChange(string sql)
        {
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();//跟数据库建立连接，并打开连接
         
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();//执行sql语句
                Console.WriteLine(result);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
       

        //对数据库进行各种查询的统一语句
        public static MySqlDataReader sqlSearch(string sql)
        {
            MySqlConnection conn = new MySqlConnection(Config.connectStr);
            try
            {
                conn.Open();//跟数据库建立连接，并打开连接
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();//执行查询
                return reader;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MySqlDataReader reader = null;
                return reader;
            }
            
        }

        //数组存储一列数据
        public static int[] setData(MySqlDataReader reader)
        {
            int[] tmp = new int[11];
            tmp[0] = reader.GetInt32("date");
            tmp[1] = reader.GetInt32("allDefinite");
            tmp[2] = reader.GetInt32("newDefinite");
            tmp[3] = reader.GetInt32("allCure");
            tmp[4] = reader.GetInt32("newCure");
            tmp[5] = reader.GetInt32("allDeath");
            tmp[6] = reader.GetInt32("newDeath");
            tmp[7] = reader.GetInt32("nowSuspected");
            tmp[8] = reader.GetInt32("newSuspected");
            tmp[9] = reader.GetInt32("nowDanger");
            tmp[10] = reader.GetInt32("newDanger");
            return tmp;
        }
    }


    //日期处理类Dates：存储了一整套日期记录函数
    public class Dates
    {
        private int[] daysInMonth;

        //初始化每月天数
        public Dates()
        {
            daysInMonth = new int[12];
            daysInMonth[0] = 31;
            daysInMonth[1] = 29;
            daysInMonth[2] = 31;
            daysInMonth[3] = 30;
            daysInMonth[4] = 31;
            daysInMonth[5] = 30;
            daysInMonth[6] = 31;
            daysInMonth[7] = 31;
            daysInMonth[8] = 30;
            daysInMonth[9] = 31;
            daysInMonth[10] = 30;
            daysInMonth[11] = 31;
        }

        //将日期数字转换为字符串
        public string getDateStr(int date)
        {
            for(int i = 0; i < 12; i++)
            {
                if (date - daysInMonth[i] >= 0)
                {
                    date = date - daysInMonth[i];
                }
                else
                {
                    string tmp = (i + 1).ToString() + "月" + date.ToString() + "日";
                    return tmp;
                }
            }
            return null;
        }

        //将日期数字转换成字符串（带年份）
        public string getDateStrNew(int date)
        {
            int year = 2020;
            int yearDays = 366;
            daysInMonth[1] = 29;
            while (date-yearDays > 0)
            {
                date = date - yearDays;
                year = year + 1;
                if (year % 4 == 0 && year % 100 != 0)
                {
                    daysInMonth[1] = 29;
                    yearDays = 366;
                }
                else
                {
                    daysInMonth[1] = 28;
                    yearDays = 365;
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (date - daysInMonth[i] >= 0)
                {
                    date = date - daysInMonth[i];
                }
                else
                {
                    string tmp = year.ToString()+"年"+(i + 1).ToString() + "月" + date.ToString() + "日";
                    return tmp;
                }
            }
            return null;
        }

        //将月和日转换成数字
        public int getStrDate(int mon,int day)
        {
            int i = 0;
            int days = 0;
            for(i = 0; i < mon-1; i++)
            {
                days = days + daysInMonth[i];
            }
            if (daysInMonth[i] >= day)
            {
                days = days + day;
                return days;
            }
            else
            {
                return 0;
            }
        }

        // 将年月日转换为字符串,从2020年开始计算
        public int getStrDateNew(int year,int mon,int day)
        {
            int days = 0;
            int i = 2020;
            if (year < 2020 )
            {
                return 0;
            }
            if(mon>12 || mon < 1)
            {
                return 0;
            }
            if (day < 1)
            {
                return 0;
            }
            for(i = 2020; i < year; i++)
            {
                if(i%4==0 && i % 100 != 0)
                {
                    daysInMonth[1] = 29;
                    days = days + 366;
                }
                else
                {
                    daysInMonth[1] = 28;
                    days = days + 365;
                }
                
            }
            if (i % 4 == 0 && i % 100 != 0)
            {
                daysInMonth[1] = 29;
            }
            else
            {
                daysInMonth[1] = 28;
            }
            for (int j = 0; j < mon - 1; j++)
            {
                days = days + daysInMonth[j];
            }
            if (daysInMonth[mon-1] >= day)
            {
                days = days + day;
                return days;
            }
            else
            {
                return 0;
            }
        }
    }

    //md5函数类，对传入数据库的密码进行加密处理
    public partial class MD5Helper
    {
        //md5加密
        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }

            Console.WriteLine(sb.ToString());
            // 返回加密的字符串
            return sb.ToString();
        }
    }
}
