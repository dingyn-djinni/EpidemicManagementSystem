namespace ELAB_Information
{
    partial class searchForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.allData = new System.Windows.Forms.Button();
            this.viewmode = new System.Windows.Forms.Button();
            this.keyPoint = new System.Windows.Forms.Button();
            this.averdata = new System.Windows.Forms.Button();
            this.startdate = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.month1 = new System.Windows.Forms.TextBox();
            this.day1 = new System.Windows.Forms.TextBox();
            this.month2 = new System.Windows.Forms.TextBox();
            this.day2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sort = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 94);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(908, 462);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // allData
            // 
            this.allData.Location = new System.Drawing.Point(981, 94);
            this.allData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allData.Name = "allData";
            this.allData.Size = new System.Drawing.Size(212, 45);
            this.allData.TabIndex = 1;
            this.allData.Text = "全国数据";
            this.allData.UseVisualStyleBackColor = true;
            this.allData.Click += new System.EventHandler(this.allData_Click);
            // 
            // viewmode
            // 
            this.viewmode.Location = new System.Drawing.Point(981, 146);
            this.viewmode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewmode.Name = "viewmode";
            this.viewmode.Size = new System.Drawing.Size(212, 45);
            this.viewmode.TabIndex = 2;
            this.viewmode.Text = "图表显示";
            this.viewmode.UseVisualStyleBackColor = true;
            this.viewmode.Click += new System.EventHandler(this.viewmode_Click);
            // 
            // keyPoint
            // 
            this.keyPoint.Location = new System.Drawing.Point(981, 249);
            this.keyPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keyPoint.Name = "keyPoint";
            this.keyPoint.Size = new System.Drawing.Size(212, 45);
            this.keyPoint.TabIndex = 3;
            this.keyPoint.Text = "拐点查看";
            this.keyPoint.UseVisualStyleBackColor = true;
            this.keyPoint.Click += new System.EventHandler(this.keyPoint_Click);
            // 
            // averdata
            // 
            this.averdata.Location = new System.Drawing.Point(981, 301);
            this.averdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.averdata.Name = "averdata";
            this.averdata.Size = new System.Drawing.Size(212, 45);
            this.averdata.TabIndex = 4;
            this.averdata.Text = "平均数据";
            this.averdata.UseVisualStyleBackColor = true;
            this.averdata.Click += new System.EventHandler(this.averdata_Click);
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Location = new System.Drawing.Point(956, 369);
            this.startdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(67, 15);
            this.startdate.TabIndex = 7;
            this.startdate.Text = "起始日期";
            this.startdate.Click += new System.EventHandler(this.label3_Click);
            // 
            // enddate
            // 
            this.enddate.AutoSize = true;
            this.enddate.Location = new System.Drawing.Point(956, 404);
            this.enddate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(67, 15);
            this.enddate.TabIndex = 8;
            this.enddate.Text = "截止日期";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "省份查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1020, 498);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 25);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(956, 501);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "省份";
            // 
            // month1
            // 
            this.month1.Location = new System.Drawing.Point(1029, 360);
            this.month1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.month1.Name = "month1";
            this.month1.Size = new System.Drawing.Size(37, 25);
            this.month1.TabIndex = 14;
            this.month1.TextChanged += new System.EventHandler(this.month1_TextChanged);
            // 
            // day1
            // 
            this.day1.Location = new System.Drawing.Point(1103, 360);
            this.day1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(37, 25);
            this.day1.TabIndex = 15;
            this.day1.TextChanged += new System.EventHandler(this.day1_TextChanged);
            // 
            // month2
            // 
            this.month2.Location = new System.Drawing.Point(1029, 400);
            this.month2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.month2.Name = "month2";
            this.month2.Size = new System.Drawing.Size(37, 25);
            this.month2.TabIndex = 16;
            this.month2.TextChanged += new System.EventHandler(this.month2_TextChanged);
            // 
            // day2
            // 
            this.day2.Location = new System.Drawing.Point(1103, 400);
            this.day2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(37, 25);
            this.day2.TabIndex = 17;
            this.day2.TextChanged += new System.EventHandler(this.day2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1075, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1075, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1157, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1157, 404);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "日";
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(981, 199);
            this.sort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(212, 45);
            this.sort.TabIndex = 22;
            this.sort.Text = "省份排序";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(980, 531);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 45);
            this.button2.TabIndex = 23;
            this.button2.Text = "城市查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(956, 587);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "城市";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(1021, 584);
            this.cityText.Margin = new System.Windows.Forms.Padding(4);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(172, 25);
            this.cityText.TabIndex = 25;
            this.cityText.TextChanged += new System.EventHandler(this.cityText_TextChanged);
            // 
            // searchForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 642);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.day2);
            this.Controls.Add(this.month2);
            this.Controls.Add(this.day1);
            this.Controls.Add(this.month1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.averdata);
            this.Controls.Add(this.keyPoint);
            this.Controls.Add(this.viewmode);
            this.Controls.Add(this.allData);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "searchForms";
            this.Text = "疫情数据管理系统客户端";
            this.Load += new System.EventHandler(this.searchForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button allData;
        private System.Windows.Forms.Button viewmode;
        private System.Windows.Forms.Button keyPoint;
        private System.Windows.Forms.Button averdata;
        private System.Windows.Forms.Label startdate;
        private System.Windows.Forms.Label enddate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox month1;
        private System.Windows.Forms.TextBox day1;
        private System.Windows.Forms.TextBox month2;
        private System.Windows.Forms.TextBox day2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cityText;
    }
}