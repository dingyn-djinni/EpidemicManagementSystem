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
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allDefinite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newDefinite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allCure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newCure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allDeath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newDeath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nowSuspected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newSuspected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nowDanger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newDanger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allData = new System.Windows.Forms.Button();
            this.viewmode = new System.Windows.Forms.Button();
            this.keyPoint = new System.Windows.Forms.Button();
            this.averdata = new System.Windows.Forms.Button();
            this.startdate = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.Label();
            this.startdates = new System.Windows.Forms.TextBox();
            this.enddates = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.allDefinite,
            this.newDefinite,
            this.allCure,
            this.newCure,
            this.allDeath,
            this.newDeath,
            this.nowSuspected,
            this.newSuspected,
            this.nowDanger,
            this.newDanger});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 75);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(682, 370);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // date
            // 
            this.date.Text = "日期";
            this.date.Width = 52;
            // 
            // allDefinite
            // 
            this.allDefinite.Text = "累计确诊";
            // 
            // newDefinite
            // 
            this.newDefinite.Text = "新增确诊";
            // 
            // allCure
            // 
            this.allCure.Text = "累计治愈";
            // 
            // newCure
            // 
            this.newCure.Text = "新增治愈";
            // 
            // allDeath
            // 
            this.allDeath.Text = "累计死亡";
            // 
            // newDeath
            // 
            this.newDeath.Text = "新增死亡";
            // 
            // nowSuspected
            // 
            this.nowSuspected.Text = "现有疑似";
            // 
            // newSuspected
            // 
            this.newSuspected.Text = "新增疑似";
            // 
            // nowDanger
            // 
            this.nowDanger.Text = "现有危重";
            // 
            // newDanger
            // 
            this.newDanger.Text = "新增危重";
            // 
            // allData
            // 
            this.allData.Location = new System.Drawing.Point(736, 75);
            this.allData.Name = "allData";
            this.allData.Size = new System.Drawing.Size(159, 36);
            this.allData.TabIndex = 1;
            this.allData.Text = "全国数据";
            this.allData.UseVisualStyleBackColor = true;
            // 
            // viewmode
            // 
            this.viewmode.Location = new System.Drawing.Point(736, 140);
            this.viewmode.Name = "viewmode";
            this.viewmode.Size = new System.Drawing.Size(159, 36);
            this.viewmode.TabIndex = 2;
            this.viewmode.Text = "图形显示";
            this.viewmode.UseVisualStyleBackColor = true;
            // 
            // keyPoint
            // 
            this.keyPoint.Location = new System.Drawing.Point(736, 204);
            this.keyPoint.Name = "keyPoint";
            this.keyPoint.Size = new System.Drawing.Size(159, 36);
            this.keyPoint.TabIndex = 3;
            this.keyPoint.Text = "拐点查看";
            this.keyPoint.UseVisualStyleBackColor = true;
            // 
            // averdata
            // 
            this.averdata.Location = new System.Drawing.Point(736, 260);
            this.averdata.Name = "averdata";
            this.averdata.Size = new System.Drawing.Size(159, 36);
            this.averdata.TabIndex = 4;
            this.averdata.Text = "平均数据";
            this.averdata.UseVisualStyleBackColor = true;
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Location = new System.Drawing.Point(705, 309);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(53, 12);
            this.startdate.TabIndex = 7;
            this.startdate.Text = "起始日期";
            this.startdate.Click += new System.EventHandler(this.label3_Click);
            // 
            // enddate
            // 
            this.enddate.AutoSize = true;
            this.enddate.Location = new System.Drawing.Point(705, 337);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(53, 12);
            this.enddate.TabIndex = 8;
            this.enddate.Text = "截止日期";
            // 
            // startdates
            // 
            this.startdates.Location = new System.Drawing.Point(765, 303);
            this.startdates.Name = "startdates";
            this.startdates.Size = new System.Drawing.Size(130, 21);
            this.startdates.TabIndex = 9;
            // 
            // enddates
            // 
            this.enddates.Location = new System.Drawing.Point(765, 334);
            this.enddates.Name = "enddates";
            this.enddates.Size = new System.Drawing.Size(130, 21);
            this.enddates.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "省份查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(765, 413);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 21);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "省份";
            // 
            // searchForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enddates);
            this.Controls.Add(this.startdates);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.averdata);
            this.Controls.Add(this.keyPoint);
            this.Controls.Add(this.viewmode);
            this.Controls.Add(this.allData);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "searchForms";
            this.Text = "查询";
            this.Load += new System.EventHandler(this.searchForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader allDefinite;
        private System.Windows.Forms.ColumnHeader newDefinite;
        private System.Windows.Forms.ColumnHeader allCure;
        private System.Windows.Forms.ColumnHeader newCure;
        private System.Windows.Forms.ColumnHeader allDeath;
        private System.Windows.Forms.ColumnHeader newDeath;
        private System.Windows.Forms.ColumnHeader nowSuspected;
        private System.Windows.Forms.ColumnHeader newSuspected;
        private System.Windows.Forms.ColumnHeader nowDanger;
        private System.Windows.Forms.ColumnHeader newDanger;
        private System.Windows.Forms.Button allData;
        private System.Windows.Forms.Button viewmode;
        private System.Windows.Forms.Button keyPoint;
        private System.Windows.Forms.Button averdata;
        private System.Windows.Forms.Label startdate;
        private System.Windows.Forms.Label enddate;
        private System.Windows.Forms.TextBox startdates;
        private System.Windows.Forms.TextBox enddates;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}