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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

         private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Username.Focus();
        }
         private void tb_Usename_TextChanged(object sender, EventArgs e)
         {
             tb_Password.Enabled = true;
         }
         private void tb_Password_TextChanged(object sender, EventArgs e)
         {
             btn_Sumit.Enabled = true;
         }
      

        private void btn_Sumit_Click(object sender, EventArgs e)
        {
           
            if(tb_Usename.Text == "Admin" && tb_Password.Text == "A1" || tb_Usename.Text == "Fork" && tb_Password.Text == "F1")
            {
                MessageBox.Show("\t Login Succesfull !!\t");

                Global_User.U_Name = tb_Usename.Text;

                Add_New_Student obj = new Add_New_Student();

                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Please Enter Valid Username or Password";
                lbl_Error.ForeColor = Color.Red;
            }
            tb_Usename.Text = "";
            tb_Password.Text = "";
            tb_Usename.Focus();
            
            
        }

        

       

        

        

       

       

        
    }
}
