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

namespace app.GUI.Stuff
{
    public partial class fEdit_Stuff : Form
    {
        public fEdit_Stuff()
        {
            InitializeComponent();
        }

        private int id_stuff; // cần phải tạo 1  mã của vật tư muốn edit, mã này được truyền vào trong fManager_Stuff sự kiện eidt

        public int Id_stuff
        {
            get
            {
                return id_stuff;
            }

            set
            {
                id_stuff = value;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Stuff_DTO stuff = new Stuff_DTO();
            //Thiếu mã vật tư cần sửa!
            stuff.Id_stuff = this.id_stuff; // mã này để xác định sửa vật tư nào
            stuff.Name_stuff = txt_stuff.Text;
            if (Stuff_BUS.Instance.Edit_Stuff(stuff))
            {
                MessageBox.Show("Edit Successful");
                this.Close();
            }
            else
                MessageBox.Show("False");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fEdit_Stuff_Load(object sender, EventArgs e)
        {
            // THiếu thông tin của vặt tư hiện lên textbox
            // mục đich cần cho người dùng biết đang sửa vặt từ nào!
            Stuff_DTO stuff_info = Stuff_BUS.Instance.Get_Info(this.Id_stuff);// truyền vào mã vặt tư
            //Đưa dữ liệu lên textbox
            txt_stuff.Text = stuff_info.Name_stuff;
        }
    }
}
