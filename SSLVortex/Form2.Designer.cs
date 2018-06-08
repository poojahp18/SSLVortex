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
            this.rdoWebsite = new System.Windows.Forms.RadioButton();
            this.rdoYear = new System.Windows.Forms.RadioButton();
            this.rdoMonth = new System.Windows.Forms.RadioButton();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoSID = new System.Windows.Forms.RadioButton();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.btnDateGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMonth = new System.Windows.Forms.GroupBox();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.btnMonthGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.btnYearGo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpSession = new System.Windows.Forms.GroupBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.btnSessionGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.grpWebsite = new System.Windows.Forms.GroupBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.btnWebsiteGo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.grpOptRep.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.grpMonth.SuspendLayout();
            this.grpYear.SuspendLayout();
            this.grpSession.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpWebsite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptRep
            // 
            this.grpOptRep.Controls.Add(this.rdoWebsite);
            this.grpOptRep.Controls.Add(this.rdoYear);
            this.grpOptRep.Controls.Add(this.rdoMonth);
            this.grpOptRep.Controls.Add(this.rdoDate);
            this.grpOptRep.Controls.Add(this.rdoSID);
            this.grpOptRep.Location = new System.Drawing.Point(12, 12);
            this.grpOptRep.Name = "grpOptRep";
            this.grpOptRep.Size = new System.Drawing.Size(256, 67);
            this.grpOptRep.TabIndex = 0;
            this.grpOptRep.TabStop = false;
            this.grpOptRep.Text = "Select options to generate Report";
            this.grpOptRep.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoWebsite
            // 
            this.rdoWebsite.AutoSize = true;
            this.rdoWebsite.Location = new System.Drawing.Point(6, 42);
            this.rdoWebsite.Name = "rdoWebsite";
            this.rdoWebsite.Size = new System.Drawing.Size(79, 17);
            this.rdoWebsite.TabIndex = 4;
            this.rdoWebsite.Text = "By Website";
            this.rdoWebsite.UseVisualStyleBackColor = true;
            this.rdoWebsite.CheckedChanged += new System.EventHandler(this.rdoWebsite_CheckedChanged);
            // 
            // rdoYear
            // 
            this.rdoYear.AutoSize = true;
            this.rdoYear.Location = new System.Drawing.Point(188, 19);
            this.rdoYear.Name = "rdoYear";
            this.rdoYear.Size = new System.Drawing.Size(62, 17);
            this.rdoYear.TabIndex = 3;
            this.rdoYear.Text = "By Year";
            this.rdoYear.UseVisualStyleBackColor = true;
            this.rdoYear.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdoMonth
            // 
            this.rdoMonth.AutoSize = true;
            this.rdoMonth.Location = new System.Drawing.Point(96, 19);
            this.rdoMonth.Name = "rdoMonth";
            this.rdoMonth.Size = new System.Drawing.Size(70, 17);
            this.rdoMonth.TabIndex = 2;
            this.rdoMonth.Text = "By Month";
            this.rdoMonth.UseVisualStyleBackColor = true;
            this.rdoMonth.CheckedChanged += new System.EventHandler(this.rdoMonth_CheckedChanged);
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(6, 19);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(63, 17);
            this.rdoDate.TabIndex = 1;
            this.rdoDate.Text = "By Date";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdoDate_CheckedChanged);
            // 
            // rdoSID
            // 
            this.rdoSID.AutoSize = true;
            this.rdoSID.Location = new System.Drawing.Point(96, 42);
            this.rdoSID.Name = "rdoSID";
            this.rdoSID.Size = new System.Drawing.Size(91, 17);
            this.rdoSID.TabIndex = 0;
            this.rdoSID.Text = "By Session ID";
            this.rdoSID.UseVisualStyleBackColor = true;
            this.rdoSID.CheckedChanged += new System.EventHandler(this.rdoSID_CheckedChanged);
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
            this.grpDate.Visible = false;
            // 
            // dtpEDate
            // 
            this.dtpEDate.CustomFormat = "dd-MM-yyyy";
            this.dtpEDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDate.Location = new System.Drawing.Point(6, 87);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(244, 20);
            this.dtpEDate.TabIndex = 6;
            // 
            // dtpSDate
            // 
            this.dtpSDate.CustomFormat = "dd-MM-yyyy";
            this.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSDate.Location = new System.Drawing.Point(6, 35);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(244, 20);
            this.dtpSDate.TabIndex = 5;
            this.dtpSDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnDateGo
            // 
            this.btnDateGo.Location = new System.Drawing.Point(6, 113);
            this.btnDateGo.Name = "btnDateGo";
            this.btnDateGo.Size = new System.Drawing.Size(244, 28);
            this.btnDateGo.TabIndex = 2;
            this.btnDateGo.Text = "Fetch";
            this.btnDateGo.UseVisualStyleBackColor = true;
            this.btnDateGo.Click += new System.EventHandler(this.btnDateGo_Click);
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
            this.grpMonth.Visible = false;
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MMMM-yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
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
            this.btnMonthGo.Text = "Fetch";
            this.btnMonthGo.UseVisualStyleBackColor = true;
            this.btnMonthGo.Click += new System.EventHandler(this.btnMonthGo_Click);
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
            this.grpYear.Visible = false;
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
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
            this.btnYearGo.Text = "Fetch";
            this.btnYearGo.UseVisualStyleBackColor = true;
            this.btnYearGo.Click += new System.EventHandler(this.btnYearGo_Click);
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
            this.grpSession.Visible = false;
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(9, 49);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(241, 20);
            this.txtSession.TabIndex = 4;
            // 
            // btnSessionGo
            // 
            this.btnSessionGo.Location = new System.Drawing.Point(6, 113);
            this.btnSessionGo.Name = "btnSessionGo";
            this.btnSessionGo.Size = new System.Drawing.Size(244, 28);
            this.btnSessionGo.TabIndex = 2;
            this.btnSessionGo.Text = "Fetch";
            this.btnSessionGo.UseVisualStyleBackColor = true;
            this.btnSessionGo.Click += new System.EventHandler(this.btnSessionGo_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select options to generate Report";
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
            // grpWebsite
            // 
            this.grpWebsite.Controls.Add(this.txtWebsite);
            this.grpWebsite.Controls.Add(this.btnWebsiteGo);
            this.grpWebsite.Controls.Add(this.label5);
            this.grpWebsite.Location = new System.Drawing.Point(12, 85);
            this.grpWebsite.Name = "grpWebsite";
            this.grpWebsite.Size = new System.Drawing.Size(256, 153);
            this.grpWebsite.TabIndex = 4;
            this.grpWebsite.TabStop = false;
            this.grpWebsite.Visible = false;
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
            this.btnWebsiteGo.Text = "Fetch";
            this.btnWebsiteGo.UseVisualStyleBackColor = true;
            this.btnWebsiteGo.Click += new System.EventHandler(this.btnWebsiteGo_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(934, 458);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(274, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 477);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.Gray;
            this.btnClose2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose2.Location = new System.Drawing.Point(6, 422);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(265, 48);
            this.btnClose2.TabIndex = 9;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 501);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.grpMonth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpWebsite);
            this.Controls.Add(this.grpSession);
            this.Controls.Add(this.grpOptRep);
            this.Controls.Add(this.grpYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpWebsite.ResumeLayout(false);
            this.grpWebsite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptRep;
        private System.Windows.Forms.RadioButton rdoWebsite;
        private System.Windows.Forms.RadioButton rdoYear;
        private System.Windows.Forms.RadioButton rdoMonth;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoSID;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.GroupBox grpWebsite;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Button btnWebsiteGo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose2;
    }
}