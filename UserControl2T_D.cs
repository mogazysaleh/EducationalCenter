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
            DataTable dt = Controller.Instance.getTeacherExams(Controller.Instance.getTeacherID(Form0.Instance.username));
            dataGridViewSchedule.DataSource = dt.DefaultView;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1T());
        }
    }
}
