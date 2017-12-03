using app.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        bool Login(string user, string pass)
        {
            return System_BUS.Instance.Login_System(user, pass);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (this.Login(user, pass))
            {
                fMain frm = new fMain();
                frm.Username = user;
                this.Hide();
                frm.ShowDialog();
                
            }
             else
            {
                if(MessageBox.Show("Please check my account!", "Error", MessageBoxButtons.RetryCancel) == System.Windows.Forms.DialogResult.Retry)
                {
                    txtPass.Clear();
                    txtUser.Focus();
                }
            }
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want exit system?", "Notifile", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            if(System_BUS.Instance.CheckExistsAccount() == true)
            {
                GUI.Staff.fAdd_Staff frm = new GUI.Staff.fAdd_Staff();
                frm.Type = 0;
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
