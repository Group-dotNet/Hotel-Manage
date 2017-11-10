using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.GUI.Staff
{
    public partial class fManage_stuff : Form
    {
        public fManage_stuff()
        {
            InitializeComponent();
        }

        #region Method
        private string choose_username = null;

        #endregion

        #region Event

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(choose_username != null)
            {
                fChange_pass frm = new fChange_pass();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose an account!");
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Staff.fAdd_account frm = new GUI.Staff.fAdd_account();
            frm.ShowDialog();
        }

        #endregion
    }
}
