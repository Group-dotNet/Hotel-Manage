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
    public partial class fManage_reservation : Form
    {
        public fManage_reservation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int id_reservation;


        public int Id_reservation
        {
            get
            {
                return id_reservation;
            }

            set
            {
                id_reservation = value;
            }
        }


        private void Load_Data()
        {
            List<Reservation_DTO> list_resevation = Reservation_BUS.Instance.GetListReservation();
            dgv_reservation.DataSource = list_resevation;
        }

        private void fManage_reservation_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dgv_reservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id_reservation = (int)dgv_reservation.Rows[e.RowIndex].Cells["Id_reservation"].Value;
                Reservation_DTO reservation = Reservation_BUS.Instance.GetInfoReservation(id_reservation);
                Calendar_DTO calendar = Calendar_BUS.Instance.GetCalendarReservation(id_reservation);

                lb_id.Text = id_reservation.ToString();
                lb_customer.Text = reservation.Customer.Name;
                lb_start_date.Text = calendar.Start_date.ToString();
                lb_end_date.Text = calendar.End_date.ToString();

                if (reservation.Is_group == true)
                    lb_group.Text = "Yes";
                else
                    lb_group.Text = "No";

                lb_people.Text = reservation.People.ToString();
                if(reservation.Status_reservation == 0)
                {
                    lb_status.Text = "Đã hủy";
                }else
                {
                    if(reservation.Status_reservation == 1)
                    {
                        lb_status.Text = "Đang sử dụng";
                    }
                    else
                    {
                        lb_status.Text = "Chưa thanh toán";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selected Error!");
                throw new Exception("Error!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            fCheck_room frm = new fCheck_room();
            frm.Id_reservation = this.id_reservation;
            frm.ShowDialog();
        }
    }
}
