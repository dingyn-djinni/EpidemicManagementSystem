namespace ELAB_Information
{
    partial class update
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Definite = new System.Windows.Forms.TextBox();
            this.Cure = new System.Windows.Forms.TextBox();
            this.Death = new System.Windows.Forms.TextBox();
            this.Suspected = new System.Windows.Forms.TextBox();
            this.Danger = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "月         日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "新增确诊";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "新增治愈";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "新增死亡";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "疑似变化";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "重症变化";
            // 
            // Definite
            // 
            this.Definite.Location = new System.Drawing.Point(123, 171);
            this.Definite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Definite.Name = "Definite";
            this.Definite.Size = new System.Drawing.Size(89, 25);
            this.Definite.TabIndex = 7;
            this.Definite.TextChanged += new System.EventHandler(this.Definite_TextChanged);
            // 
            // Cure
            // 
            this.Cure.Location = new System.Drawing.Point(244, 171);
            this.Cure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cure.Name = "Cure";
            this.Cure.Size = new System.Drawing.Size(89, 25);
            this.Cure.TabIndex = 8;
            this.Cure.TextChanged += new System.EventHandler(this.Cure_TextChanged);
            // 
            // Death
            // 
            this.Death.Location = new System.Drawing.Point(339, 171);
            this.Death.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Death.Name = "Death";
            this.Death.Size = new System.Drawing.Size(89, 25);
            this.Death.TabIndex = 9;
            this.Death.TextChanged += new System.EventHandler(this.Death_TextChanged);
            // 
            // Suspected
            // 
            this.Suspected.Location = new System.Drawing.Point(433, 171);
            this.Suspected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Suspected.Name = "Suspected";
            this.Suspected.Size = new System.Drawing.Size(89, 25);
            this.Suspected.TabIndex = 10;
            this.Suspected.TextChanged += new System.EventHandler(this.Suspected_TextChanged);
            // 
            // Danger
            // 
            this.Danger.Location = new System.Drawing.Point(537, 171);
            this.Danger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Danger.Name = "Danger";
            this.Danger.Size = new System.Drawing.Size(89, 25);
            this.Danger.TabIndex = 11;
            this.Danger.TextChanged += new System.EventHandler(this.Danger_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(152, 91);
            this.month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(89, 25);
            this.month.TabIndex = 13;
            this.month.TextChanged += new System.EventHandler(this.month_TextChanged);
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(274, 92);
            this.day.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(59, 25);
            this.day.TabIndex = 14;
            this.day.TextChanged += new System.EventHandler(this.day_TextChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(362, 92);
            this.city.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(89, 25);
            this.city.TabIndex = 16;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "地区";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(523, 97);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 25);
            this.search.TabIndex = 19;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 445);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.city);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Danger);
            this.Controls.Add(this.Suspected);
            this.Controls.Add(this.Death);
            this.Controls.Add(this.Cure);
            this.Controls.Add(this.Definite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "update";
            this.Text = "更新";
            this.Load += new System.EventHandler(this.update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Definite;
        private System.Windows.Forms.TextBox Cure;
        private System.Windows.Forms.TextBox Death;
        private System.Windows.Forms.TextBox Suspected;
        private System.Windows.Forms.TextBox Danger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search;
    }
}