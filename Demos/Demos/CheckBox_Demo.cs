using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demos
{
    public partial class CheckBox_Demo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Demos_DB;Integrated Security=True");

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
        public CheckBox_Demo()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            String C = "";
            String Cpp = "";
            String Java = "";
            String Python = "";

            if (cb_C.Checked)
            {
                C = "C";
            }
            else
            {
                C = null;
            }

            if (cb_Cpp.Checked)
            {
                Cpp = "Cpp";
            }
            else
            {
                Cpp = null;
            }

            if (cb_Java.Checked)
            {
                Java = "Java";
            }
            else
            {
                Java = null;
            }

            if (cb_Python.Checked)
            {
                Python = "Python";
            }
            else
            {
                Python = null;
            }

            SqlDataAdapter sda = new SqlDataAdapter("Insert into Course(C,Cpp,Java,Python) values('"+C+"','"+Cpp+"','"+Java+"','"+Python+"') ", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            MessageBox.Show("\t Add Course Successfully \t");

            Con_Close();
        }
    }
}
