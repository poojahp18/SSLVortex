namespace SSLVortex
{
    partial class Form2
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
            this.grpOptRep = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.btnDateGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.grpMonth = new System.Windows.Forms.GroupBox();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.btnMonthGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.btnYearGo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpSession = new System.Windows.Forms.GroupBox();
            this.btnSessionGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.grpWebsite = new System.Windows.Forms.GroupBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.btnWebsiteGo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.grpOptRep.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.grpMonth.SuspendLayout();
            this.grpYear.SuspendLayout();
            this.grpSession.SuspendLayout();
            this.grpWebsite.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptRep
            // 
            this.grpOptRep.Controls.Add(this.radioButton5);
            this.grpOptRep.Controls.Add(this.radioButton4);
            this.grpOptRep.Controls.Add(this.radioButton3);
            this.grpOptRep.Controls.Add(this.radioButton2);
            this.grpOptRep.Controls.Add(this.radioButton1);
            this.grpOptRep.Location = new System.Drawing.Point(12, 12);
            this.grpOptRep.Name = "grpOptRep";
            this.grpOptRep.Size = new System.Drawing.Size(256, 67);
            this.grpOptRep.TabIndex = 0;
            this.grpOptRep.TabStop = false;
            this.grpOptRep.Text = "Select options to generate Report";
            this.grpOptRep.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(96, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "By Session ID";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "By Date";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(96, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "By Month";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(188, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "By Year";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(79, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "By Website";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.dtpEDate);
            this.grpDate.Controls.Add(this.dtpSDate);
            this.grpDate.Controls.Add(this.btnDateGo);
            this.grpDate.Controls.Add(this.label2);
            this.grpDate.Controls.Add(this.label1);
            this.grpDate.Location = new System.Drawing.Point(12, 85);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(256, 153);
            this.grpDate.TabIndex = 1;
            this.grpDate.TabStop = false;
            // 
            // btnDateGo
            // 
            this.btnDateGo.Location = new System.Drawing.Point(6, 113);
            this.btnDateGo.Name = "btnDateGo";
            this.btnDateGo.Size = new System.Drawing.Size(244, 28);
            this.btnDateGo.TabIndex = 2;
            this.btnDateGo.Text = "button1";
            this.btnDateGo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date";
            // 
            // dtpSDate
            // 
            this.dtpSDate.Location = new System.Drawing.Point(6, 35);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(244, 20);
            this.dtpSDate.TabIndex = 5;
            this.dtpSDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpEDate
            // 
            this.dtpEDate.Location = new System.Drawing.Point(6, 87);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(244, 20);
            this.dtpEDate.TabIndex = 6;
            // 
            // grpMonth
            // 
            this.grpMonth.Controls.Add(this.dtpMonth);
            this.grpMonth.Controls.Add(this.btnMonthGo);
            this.grpMonth.Controls.Add(this.label4);
            this.grpMonth.Location = new System.Drawing.Point(12, 85);
            this.grpMonth.Name = "grpMonth";
            this.grpMonth.Size = new System.Drawing.Size(256, 153);
            this.grpMonth.TabIndex = 2;
            this.grpMonth.TabStop = false;
            // 
            // dtpMonth
            // 
            this.dtpMonth.Location = new System.Drawing.Point(9, 55);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(244, 20);
            this.dtpMonth.TabIndex = 5;
            // 
            // btnMonthGo
            // 
            this.btnMonthGo.Location = new System.Drawing.Point(6, 113);
            this.btnMonthGo.Name = "btnMonthGo";
            this.btnMonthGo.Size = new System.Drawing.Size(244, 28);
            this.btnMonthGo.TabIndex = 2;
            this.btnMonthGo.Text = "button2";
            this.btnMonthGo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Month";
            // 
            // grpYear
            // 
            this.grpYear.Controls.Add(this.dtpYear);
            this.grpYear.Controls.Add(this.btnYearGo);
            this.grpYear.Controls.Add(this.label6);
            this.grpYear.Location = new System.Drawing.Point(12, 85);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(256, 153);
            this.grpYear.TabIndex = 3;
            this.grpYear.TabStop = false;
            // 
            // dtpYear
            // 
            this.dtpYear.Location = new System.Drawing.Point(9, 55);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(244, 20);
            this.dtpYear.TabIndex = 5;
            // 
            // btnYearGo
            // 
            this.btnYearGo.Location = new System.Drawing.Point(6, 113);
            this.btnYearGo.Name = "btnYearGo";
            this.btnYearGo.Size = new System.Drawing.Size(244, 28);
            this.btnYearGo.TabIndex = 2;
            this.btnYearGo.Text = "button3";
            this.btnYearGo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Year";
            // 
            // grpSession
            // 
            this.grpSession.Controls.Add(this.txtSession);
            this.grpSession.Controls.Add(this.btnSessionGo);
            this.grpSession.Controls.Add(this.label3);
            this.grpSession.Location = new System.Drawing.Point(12, 85);
            this.grpSession.Name = "grpSession";
            this.grpSession.Size = new System.Drawing.Size(256, 153);
            this.grpSession.TabIndex = 4;
            this.grpSession.TabStop = false;
            // 
            // btnSessionGo
            // 
            this.btnSessionGo.Location = new System.Drawing.Point(6, 113);
            this.btnSessionGo.Name = "btnSessionGo";
            this.btnSessionGo.Size = new System.Drawing.Size(244, 28);
            this.btnSessionGo.TabIndex = 2;
            this.btnSessionGo.Text = "button4";
            this.btnSessionGo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Session ID";
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(9, 49);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(241, 20);
            this.txtSession.TabIndex = 4;
            // 
            // grpWebsite
            // 
            this.grpWebsite.Controls.Add(this.txtWebsite);
            this.grpWebsite.Controls.Add(this.btnWebsiteGo);
            this.grpWebsite.Controls.Add(this.label5);
            this.grpWebsite.Location = new System.Drawing.Point(12, 85);
            this.grpWebsite.Name = "grpWebsite";
            this.grpWebsite.Size = new System.Drawing.Size(256, 153);
            this.grpWebsite.TabIndex = 5;
            this.grpWebsite.TabStop = false;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(9, 49);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(241, 20);
            this.txtWebsite.TabIndex = 4;
            // 
            // btnWebsiteGo
            // 
            this.btnWebsiteGo.Location = new System.Drawing.Point(6, 113);
            this.btnWebsiteGo.Name = "btnWebsiteGo";
            this.btnWebsiteGo.Size = new System.Drawing.Size(244, 28);
            this.btnWebsiteGo.TabIndex = 2;
            this.btnWebsiteGo.Text = "button5";
            this.btnWebsiteGo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Website";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select options to generate Report";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 42);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(79, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Text = "By Website";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(188, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(62, 17);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.Text = "By Year";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(96, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(70, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "By Month";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 19);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(63, 17);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.Text = "By Date";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(96, 42);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(91, 17);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "By Session ID";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpWebsite);
            this.Controls.Add(this.grpSession);
            this.Controls.Add(this.grpYear);
            this.Controls.Add(this.grpMonth);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.grpOptRep);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpOptRep.ResumeLayout(false);
            this.grpOptRep.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.grpMonth.ResumeLayout(false);
            this.grpMonth.PerformLayout();
            this.grpYear.ResumeLayout(false);
            this.grpYear.PerformLayout();
            this.grpSession.ResumeLayout(false);
            this.grpSession.PerformLayout();
            this.grpWebsite.ResumeLayout(false);
            this.grpWebsite.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptRep;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDateGo;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpMonth;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Button btnMonthGo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpYear;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Button btnYearGo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpSession;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Button btnSessionGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpWebsite;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Button btnWebsiteGo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
    }
}