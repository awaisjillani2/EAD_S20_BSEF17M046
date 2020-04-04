using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            New_User frm1 = new New_User();
            frm1.ShowDialog();
            
        }

        private void ExistingUser_Click(object sender, EventArgs e)
        {
            Login frm2 = new Login();
            frm2.ShowDialog();

        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }
    }
}
