using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLHBaseWindow;
using NLHospitalLibrary;

namespace NLHospital
{
    public partial class Form1 : NLHBase
    {
        Patients patients = new Patients();

        public Form1()
        {
            InitializeComponent();
            DataSet data = patients.ListPatients();
            dgDoctors.DataSource = data.Tables[0];
        }
        
        private void btnFind_Click(object sender, EventArgs e)
        {
            DataSet data = patients.FindData(txtPatientID.Text);
            dgDoctors.DataSource = data.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            patients.AddData(txtLastName.Text, txtFirstName.Text, txtPatientID.Text, textBox1.Text, Address.Text, City.Text, Province.Text, PostalCode.Text, PhoneNum.Text, Insurance.Text, InsurNum.Text, NextOfKin.Text, kinRelation.Text, Doctor.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            patients.UpdateData(txtPatientID.Text, txtLastName.Text, txtFirstName.Text, textBox1.Text, Address.Text, City.Text, Province.Text, PostalCode.Text, PhoneNum.Text, Insurance.Text, InsurNum.Text, NextOfKin.Text, kinRelation.Text, Doctor.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
