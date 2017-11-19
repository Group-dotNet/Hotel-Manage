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
    public partial class fStuff_detail : Form
    {
        public fStuff_detail()
        {
            InitializeComponent();
        }
        private int id_room;

        public int Id_room
        {
            get
            {
                return id_room;
            }

            set
            {
                id_room = value;
            }
        }

        private void Load_Combobox()
        {
            List<Stuff_DTO> list_stuff = Stuff_BUS.Instance.Get_List();
            foreach(Stuff_DTO stuff in list_stuff)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = stuff.Name_stuff;
                item.Value = stuff.Id_stuff;
                cb_stuff.Items.Add(item);
            }
        }

        private void Load_Data()
        {
            lb_room.Text = "Room " + this.id_room.ToString();
            Room_DTO room = Room_BUS.Instance.Get_Info_Room(this.id_room);
            List<Stuff_detail_DTO> list_stuff_detail = Stuff_detail_BUS.Instance.Get_List(room.Kind_of_room.Id);
            foreach (Stuff_detail_DTO stuff_detail in list_stuff_detail)
            {
                ListViewItem lvitem = new ListViewItem(stuff_detail.Stuff.Name_stuff.ToString());
                lvitem.SubItems.Add(stuff_detail.Kind_of_room.Name.ToString());
                lvitem.SubItems.Add(stuff_detail.Number.ToString());
                lv_stuff_detail.Items.Add(lvitem);
            }
            txt_type_room.Text = room.Kind_of_room.Name;
        }

        private void fStuff_detail_Load(object sender, EventArgs e)
        {
            Load_Combobox();
            Load_Data();
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            int id_kind_of_room = Room_BUS.Instance.Get_Info_Room(this.id_room).Kind_of_room.Id;
            //Stuff_detail_DTO stuff_detail = new Stuff_detail_DTO();
            //Stuff_detail_BUS.Instance.Get_Commit()
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
