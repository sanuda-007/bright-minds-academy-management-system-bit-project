﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectE2248373
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDetails studentDetails = new StudentDetails();
            studentDetails.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherDetails teacherDetails = new TeacherDetails();
            teacherDetails.Show();
        }
    }
}