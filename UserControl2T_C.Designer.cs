﻿
namespace EducationalCenter
{
    partial class UserControl2T_C
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
            this.label_Grade = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.label_ExamID = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.dataGridViewTeacherGradesReport = new System.Windows.Forms.DataGridView();
            this.labelGradesReport = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxExamID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherGradesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Grade
            // 
            this.label_Grade.AutoSize = true;
            this.label_Grade.Location = new System.Drawing.Point(170, 234);
            this.label_Grade.Name = "label_Grade";
            this.label_Grade.Size = new System.Drawing.Size(36, 13);
            this.label_Grade.TabIndex = 66;
            this.label_Grade.Text = "Grade";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(173, 249);
            this.textBoxGrade.MaxLength = 15;
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrade.TabIndex = 65;
            // 
            // label_ExamID
            // 
            this.label_ExamID.AutoSize = true;
            this.label_ExamID.Location = new System.Drawing.Point(31, 286);
            this.label_ExamID.Name = "label_ExamID";
            this.label_ExamID.Size = new System.Drawing.Size(47, 13);
            this.label_ExamID.TabIndex = 64;
            this.label_ExamID.Text = "Exam ID";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(31, 234);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(55, 13);
            this.labelStudentID.TabIndex = 63;
            this.labelStudentID.Text = "StudentID";
            // 
            // dataGridViewTeacherGradesReport
            // 
            this.dataGridViewTeacherGradesReport.AllowUserToAddRows = false;
            this.dataGridViewTeacherGradesReport.AllowUserToDeleteRows = false;
            this.dataGridViewTeacherGradesReport.AllowUserToOrderColumns = true;
            this.dataGridViewTeacherGradesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacherGradesReport.Location = new System.Drawing.Point(32, 87);
            this.dataGridViewTeacherGradesReport.Name = "dataGridViewTeacherGradesReport";
            this.dataGridViewTeacherGradesReport.ReadOnly = true;
            this.dataGridViewTeacherGradesReport.RowTemplate.Height = 25;
            this.dataGridViewTeacherGradesReport.Size = new System.Drawing.Size(536, 130);
            this.dataGridViewTeacherGradesReport.TabIndex = 60;
            this.dataGridViewTeacherGradesReport.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTeacherGradesReport_CellMouseDoubleClick);
            // 
            // labelGradesReport
            // 
            this.labelGradesReport.AutoSize = true;
            this.labelGradesReport.BackColor = System.Drawing.Color.Transparent;
            this.labelGradesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradesReport.Location = new System.Drawing.Point(29, 50);
            this.labelGradesReport.Name = "labelGradesReport";
            this.labelGradesReport.Size = new System.Drawing.Size(133, 20);
            this.labelGradesReport.TabIndex = 89;
            this.labelGradesReport.Text = "Grades Report:";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(332, 246);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 87;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(32, 250);
            this.textBoxStudentID.MaxLength = 15;
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(124, 20);
            this.textBoxStudentID.TabIndex = 92;
            // 
            // textBoxExamID
            // 
            this.textBoxExamID.Location = new System.Drawing.Point(33, 302);
            this.textBoxExamID.MaxLength = 15;
            this.textBoxExamID.Name = "textBoxExamID";
            this.textBoxExamID.Size = new System.Drawing.Size(124, 20);
            this.textBoxExamID.TabIndex = 93;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(540, 55);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(28, 26);
            this.buttonDelete.TabIndex = 111;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // UserControl2T_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxExamID);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelGradesReport);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label_Grade);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.label_ExamID);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.dataGridViewTeacherGradesReport);
            this.Name = "UserControl2T_C";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherGradesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Grade;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label label_ExamID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.DataGridView dataGridViewTeacherGradesReport;
        private System.Windows.Forms.Label labelGradesReport;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxExamID;
        private System.Windows.Forms.Button buttonDelete;
    }
}
