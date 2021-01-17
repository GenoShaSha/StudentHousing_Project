namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
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
            this.EventPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ComplaintsBtn_Submission
            // 
            this.ComplaintsBtn_Submission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComplaintsBtn_Submission.Location = new System.Drawing.Point(233, 442);
            this.ComplaintsBtn_Submission.Name = "ComplaintsBtn_Submission";
            this.ComplaintsBtn_Submission.Size = new System.Drawing.Size(98, 34);
            this.ComplaintsBtn_Submission.TabIndex = 13;
            this.ComplaintsBtn_Submission.Text = "Add";
            this.ComplaintsBtn_Submission.UseVisualStyleBackColor = true;
            this.ComplaintsBtn_Submission.Click += new System.EventHandler(this.ComplaintsBtn_Submission_Click);
            // 
            // EventsBtn_Submission
            // 
            this.EventsBtn_Submission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EventsBtn_Submission.Location = new System.Drawing.Point(233, 231);
            this.EventsBtn_Submission.Name = "EventsBtn_Submission";
            this.EventsBtn_Submission.Size = new System.Drawing.Size(98, 35);
            this.EventsBtn_Submission.TabIndex = 12;
            this.EventsBtn_Submission.Text = "Add";
            this.EventsBtn_Submission.UseVisualStyleBackColor = true;
            this.EventsBtn_Submission.Click += new System.EventHandler(this.EventsBtn_Submission_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(35, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Complaints ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Events ";
            // 
            // Events_TB
            // 
            this.Events_TB.Location = new System.Drawing.Point(40, 95);
            this.Events_TB.Multiline = true;
            this.Events_TB.Name = "Events_TB";
            this.Events_TB.Size = new System.Drawing.Size(291, 130);
            this.Events_TB.TabIndex = 14;
            // 
            // Complaints_TB
            // 
            this.Complaints_TB.Location = new System.Drawing.Point(39, 306);
            this.Complaints_TB.Multiline = true;
            this.Complaints_TB.Name = "Complaints_TB";
            this.Complaints_TB.Size = new System.Drawing.Size(292, 130);
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
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BackBtn.Location = new System.Drawing.Point(40, 497);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(291, 35);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EventPicker
            // 
            this.EventPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EventPicker.Location = new System.Drawing.Point(131, 65);
            this.EventPicker.Name = "EventPicker";
            this.EventPicker.Size = new System.Drawing.Size(200, 24);
            this.EventPicker.TabIndex = 18;
            // 
            // Submission_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 544);
            this.Controls.Add(this.EventPicker);
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
        private System.Windows.Forms.DateTimePicker EventPicker;
    }
}