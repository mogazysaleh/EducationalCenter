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
    public partial class UserControl1 : UserControl
    {
       //Fields

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private UserControl activeForm;
        //Constructor
        public UserControl1()
        {
            InitializeComponent();
            random = new Random();
            labelname.Text = "Welcome";
            buttonCloseChildForm.Visible = false;
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    buttonCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(UserControl childForm)
        {
            this.panelDesktopPane.Controls.Remove(this.pictureBoxLogIn2);
            this.panelDesktopPane.Controls.Remove(this.pictureBoxLogIn);
            activeForm = childForm;
            childForm.BorderStyle = BorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            this.panelDesktopPane.Controls.Remove(activeForm);
            this.panelDesktopPane.Controls.Add(this.pictureBoxLogIn2);
            this.panelDesktopPane.Controls.Add(this.pictureBoxLogIn);
            currentButton = null;
            buttonCloseChildForm.Visible = false;
            activeForm = null;
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            Form0.Instance.Release();
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            Form0.Instance.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (Form0.Instance.WindowState == FormWindowState.Normal)
            {
                Form0.Instance.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Form0.Instance.WindowState = FormWindowState.Normal;
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Form0.Instance.WindowState == FormWindowState.Normal)
            {
                Form0.Instance.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Form0.Instance.WindowState = FormWindowState.Normal;
            }
        }
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControlChangePass());
            labelTitle.Text = "Change password";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControlLogin());
            labelTitle.Text = "Log in";
        }

    }
}
