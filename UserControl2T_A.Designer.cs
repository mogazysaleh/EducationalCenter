﻿
namespace EducationalCenter
{
    partial class UserControl2T_A
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
            this.labelSchedule = new System.Windows.Forms.Label();
            this.dataGridViewTeacherSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.BackColor = System.Drawing.Color.Transparent;
            this.labelSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelSchedule.Location = new System.Drawing.Point(27, 66);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(89, 20);
            this.labelSchedule.TabIndex = 42;
            this.labelSchedule.Text = "Schedule:";
            // 
            // dataGridViewTeacherSchedule
            // 
            this.dataGridViewTeacherSchedule.AllowUserToAddRows = false;
            this.dataGridViewTeacherSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewTeacherSchedule.AllowUserToOrderColumns = true;
            this.dataGridViewTeacherSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacherSchedule.Location = new System.Drawing.Point(31, 115);
            this.dataGridViewTeacherSchedule.Name = "dataGridViewTeacherSchedule";
            this.dataGridViewTeacherSchedule.ReadOnly = true;
            this.dataGridViewTeacherSchedule.Size = new System.Drawing.Size(230, 150);
            this.dataGridViewTeacherSchedule.TabIndex = 45;
            // 
            // UserControl2T_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTeacherSchedule);
            this.Controls.Add(this.labelSchedule);
            this.Name = "UserControl2T_A";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.DataGridView dataGridViewTeacherSchedule;
    }
}
