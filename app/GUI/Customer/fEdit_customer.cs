using app.DTO;
using app.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.BUS;

namespace app.GUI.Customer
{
    public partial class fEdit_customer : Form
    {
        public fEdit_customer()
        {
            InitializeComponent();
        }

        /*private void btn_add_Click(object sender, EventArgs e)
        {
            Customer_DTO customer = new Customer_DTO();
            customer.Name = txt_name.Text;
            //customer.Sex = cb_sex.SelectedItem;
            customer.Identity_card = txt_passport.Text;
            customer.Address = txt_address.Text;
            customer.Email = txt_email.Text;
            customer.Company = txt_company.Text;

            if (Customer_BUS.Instance.Edit_Customer(customer ))
            {
                MessageBox.Show("Edit Successful");
                this.Close();
            }
            else
                MessageBox.Show("Failed");
        }*/

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }

}

