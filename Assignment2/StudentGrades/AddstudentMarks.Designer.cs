namespace StudentGrades
{
    partial class Addstudent
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
            this.nametxt = new System.Windows.Forms.TextBox();
            this.exam1txt = new System.Windows.Forms.TextBox();
            this.exam2txt = new System.Windows.Forms.TextBox();
            this.exam3txt = new System.Windows.Forms.TextBox();
            this.fnltxt = new System.Windows.Forms.TextBox();
            this.submitMarksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exam 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exam 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exam 3";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Final Exam";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(159, 44);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(132, 22);
            this.nametxt.TabIndex = 5;
            // 
            // exam1txt
            // 
            this.exam1txt.Location = new System.Drawing.Point(159, 96);
            this.exam1txt.Margin = new System.Windows.Forms.Padding(4);
            this.exam1txt.Name = "exam1txt";
            this.exam1txt.Size = new System.Drawing.Size(87, 22);
            this.exam1txt.TabIndex = 6;
            // 
            // exam2txt
            // 
            this.exam2txt.Location = new System.Drawing.Point(159, 145);
            this.exam2txt.Margin = new System.Windows.Forms.Padding(4);
            this.exam2txt.Name = "exam2txt";
            this.exam2txt.Size = new System.Drawing.Size(87, 22);
            this.exam2txt.TabIndex = 7;
            // 
            // exam3txt
            // 
            this.exam3txt.Location = new System.Drawing.Point(159, 194);
            this.exam3txt.Margin = new System.Windows.Forms.Padding(4);
            this.exam3txt.Name = "exam3txt";
            this.exam3txt.Size = new System.Drawing.Size(87, 22);
            this.exam3txt.TabIndex = 8;
            // 
            // fnltxt
            // 
            this.fnltxt.Location = new System.Drawing.Point(159, 242);
            this.fnltxt.Margin = new System.Windows.Forms.Padding(4);
            this.fnltxt.Name = "fnltxt";
            this.fnltxt.Size = new System.Drawing.Size(87, 22);
            this.fnltxt.TabIndex = 9;
            // 
            // submitMarksBtn
            // 
            this.submitMarksBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitMarksBtn.Location = new System.Drawing.Point(111, 302);
            this.submitMarksBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitMarksBtn.Name = "submitMarksBtn";
            this.submitMarksBtn.Size = new System.Drawing.Size(100, 28);
            this.submitMarksBtn.TabIndex = 10;
            this.submitMarksBtn.Text = "Ok";
            this.submitMarksBtn.UseVisualStyleBackColor = true;
            this.submitMarksBtn.Click += new System.EventHandler(this.submitMarksBtn_Click_1);
            // 
            // Addstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 340);
            this.Controls.Add(this.submitMarksBtn);
            this.Controls.Add(this.fnltxt);
            this.Controls.Add(this.exam3txt);
            this.Controls.Add(this.exam2txt);
            this.Controls.Add(this.exam1txt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Addstudent";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox exam1txt;
        private System.Windows.Forms.TextBox exam2txt;
        private System.Windows.Forms.TextBox exam3txt;
        private System.Windows.Forms.TextBox fnltxt;
        private System.Windows.Forms.Button submitMarksBtn;
    }
}