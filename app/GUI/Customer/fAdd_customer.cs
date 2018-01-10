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
                MessageBox.Show("Name is not null", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Viêt thông báo cho tất cả các điểu kiện
                flat = false;
                return;
            }
            if (txt_passport.Text == "")
            {
                MessageBox.Show("Id Card is not null", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }

            if (txt_passport.Text.Length != 12)
            {
                MessageBox.Show("Id Cart is not exist!", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }

            double parsedValue;
            if (!double.TryParse(txt_passport.Text, out parsedValue))
            {
                MessageBox.Show("Id Cart is number only field", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }
            if (txt_address.Text == "")
            {
                MessageBox.Show("Address is not null", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }
            if (txt_email.Text == "")
            {
                MessageBox.Show("Email is not null", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(txt_email.Text);
                flat = true;
            }
            catch
            {
                MessageBox.Show("Email is not exists", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }

            if (Customer_BUS.Instance.Check_Email(txt_email.Text) == true)
            {
                MessageBox.Show("Email exists in system", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }

            if (txt_phone.Text == "")
            {
                MessageBox.Show("Phone is not null", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }


            if (txt_phone.Text.Length != 11 && txt_phone.Text.Length != 10)
            {
                MessageBox.Show("Phone is not exist!", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }

            double parsedValue1;
            if (!double.TryParse(txt_phone.Text, out parsedValue1))
            {
                MessageBox.Show("Phone is number only field", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }

            if (txt_company.Text == "")
            {
                MessageBox.Show("Company is not null", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flat = false;
                return;
            }
            if (flat == true)
            {
                Customer_DTO customer = new Customer_DTO();
                customer.Name = txt_name.Text;
                if (cb_sex.SelectedIndex == 1)
                    customer.Sex = true;
                else
                    customer.Sex = false;
      
                customer.Identity_card = txt_passport.Text;
                customer.Address = txt_address.Text;
                customer.Email = txt_email.Text;
                customer.Phone = txt_phone.Text;
                customer.Company = txt_company.Text;


                if (Customer_BUS.Instance.Add_Customer(customer)) 
                {
                    MessageBox.Show("Add Customer is success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                     MessageBox.Show("Error when insert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username was exists in system", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAdd_customer_Load(object sender, EventArgs e)
        {
            cb_sex.SelectedIndex = 1;
        }

        private void txt_passport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }
    }
}

                
            
        
   

