﻿namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
{
    partial class Submission_Form
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
            this.ComplaintsBtn_Submission = new System.Windows.Forms.Button();
            this.EventsBtn_Submission = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Events_TB = new System.Windows.Forms.TextBox();
            this.Complaints_TB = new System.Windows.Forms.TextBox();
            this.StudentNameLbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComplaintsBtn_Submission
            // 
            this.ComplaintsBtn_Submission.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplaintsBtn_Submission.Location = new System.Drawing.Point(44, 373);
            this.ComplaintsBtn_Submission.Name = "ComplaintsBtn_Submission";
            this.ComplaintsBtn_Submission.Size = new System.Drawing.Size(75, 32);
            this.ComplaintsBtn_Submission.TabIndex = 13;
            this.ComplaintsBtn_Submission.Text = "Add";
            this.ComplaintsBtn_Submission.UseVisualStyleBackColor = true;
            this.ComplaintsBtn_Submission.Click += new System.EventHandler(this.ComplaintsBtn_Submission_Click);
            // 
            // EventsBtn_Submission
            // 
            this.EventsBtn_Submission.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsBtn_Submission.Location = new System.Drawing.Point(44, 167);
            this.EventsBtn_Submission.Name = "EventsBtn_Submission";
            this.EventsBtn_Submission.Size = new System.Drawing.Size(75, 32);
            this.EventsBtn_Submission.TabIndex = 12;
            this.EventsBtn_Submission.Text = "Add";
            this.EventsBtn_Submission.UseVisualStyleBackColor = true;
            this.EventsBtn_Submission.Click += new System.EventHandler(this.EventsBtn_Submission_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11F);
            this.label3.Location = new System.Drawing.Point(40, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Complaints :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11F);
            this.label2.Location = new System.Drawing.Point(40, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Events :";
            // 
            // Events_TB
            // 
            this.Events_TB.Location = new System.Drawing.Point(44, 50);
            this.Events_TB.Multiline = true;
            this.Events_TB.Name = "Events_TB";
            this.Events_TB.Size = new System.Drawing.Size(258, 111);
            this.Events_TB.TabIndex = 14;
            // 
            // Complaints_TB
            // 
            this.Complaints_TB.Location = new System.Drawing.Point(44, 251);
            this.Complaints_TB.Multiline = true;
            this.Complaints_TB.Name = "Complaints_TB";
            this.Complaints_TB.Size = new System.Drawing.Size(258, 116);
            this.Complaints_TB.TabIndex = 15;
            // 
            // StudentNameLbl
            // 
            this.StudentNameLbl.AutoSize = true;
            this.StudentNameLbl.Location = new System.Drawing.Point(412, 50);
            this.StudentNameLbl.Name = "StudentNameLbl";
            this.StudentNameLbl.Size = new System.Drawing.Size(0, 17);
            this.StudentNameLbl.TabIndex = 16;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(173, 420);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(129, 47);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Submission_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 492);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.StudentNameLbl);
            this.Controls.Add(this.Complaints_TB);
            this.Controls.Add(this.Events_TB);
            this.Controls.Add(this.ComplaintsBtn_Submission);
            this.Controls.Add(this.EventsBtn_Submission);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Submission_Form";
            this.Text = "Submission_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComplaintsBtn_Submission;
        private System.Windows.Forms.Button EventsBtn_Submission;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Events_TB;
        private System.Windows.Forms.TextBox Complaints_TB;
        private System.Windows.Forms.Label StudentNameLbl;
        private System.Windows.Forms.Button BackBtn;
    }
}