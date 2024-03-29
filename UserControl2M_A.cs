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
    public partial class UserControl2M_A : UserControl
    {
        UserControl1M userControl1M;
        DataGridViewCellMouseEventArgs delete;
        public UserControl2M_A(UserControl1M userControl1M)
        {
            this.userControl1M = userControl1M;
            InitializeComponent();
            LoadTheme();
            displayData();
            buttonDelete.Visible = false;
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelEmployees.ForeColor = ThemeColor.PrimaryColor;
        }
        private void displayData(string ID = "", string name = "", string address = "", decimal salary = 0, string phoneNumber = "")
        {
            DataTable dt = Controller.Instance.getAllEmployees(ID, name, address, salary, phoneNumber);
            dataGridViewEmployees.DataSource = dt.DefaultView;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text) || String.IsNullOrWhiteSpace(textBoxNID.Text))
            {
                MessageBox.Show("Please Fill the ID and name fields at least");
            }
            else
            {
                if (String.IsNullOrWhiteSpace(textBoxAddress.Text))
                {
                    textBoxAddress.Text = "";
                }

                if (String.IsNullOrWhiteSpace(textBoxPhoneNumber.Text))
                {
                    textBoxPhoneNumber.Text = "";
                }
                if(Controller.Instance.insertEmployee(textBoxNID.Text, textBoxName.Text, numericUpDownSalary.Value, textBoxAddress.Text, textBoxPhoneNumber.Text))
                {
                    MessageBox.Show("Employee added successfully");
                    displayData();
                }
                else
                {
                    MessageBox.Show("Employee already exists");
                }



            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string ID = "", name = "", address = "", phoneNumber = "";
            decimal salary = 0;

            if (!String.IsNullOrWhiteSpace(textBoxNID.Text))
            {
                ID = textBoxNID.Text;
            }

            if (!String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                name = textBoxName.Text;
            }

            if (!String.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                address = textBoxAddress.Text;
            }

            if (!String.IsNullOrWhiteSpace(textBoxPhoneNumber.Text))
            {
                phoneNumber = textBoxPhoneNumber.Text;
            }

            if(numericUpDownSalary.Value != 0)
            {
                salary = numericUpDownSalary.Value;
            }

            displayData(ID, name, address, salary, phoneNumber);
            clearInputs();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1M());
        }

        private void clearInputs()
        {
            textBoxAddress.Text = "";
            textBoxName.Text = "";
            textBoxNID.Text = "";
            textBoxPhoneNumber.Text = "";
            numericUpDownSalary.Value = 0;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearInputs();
            displayData();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            userControl1M.OpenChildForm(new EmployeesReport());
        }

        private void dataGridViewEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            delete = e;
            buttonDelete.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (delete.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Employee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteEmployee(dataGridViewEmployees.Rows[delete.RowIndex].Cells[1].Value.ToString());
                    dataGridViewEmployees.Rows.RemoveAt(delete.RowIndex);
                }

            }
            buttonDelete.Visible = false;
        }
    }
}
