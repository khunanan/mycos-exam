
namespace Ex_Mycos
{
    partial class NewEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.startwork = new System.Windows.Forms.DateTimePicker();
            this.labeldisplay = new System.Windows.Forms.Label();
            this.pvdRate3_12 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pvdRate12_36 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pvdRate36_60 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.pvdRateAfter60 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pvdRate3_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvdRate12_36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvdRate36_60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvdRateAfter60)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of birth :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start work date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salary :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(168, 70);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 23);
            this.txtname.TabIndex = 8;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(168, 110);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(200, 23);
            this.txtlastname.TabIndex = 9;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(462, 110);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(200, 23);
            this.salary.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Calculate The Providence Fund System ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-774, -18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "LastName :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "FirstName";
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(495, 67);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(200, 23);
            this.birth.TabIndex = 16;
            // 
            // startwork
            // 
            this.startwork.Location = new System.Drawing.Point(168, 147);
            this.startwork.Name = "startwork";
            this.startwork.Size = new System.Drawing.Size(200, 23);
            this.startwork.TabIndex = 17;
            // 
            // labeldisplay
            // 
            this.labeldisplay.AutoSize = true;
            this.labeldisplay.Location = new System.Drawing.Point(185, 353);
            this.labeldisplay.Name = "labeldisplay";
            this.labeldisplay.Size = new System.Drawing.Size(0, 15);
            this.labeldisplay.TabIndex = 19;
            // 
            // pvdRate3_12
            // 
            this.pvdRate3_12.Location = new System.Drawing.Point(168, 196);
            this.pvdRate3_12.Name = "pvdRate3_12";
            this.pvdRate3_12.Size = new System.Drawing.Size(120, 23);
            this.pvdRate3_12.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Pvd Rate 3 - 12 M";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Pvd Rate 12 - 36 M";
            // 
            // pvdRate12_36
            // 
            this.pvdRate12_36.Location = new System.Drawing.Point(168, 236);
            this.pvdRate12_36.Name = "pvdRate12_36";
            this.pvdRate12_36.Size = new System.Drawing.Size(120, 23);
            this.pvdRate12_36.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Pvd Rate 36 - 60 M";
            // 
            // pvdRate36_60
            // 
            this.pvdRate36_60.Location = new System.Drawing.Point(168, 282);
            this.pvdRate36_60.Name = "pvdRate36_60";
            this.pvdRate36_60.Size = new System.Drawing.Size(120, 23);
            this.pvdRate36_60.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Pvd Rate After";
            // 
            // pvdRateAfter60
            // 
            this.pvdRateAfter60.Location = new System.Drawing.Point(168, 327);
            this.pvdRateAfter60.Name = "pvdRateAfter60";
            this.pvdRateAfter60.Size = new System.Drawing.Size(120, 23);
            this.pvdRateAfter60.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pvdRateAfter60);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pvdRate36_60);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pvdRate12_36);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pvdRate3_12);
            this.Controls.Add(this.labeldisplay);
            this.Controls.Add(this.startwork);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "New Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvdRate3_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvdRate12_36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvdRate36_60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvdRateAfter60)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.DateTimePicker startwork;
        private System.Windows.Forms.Label labeldisplay;
        private System.Windows.Forms.NumericUpDown pvdRate3_12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown pvdRate12_36;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown pvdRate36_60;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown pvdRateAfter60;
    }
}

