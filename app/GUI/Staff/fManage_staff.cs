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
    public partial class fManage_staff : Form
    {
        public fManage_staff()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Staff.fAdd_account frm = new GUI.Staff.fAdd_account();
            frm.ShowDialog();
        }
    }
}
