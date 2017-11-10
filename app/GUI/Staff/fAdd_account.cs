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

namespace app.GUI.Staff
{
    public partial class fAdd_account : Form
    {
        public fAdd_account()
        {
            InitializeComponent();
        }

        private void Clear_Error()
        {
            lb_error_username.ResetText();
            lb_error_password.ResetText();
            lb_error_check_match.ResetText();
            lb_error_position.ResetText();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void fAdd_account_Load(object sender, EventArgs e)
        {

        }

        private void btn_create_Click_1(object sender, EventArgs e)
        {
            this.Clear_Error();
            bool flat = true;

            if (txt_username.Text == "")
            {
                lb_error_username.Text = "The \"Username\" is not empty";
                flat = false;
            }

            if (txt_password.Text == "")
            {
                lb_error_password.Text = "The \"Password\" is not empty";
                flat = false;
            }

            if (txt_check_match.Text == "")
            {
                lb_error_check_match.Text = "The \"Check match\" is not empty";
                flat = false;
            }

            if (cb_position.SelectedValue != "Admin" && cb_position.SelectedValue != "Staff")
            {
                lb_error_position.Text = "The \"Position\" is not selected";
            }

            MessageBox.Show(Staff_BUS.Instance.Check_Username(txt_username.Text).ToString());

        }
    }
}
