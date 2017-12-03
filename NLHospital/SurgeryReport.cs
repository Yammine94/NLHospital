using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLHospitalLibrary;
using NLHBaseWindow;
using System.Data.SqlClient;

namespace NLHospital
{
    public partial class SurgeryReport : NLHBase
    {
        public SurgeryReport()
        {
            InitializeComponent();
            string _querySelectPatients = "SELECT PatientID,BedNumber,AdmitDate ,SurgeryDate FROM AdmissionRecords WHERE SurgeryScheduled = 1 ";

            string connectionString = "Data Source=DESKTOP-CBDVJLK;Initial Catalog=NLHospital;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand comm = new SqlCommand(_querySelectPatients, connection);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataTable dt = new DataTable("AdmissionRecords");
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
