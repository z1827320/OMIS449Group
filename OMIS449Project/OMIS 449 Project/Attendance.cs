using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMIS_449_Project
{
    public partial class Attendance : Form
    {
        //list to store objects used in form
        List<Student> StudentList = new List<Student>();
        List<PictureBox> Seats = new List<PictureBox>();
        StreamReader inputFile;

        public Attendance()
        {
            InitializeComponent();
        }

        //function to change back.color
        private void ChangeAttendance(PictureBox p)
        {
            if (p.BackColor == Color.Red)
                p.BackColor = Color.Lime;

            else
                p.BackColor = Color.Red;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            try
            {
                string Line;

                char[] Delim = { ',' };

                try
                {
                    //Filters all but CSV files from view
                    OpenFileDialog OpenFile = new OpenFileDialog
                    {
                        Filter = "CSV|*.csv" 
                    };

                    if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        inputFile = File.OpenText(OpenFile.FileName);

                        while (!inputFile.EndOfStream)
                        {
                            Line = inputFile.ReadLine();
                            string[] Columns = Line.Split(Delim);

                            //Creates a new instance of Student for every line in CSV
                            Student NewStudent = new Student
                            {
                                FirstName = Columns[0],
                                LastName = Columns[1],
                                ZID = int.Parse(Columns[2]),
                                SeatNum = int.Parse(Columns[3]),
                                Absenses = int.Parse(Columns[4])
                            };

                            //Adds new Student to List<Student>
                            StudentList.Add(NewStudent);
                        }

                        inputFile.Close();
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Auto generates all labels with names provided by CSV
            for (int i = 1; i <= StudentList.Count; i++)
            {
                Label CurrentLabel = (Label)Controls.Find("NameS" + i, true)[0];
                CurrentLabel.Text = StudentList[i-1].FirstName + " " + StudentList[i-1].LastName;
            }
        }

        //Finds all picture boxes and stores them into Seats List
        private void SaveAttendance_Click(object sender, EventArgs e)
        {
            Control[] matches;
            for (int i = 1; i <= 100; i++)
            {
                matches = this.Controls.Find("Seat" + i.ToString(), true);
                if (matches.Length > 0 && matches[0] is PictureBox)
                {
                    Seats.Add((PictureBox)matches[0]);
                }
            }


            //Accumulator for Total Absenses
            for (int i = 0; i < Seats.Count && i < StudentList.Count; i++)
            {
                if (Seats[i].BackColor == Color.Red)
                {
                    StudentList[i].Absenses += 1;
                }
            }

            //Writing ammended information back into CSV via SaveFileDialog
            SaveFileDialog SaveFile = new SaveFileDialog() { Filter = "CSV|*.csv" };
            try
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter OutputFile;
                    OutputFile = File.CreateText(SaveFile.FileName);

                    for (int i = 0; i < StudentList.Count; i++)
                    {
                        OutputFile.WriteLine(StudentList[i].FirstName + "," + StudentList[i].LastName + ","
                            + StudentList[i].ZID + "," + StudentList[i].SeatNum + ","
                            + StudentList[i].Absenses);
                    }

                    MessageBox.Show("File Saved Successfully!");
                    OutputFile.Close();
                }

                else
                    MessageBox.Show("Something went wrong!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Ties all 52 seat Clicks to the same event handler, which call the function needed to change the back.color
        private void Seat1_Click(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            ChangeAttendance(b);
        }
    }
}
