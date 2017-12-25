using app.BUS;
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

namespace app.GUI.Staff
{
    public partial class fAdd_Staff : Form
    {
        public fAdd_Staff()
        {
            InitializeComponent();
        }

        private int type = 1;
        private string filename = null;

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

        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file";
            ofd.InitialDirectory = "C:\\"; // Thư mục bắt đầu
            ofd.Filter = "Image|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
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

        private void fAdd_Staff_Load(object sender, EventArgs e)
        {
            cb_sex.SelectedIndex = 1;
            cb_role.SelectedIndex = 1;
            if (this.type == 0) cb_role.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            bool flat = true;

            if ( txt_password.Text == "" || cb_role.SelectedIndex == -1 || txt_name.Text == "" || txt_phone.Text == "" || txt_address.Text == "" || txt_email.Text == "" || cb_sex.SelectedIndex == -1)
            {
                MessageBox.Show("Error!");
                flat = false;
                return;
            }

            System_DTO account = new System_DTO();
            account.Username = txt_username.Text;
            account.Password = txt_password.Text;
            account.Id_type = cb_role.SelectedIndex;

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
                MessageBox.Show("You must upload image!");
                return;
            }

            if (Staff_BUS.Instance.Check_Email(txt_email.Text) == false)
            {
                if (Staff_BUS.Instance.Insert_Staff(account, staff))
                {
                    MessageBox.Show("Add satff is success!");
                    this.Close();
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

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }
    }
}
