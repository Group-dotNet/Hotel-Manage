using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.GUI.Customer
{
    public partial class fManage_customer : Form
    {
        public fManage_customer()
        {
            InitializeComponent();
        }

        private void fManage_customer_Load(object sender, EventArgs e)
        {
            btn_delete.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Customer.fAdd_customer frm = new GUI.Customer.fAdd_customer();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("print data");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("export file excel");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
