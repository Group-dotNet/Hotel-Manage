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

namespace app.GUI.Bill
{
    public partial class fManage_Bill : Form
    {
        public fManage_Bill()
        {
            InitializeComponent();
        }
        private int id_bill;
        private string username = "phuc";

        public int Id_bill
        {
            get
            {
                return id_bill;
            }

            set
            {
                id_bill = value;
            }
        }

        private void Load_Data()
        {
            List<Bill_DTO> list_bill = Bill_BUS.Instance.GetListBill();
            List<Bill_DGV> list_bill_dgv = new List<Bill_DGV>();
            foreach(Bill_DTO bill in list_bill)
            {
                Bill_DGV bill_dgv = new Bill_DGV(bill.Id_bill, bill.Total_money, bill.Staff.Username, bill.Confirm, bill.Created);
                list_bill_dgv.Add(bill_dgv);
            }
            dgv_bill.DataSource = list_bill_dgv;
        }

        private void fManage_Bill_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dgv_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id_bill = (int)dgv_bill.Rows[e.RowIndex].Cells["id"].Value;
                this.id_bill = id_bill;

                Bill_DTO bill = Bill_BUS.Instance.GetInfoBill(id_bill);
                Reservation_DTO reservation = Reservation_BUS.Instance.GetInfoReservation(bill.Reservation.Id_reservation);

                lb_reservation.Text = bill.Reservation.Id_reservation.ToString();
                lb_customer.Text = reservation.Customer.Name.ToString();
                lb_staff.Text = reservation.Staff.Username.ToString();
                if (bill.Confirm == false) lb_confirm.Text = "Not paid";
                else lb_confirm.Text = "Have Pay";
                lb_created.Text = bill.Created.ToString();
            }
            catch
            {
                MessageBox.Show("Selected Error!");
            }
        }



        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.id_bill != 0)
            {
                if (Bill_BUS.Instance.CheckConfirmBill(id_bill) == false)
                {
                    fCheckOut frm = new fCheckOut();
                    frm.Id_bill = this.Id_bill;
                    frm.ShowDialog();
                    this.Load_Data();
                }
                else
                {
                    MessageBox.Show("This bill is not check out");
                    this.Id_bill = 0;
                }
            }
            else
            {
                MessageBox.Show("You must select Bill");
                this.id_bill = 0;
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool flat = true;

            if(txt_search.Text == "")
            {
                flat = false;
                MessageBox.Show("Error! No keyword!");
                return;
            }

            if(cb_search.SelectedIndex == -1)
            {
                flat = false;
                MessageBox.Show("Error! No select option!");
                return;
            }

            if (flat)
            {

                List<Bill_DTO> list_bill = Bill_BUS.Instance.SearchBill(this.cb_search.SelectedIndex, this.txt_search.Text);
                List<Bill_DGV> list_bill_dgv = new List<Bill_DGV>();
                foreach (Bill_DTO bill in list_bill)
                {
                    Bill_DGV bill_dgv = new Bill_DGV(bill.Id_bill, bill.Total_money, bill.Staff.Username, bill.Confirm, bill.Created);
                    list_bill_dgv.Add(bill_dgv);
                }
                dgv_bill.DataSource = list_bill_dgv;
            }
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (this.id_bill != 0)
            {
                if (System_BUS.Instance.Get_Account(this.username).Id_type == 1)
                {
                    fBill_info frm = new fBill_info();
                    frm.Id_bill = this.Id_bill;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You don't have permission to view details!");
                    this.id_bill = 0;
                }
            }
            else
            {
                MessageBox.Show("You must select Bill");
                this.id_bill = 0;
            }
        }
    }
}
