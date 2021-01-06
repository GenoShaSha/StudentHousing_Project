namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
{
    partial class StudentPageForm
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
            this.rulesLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmissionBtn = new System.Windows.Forms.Button();
            this.WelcomeBackLbl = new System.Windows.Forms.Label();
            this.StudentNameLbl = new System.Windows.Forms.Label();
            this.eventsLB = new System.Windows.Forms.ListBox();
            this.complaintsLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rulesLB
            // 
            this.rulesLB.FormattingEnabled = true;
            this.rulesLB.ItemHeight = 16;
            this.rulesLB.Location = new System.Drawing.Point(12, 78);
            this.rulesLB.Name = "rulesLB";
            this.rulesLB.Size = new System.Drawing.Size(269, 436);
            this.rulesLB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20F);
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "RULES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11F);
            this.label2.Location = new System.Drawing.Point(292, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Events :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11F);
            this.label3.Location = new System.Drawing.Point(292, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Complaints :";
            // 
            // SubmissionBtn
            // 
            this.SubmissionBtn.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmissionBtn.Location = new System.Drawing.Point(429, 473);
            this.SubmissionBtn.Name = "SubmissionBtn";
            this.SubmissionBtn.Size = new System.Drawing.Size(195, 37);
            this.SubmissionBtn.TabIndex = 7;
            this.SubmissionBtn.Text = "Submission Form";
            this.SubmissionBtn.UseVisualStyleBackColor = true;
            this.SubmissionBtn.Click += new System.EventHandler(this.SubmissionBtn_Click);
            // 
            // WelcomeBackLbl
            // 
            this.WelcomeBackLbl.AutoSize = true;
            this.WelcomeBackLbl.Font = new System.Drawing.Font("Century", 9F);
            this.WelcomeBackLbl.Location = new System.Drawing.Point(9, 9);
            this.WelcomeBackLbl.Name = "WelcomeBackLbl";
            this.WelcomeBackLbl.Size = new System.Drawing.Size(112, 18);
            this.WelcomeBackLbl.TabIndex = 8;
            this.WelcomeBackLbl.Text = "Welcome back,";
            // 
            // StudentNameLbl
            // 
            this.StudentNameLbl.AutoSize = true;
            this.StudentNameLbl.Font = new System.Drawing.Font("Century", 9F);
            this.StudentNameLbl.Location = new System.Drawing.Point(127, 9);
            this.StudentNameLbl.Name = "StudentNameLbl";
            this.StudentNameLbl.Size = new System.Drawing.Size(0, 18);
            this.StudentNameLbl.TabIndex = 9;
            // 
            // eventsLB
            // 
            this.eventsLB.FormattingEnabled = true;
            this.eventsLB.ItemHeight = 16;
            this.eventsLB.Location = new System.Drawing.Point(296, 93);
            this.eventsLB.Name = "eventsLB";
            this.eventsLB.Size = new System.Drawing.Size(328, 212);
            this.eventsLB.TabIndex = 3;
            // 
            // complaintsLB
            // 
            this.complaintsLB.FormattingEnabled = true;
            this.complaintsLB.ItemHeight = 16;
            this.complaintsLB.Location = new System.Drawing.Point(296, 334);
            this.complaintsLB.Name = "complaintsLB";
            this.complaintsLB.Size = new System.Drawing.Size(328, 116);
            this.complaintsLB.TabIndex = 5;
            // 
            // StudentPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 557);
            this.Controls.Add(this.StudentNameLbl);
            this.Controls.Add(this.WelcomeBackLbl);
            this.Controls.Add(this.SubmissionBtn);
            this.Controls.Add(this.complaintsLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventsLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rulesLB);
            this.Name = "StudentPageForm";
            this.Text = "Student Page";
            this.Load += new System.EventHandler(this.StudentPageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rulesLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmissionBtn;
        private System.Windows.Forms.Label WelcomeBackLbl;
        private System.Windows.Forms.Label StudentNameLbl;
        private System.Windows.Forms.ListBox eventsLB;
        private System.Windows.Forms.ListBox complaintsLB;
    }
}

