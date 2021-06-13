﻿
namespace EducationalCenter
{
    partial class UserControl1TA
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxTeacher = new System.Windows.Forms.PictureBox();
            this.buttonExams = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonGradesReport = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonViewSchedule = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTeacher
            // 
            this.pictureBoxTeacher.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTeacher.Image = global::EducationalCenter.Properties.Resources.TA;
            this.pictureBoxTeacher.Location = new System.Drawing.Point(438, 50);
            this.pictureBoxTeacher.Name = "pictureBoxTeacher";
            this.pictureBoxTeacher.Size = new System.Drawing.Size(98, 104);
            this.pictureBoxTeacher.TabIndex = 21;
            this.pictureBoxTeacher.TabStop = false;
            // 
            // buttonExams
            // 
            this.buttonExams.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExams.Location = new System.Drawing.Point(363, 193);
            this.buttonExams.Name = "buttonExams";
            this.buttonExams.Size = new System.Drawing.Size(86, 43);
            this.buttonExams.TabIndex = 20;
            this.buttonExams.Text = "Exams";
            this.buttonExams.UseVisualStyleBackColor = true;
            this.buttonExams.Click += new System.EventHandler(this.buttonExams_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(42, 99);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 25);
            this.labelWelcome.TabIndex = 18;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonGradesReport
            // 
            this.buttonGradesReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGradesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGradesReport.Location = new System.Drawing.Point(99, 345);
            this.buttonGradesReport.Name = "buttonGradesReport";
            this.buttonGradesReport.Size = new System.Drawing.Size(86, 43);
            this.buttonGradesReport.TabIndex = 15;
            this.buttonGradesReport.Text = "Grades Report";
            this.buttonGradesReport.UseVisualStyleBackColor = true;
            this.buttonGradesReport.Click += new System.EventHandler(this.buttonGradesReport_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStudents.Location = new System.Drawing.Point(99, 193);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(86, 43);
            this.buttonStudents.TabIndex = 14;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewSchedule.Location = new System.Drawing.Point(363, 345);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(86, 43);
            this.buttonViewSchedule.TabIndex = 13;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            this.buttonViewSchedule.Click += new System.EventHandler(this.buttonViewSchedule_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.Location = new System.Drawing.Point(25, 20);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(70, 30);
            this.buttonLogOut.TabIndex = 22;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // UserControl1TA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.pictureBoxTeacher);
            this.Controls.Add(this.buttonExams);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonGradesReport);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonViewSchedule);
            this.Name = "UserControl1TA";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTeacher;
        private System.Windows.Forms.Button buttonExams;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonGradesReport;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonViewSchedule;
        private System.Windows.Forms.Button buttonLogOut;
    }
}
