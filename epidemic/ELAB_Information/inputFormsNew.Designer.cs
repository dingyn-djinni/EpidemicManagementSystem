namespace ELAB_Information
{
    partial class inputFormsNew
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
            this.input = new System.Windows.Forms.Button();
            this.newDanger = new System.Windows.Forms.TextBox();
            this.newSuspected = new System.Windows.Forms.TextBox();
            this.newDeath = new System.Windows.Forms.TextBox();
            this.newCure = new System.Windows.Forms.TextBox();
            this.newDefinite = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.provinceName = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(227, 267);
            this.input.Margin = new System.Windows.Forms.Padding(2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(126, 33);
            this.input.TabIndex = 29;
            this.input.Text = "输入";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.button1_Click);
            // 
            // newDanger
            // 
            this.newDanger.Location = new System.Drawing.Point(201, 224);
            this.newDanger.Margin = new System.Windows.Forms.Padding(2);
            this.newDanger.Name = "newDanger";
            this.newDanger.Size = new System.Drawing.Size(87, 21);
            this.newDanger.TabIndex = 27;
            this.newDanger.Text = "0";
            // 
            // newSuspected
            // 
            this.newSuspected.Location = new System.Drawing.Point(202, 194);
            this.newSuspected.Margin = new System.Windows.Forms.Padding(2);
            this.newSuspected.Name = "newSuspected";
            this.newSuspected.Size = new System.Drawing.Size(87, 21);
            this.newSuspected.TabIndex = 26;
            this.newSuspected.Text = "0";
            this.newSuspected.TextChanged += new System.EventHandler(this.newSuspected_TextChanged);
            // 
            // newDeath
            // 
            this.newDeath.Location = new System.Drawing.Point(202, 164);
            this.newDeath.Margin = new System.Windows.Forms.Padding(2);
            this.newDeath.Name = "newDeath";
            this.newDeath.Size = new System.Drawing.Size(87, 21);
            this.newDeath.TabIndex = 25;
            this.newDeath.Text = "0";
            // 
            // newCure
            // 
            this.newCure.Location = new System.Drawing.Point(202, 133);
            this.newCure.Margin = new System.Windows.Forms.Padding(2);
            this.newCure.Name = "newCure";
            this.newCure.Size = new System.Drawing.Size(87, 21);
            this.newCure.TabIndex = 24;
            this.newCure.Text = "0";
            // 
            // newDefinite
            // 
            this.newDefinite.Location = new System.Drawing.Point(202, 104);
            this.newDefinite.Margin = new System.Windows.Forms.Padding(2);
            this.newDefinite.Name = "newDefinite";
            this.newDefinite.Size = new System.Drawing.Size(87, 21);
            this.newDefinite.TabIndex = 23;
            this.newDefinite.Text = "0";
            this.newDefinite.TextChanged += new System.EventHandler(this.newDefinite_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(87, 21);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "新增重症";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "新增疑似";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "新增死亡";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "新增治愈";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "新增确诊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "下一日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "地区";
            // 
            // provinceName
            // 
            this.provinceName.Location = new System.Drawing.Point(201, 49);
            this.provinceName.Margin = new System.Windows.Forms.Padding(2);
            this.provinceName.Name = "provinceName";
            this.provinceName.Size = new System.Drawing.Size(87, 21);
            this.provinceName.TabIndex = 30;
            this.provinceName.TextChanged += new System.EventHandler(this.provinceName_TextChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(67, 267);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 33);
            this.back.TabIndex = 31;
            this.back.Text = "退出";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // inputFormsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 345);
            this.Controls.Add(this.back);
            this.Controls.Add(this.provinceName);
            this.Controls.Add(this.input);
            this.Controls.Add(this.newDanger);
            this.Controls.Add(this.newSuspected);
            this.Controls.Add(this.newDeath);
            this.Controls.Add(this.newCure);
            this.Controls.Add(this.newDefinite);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "inputFormsNew";
            this.Text = "inputFormsNew";
            this.Load += new System.EventHandler(this.inputFormsNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button input;
        private System.Windows.Forms.TextBox newDanger;
        private System.Windows.Forms.TextBox newSuspected;
        private System.Windows.Forms.TextBox newDeath;
        private System.Windows.Forms.TextBox newCure;
        private System.Windows.Forms.TextBox newDefinite;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox provinceName;
        private System.Windows.Forms.Button back;
    }
}