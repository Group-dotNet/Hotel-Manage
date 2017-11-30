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
                if (item.Locked == true) btn.BackColor = Color.Red;
                else btn.BackColor = Color.Aqua;

                btn.Click += btn_Click;
                btn.MouseDown += ((o, e) => {
                    this.room = item.Id_room;
                });
                if(Room_BUS.Instance.Get_Info_Room(item.Id_room).Locked == true)
                    btn.ContextMenuStrip = contextMenuStrip1;
                btn.Tag = item;
                pn_room.Controls.Add(btn);
            }

            if (this.choose_floor <= 1) btn_prev.Hide();
            if (this.choose_floor >= Room_BUS.Instance.Get_Max_Floor()) btn_next.Hide();
            lb_num_floor.Text = "Floor " + this.choose_floor.ToString();
            cb_fittel.SelectedIndex = 0;
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

            Room_DTO room = Room_BUS.Instance.Get_Info_Room(this.room);
            if(room.Locked == true)
            {
                
                Reservation_room_DTO reservation_room = Reservation_room_BUS.Instance.GetInfoReservationRoom(this.room);
                Calendar_DTO calendar = Calendar_BUS.Instance.GetInfoCalendarLaster(reservation_room.Reservation.Id_reservation);
                Reservation_DTO reservation = Reservation_BUS.Instance.GetInfoReservation(reservation_room.Reservation.Id_reservation);
                lb_name.Text = reservation.Customer.Name.ToString();
                lb_reservation.Text = reservation_room.Reservation.Id_reservation.ToString();
                lb_startdate.Text = calendar.Start_date.ToString();
                lb_end_date.Text = calendar.End_date.ToString();
                lb_type_room.Text = room.Kind_of_room.Name.ToString();
                lb_people.Text = room.Kind_of_room.People.ToString();
            }
            else
            {
                lb_name.Text = "Nope";
                lb_reservation.Text = "Nope";
                lb_startdate.Text = "Nope";
                lb_end_date.Text = "Nope";
                lb_type_room.Text = room.Kind_of_room.Name.ToString();
                lb_people.Text = room.Kind_of_room.People.ToString();
            }
        }

      

      

        private void fManage_room_Load(object sender, EventArgs e)
        {
            LoadData(1);
          
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
            Resert_Buton();
            this.ReLoad_Page();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Resert_Buton();
            this.ReLoad_Page();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(this.Room > 0)
            {
                if(Room_BUS.Instance.Get_Info_Room(this.room).Locked == false)
                {
                    fEdit_room frm = new fEdit_room();
                    frm.Id_room = this.room;
                    frm.ShowDialog();
                    this.ReLoad_Page();
                }
                else
                {
                    MessageBox.Show("Error! Room is using!");
                    this.room = 0;
                }
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI.Service.fService_ticket frm = new GUI.Service.fService_ticket();
            frm.Id_room = this.room;
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GUI.Stuff.fStuff_detail frm = new Stuff.fStuff_detail();
            frm.Id_room = this.Room;
            frm.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            if(this.room != 0)
            {
                fRoom_info frm = new fRoom_info();
                frm.Id_room = this.room;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select room!");
                this.room = 0;
            }
        }
    }
}
