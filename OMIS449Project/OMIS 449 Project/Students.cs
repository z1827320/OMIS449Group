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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                string Line;

                //splits lines by commas
                char[] Delim = { ',' };

                //loads and reads CSV into grid
                try
                {
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

                            //Adds student info to the grid
                            StudentGrid.Rows.Add(Columns[0], Columns[1], Columns[2], Columns[3], Columns[4]);
                        }

                        inputFile.Close();
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
        }
    }
}
