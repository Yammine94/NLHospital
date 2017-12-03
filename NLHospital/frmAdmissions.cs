using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using NLHBaseWindow;
using NLHospitalLibrary;

namespace NLHospital
{
    public partial class frmAdmissions : NLHBase
    {
        public frmAdmissions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admissions admin = new Admissions();
            try
            {
                DataSet tableSource = admin.GetData();
                dataGridView1.DataSource = tableSource.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID = textBox2.Text;
            Admissions admin = new Admissions();
            try
            {
                DataSet tableSource = admin.FindData(ID);
                dataGridView1.DataSource = tableSource.Tables[0];
            }
            catch
            {
                MessageBox.Show("No Record Found with that ID");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            Admissions admin = new Admissions();
            try
            {
                int days = admin.GetDays(ID);
                MessageBox.Show("Patient ID " + ID + " has spent " + days + " days in hospital care.");
            }
            catch
            {
                MessageBox.Show("No Record Found with that ID");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
    }
