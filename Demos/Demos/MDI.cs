using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demos
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void btn_RadioButton_Click(object sender, EventArgs e)
        {
            Radio_Button_Demo obj = new Radio_Button_Demo();
            obj.MdiParent = this.MdiParent;
            obj.Show();
        }

        private void btn_CheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_Demo obj = new CheckBox_Demo();
            obj.MdiParent = this.MdiParent;
            obj.Show();
        }
    }
}
