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
    public partial class Search_Student : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Managment_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State == ConnectionState.Closed)
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

        public Search_Student()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Add_New_Student obj = new Add_New_Student();

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

        private void Search_Student_Load(object sender, EventArgs e)
        {
            lbl_User.Text = " Welcome "  + Global_User.U_Name;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text = "";
            tb_Cource.Clear();
            tb_Roll_No.Focus();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand Cmd = new SqlCommand("select *From Student_Details where ID =  " + tb_Roll_No.Text + "",Con);

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                tb_Mobile_No.Text = (obj["Mobile_No"].ToString());
                tb_Cource.Text = obj.GetString(obj.GetOrdinal("Course"));
                dtp_DOB.Text = (obj["DOB"].ToString());


            }
            else
            {
                MessageBox.Show("Inavlid Roll Number");
                tb_Roll_No.Focus();
                tb_Roll_No.Clear();
            }

            Con.Close();
        }
    }
}
