﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class UserControl2T_E : UserControl
    {
        public UserControl2T_E()
        {
            InitializeComponent();
            DataTable dt = Controller.Instance.getTeacherAssistants(Controller.Instance.getTeacherID(Form0.Instance.username));
            dataGridViewTeacherAssistants.DataSource = dt.DefaultView;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Controller.Instance.insertTeacherAssistant(textBoxName.Text, Convert.ToInt32(textBoxID.Text), 
                                                       Convert.ToInt32(textBoxPhoneNumber.Text), Controller.Instance.getTeacherID(Form0.Instance.username));

            DataTable dt = Controller.Instance.getTeacherAssistants(Controller.Instance.getTeacherID(Form0.Instance.username));
            dataGridViewTeacherAssistants.DataSource = dt.DefaultView;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            if (Form0.Instance.type == "teacher")
                Form0.Instance.Controls.Add(new UserControl1T());
            else Form0.Instance.Controls.Add(new UserControl1TA());
        }

        private void dataGridViewTeacherAssistants_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Teaching Assistant", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteTeachingAssistant(Convert.ToInt32(dataGridViewTeacherAssistants.Rows[e.RowIndex].Cells[1].Value), Controller.Instance.getTeacherID(Form0.Instance.username));
                    dataGridViewTeacherAssistants.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

    }
}
