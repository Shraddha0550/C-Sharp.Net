using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Managment_System
{
    public partial class Add_New_Student : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Managment_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        
        public Add_New_Student()
        {
            InitializeComponent();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            Search_Student obj = new Search_Student();

            obj.Show();
            this.Hide();

        }

        private void btn_View_All_Student_Click(object sender, EventArgs e)
        {
            View_All_Student obj = new View_All_Student();

            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();

            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert into Student_Details(ID,Name,Mobile_No,DOB,Course) values (" + tb_Roll_No.Text + " , '" + tb_Name.Text + "' , " + tb_Mobile_No.Text + " , '" + dtp_DOB.Text + "' , '" + cmb_Course.Text+ "' ) ",Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                MessageBox.Show("\t Saved Details Succesfully \t");

                tb_Roll_No.Text = "";
                tb_Name.Text = "";
                tb_Mobile_No.Text = "";
                dtp_DOB.Text = "";

            }
            else
            {
                MessageBox.Show(" Please Filled All Fields");
            }

            Con.Close();
        }

        private void Add_New_Student_Load(object sender, EventArgs e)
        {
            lbl_User.Text =" Welcome " +  Global_User.U_Name;

            cmb_Course.SelectedIndex = -1;
            tb_Roll_No.Focus();
        }

        
        
    }
}
