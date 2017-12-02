using app.BUS;
using app.DTO;
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
        private void Load_Data()
        {
            List<Customer_DTO> list_customer = Customer_BUS.Instance.Get_List();
            dgv_customer.DataSource = list_customer;
        }


        private void fManage_customer_Load(object sender, EventArgs e)
        {
            btn_delete.Enabled = false;
           
        }
        public string username=null;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public int id_customer = 0;

        public int Id_customer
        {
            get
            {
                return id_customer;
            }

            set
            {
                id_customer = value;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Customer.fAdd_customer frm = new GUI.Customer.fAdd_customer();
            frm.ShowDialog();
            Load_Data();

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }


        private void fManage_customer_Load_1(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_customer = (int)dgv_customer.Rows[e.RowIndex].Cells["Column1"].Value;
            this.id_customer = id_customer;
            lb_name.Text = dgv_customer.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            lb_sex.Text = dgv_customer.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            //lb_passport.Text = dgv_customer.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
            lb_address.Text = dgv_customer.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
            lb_email.Text = dgv_customer.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
            lb_phone.Text = dgv_customer.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
            lb_company.Text = dgv_customer.Rows[e.RowIndex].Cells["Column8"].Value.ToString();

        }

        

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (this.id_customer > 0)
            {
                if (Customer_BUS.Instance.Lock_Customer(this.id_customer)) ;
                MessageBox.Show("Delete customer is sucess!");
                this.id_customer = 0;
                Load_Data();
            }
            else
            {
                MessageBox.Show("You must select customer");
            }
            this.id_customer =0;

        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (id_customer > 0)
            {
                fEdit_customer frm = new fEdit_customer();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose an account!");
            }
        }
    }
}
