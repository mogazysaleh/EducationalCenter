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
    public partial class UserControlLogin : UserControl
    {

       public UserControlLogin()
        {
            InitializeComponent();
            LoadTheme();
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
            labelUsername.ForeColor = ThemeColor.PrimaryColor;
            labelPassword.ForeColor = ThemeColor.PrimaryColor;
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Please enter a username and a password");
            }
            else
            {
                Form0.Instance.username = textBoxUser.Text;

                string type = Controller.Instance.checkUserPassword(textBoxUser.Text, textBoxPass.Text);

                if (type == "manager")
                {
                    Form0.Instance.Controls.Clear();
                    Form0.Instance.Controls.Add(new UserControl1M());
                }
                else if (type == "employee")
                {
                    Form0.Instance.Controls.Clear();
                    Form0.Instance.Controls.Add(new UserControl1E());
                    Form0.Instance.username = textBoxUser.Text;
                    Form0.Instance.Controls.Clear();
                    Form0.Instance.Controls.Add(new UserControl1E());
                }
                else if (type == "teacher")
                {
                    Form0.Instance.Controls.Clear();
                    Form0.Instance.Controls.Add(new UserControl1T());
                }
                else if (type == "TA")
                {
                    Form0.Instance.TA = Form0.Instance.username;
                    Form0.Instance.username = Controller.Instance.getTusername(Form0.Instance.username);
                    Form0.Instance.Controls.Clear();
                    Form0.Instance.Controls.Add(new UserControl1TA());
                }
                else if (type == "student" || type == "parent")
                {
                    UserControl student = new UserControl1S();
                    Form0.Instance.username = textBoxUser.Text;
                    Form0.Instance.Controls.Clear();
                    Form0.Instance.Controls.Add(student);
                    student.Location = new System.Drawing.Point(0, 0);
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
                Form0.Instance.type = type;
                textBoxUser.Text = "";
                textBoxPass.Text = "";
            }
        }

        private void linkLabelChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControlChangePass());
        }
    }
}
