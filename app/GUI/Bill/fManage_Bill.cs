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
                if (System_BUS.Instance.Get_Account(DTO.Session.username).Id_type == 1)
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

        private void ptb_export_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Data Export";

                worksheet = workbook.ActiveSheet;
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgv_bill.Columns.Count]].Merge();
                worksheet.Cells[1, 1].Value = "List Bill";
                worksheet.Cells[1, 1].Font.Size = 20;

                for (int i = 1; i <= dgv_bill.Columns.Count; i++)
                {
                    worksheet.Cells[2, i] = dgv_bill.Columns[i - 1].HeaderText;

                    worksheet.Cells[2, i].Font.Bold = true;
                }

                for (int i = 1; i <= dgv_bill.Rows.Count; i++)
                {
                    for (int j = 1; j <= dgv_bill.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j] = dgv_bill.Rows[i - 1].Cells[j - 1].Value.ToString();
                    }
                }



                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
        Bitmap bmp;
        private void ptb_print_Click(object sender, EventArgs e)
        {
            try
            {
                int heght = dgv_bill.Height;
                dgv_bill.Height = dgv_bill.RowCount * dgv_bill.RowTemplate.Height * 2;
                bmp = new Bitmap(dgv_bill.Width, dgv_bill.Height);
                dgv_bill.DrawToBitmap(bmp, new Rectangle(0, 0, dgv_bill.Width, dgv_bill.Height));
                dgv_bill.Height = heght;
                printPreviewDialog1.ShowDialog();
                dgv_bill.Height = 361;
                dgv_bill.Width = 655;
            }
            catch
            {
                MessageBox.Show("Not find data!");
                dgv_bill.Height = 361;
                dgv_bill.Width = 655;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
