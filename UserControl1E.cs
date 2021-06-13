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
    public partial class UserControl1E : UserControl
    {
        //Fields

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private UserControl activeForm;
        //Constructor
        public UserControl1E()
        {
            InitializeComponent();
            random = new Random();
            string name = Controller.Instance.getEmployeename(Form0.Instance.username);
            labelname.Text = "Welcome, " + name;
            buttonCloseChildForm.Visible = false;
        }
        //Methods

        private void buttonLessons_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControl2E_B());
            labelTitle.Text = "Lessons";
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControl2E_C());
            labelTitle.Text = "Students";
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControl2E_H());
            labelTitle.Text = "Rooms";
        }

        private void buttonExams_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControl2E_G());
            labelTitle.Text = "Exams";
        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControl2E_F());
            labelTitle.Text = "Subjects";
        }

        private void buttonParents_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControl2E_D());
            labelTitle.Text = "Parents";
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControl2E_E(this));
            labelTitle.Text = "Teachers";
        }

        private void buttonStudy_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControl2E_I());
            labelTitle.Text = "Study";
        }

        private void buttonStudentReservation_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender);
            OpenChildForm(new UserControl2E_A());
            labelTitle.Text = "Student Reservation";
        }
        
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
        public void OpenChildForm(UserControl childForm)
        {
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
    }
}
