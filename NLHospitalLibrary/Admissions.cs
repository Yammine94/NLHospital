using System;
using System.Data ;
using System.Data.SqlClient ;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Admissions.
	/// </summary>
	public class Admissions
	{
		private DataSet m_oDS ; 
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
		private string m_sClassName = "AdmissionRecords";
		private string sSQL;	

		public Admissions()
		{
			//
			// TODO: Add constructor logic here
			//
			SqlCommand oSelCmd;

			InitializeConnection();

			sSQL = "SELECT AdmissionID, PatientID, BedNumber, " +
				" SurgeryScheduled, SurgeryDate, AdmitDate, DischargeDate" +
				" FROM	AdmissionRecords " +
				" ORDER BY AdmissionID ";
			oSelCmd = null;
			oSelCmd = new SqlCommand(sSQL, m_oCn);
			oSelCmd.CommandType = CommandType.Text;

			m_oDA = new SqlDataAdapter();
			m_oDA.SelectCommand = oSelCmd;

			m_oCn = null;

		}

	

		public DataSet FindData(string ID)
		{
			InitializeConnection();
			m_oCn.Open();
			DataSet thisDataSet = new DataSet();
			DataSet foundDataSet = new DataSet();
			try
			{
				m_oDA.Fill (thisDataSet, m_sClassName);
				for (int n = 0; n < thisDataSet.Tables["AdmissionRecords"].Rows.Count ; n++)
				{
					if (thisDataSet.Tables["AdmissionRecords"].Rows[n]["AdmissionID"].ToString () == ID)
					{
						m_oDA.Fill(foundDataSet,n,1,"AdmissionRecords");							
					}
				}
			}
			catch 
			{
			}
			finally
			{
				m_oCn.Close();
				m_oCn = null;
			}
			return foundDataSet;
		}


		public DataSet GetData()
		{
			m_oDS = new DataSet();
			m_oDA.Fill(m_oDS, m_sClassName);
			return m_oDS;
		}

		private void InitializeConnection()
		{
			m_oCn = new SqlConnection(
                "Data Source=DESKTOP-CBDVJLK;Initial Catalog=NLHospital;Integrated Security=True");
		}


		public void SetPatientDischarge(string ID)
		{
			InitializeConnection();
			m_oCn.Open();

		
            string sqlDate = "Update AdmissionRecords SET DischargeDate = @date where PatientID = @id;";
            string sqlBed = "Update Beds SET Occupied = 0 from Beds INNER JOIN AdmissionRecords ON [AdmissionRecords].BedNumber = [Beds].BedNumber WHERE [AdmissionRecords].BedNumber = [Beds].BedNumber AND  [AdmissionRecords].PatientID = @id ";
            SqlCommand cmdDate = new SqlCommand(sqlDate, m_oCn);
            SqlCommand cmdBed = new SqlCommand(sqlBed, m_oCn);
            cmdBed.Parameters.AddWithValue("@id", ID);
            cmdDate.Parameters.Add("@date", SqlDbType.DateTime2).Value = DateTime.Today.Date;
            cmdDate.Parameters.AddWithValue("@id", ID);
            try
			{
                cmdBed.ExecuteNonQuery();
                cmdDate.ExecuteNonQuery();
            }
			catch 
			{
                
            }
			finally
			{
				m_oCn.Close();
				m_oCn = null;
			}
		}

		public int GetDays(string ID)
		{
			int days;
			DateTime dis = new DateTime();
			DateTime ad = new DateTime ();
            
			DataSet thisDataSet = new DataSet();
			thisDataSet = this.FindData (ID);

			ad = Convert.ToDateTime (thisDataSet.Tables["Admissions"].Rows [0]["AdmitDate"]);
			dis = Convert.ToDateTime (thisDataSet.Tables["Admissions"].Rows [0]["DischargeDate"]);
			
			days = dis.Day - ad.Day;

			return days;

		}
	}
}

