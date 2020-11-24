/*
 * name：管理员菜单
 * description：这一页面是管理员的菜单选择页面，提供了输入数据、修改数据和查看数据三个选项
 * date:2020.11.24
 * author:Yuning Ding; Zian Wang; Shijie Wang
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

namespace ELAB_Information
{
    public partial class chooselist : Form
    {
        public chooselist()
        {
            InitializeComponent();
        }

        //点击此按钮进入更新页面
        private void button1_Click(object sender, EventArgs e)
        {
            update c1 = new update();
            this.Hide();
            c1.ShowDialog();
            this.Show();
        }

        // 点击此按钮进入查询页面
        private void search_Click(object sender, EventArgs e)
        {
            searchForms c1 = new searchForms();
            this.Hide();
            c1.ShowDialog();
            this.Show();
        }

        private void input_Click(object sender, EventArgs e)
        {
            inputforms c1 = new inputforms();
            this.Hide();
            c1.ShowDialog();
            this.Show();
        }

        private void chooselist_Load(object sender, EventArgs e)
        {

        }
    }
}
