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

namespace app
{
    public partial class fProfile : Form
    {
        public fProfile()
        {
            InitializeComponent();
        }

        #region Method 

        private String username;

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



        #endregion

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }


        private void fProfile_Load(object sender, EventArgs e)
        {
            txt_username.Text = this.Username;
            Staff_DTO staff_info = Staff_DAO.Instance.Get_Info(this.Username);
            txt_name.Text = staff_info.Name;
            txt_address.Text = staff_info.Address;
            txt_email.Text = staff_info.Email;
            txt_phone.Text = staff_info.Phone;
            if (staff_info.Sex == true)
                cb_sex.SelectedItem = "Men";
            else
                cb_sex.SelectedItem = "Woman";
            dtp_birthday.Value = staff_info.Birthday;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {

        }
    }
}
