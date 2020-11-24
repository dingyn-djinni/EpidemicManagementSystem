/*
 * project: dlut epidemic management system v0.1
 * description：一个简单的，基于C#的小型疫情信息管理系统
 * date: 2020.11.23
 * author:team 0cal(Yuning Ding; Zian Wang; Xin Zhao; Shijie Wang)
 * developer:Yuning Ding; Zian Wang; Xin Zhao; Shijie Wang
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
    public class Config
    {
        public static int level;
        public static string id;
        //数据库连接语句，方便修改，（极为不安全,这句话本身应该做加密，普通用户应该使用只读数据库账号连接，对于管理员用户考虑输入数据库密码也不是不可以）
        private const string connectStr="server=140.143.54.132;port=3306;database=epidemic;user=root;password=6a406dee537e603d;";
        
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


    //日期处理函数
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
    }

    //md5函数类
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
