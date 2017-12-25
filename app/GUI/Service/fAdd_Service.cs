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

namespace app.GUI.Service
{
    public partial class fAdd_Service : Form
    {
        public fAdd_Service()
        {
            InitializeComponent();
        }

        
        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool flat = true;

            if (txt_nameservice.Text == "")
            {
                
                lb_error_name.Text = "The \"Username\" is not empty";
                flat = false;
            }
            if (txt_price.Text == "")
            {
                lb_error_price.Text = "The \"Price\" is not empty";
                flat = false;
            }

            if (txt_unit.Text == "")
            {
                lb_error_unit.Text = "The \"Unit\" is not empty";
                flat = false;
            }


            if (flat == true)
            {
                Service_DTO service = new Service_DTO();
                service.Name_service = txt_nameservice.Text;
                service.Price = decimal.Parse(txt_price.Text);
                service.Unit = txt_unit.Text;
                if (Service_BUS.Instance.Add_Service(service))
                {
                    MessageBox.Show("Add Successful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("False");

                }
            }
    }

        private void txt_nameservice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fAdd_Service_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }
    }
}
