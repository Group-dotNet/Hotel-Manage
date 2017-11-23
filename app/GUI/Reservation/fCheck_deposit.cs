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
    public partial class fCheck_deposit : Form
    {
        public fCheck_deposit()
        {
            InitializeComponent();
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
        private void Load_ListDeposit()
        {
            List<Deposit_DTO> list_deposit = Deposit_BUS.Instance.GetListDepositReservation(id_reservation);
            foreach(Deposit_DTO deposit in list_deposit)
            {
                ListViewItem item = new ListViewItem(deposit.Id_deposit.ToString());
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
                item.SubItems.Add(deposit.Deposit.ToString("c", culture));
                item.SubItems.Add(deposit.Confirm.ToString());
                item.SubItems.Add(deposit.Created_confirm.ToString());
                item.SubItems.Add(deposit.Locked.ToString());
                item.SubItems.Add(deposit.Note.ToString());

                listView1.Items.Add(item);
            }

        }

        private void Load_Deposit_Using()
        {
            Deposit_DTO deposit = Deposit_BUS.Instance.GetInfoDepositUsing(this.id_reservation);

            lb_reservation.Text = "Reservation: " + id_reservation.ToString();
            lb_id.Text = deposit.Id_deposit.ToString();
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
            lb_deposit.Text = deposit.Deposit.ToString("c", culture);
            lb_confirm.Text = deposit.Confirm.ToString();
            lb_created.Text = deposit.Created_confirm.ToString();
        }

        private void fCheck_deposit_Load(object sender, EventArgs e)
        {
            Load_Deposit_Using();
            Load_ListDeposit();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
