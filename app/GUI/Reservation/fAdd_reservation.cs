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

namespace app.GUI.Reservation
{
    public partial class fAdd_reservation : Form
    {
        public fAdd_reservation()
        {
            InitializeComponent();
        }

        private int floor;

        private int id_room;

        private List<Room_DTO> list_room = new List<Room_DTO>();

        public int Floor
        {
            get
            {
                return floor;
            }

            set
            {
                floor = value;
            }
        }

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

        internal List<Room_DTO> List_room
        {
            get
            {
                return list_room;
            }

            set
            {
                list_room = value;
            }
        }

        private void LoadListView()
        {
            int people = 0;
            lv_reservation_room.Items.Clear();
            foreach (Room_DTO room in this.list_room)
            {
                ListViewItem item = new ListViewItem(room.Id_room.ToString());
                item.SubItems.Add(room.Num_floor.ToString());
                item.SubItems.Add(room.Num_order.ToString());
                item.SubItems.Add(room.Kind_of_room.Name.ToString());
                item.SubItems.Add(((int)room.Kind_of_room.Price).ToString());
                people = people + room.Kind_of_room.People;
                item.SubItems.Add(room.Kind_of_room.People.ToString());
                lv_reservation_room.Items.Add(item);
            }
            lb_number_total_people.Text = people.ToString();
        }

        private int Check_Room(int id_room)
        {
            if (Room_BUS.Instance.Get_Info_Room(id_room).Locked == true)
                return 0;
            foreach(Room_DTO room in this.list_room)
            {
                if (room.Id_room == id_room)
                    return 1;
                
            }
            return 2;
        }

        private void LoadData(int floor)
        {
            List<Room_DTO> list_room_floor = Room_BUS.Instance.Get_List_Room_Floor(floor);
            foreach (Room_DTO item in list_room_floor)
            {
                Button btn = new Button() { Width = 65, Height = 65 };

                String room = "Room " + item.Num_floor.ToString() + item.Num_order.ToString("00");
                String type = item.Kind_of_room.Name.ToString();
                btn.Text = room + Environment.NewLine + type;
                if (item.Locked == true) btn.BackColor = Color.Red;
                else btn.BackColor = Color.Aqua;

                btn.Click += btn_Click;
                btn.MouseDown += ((o, e) => {
                    this.id_room = item.Id_room;
                    if(this.Check_Room(this.id_room) == 0)
                    {
                        addToolStripMenuItem.Enabled = false;
                        cancelToolStripMenuItem.Enabled = false;
                    }
                    else if(this.Check_Room(this.id_room) == 1)
                    {
                        addToolStripMenuItem.Enabled = false;
                        cancelToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        addToolStripMenuItem.Enabled = true;
                        cancelToolStripMenuItem.Enabled = false;
                    }
                });
                btn.ContextMenuStrip = contextMenuStrip1;
                btn.Tag = item;
                flp_room.Controls.Add(btn);
            }
        }

        private void ReLoad_Page()
        {
            flp_room.Controls.Clear();
            LoadData(this.floor);
            if (this.floor <= 1) btn_prew.Hide();
            if (this.floor >= Room_BUS.Instance.Get_Max_Floor()) btn_next.Hide();
            lb_floor.Text = "Floor " + this.floor.ToString();
        }

        private void Resert_Buton()
        {
            btn_next.Show();
            btn_prew.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void number_total_people_Click(object sender, EventArgs e)
        {

        }

        private void nud_people_ValueChanged(object sender, EventArgs e)
        {
            if(nud_people.Value <= 0)
            {
                nud_people.Value = 1;
                MessageBox.Show("Number people than less 1");
            }
        }

        
        private void btn_Click(object sender, EventArgs e)
        {
            int id_room = (int)((sender as Button).Tag as Room_DTO).Id_room;
            this.Id_room = id_room;

            MessageBox.Show(id_room.ToString());
        }

        private void fAdd_reservation_Load(object sender, EventArgs e)
        {
            LoadData(1);
            LoadListView();
            this.floor = 1;
            if (this.floor <= 1) btn_prew.Hide();
            if (this.floor >= Room_BUS.Instance.Get_Max_Floor()) btn_next.Hide();
            lb_floor.Text = "Floor " + this.floor.ToString();
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room_DTO room = Room_BUS.Instance.Get_Info_Room(id_room);
            this.list_room.Add(room);
            LoadListView();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = list_room.FindIndex(item => (int)item.Id_room == this.id_room);

            list_room.RemoveAt(i);

            LoadListView();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool flat = true;

            if (int.Parse(lb_number_total_people.Text) < nud_people.Value)
            {
                MessageBox.Show("Error people in room");
                flat = false;
                return;
            }

            if (dtp_endate.Value <= DateTime.Now)
            {
                MessageBox.Show("Error End date");
                flat = false;
                return;
            }

            //if (cb_customer.SelectedIndex == -1)
            //{
            //    MessageBox.Show("You must select customer");
            //    flat = false;
            //    return;
            //}

            //if (cb_group.SelectedIndex == -1)
            //{
            //    MessageBox.Show("You must select Group");
            //    flat = false;
            //    return;
            //}

            if (flat == true)
            {
                Reservation_DTO reservation = new Reservation_DTO();
                reservation.Customer.Id_customer = 1;
                reservation.Is_group = false;
                reservation.People = (int)nud_people.Value;
                reservation.Staff.Username = "phuc";
                int x = Reservation_BUS.Instance.Insert_Reservation(reservation, dtp_endate.Value, this.list_room);
                if ( x != 0)
                {
                    fDeposit frm = new fDeposit();
                    frm.Id_reservation = x;
                    this.Close();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Not insert success!");
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }
         
        }

        private void btn_prew_Click(object sender, EventArgs e)
        {
            this.Resert_Buton();
            if (this.floor > 1)
            {
                this.floor = this.floor - 1;
                if (this.floor <= 1) btn_prew.Hide();
                if (this.floor >= Room_BUS.Instance.Get_Max_Floor()) btn_next.Hide();
                flp_room.Controls.Clear();
                LoadData(this.floor);
            }
            else
            {
                MessageBox.Show("Floor is not exists!");
            }
            lb_floor.Text = "Floor " + this.floor.ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Resert_Buton();
            if (this.floor < Room_BUS.Instance.Get_Max_Floor())
            {
                this.floor = this.floor + 1;
                if (this.floor <= 1) btn_prew.Hide();
                if (this.floor >= Room_BUS.Instance.Get_Max_Floor()) btn_next.Hide();
                flp_room.Controls.Clear();
                LoadData(this.floor);
            }
            else
            {
                MessageBox.Show("Floor is not exists!");
            }
            lb_floor.Text = "Floor " + this.floor.ToString();
        }

        private void btn_del_all_Click(object sender, EventArgs e)
        {
            lv_reservation_room.Items.Clear();
            this.list_room.Clear();
        }
    }
}
