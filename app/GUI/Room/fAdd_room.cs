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

namespace app.GUI.Room
{
    public partial class fAdd_room : Form
    {
        public fAdd_room()
        {
            InitializeComponent();
        }

 
        private void Load_Staff()
        {
            List<System_DTO> list_staff = System_BUS.Instance.Get_List_Staff_Service();
            foreach (System_DTO staff in list_staff)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = staff.Username;
                item.Value = staff.Id;
                cb_staff.Items.Add(item);
            }
        }

        private void Load_Kind_of_room()
        {
            List<Kind_of_room_DTO> list_kof = Kind_of_room_BUS.Instance.Get_List();
            foreach(Kind_of_room_DTO kof in list_kof)
            {
                //Class ComboboxItem save in file BUS/Function_Other.cs
                // follow is https://goo.gl/r3uBtj
                ComboboxItem item = new ComboboxItem();
                item.Text = kof.Name;
                item.Value = kof.Id;
                cb_type.Items.Add(item);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            bool flat = true;

            if (cb_type.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Kind of room");
                flat = false;
                return;
            }

            if (cb_staff.SelectedIndex == -1)
            {
                MessageBox.Show("You must select staff");
                flat = false;
                return;
            }
            
            if(flat == true)
            {
                if (Room_BUS.Instance.Check_Exists_Room((int)nud_floor.Value, (int)nud_order.Value))
                {
                    ComboboxItem item_type = (ComboboxItem)cb_type.SelectedItem;
                    ComboboxItem item_staff = (ComboboxItem)cb_staff.SelectedItem;
                    Room_BUS.Instance.Insert_Room((int)nud_floor.Value, (int)nud_order.Value, (int) item_type.Value, item_staff.Text.ToString());
                    MessageBox.Show("Insert Room is success!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Room was exists is system!");
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(nud_floor.Value < 1)
            {
                MessageBox.Show("Floor must not be less than 1");
                nud_floor.Value = 1;
            }
        }

        private void nud_order_ValueChanged(object sender, EventArgs e)
        {
            if (nud_floor.Value < 1)
            {
                MessageBox.Show("Floor must not be less than 1");
                nud_floor.Value = 1;
            }
        }

        private void fAdd_room_Load(object sender, EventArgs e)
        {
            this.Load_Staff();
            this.Load_Kind_of_room();
        }

        private void lbl_add_kind_of_room_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fManage_kind_of_room frm = new fManage_kind_of_room();
            frm.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
