﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*	     proudLy powered by : Md.ImAmUdDiN

       _ +-------------------------------------------+ _
      /o)|      https://www.facebook.com/imamcu07    |(o\
     / / |      https://about.me/imamcu07            | \ \
    ( (_ |  _           HeLpLine=01815-682307     _  | _) )
   ((\ \)+-/o)-----------------------------------(o\-+(/ /))
   (\\\ \_/ /                                     \ \_/ ///)
    \      /                  __                   \      /
     \____/                  |  |                   \____/
              +++++++++++++++++++++++++++++++++++
              +               **                +
              +        Md.ImAmUdDiN             +
              +        Assistant Officer        +
              +       Youngone Group.           +
              +          Korean EPZ             +
              +      Dhaka, Bangladesh.         +
              +++++++++++++++++++++++++++++++++++ 
      ***********************************************************/

namespace HRMS_Project.ALL_Forms
{
    public partial class Employee_Information : Form
    {
        public Employee_Information()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["imamcu07_HRMS"].ConnectionString);
        DataRow dr;     

        private void Employee_Information_Load(object sender, EventArgs e)
        {
            txtEmpID.Enabled = false;
            LoadPrsntDvsn();
            LoadPrmntDvsn();
            LoadDept();
            LoadDesign();
            LoadBloodGroup();
        }

        #region     [--ALL Methods Go Here--]

        private void LoadBloodGroup()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Load_bGroup", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Select Blood Group" };
            dt.Rows.InsertAt(dr, 0);
            cmbBloodGroup.ValueMember = "BloodGroup_ID";
            cmbBloodGroup.DisplayMember = "BloodGroupName";
            cmbBloodGroup.DataSource = dt;
        }

        private void LoadDept()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Load_Department", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Department" };
                dt.Rows.InsertAt(dr, 0);
                cmbDept.ValueMember = "Department_ID";
                cmbDept.DisplayMember = "Department_Name";
                cmbDept.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\nCheck Connection and DB server in 'App.config' file !!!" + "\n" + "\n=====================================" + "\n                       proudLy powered by --- Md.ImAmUdDiN" + "\n" + "\n                    ____________________________________" + "\n                                 C#.NET || HRMS_Project " + "\n                    ____________________________________" + "\n                                 Dhaka, Bangladesh. " + "\n                    ____________________________________ " + "\n                            HeLpLiNe  :  01815-682307" + "\n         _________________________________________________" + "\n             https://www.facebook.com/imamcu07" + "\n=====================================" + "\n               ___________________________________________" + "\n               Copyright © 2014-2018 Md.ImAmUdDiN");
            }
        }

        private void LoadDesign()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Load_Designation", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Designation" };
                dt.Rows.InsertAt(dr, 0);
                cmbDesign.ValueMember = "Designation_ID";
                cmbDesign.DisplayMember = "Designation_Name";
                cmbDesign.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\nCheck Connection and DB server in 'App.config' file !!!" + "\n" + "\n=====================================" + "\n                       proudLy powered by --- Md.ImAmUdDiN" + "\n" + "\n                    ____________________________________" + "\n                                 C#.NET || HRMS_Project " + "\n                    ____________________________________" + "\n                                 Dhaka, Bangladesh. " + "\n                    ____________________________________ " + "\n                            HeLpLiNe  :  01815-682307" + "\n         _________________________________________________" + "\n             https://www.facebook.com/imamcu07" + "\n=====================================" + "\n               ___________________________________________" + "\n               Copyright © 2014-2018 Md.ImAmUdDiN");
            }
        }

        private void LoadPrsntDvsn()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Load_Divisions", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Division" };
                dt.Rows.InsertAt(dr, 0);
                cmbPrsntDvsn.ValueMember = "Divsion_ID";
                cmbPrsntDvsn.DisplayMember = "Division_Name";
                cmbPrsntDvsn.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\nCheck Connection and DB server in 'App.config' file !!!" + "\n" + "\n=====================================" + "\n                       proudLy powered by --- Md.ImAmUdDiN" + "\n" + "\n                    ____________________________________" + "\n                                 C#.NET || HRMS_Project " + "\n                    ____________________________________" + "\n                                 Dhaka, Bangladesh. " + "\n                    ____________________________________ " + "\n                            HeLpLiNe  :  01815-682307" + "\n         _________________________________________________" + "\n             https://www.facebook.com/imamcu07" + "\n=====================================" + "\n               ___________________________________________" + "\n               Copyright © 2014-2018 Md.ImAmUdDiN");
            }

        }

        private void LoadPrmntDvsn()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Load_Divisions", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Division" };
                dt.Rows.InsertAt(dr, 0);
                cmbPrmntDvsn.ValueMember = "Divsion_ID";
                cmbPrmntDvsn.DisplayMember = "Division_Name";
                cmbPrmntDvsn.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\nCheck Connection and DB server in 'App.config' file !!!" + "\n" + "\n=====================================" + "\n                       proudLy powered by --- Md.ImAmUdDiN" + "\n" + "\n                    ____________________________________" + "\n                                 C#.NET || HRMS_Project " + "\n                    ____________________________________" + "\n                                 Dhaka, Bangladesh. " + "\n                    ____________________________________ " + "\n                            HeLpLiNe  :  01815-682307" + "\n         _________________________________________________" + "\n             https://www.facebook.com/imamcu07" + "\n=====================================" + "\n               ___________________________________________" + "\n               Copyright © 2014-2018 Md.ImAmUdDiN");
            }
        }

        private void Load_PrsntDstrct(int DivID)
        {
            SqlCommand cmd = new SqlCommand("sp_Load_District", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@divID", DivID);
            DataSet dt = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(dt);
            con.Close();
            if (dt.Tables[0].Rows.Count > 0)
            {
                cmbPrsntDstrct.ValueMember = "District_ID";
                cmbPrsntDstrct.DisplayMember = "District_Names";
                cmbPrsntDstrct.DataSource = dt.Tables[0];
                cmbPrsntDstrct.Text = "Select District";
                cmbPrsntPs.Text = "Select Upazilla";
            }
        }

        private void Load_Prmntdstrct(int DivID)
        {
            SqlCommand cmd = new SqlCommand("sp_Load_District", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@divID", DivID);
            DataSet dt = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(dt);
            con.Close();
            if (dt.Tables[0].Rows.Count > 0)
            {
                cmbPrmntDstrct.ValueMember = "District_ID";
                cmbPrmntDstrct.DisplayMember = "District_Names";
                cmbPrmntDstrct.DataSource = dt.Tables[0];
                cmbPrmntDstrct.Text = "Select District";
                cmbPrmntPs.Text = "Select Upazilla";
            }
        }

        private void Load_PrsntPs(int DisID)
        {
            SqlCommand cmd = new SqlCommand("sp_Load_UpaziLLa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@disID", DisID);
            DataSet dt = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(dt);
            con.Close();
            if (dt.Tables[0].Rows.Count > 0)
            {
                cmbPrsntPs.ValueMember = "UpaziLLa_ID";
                cmbPrsntPs.DisplayMember = "UpaziLLa_Names";
                cmbPrsntPs.DataSource = dt.Tables[0];
                cmbPrsntPs.Text = "Select Upazilla";
            }
        }

        private void Load_PrmntPs(int DisID)
        {
            SqlCommand cmd = new SqlCommand("sp_Load_UpaziLLa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@disID", DisID);
            DataSet dt = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(dt);
            con.Close();
            if (dt.Tables[0].Rows.Count > 0)
            {
                cmbPrmntPs.ValueMember = "UpaziLLa_ID";
                cmbPrmntPs.DisplayMember = "UpaziLLa_Names";
                cmbPrmntPs.DataSource = dt.Tables[0];
                cmbPrmntPs.Text = "Select Upazilla";
            }
        }

        private void InsertToDatabase()
        {
            if (!ControL_Validation())
            {
                if (!DupLicate_Check())
                {
                     /* image insert */
                    MemoryStream stream = new MemoryStream();
                    pictureBoxEmpPic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    pictureBoxEmpSign.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] sign = stream.ToArray();

                    if (pic.Length > 80000)
                    {
                        MessageBox.Show("Please upload less than 80 kb jpeg image");
                        pictureBoxEmpPic.Image = null;
                        tabControL01.SelectedTab = tabPagePhoto;
                        return;
                    }
                    else if (sign.Length > 60000)
                    {
                        MessageBox.Show("Please upload less than 60 kb jpeg Signature");
                        pictureBoxEmpSign.Image = null;
                        tabControL01.SelectedTab = tabPagePhoto;
                        return;
                    }

                    else
                    {
                        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["imamcu07_HRMS"].ConnectionString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_Emp_Insert", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@empName", txtEmpName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dept", cmbDept.Text.ToString());
                        cmd.Parameters.AddWithValue("@design", cmbDesign.Text.ToString());
                        cmd.Parameters.AddWithValue("@bSalary", txtBasicSalary.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);

                        if (rdoMale.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@gend", "Male");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@gend", "Female");
                        }

                        cmd.Parameters.AddWithValue("@bGroup", cmbBloodGroup.Text.ToString());
                        cmd.Parameters.AddWithValue("@email", txtEmpEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@mob", txtEmpMob.Text.Trim());
                        cmd.Parameters.AddWithValue("@fName", txtFName.Text.Trim());
                        cmd.Parameters.AddWithValue("@mName", txtMName.Text.Trim());
                        cmd.Parameters.AddWithValue("@prsntDiv", cmbPrsntDvsn.Text.ToString());
                        cmd.Parameters.AddWithValue("@prsntDis", cmbPrsntDstrct.Text.ToString());
                        cmd.Parameters.AddWithValue("@prsntPs", cmbPrsntPs.Text.ToString());
                        cmd.Parameters.AddWithValue("@prsntPO", txtPrsntPO.Text.Trim());
                        cmd.Parameters.AddWithValue("@prmntDiv", cmbPrmntDvsn.Text.ToString());
                        cmd.Parameters.AddWithValue("@prmntDis", cmbPrmntDstrct.Text.ToString());
                        cmd.Parameters.AddWithValue("@prmntPs", cmbPrmntPs.Text.ToString());
                        cmd.Parameters.AddWithValue("@prmntPO", txtPrmntPO.Text.Trim());
                        cmd.Parameters.AddWithValue("@empPho", pic);
                        cmd.Parameters.AddWithValue("@empSign", sign);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Congratulations,,, " + "\nInformation Successfully Saved in Database!!!");
                            Reset_ALL();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            con.Close();
                            con.Dispose();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Email-->  "+txtEmpEmail.Text+"   Already Exist, Try another!!!");
                    tabControL01.SelectedTab = tabPageBasicInfo;
                    txtEmpEmail.ForeColor = Color.Red;
                    txtEmpEmail.Font = new Font(txtEmpEmail.Font, FontStyle.Bold);
                    txtEmpEmail.SelectAll();
                    return;
                }

            }
            else
            {
                return;
            }


        }

        private bool ControL_Validation()
        {
            /*Office tab*/
            if (txtEmpName.Text == string.Empty)
            {
                MessageBox.Show("Please, Insert Employee Name");
                tabControL01.SelectedTab = tabPageOfficiaL;
                txtEmpName.BackColor = System.Drawing.Color.Yellow;
                txtEmpName.Focus();
                return true;
            }
            else if (cmbDept.Text == "Select Department")
            {
                MessageBox.Show("Please, Select Department");
                tabControL01.SelectedTab = tabPageOfficiaL;
                cmbDept.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else if (cmbDesign.Text == "Select Designation")
            {
                MessageBox.Show("Please, Select Designation ");
                tabControL01.SelectedTab = tabPageOfficiaL;
                cmbDesign.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else if (txtBasicSalary.Text == string.Empty)
            {
                MessageBox.Show("Please, Insert Employee Name");
                tabControL01.SelectedTab = tabPageOfficiaL;
                txtBasicSalary.BackColor = System.Drawing.Color.Yellow;
                txtBasicSalary.Focus();
                return true;
            }

                /*Basic tab*/

            else if (dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("Please, Select Valid Date From Calender !!!");
                tabControL01.SelectedTab = tabPageBasicInfo;
                dateTimePicker1.CalendarForeColor = System.Drawing.Color.Red;
                return true;
            }
            else if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Please, Check Gender Male Or Female!!!");
                tabControL01.SelectedTab = tabPageBasicInfo;
                rdoMale.BackColor = System.Drawing.Color.Yellow;
                rdoFemale.BackColor = System.Drawing.Color.Yellow;
                rdoMale.ForeColor = System.Drawing.Color.Black;
                rdoFemale.ForeColor = System.Drawing.Color.Black;
                return true;
            }
            else if (cmbBloodGroup.Text == "Select Blood Group")
            {
                MessageBox.Show("Please, Select Blood Group ");
                tabControL01.SelectedTab = tabPageBasicInfo;
                cmbBloodGroup.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else if (txtEmpEmail.Text == string.Empty)
            {
                MessageBox.Show("Please, Insert Email !!!");
                tabControL01.SelectedTab = tabPageBasicInfo;
                txtEmpEmail.BackColor = System.Drawing.Color.Yellow;
                txtEmpEmail.Focus();
                return true;
            }
            else if (txtEmpMob.Text == string.Empty)
            {
                MessageBox.Show("Please Insert Mobile Number !!!");
                tabControL01.SelectedTab = tabPageBasicInfo;
                txtEmpMob.BackColor = System.Drawing.Color.Yellow;
                txtEmpMob.Focus();
                return true;
            }

            /*Family tab*/

            else if (txtFName.Text == string.Empty)
            {
                MessageBox.Show("Please Insert Father's Name !!!");
                tabControL01.SelectedTab = tabPageFamily;
                txtFName.BackColor = System.Drawing.Color.Yellow;
                txtFName.Focus();
                return true;
            }
            else if (txtMName.Text == string.Empty)
            {
                MessageBox.Show("Please Insert Mother's Name !!!");
                tabControL01.SelectedTab = tabPageFamily;
                txtMName.BackColor = System.Drawing.Color.Yellow;
                txtMName.Focus();
                return true;
            }

            /*Address tab*/

            else if (cmbPrsntDvsn.Text == "Select Division")
            {
                MessageBox.Show("Please Select Present Division");
                tabControL01.SelectedTab = tabPageAddress;
                cmbPrsntDvsn.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else if (cmbPrsntDstrct.Text == "Select District")
            {
                MessageBox.Show("Please Select Present District");
                tabControL01.SelectedTab = tabPageAddress;
                cmbPrsntDstrct.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else if (cmbPrsntPs.Text == "Select Upazilla")
            {
                MessageBox.Show("Please Select Present Upazilla");
                tabControL01.SelectedTab = tabPageAddress;
                cmbPrsntPs.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else if (cmbPrmntDvsn.Text == "Select Division")
            {
                MessageBox.Show("Please Select Permanent Division");
                tabControL01.SelectedTab = tabPageAddress;
                cmbPrmntDvsn.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else if (cmbPrmntDstrct.Text == "Select District")
            {
                MessageBox.Show("Please Select Permanent District");
                tabControL01.SelectedTab = tabPageAddress;
                cmbPrmntDstrct.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else if (cmbPrmntPs.Text == "Select Upazilla")
            {
                MessageBox.Show("Please Select Permanent Upazilla");
                tabControL01.SelectedTab = tabPageAddress;
                cmbPrmntPs.ForeColor = System.Drawing.Color.Red;
                return true;
            }

            /*Photo tab*/

            else if (pictureBoxEmpPic.Image == null)
            {
                MessageBox.Show("Please, Browse for image to save");
                tabControL01.SelectedTab = tabPagePhoto;
                linkLabelPhoto.BackColor = System.Drawing.Color.Red;
                return true;
            }
            else if (pictureBoxEmpSign.Image == null)
            {
                MessageBox.Show("Please, Browse for Sign to save");
                tabControL01.SelectedTab = tabPagePhoto;
                linkLabelSign.BackColor = System.Drawing.Color.Red;
                return true;
            }

            else
            {
                return false;
            }
        }

        private bool DupLicate_Check()
        {
            int count;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["imamcu07_HRMS"].ConnectionString);

            SqlCommand cmd = new SqlCommand("sp_DuplicateChecking ", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@email", this.txtEmpEmail.Text);
            con.Open();

            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        private void LoadEmpPhoto()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxEmpPic.Image = new Bitmap(ofd.FileName);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void LoadSign()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxEmpSign.Image = new Bitmap(ofd.FileName);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void Reset_ALL()
        {
            
            foreach (Control ctrl in groupBoxOffice_01.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtB = (TextBox)ctrl;
                    txtB.Text = null;
                    txtB.BackColor = System.Drawing.Color.White;
                }
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = 0;
                    cmb.BackColor = System.Drawing.Color.White;
                }

            }

            foreach (Control ctrl in panelBasicInfo.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtB = (TextBox)ctrl;
                    txtB.Text = null;
                }
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    dtp.Value = DateTime.Now;
                }
                if (ctrl is RadioButton)
                {
                    RadioButton rB = (RadioButton)ctrl;
                    rB.Checked = false;
                    rB.BackColor = System.Drawing.Color.DarkTurquoise;
                }
            }
            foreach (Control ctrl in groupBoxAddress_01.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtB = (TextBox)ctrl;
                    txtB.Text = null;
                }
                /*if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedValue = 0;
                    cmb.BackColor = System.Drawing.Color.White;
                }*/
            }
            foreach (Control ctrl in groupBoxAddress_02.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtB = (TextBox)ctrl;
                    txtB.Text = null;
                }
               /* if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedValue = 0;
                    cmb.BackColor = System.Drawing.Color.White;
                }*/
            }
            foreach (Control ctrl in groupBoxFamily_01.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtB = (TextBox)ctrl;
                    txtB.Text = null;
                }
            }
            foreach (Control ctrl in groupBoxFamily_02.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtB = (TextBox)ctrl;
                    txtB.Text = null;
                }
            }

            pictureBoxEmpPic.Image = null;
            pictureBoxEmpSign.Image = null;
            tabControL01.SelectedTab = tabPageOfficiaL;
        }

        #endregion

        #region     [--ALL Click Events Go Here--]

        private void cmbPrsntDvsn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrsntDvsn.SelectedValue.ToString() != string.Empty)
            {
                int divID = Convert.ToInt32(cmbPrsntDvsn.SelectedValue.ToString());

                Load_PrsntDstrct(divID);
                cmbPrsntDstrct.Text = "Select District";
                cmbPrsntPs.Text = "Select Upazilla";

            }
        }

        private void cmbPrmntDvsn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrmntDvsn.SelectedValue.ToString() != string.Empty)
            {
                int divID = Convert.ToInt32(cmbPrmntDvsn.SelectedValue.ToString());

                Load_Prmntdstrct(divID);
                cmbPrmntDstrct.Text = "Select District";
                cmbPrmntPs.Text = "Select Upazilla";

            }
        }

        private void cmbPrsntDstrct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int disID = Convert.ToInt32(cmbPrsntDstrct.SelectedValue.ToString());
            Load_PrsntPs(disID);
        }

        private void cmbPrmntDstrct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int disID = Convert.ToInt32(cmbPrmntDstrct.SelectedValue.ToString());
            Load_PrmntPs(disID);
        }

        private void btnOfficialNext_Click(object sender, EventArgs e)
        {
            tabControL01.SelectedTab = tabPageBasicInfo;
        }

        private void btnBasicNext_Click(object sender, EventArgs e)
        {
            tabControL01.SelectedTab = tabPageFamily;
        }

        private void btnAddressNext_Click(object sender, EventArgs e)
        {
            tabControL01.SelectedTab = tabPageEmpEdu;
        }

        private void btnFamilyNext_Click(object sender, EventArgs e)
        {
            tabControL01.SelectedTab = tabPageAddress;
        }

        private void btnEduNext_Click(object sender, EventArgs e)
        {
            tabControL01.SelectedTab = tabPageExprnc;
        }

        private void btnExpNext_Click(object sender, EventArgs e)
        {
            tabControL01.SelectedTab = tabPagePhoto;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            InsertToDatabase();
        }

        private void linkLabelPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadEmpPhoto();
        }

        private void linkLabelSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadSign();
        }

        private void txtBasicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtEmpEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmpEmail.Text != string.Empty)
            {
                System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (txtEmpEmail.Text.Length > 0)
                {
                    if (!rEMail.IsMatch(txtEmpEmail.Text))
                    {
                        txtEmpEmail.SelectAll();
                        txtEmpEmail.ForeColor = Color.Red;
                        txtEmpEmail.Font = new Font(txtEmpEmail.Font, FontStyle.Bold);
                        MessageBox.Show("Please insert valid email e.g: imamcu07@gmail.com", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        e.Cancel = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Insert Email!!!");
                txtEmpEmail.Focus();
                return;
            }
        }

        private void txtEmpMob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset_ALL();
        }

        #endregion
    }
}
