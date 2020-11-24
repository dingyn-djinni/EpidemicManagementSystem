namespace ELAB_Information
{
    partial class chooselist
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
            this.upadte = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.inputs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upadte
            // 
            this.upadte.Location = new System.Drawing.Point(70, 154);
            this.upadte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upadte.Name = "upadte";
            this.upadte.Size = new System.Drawing.Size(116, 33);
            this.upadte.TabIndex = 0;
            this.upadte.Text = "更新数据";
            this.upadte.UseVisualStyleBackColor = true;
            this.upadte.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(70, 209);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(116, 33);
            this.search.TabIndex = 1;
            this.search.Text = "查询数据";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // inputs
            // 
            this.inputs.Location = new System.Drawing.Point(70, 102);
            this.inputs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputs.Name = "inputs";
            this.inputs.Size = new System.Drawing.Size(116, 33);
            this.inputs.TabIndex = 2;
            this.inputs.Text = "输入数据";
            this.inputs.UseVisualStyleBackColor = true;
            this.inputs.Click += new System.EventHandler(this.input_Click);
            // 
            // chooselist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 298);
            this.Controls.Add(this.inputs);
            this.Controls.Add(this.search);
            this.Controls.Add(this.upadte);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "chooselist";
            this.Text = "管理员菜单";
            this.Load += new System.EventHandler(this.chooselist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upadte;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button inputs;
    }
}