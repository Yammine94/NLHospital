using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLHBaseWindow;
using NLHospitalLibrary;
using System.Data.SqlClient;

namespace NLHospital
{
    public partial class PatientList : NLHBase
    {
        public PatientList()
        {
            InitializeComponent();
            Patients patients = new Patients();
            DataSet data = patients.ListPatients();
            dataGridView1.DataSource = data.Tables[0];
        }

    }
}
