
namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
{
    partial class TenantForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventPicker = new System.Windows.Forms.DateTimePicker();
            this.userBtn = new System.Windows.Forms.Button();
            this.btnStudentPage = new System.Windows.Forms.Button();
            this.tbEvents = new System.Windows.Forms.TextBox();
            this.tbRules = new System.Windows.Forms.TextBox();
            this.btnRemoveRules = new System.Windows.Forms.Button();
            this.lbRule = new System.Windows.Forms.Label();
            this.btnRemoveEvent = new System.Windows.Forms.Button();
            this.btwnAddEvent = new System.Windows.Forms.Button();
            this.lsbEvents = new System.Windows.Forms.ListBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lsbRules = new System.Windows.Forms.ListBox();
            this.lsbComplaints = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 568);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.eventPicker);
            this.tabPage1.Controls.Add(this.userBtn);
            this.tabPage1.Controls.Add(this.btnStudentPage);
            this.tabPage1.Controls.Add(this.tbEvents);
            this.tabPage1.Controls.Add(this.tbRules);
            this.tabPage1.Controls.Add(this.btnRemoveRules);
            this.tabPage1.Controls.Add(this.lbRule);
            this.tabPage1.Controls.Add(this.btnRemoveEvent);
            this.tabPage1.Controls.Add(this.btwnAddEvent);
            this.tabPage1.Controls.Add(this.lsbEvents);
            this.tabPage1.Controls.Add(this.btnAddRule);
            this.tabPage1.Controls.Add(this.lsbRules);
            this.tabPage1.Controls.Add(this.lsbComplaints);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1072, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(324, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Complaints :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(324, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Events :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCB_S04_Grp3_Project_FinalBuild.Properties.Resources.RULES;
            this.pictureBox1.Location = new System.Drawing.Point(19, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // eventPicker
            // 
            this.eventPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eventPicker.Location = new System.Drawing.Point(431, 63);
            this.eventPicker.Name = "eventPicker";
            this.eventPicker.Size = new System.Drawing.Size(214, 24);
            this.eventPicker.TabIndex = 16;
            // 
            // userBtn
            // 
            this.userBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userBtn.Location = new System.Drawing.Point(465, 7);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(147, 36);
            this.userBtn.TabIndex = 15;
            this.userBtn.Text = "Add User";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // btnStudentPage
            // 
            this.btnStudentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStudentPage.Location = new System.Drawing.Point(631, 7);
            this.btnStudentPage.Name = "btnStudentPage";
            this.btnStudentPage.Size = new System.Drawing.Size(94, 29);
            this.btnStudentPage.TabIndex = 14;
            this.btnStudentPage.Text = "Back";
            this.btnStudentPage.UseVisualStyleBackColor = true;
            this.btnStudentPage.Click += new System.EventHandler(this.btnStudentPage_Click);
            // 
            // tbEvents
            // 
            this.tbEvents.Location = new System.Drawing.Point(328, 233);
            this.tbEvents.Margin = new System.Windows.Forms.Padding(4);
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.Size = new System.Drawing.Size(397, 22);
            this.tbEvents.TabIndex = 13;
            // 
            // tbRules
            // 
            this.tbRules.Location = new System.Drawing.Point(19, 439);
            this.tbRules.Margin = new System.Windows.Forms.Padding(4);
            this.tbRules.Multiline = true;
            this.tbRules.Name = "tbRules";
            this.tbRules.Size = new System.Drawing.Size(287, 25);
            this.tbRules.TabIndex = 5;
            // 
            // btnRemoveRules
            // 
            this.btnRemoveRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemoveRules.Location = new System.Drawing.Point(19, 472);
            this.btnRemoveRules.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveRules.Name = "btnRemoveRules";
            this.btnRemoveRules.Size = new System.Drawing.Size(136, 43);
            this.btnRemoveRules.TabIndex = 12;
            this.btnRemoveRules.Text = "Remove";
            this.btnRemoveRules.UseVisualStyleBackColor = true;
            this.btnRemoveRules.Click += new System.EventHandler(this.btnRemoveRules_Click_1);
            // 
            // lbRule
            // 
            this.lbRule.AutoSize = true;
            this.lbRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRule.Location = new System.Drawing.Point(33, 31);
            this.lbRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRule.Name = "lbRule";
            this.lbRule.Size = new System.Drawing.Size(0, 31);
            this.lbRule.TabIndex = 10;
            // 
            // btnRemoveEvent
            // 
            this.btnRemoveEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemoveEvent.Location = new System.Drawing.Point(327, 263);
            this.btnRemoveEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveEvent.Name = "btnRemoveEvent";
            this.btnRemoveEvent.Size = new System.Drawing.Size(189, 43);
            this.btnRemoveEvent.TabIndex = 9;
            this.btnRemoveEvent.Text = "Remove";
            this.btnRemoveEvent.UseVisualStyleBackColor = true;
            this.btnRemoveEvent.Click += new System.EventHandler(this.btnRemoveEvent_Click_1);
            // 
            // btwnAddEvent
            // 
            this.btwnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btwnAddEvent.Location = new System.Drawing.Point(540, 263);
            this.btwnAddEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btwnAddEvent.Name = "btwnAddEvent";
            this.btwnAddEvent.Size = new System.Drawing.Size(185, 43);
            this.btwnAddEvent.TabIndex = 8;
            this.btwnAddEvent.Text = "Add";
            this.btwnAddEvent.UseVisualStyleBackColor = true;
            this.btwnAddEvent.Click += new System.EventHandler(this.btwnAddEvent_Click);
            // 
            // lsbEvents
            // 
            this.lsbEvents.FormattingEnabled = true;
            this.lsbEvents.ItemHeight = 16;
            this.lsbEvents.Location = new System.Drawing.Point(327, 90);
            this.lsbEvents.Margin = new System.Windows.Forms.Padding(4);
            this.lsbEvents.Name = "lsbEvents";
            this.lsbEvents.Size = new System.Drawing.Size(398, 132);
            this.lsbEvents.TabIndex = 7;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddRule.Location = new System.Drawing.Point(170, 472);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(136, 43);
            this.btnAddRule.TabIndex = 6;
            this.btnAddRule.Text = "Add ";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click_1);
            // 
            // lsbRules
            // 
            this.lsbRules.FormattingEnabled = true;
            this.lsbRules.ItemHeight = 16;
            this.lsbRules.Location = new System.Drawing.Point(19, 90);
            this.lsbRules.Margin = new System.Windows.Forms.Padding(4);
            this.lsbRules.Name = "lsbRules";
            this.lsbRules.Size = new System.Drawing.Size(287, 340);
            this.lsbRules.TabIndex = 4;
            // 
            // lsbComplaints
            // 
            this.lsbComplaints.FormattingEnabled = true;
            this.lsbComplaints.ItemHeight = 16;
            this.lsbComplaints.Location = new System.Drawing.Point(328, 342);
            this.lsbComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.lsbComplaints.Name = "lsbComplaints";
            this.lsbComplaints.Size = new System.Drawing.Size(397, 132);
            this.lsbComplaints.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.Location = new System.Drawing.Point(386, 482);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(297, 33);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // TenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "TenantForm";
            this.Text = "TenantForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker eventPicker;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button btnStudentPage;
        private System.Windows.Forms.TextBox tbEvents;
        private System.Windows.Forms.TextBox tbRules;
        private System.Windows.Forms.Button btnRemoveRules;
        private System.Windows.Forms.Label lbRule;
        private System.Windows.Forms.Button btnRemoveEvent;
        private System.Windows.Forms.Button btwnAddEvent;
        private System.Windows.Forms.ListBox lsbEvents;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.ListBox lsbRules;
        private System.Windows.Forms.ListBox lsbComplaints;
        private System.Windows.Forms.Button btnRemove;
    }
}