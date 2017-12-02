using app.BUS;
using app.DAO;
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
    public partial class fAdd_customer : Form
    {
        public fAdd_customer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool flat = true;
            if (txt_name.Text == "")
            {
                flat = false;
            }
            if (txt_passport.Text == "")
            {
                flat = false;
            }
            if (txt_address.Text == "")
            {
                flat = false;
            }
            if (txt_email.Text == "")
            {
                flat = false;
            }
            if (txt_phone.Text == "")
            {
                flat = false;
            }
            if (txt_company.Text == "")
            {
                flat = false;
            }
            if (flat = true)
            {
                Customer_DTO customer = new Customer_DTO();
                customer.Name = txt_name.Text;
                //customer.Sex = (bool)((int)(cb_sex.SelectedIndex));
                customer.Identity_card = txt_passport.Text;
                customer.Address = txt_address.Text;
                customer.Email = txt_email.Text;
                customer.Phone = txt_phone.Text;
                customer.Company = txt_company.Text;
                {
                    if (Customer_BUS.Instance.Add_Customer(customer)) 
                    {
                        MessageBox.Show("Account was insert in system");
                        this.Close();
                    }
                else
                {
                        MessageBox.Show("Error when insert!");
                 }
                }
            }
            else
            {
                MessageBox.Show("Username was exists in system");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

                
            
        
   

