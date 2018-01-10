using app.BUS;
using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string email_old;
        private byte[] image_byte;
        private string filename = null;


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

        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file";
            ofd.InitialDirectory = "C:\\"; // Thư mục bắt đầu
            ofd.Filter = "Image|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.filename = ofd.FileName;
                pib_profile.Image = Image.FromFile(this.filename);
            }
        }

        private byte[] CovertImage()
        {
            byte[] image = null;
            FileStream stream = new FileStream(this.filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            image = br.ReadBytes((int)stream.Length);
            return image;
        }

        #endregion

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Staff_DTO staff = new Staff_DTO();
            staff.Username = txt_username.Text;
            staff.Name = txt_name.Text;
            if (cb_sex.SelectedIndex == 1) staff.Sex = true;
            else staff.Sex = false;
            staff.Birthday = dtp_birthday.Value;
            staff.Address = txt_address.Text;
            staff.Phone = txt_phone.Text;
            staff.Email = txt_email.Text;
            if (this.filename != null)
                staff.Image = this.CovertImage();
            else
            {

                staff.Image = this.image_byte;
            }

            bool flat = true;
            
            if(txt_name.Text == "" || txt_phone.Text == "" || txt_address.Text == "" || txt_email.Text == "" || cb_sex.SelectedIndex == -1)
            {
                MessageBox.Show("Error!", "Error validate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            if (txt_email.Text == this.email_old)
            {
                if (Staff_BUS.Instance.Edit_Info_Staff(staff))
                {
                    MessageBox.Show("Edit satff is success!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                if(Staff_BUS.Instance.Check_Email(txt_email.Text) == false)
                {
                    if (Staff_BUS.Instance.Edit_Info_Staff(staff))
                    {
                        MessageBox.Show("Edit satff is success!");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Email was exists in system!");
                    return;
                }
            }
            
            
        }


        private void fProfile_Load(object sender, EventArgs e)
        {
            txt_username.Text = this.Username;
            Staff_DTO staff_info = Staff_DAO.Instance.Get_Info(this.Username);
            txt_name.Text = staff_info.Name;
            txt_address.Text = staff_info.Address;
            txt_email.Text = staff_info.Email;
            this.email_old = staff_info.Email;
            txt_phone.Text = staff_info.Phone;
            if (staff_info.Sex == true)
                cb_sex.SelectedItem = "Men";
            else
                cb_sex.SelectedItem = "Woman";
            dtp_birthday.Value = staff_info.Birthday;

            
            if (staff_info.Image != null && staff_info.Image.Length > 0)
            {
                this.image_byte = staff_info.Image;
                MemoryStream stream = new MemoryStream(staff_info.Image);
                pib_profile.Image = Image.FromStream(stream);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fProfile_FormClosing(object sender, FormClosingEventArgs e)
        {

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
