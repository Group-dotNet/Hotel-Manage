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
    public partial class fManage_room : Form
    {
        public fManage_room()
        {
            InitializeComponent();
        }

        private int choose_floor;

        private int room = 0;

        private void LoadData(int floor)
        {
            List<Room_DTO> list_room_floor = Room_BUS.Instance.Get_List_Room_Floor(floor);
            foreach(Room_DTO item in list_room_floor)
            {
                Button btn = new Button() { Width = 95, Height = 95 };

                String room = "Room " + item.Num_floor.ToString() + item.Num_order.ToString("00");
                String type = item.Kind_of_room.Name.ToString();
                btn.Text = room + Environment.NewLine + type ;
                if (item.Logged == true) btn.BackColor = Color.Red;
                else btn.BackColor = Color.Aqua;

                btn.Click += btn_Click;
                btn.Tag = item;
                pn_room.Controls.Add(btn);
            }

        }

        private void ReLoad_Page()
        {
            pn_room.Controls.Clear();
            LoadData(this.choose_floor);
            if (this.choose_floor <= 1) btn_prev.Hide();
            if (this.choose_floor >= Room_BUS.Instance.Get_Max_Floor()) btn_next.Hide();
            lb_num_floor.Text = "Floor " + this.choose_floor.ToString();
            cb_fittel.SelectedIndex = 0;
        }

        private void Resert_Buton()
        {
            btn_next.Show();
            btn_prev.Show();
        }



        public int Choose_floor
        {
            get
            {
                return choose_floor;
            }

            set
            {
                choose_floor = value;
            }
        }

        public int Room
        {
            get
            {
                return room;
            }

            set
            {
                room = value;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int id_room = (int)((sender as Button).Tag as Room_DTO).Id_room;
            this.room = id_room;
            MessageBox.Show(id_room.ToString());
        }

      

      

        private void fManage_room_Load(object sender, EventArgs e)
        {
            LoadData(1);
            if (this.choose_floor <= 1) btn_prev.Hide();
            if (this.choose_floor >= Room_BUS.Instance.Get_Max_Floor()) btn_next.Hide();
            lb_num_floor.Text = "Floor " + this.choose_floor.ToString();
            cb_fittel.SelectedIndex = 0;
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.Resert_Buton();
            if (this.choose_floor > 1)
            {
                this.choose_floor = this.choose_floor - 1;
                if (this.choose_floor <= 1) btn_prev.Hide();
                if (this.choose_floor >= Room_BUS.Instance.Get_Max_Floor()) btn_next.Hide();
                pn_room.Controls.Clear();
                LoadData(this.choose_floor);
            }
            else
            {
                MessageBox.Show("Floor is not exists!");
            }
            lb_num_floor.Text = "Floor " + this.choose_floor.ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Resert_Buton();
            if (this.choose_floor < Room_BUS.Instance.Get_Max_Floor())
            {
                this.choose_floor = this.choose_floor + 1;
                if (this.choose_floor <= 1) btn_prev.Hide();
                if (this.choose_floor >= Room_BUS.Instance.Get_Max_Floor()) btn_next.Hide();
                pn_room.Controls.Clear();
                LoadData(this.choose_floor);
            }
            else
            {
                MessageBox.Show("Floor is not exists!");
            }
            lb_num_floor.Text = "Floor " + this.choose_floor.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fAdd_room frm = new fAdd_room();
            frm.ShowDialog();
            this.ReLoad_Page();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.ReLoad_Page();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(this.Room > 0)
            {
                fEdit_room frm = new fEdit_room();
                frm.Id_room = this.room;
                frm.ShowDialog();
                this.ReLoad_Page();
            }
            else
            {
                MessageBox.Show("You must select room!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.Room > 0)
            {
                if(Room_BUS.Instance.Del_Room(this.room))
                {
                    MessageBox.Show("Delete room is success!");
                    this.room = 0;
                    this.ReLoad_Page();
                }

            }
            else
            {
                MessageBox.Show("You must select room!");
            }
        }
    }
}
