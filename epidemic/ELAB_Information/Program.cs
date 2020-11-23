/*
 * project: dlut epidemic management system v0.1
 * date: 2020.11.23
 * author:Yuning Ding; Zian Wang; Xin Zhao; Shijie Wang
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
        //数据库连接语句，方便修改，（极为不安全,之后会改为调用php交互数据库，也会对关键代码做混淆）
        public const string connectStr="server=140.143.54.132;port=3306;database=epidemic;user=root;password=6a406dee537e603d;";
        
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
