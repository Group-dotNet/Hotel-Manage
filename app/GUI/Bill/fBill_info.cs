using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.GUI.Bill
{
    public partial class fBill_info : Form
    {
        public fBill_info()
        {
            InitializeComponent();
        }

        private int id_bill;

        public int Id_bill
        {
            get
            {
                return id_bill;
            }

            set
            {
                id_bill = value;
            }
        }

        private void fBill_info_Load(object sender, EventArgs e)
        {

        }
    }
}
