using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Managment_System
{
    public partial class View_All_Student : Form
    {
        public View_All_Student()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Add_New_Student obj = new Add_New_Student();

            obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            Search_Student obj = new Search_Student();

            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();

            obj.Show();
            this.Hide();
        }

        private void View_All_Student_Load(object sender, EventArgs e)
        {
            lbl_User.Text = " Welcome " + Global_User.U_Name;
            
            // TODO: This line of code loads data into the 'student_Managment_System_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Managment_System_DBDataSet.Student_Details);

        }

       
    }
}
