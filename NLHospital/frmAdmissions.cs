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
    }
    }
