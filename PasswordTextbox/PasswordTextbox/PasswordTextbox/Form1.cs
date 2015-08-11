using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordTextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You entered the following password : " + passwordTextBox1.AdminPassword,"Password preview",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ShowPassword(object sender, EventArgs e)
        {
            MessageBox.Show("You entered the following password : " + passwordFrenchTextBox1.AdminPassword, "Password preview", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
