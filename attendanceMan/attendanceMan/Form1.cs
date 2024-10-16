using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendanceMan
{
    public partial class frmLogin : Form
    {
        Double count = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton=btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user,pass;
            user = "Zayan";
            pass = "21011556-169";
            if ((txtUser.Text == user) && (txtPass.Text == pass))
            {
                MessageBox.Show("WELCOME USER");
            }
            else
            {
                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong user name or password" + "\t" + remain + "\t" + "tries left");
                txtPass.Clear();
                txtUser.Clear();
                if (count == maxcount)
                {
                    MessageBox.Show("MAX TRY EXCED.");
                    Application.Exit();
                }
            }
        }
    }
}
