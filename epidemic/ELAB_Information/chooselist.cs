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
            inputForms c1 = new inputForms();
            this.Hide();
            c1.ShowDialog();
            this.Show();
        }
    }
}
