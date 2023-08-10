using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cognizantlogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userid, password;
            userid = textBox1.Text;
            password = textBox2.Text;

            if (userid == "Cognizant" && password == "cognizant@365")
            {
                MessageBox.Show("You have successfully Logged In", "LoginMessgeDbox", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("You have entered Wrong userid & password,plz,check it once again ", "ErrorMessageDbox", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
