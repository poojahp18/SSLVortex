namespace SSLVortex
{
    partial class Form3
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
            this.grpReq = new System.Windows.Forms.GroupBox();
            this.txtReq = new System.Windows.Forms.TextBox();
            this.grpRes = new System.Windows.Forms.GroupBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.grpReq.SuspendLayout();
            this.grpRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReq
            // 
            this.grpReq.Controls.Add(this.txtReq);
            this.grpReq.Location = new System.Drawing.Point(2, 11);
            this.grpReq.Margin = new System.Windows.Forms.Padding(2);
            this.grpReq.Name = "grpReq";
            this.grpReq.Padding = new System.Windows.Forms.Padding(2);
            this.grpReq.Size = new System.Drawing.Size(759, 225);
            this.grpReq.TabIndex = 15;
            this.grpReq.TabStop = false;
            this.grpReq.Text = "Raw Request";
            // 
            // txtReq
            // 
            this.txtReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReq.Location = new System.Drawing.Point(2, 15);
            this.txtReq.Margin = new System.Windows.Forms.Padding(2);
            this.txtReq.Multiline = true;
            this.txtReq.Name = "txtReq";
            this.txtReq.ReadOnly = true;
            this.txtReq.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReq.Size = new System.Drawing.Size(755, 208);
            this.txtReq.TabIndex = 6;
            this.txtReq.TabStop = false;
            this.txtReq.TextChanged += new System.EventHandler(this.txtReq_TextChanged);
            // 
            // grpRes
            // 
            this.grpRes.Controls.Add(this.txtRes);
            this.grpRes.Location = new System.Drawing.Point(2, 240);
            this.grpRes.Margin = new System.Windows.Forms.Padding(2);
            this.grpRes.Name = "grpRes";
            this.grpRes.Padding = new System.Windows.Forms.Padding(2);
            this.grpRes.Size = new System.Drawing.Size(759, 225);
            this.grpRes.TabIndex = 16;
            this.grpRes.TabStop = false;
            this.grpRes.Text = "Raw Response";
            // 
            // txtRes
            // 
            this.txtRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRes.Location = new System.Drawing.Point(2, 15);
            this.txtRes.Margin = new System.Windows.Forms.Padding(2);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRes.Size = new System.Drawing.Size(755, 208);
            this.txtRes.TabIndex = 6;
            this.txtRes.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 471);
            this.Controls.Add(this.grpRes);
            this.Controls.Add(this.grpReq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "label";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpReq.ResumeLayout(false);
            this.grpReq.PerformLayout();
            this.grpRes.ResumeLayout(false);
            this.grpRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReq;
        private System.Windows.Forms.TextBox txtReq;
        private System.Windows.Forms.GroupBox grpRes;
        private System.Windows.Forms.TextBox txtRes;
    }
}