namespace NLHospital
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Doctor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.kinRelation = new System.Windows.Forms.TextBox();
            this.NextOfKin = new System.Windows.Forms.TextBox();
            this.InsurNum = new System.Windows.Forms.TextBox();
            this.Insurance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PostalCode = new System.Windows.Forms.TextBox();
            this.Province = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DateBirth = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dgDoctors = new System.Windows.Forms.DataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Doctor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.kinRelation);
            this.panel1.Controls.Add(this.NextOfKin);
            this.panel1.Controls.Add(this.InsurNum);
            this.panel1.Controls.Add(this.Insurance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PhoneNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PostalCode);
            this.panel1.Controls.Add(this.Province);
            this.panel1.Controls.Add(this.City);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.DateBirth);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Controls.Add(this.lblLName);
            this.panel1.Controls.Add(this.lblDoctorID);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtPatientID);
            this.panel1.Location = new System.Drawing.Point(12, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 175);
            this.panel1.TabIndex = 30;
            // 
            // Doctor
            // 
            this.Doctor.Location = new System.Drawing.Point(578, 94);
            this.Doctor.MaxLength = 20;
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(100, 20);
            this.Doctor.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Doctor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Kin Relationship";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Next of Kin:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Insurance Number:";
            // 
            // kinRelation
            // 
            this.kinRelation.Location = new System.Drawing.Point(578, 69);
            this.kinRelation.MaxLength = 20;
            this.kinRelation.Name = "kinRelation";
            this.kinRelation.Size = new System.Drawing.Size(100, 20);
            this.kinRelation.TabIndex = 63;
            // 
            // NextOfKin
            // 
            this.NextOfKin.Location = new System.Drawing.Point(578, 43);
            this.NextOfKin.MaxLength = 20;
            this.NextOfKin.Name = "NextOfKin";
            this.NextOfKin.Size = new System.Drawing.Size(100, 20);
            this.NextOfKin.TabIndex = 62;
            // 
            // InsurNum
            // 
            this.InsurNum.Location = new System.Drawing.Point(578, 17);
            this.InsurNum.MaxLength = 4;
            this.InsurNum.Name = "InsurNum";
            this.InsurNum.Size = new System.Drawing.Size(100, 20);
            this.InsurNum.TabIndex = 61;
            // 
            // Insurance
            // 
            this.Insurance.Location = new System.Drawing.Point(356, 117);
            this.Insurance.MaxLength = 20;
            this.Insurance.Name = "Insurance";
            this.Insurance.Size = new System.Drawing.Size(100, 20);
            this.Insurance.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Insured:";
            // 
            // PhoneNum
            // 
            this.PhoneNum.Location = new System.Drawing.Point(356, 91);
            this.PhoneNum.MaxLength = 20;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(100, 20);
            this.PhoneNum.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Postal Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Province:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "City:";
            // 
            // PostalCode
            // 
            this.PostalCode.Location = new System.Drawing.Point(356, 66);
            this.PostalCode.MaxLength = 20;
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(100, 20);
            this.PostalCode.TabIndex = 53;
            // 
            // Province
            // 
            this.Province.Location = new System.Drawing.Point(356, 40);
            this.Province.MaxLength = 20;
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(100, 20);
            this.Province.TabIndex = 52;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(356, 14);
            this.City.MaxLength = 4;
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(100, 20);
            this.City.TabIndex = 51;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(95, 117);
            this.Address.MaxLength = 20;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 20);
            this.Address.TabIndex = 50;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(8, 120);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(48, 13);
            this.a.TabIndex = 49;
            this.a.Text = "Address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 91);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(700, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(700, 26);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(700, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DateBirth
            // 
            this.DateBirth.AutoSize = true;
            this.DateBirth.Location = new System.Drawing.Point(8, 94);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.Size = new System.Drawing.Size(69, 13);
            this.DateBirth.TabIndex = 26;
            this.DateBirth.Text = "Date of Birth:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(8, 69);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 25;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(8, 43);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 24;
            this.lblLName.Text = "Last Name:";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(8, 17);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(81, 13);
            this.lblDoctorID.TabIndex = 23;
            this.lblDoctorID.Text = "Health Number:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 66);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 22;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(95, 40);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 21;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(95, 14);
            this.txtPatientID.MaxLength = 4;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(100, 20);
            this.txtPatientID.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(811, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(811, 416);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 28;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dgDoctors
            // 
            this.dgDoctors.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dgDoctors.BackColor = System.Drawing.Color.Gainsboro;
            this.dgDoctors.BackgroundColor = System.Drawing.Color.Silver;
            this.dgDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDoctors.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgDoctors.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgDoctors.DataMember = "";
            this.dgDoctors.FlatMode = true;
            this.dgDoctors.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgDoctors.ForeColor = System.Drawing.Color.Black;
            this.dgDoctors.GridLineColor = System.Drawing.Color.DimGray;
            this.dgDoctors.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgDoctors.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgDoctors.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgDoctors.HeaderForeColor = System.Drawing.Color.White;
            this.dgDoctors.LinkColor = System.Drawing.Color.MidnightBlue;
            this.dgDoctors.Location = new System.Drawing.Point(12, 22);
            this.dgDoctors.Name = "dgDoctors";
            this.dgDoctors.ParentRowsBackColor = System.Drawing.Color.DarkGray;
            this.dgDoctors.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgDoctors.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgDoctors.SelectionForeColor = System.Drawing.Color.White;
            this.dgDoctors.Size = new System.Drawing.Size(793, 207);
            this.dgDoctors.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.dgDoctors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Doctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox kinRelation;
        private System.Windows.Forms.TextBox NextOfKin;
        private System.Windows.Forms.TextBox InsurNum;
        private System.Windows.Forms.TextBox Insurance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PostalCode;
        private System.Windows.Forms.TextBox Province;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label DateBirth;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGrid dgDoctors;
    }
}