using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMIS_449_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewStudents_Click(object sender, EventArgs e)
        {
            //creates new instance form and opens it
            Students myStudents = new Students();

            myStudents.ShowDialog();
        }

        private void TakeAttendance_Click(object sender, EventArgs e)
        {
            //creates new instance form and opens it
            Attendance takeAttendance = new Attendance();

            takeAttendance.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
