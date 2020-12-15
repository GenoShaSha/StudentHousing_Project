namespace TenantPage
{
    partial class Form1
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
            this.lbComplaints = new System.Windows.Forms.Label();
            this.lsbComplaints = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemoveRules = new System.Windows.Forms.Button();
            this.lbEvent = new System.Windows.Forms.Label();
            this.lbRule = new System.Windows.Forms.Label();
            this.btnRemoveEvent = new System.Windows.Forms.Button();
            this.btwnAddEvent = new System.Windows.Forms.Button();
            this.lsbEvents = new System.Windows.Forms.ListBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.tbRules = new System.Windows.Forms.TextBox();
            this.lsbRules = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveWarning = new System.Windows.Forms.Button();
            this.btnAddWarning = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.lsbStudents = new System.Windows.Forms.ListBox();
            this.tbEvents = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbComplaints
            // 
            this.lbComplaints.AutoSize = true;
            this.lbComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplaints.Location = new System.Drawing.Point(504, 25);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(129, 25);
            this.lbComplaints.TabIndex = 1;
            this.lbComplaints.Text = "Complaints";
            // 
            // lsbComplaints
            // 
            this.lsbComplaints.FormattingEnabled = true;
            this.lsbComplaints.Location = new System.Drawing.Point(509, 53);
            this.lsbComplaints.Name = "lsbComplaints";
            this.lsbComplaints.Size = new System.Drawing.Size(207, 95);
            this.lsbComplaints.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(509, 173);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(207, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 459);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbEvents);
            this.tabPage1.Controls.Add(this.btnRemoveRules);
            this.tabPage1.Controls.Add(this.lbEvent);
            this.tabPage1.Controls.Add(this.lbRule);
            this.tabPage1.Controls.Add(this.btnRemoveEvent);
            this.tabPage1.Controls.Add(this.btwnAddEvent);
            this.tabPage1.Controls.Add(this.lsbEvents);
            this.tabPage1.Controls.Add(this.btnAddRule);
            this.tabPage1.Controls.Add(this.tbRules);
            this.tabPage1.Controls.Add(this.lsbRules);
            this.tabPage1.Controls.Add(this.lsbComplaints);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.lbComplaints);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveRules
            // 
            this.btnRemoveRules.Location = new System.Drawing.Point(159, 369);
            this.btnRemoveRules.Name = "btnRemoveRules";
            this.btnRemoveRules.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRules.TabIndex = 12;
            this.btnRemoveRules.Text = "Remove";
            this.btnRemoveRules.UseVisualStyleBackColor = true;
            this.btnRemoveRules.Click += new System.EventHandler(this.btnRemoveRules_Click);
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.BackColor = System.Drawing.Color.Transparent;
            this.lbEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvent.Location = new System.Drawing.Point(504, 222);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(84, 25);
            this.lbEvent.TabIndex = 11;
            this.lbEvent.Text = "Events";
            // 
            // lbRule
            // 
            this.lbRule.AutoSize = true;
            this.lbRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRule.Location = new System.Drawing.Point(25, 25);
            this.lbRule.Name = "lbRule";
            this.lbRule.Size = new System.Drawing.Size(64, 25);
            this.lbRule.TabIndex = 10;
            this.lbRule.Text = "rules";
            // 
            // btnRemoveEvent
            // 
            this.btnRemoveEvent.Location = new System.Drawing.Point(619, 369);
            this.btnRemoveEvent.Name = "btnRemoveEvent";
            this.btnRemoveEvent.Size = new System.Drawing.Size(97, 37);
            this.btnRemoveEvent.TabIndex = 9;
            this.btnRemoveEvent.Text = "Remove";
            this.btnRemoveEvent.UseVisualStyleBackColor = true;
            this.btnRemoveEvent.Click += new System.EventHandler(this.btnRemoveEvent_Click);
            // 
            // btwnAddEvent
            // 
            this.btwnAddEvent.Location = new System.Drawing.Point(509, 369);
            this.btwnAddEvent.Name = "btwnAddEvent";
            this.btwnAddEvent.Size = new System.Drawing.Size(97, 37);
            this.btwnAddEvent.TabIndex = 8;
            this.btwnAddEvent.Text = "Add";
            this.btwnAddEvent.UseVisualStyleBackColor = true;
            this.btwnAddEvent.Click += new System.EventHandler(this.btwnAddEvent_Click);
            // 
            // lsbEvents
            // 
            this.lsbEvents.FormattingEnabled = true;
            this.lsbEvents.Location = new System.Drawing.Point(509, 250);
            this.lsbEvents.Name = "lsbEvents";
            this.lsbEvents.Size = new System.Drawing.Size(207, 95);
            this.lsbEvents.TabIndex = 7;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(159, 325);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(75, 23);
            this.btnAddRule.TabIndex = 6;
            this.btnAddRule.Text = "Add Rule";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // tbRules
            // 
            this.tbRules.Location = new System.Drawing.Point(30, 325);
            this.tbRules.Name = "tbRules";
            this.tbRules.Size = new System.Drawing.Size(100, 20);
            this.tbRules.TabIndex = 5;
            // 
            // lsbRules
            // 
            this.lsbRules.FormattingEnabled = true;
            this.lsbRules.Location = new System.Drawing.Point(30, 53);
            this.lsbRules.Name = "lsbRules";
            this.lsbRules.Size = new System.Drawing.Size(216, 251);
            this.lsbRules.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnRemoveWarning);
            this.tabPage2.Controls.Add(this.btnAddWarning);
            this.tabPage2.Controls.Add(this.btnRemoveStudent);
            this.tabPage2.Controls.Add(this.lsbStudents);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Students";
            // 
            // btnRemoveWarning
            // 
            this.btnRemoveWarning.BackColor = System.Drawing.Color.Green;
            this.btnRemoveWarning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveWarning.Location = new System.Drawing.Point(320, 204);
            this.btnRemoveWarning.Name = "btnRemoveWarning";
            this.btnRemoveWarning.Size = new System.Drawing.Size(101, 39);
            this.btnRemoveWarning.TabIndex = 3;
            this.btnRemoveWarning.Text = "Remove Warning";
            this.btnRemoveWarning.UseVisualStyleBackColor = false;
            // 
            // btnAddWarning
            // 
            this.btnAddWarning.BackColor = System.Drawing.Color.Red;
            this.btnAddWarning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddWarning.Location = new System.Drawing.Point(320, 118);
            this.btnAddWarning.Name = "btnAddWarning";
            this.btnAddWarning.Size = new System.Drawing.Size(101, 39);
            this.btnAddWarning.TabIndex = 2;
            this.btnAddWarning.Text = "Warn";
            this.btnAddWarning.UseVisualStyleBackColor = false;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.Color.Red;
            this.btnRemoveStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveStudent.Location = new System.Drawing.Point(320, 45);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(101, 39);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            // 
            // lsbStudents
            // 
            this.lsbStudents.FormattingEnabled = true;
            this.lsbStudents.Location = new System.Drawing.Point(31, 45);
            this.lsbStudents.Name = "lsbStudents";
            this.lsbStudents.Size = new System.Drawing.Size(257, 342);
            this.lsbStudents.TabIndex = 0;
            // 
            // tbEvents
            // 
            this.tbEvents.Location = new System.Drawing.Point(509, 343);
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.Size = new System.Drawing.Size(207, 20);
            this.tbEvents.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbComplaints;
        private System.Windows.Forms.ListBox lsbComplaints;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lsbRules;
        private System.Windows.Forms.Label lbEvent;
        private System.Windows.Forms.Label lbRule;
        private System.Windows.Forms.Button btnRemoveEvent;
        private System.Windows.Forms.Button btwnAddEvent;
        private System.Windows.Forms.ListBox lsbEvents;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.TextBox tbRules;
        private System.Windows.Forms.Button btnRemoveWarning;
        private System.Windows.Forms.Button btnAddWarning;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.ListBox lsbStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveRules;
        private System.Windows.Forms.TextBox tbEvents;
    }
}

