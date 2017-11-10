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

namespace app.GUI.Staff
{
    public partial class fShow_profile : Form
    {
        public fShow_profile()
        {
            InitializeComponent();
        }

        private int type;
        private string username;

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

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


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fShow_profile_Load(object sender, EventArgs e)
        {
            if(this.username == null)
            {
                MessageBox.Show("Erorr! Not receive");
                this.Hide();
            }
            else
            {
                Staff_DTO staff_info = Staff_BUS.Instance.Get_Info(this.username);
                lb_name.Text = staff_info.Name;
                txt_name.Text = staff_info.Name;
                if (staff_info.Sex == true)
                    cb_sex.SelectedIndex = 1;
                else
                    cb_sex.SelectedIndex = 0;

                dtp_birthday.Value = staff_info.Birthday;
                txt_address.Text = staff_info.Address;
                txt_phone.Text = staff_info.Phone;
                txt_mail.Text = staff_info.Email;


                if (this.Type == 1)
                {
                    txt_name.Enabled = true;
                }
                if(this.Type == 2)
                {
                    txt_name.Enabled = false;
                    cb_sex.Enabled = false;
                    dtp_birthday.Enabled = false;
                    txt_address.Enabled = false;
                    txt_phone.Enabled = false;
                    txt_mail.Enabled = false;
                    btn_upload.Enabled = false;
                    btn_ok.Hide();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
