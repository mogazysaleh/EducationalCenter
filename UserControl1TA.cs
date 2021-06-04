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
    public partial class UserControl1T : UserControl
    {
        public UserControl1T()
        {
            InitializeComponent();
            labelWelcome.Text += Form0.Instance.username;
        }

        private void buttonViewSchedule_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2T_A());
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2T_B());
        }

        private void buttonGradesReport_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2T_C());
        }

        private void buttonExams_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2T_D());
        }

        private void buttonTeachingAssistants_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2T_E());
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form0.Instance.username = "";
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControlLogin());
        }
    }
}
