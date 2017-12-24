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

namespace app.GUI.Customer
{
    public partial class fManage_customer : Form
    {
        public fManage_customer()
        {
            InitializeComponent();
            
        }

        private void Load_Data()
        {

            List<Customer_DGV> list_customer_dgv = new List<Customer_DGV>();
            foreach(Customer_DTO customer in Customer_BUS.Instance.Get_List())
            {
                Customer_DGV customer_dgv = new Customer_DGV(customer.Id_customer, customer.Name, customer.Sex, customer.Phone, customer.Id_history);
                list_customer_dgv.Add(customer_dgv);
            }
            dgv_customer.DataSource = list_customer_dgv;
        }


        private void fManage_customer_Load(object sender, EventArgs e)
        {
            btn_delete.Enabled = false;
           
        }

        public int id_customer = 0;

        public int Id_customer
        {
            get
            {
                return id_customer;
            }

            set
            {
                id_customer = value;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Customer.fAdd_customer frm = new GUI.Customer.fAdd_customer();
            frm.ShowDialog();
            Load_Data();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                int heght = dgv_customer.Height;
                dgv_customer.Height = dgv_customer.RowCount * dgv_customer.RowTemplate.Height * 2;
                bmp = new Bitmap(dgv_customer.Width, dgv_customer.Height);
                dgv_customer.DrawToBitmap(bmp, new Rectangle(0, 0, dgv_customer.Width, dgv_customer.Height));
                dgv_customer.Height = heght;
                printPreviewDialog1.ShowDialog();
                dgv_customer.Height = 360;
                dgv_customer.Width = 643;
            }
            catch
            {
                MessageBox.Show("Not find data!");
                dgv_customer.Height = 360;
                dgv_customer.Width = 643;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Data Export";

                worksheet = workbook.ActiveSheet;
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgv_customer.Columns.Count]].Merge();
                worksheet.Cells[1, 1].Value = "List Customer";
                worksheet.Cells[1, 1].Font.Size = 20;

                for (int i = 1; i <= dgv_customer.Columns.Count; i++)
                {
                    worksheet.Cells[2, i] = dgv_customer.Columns[i - 1].HeaderText;

                    worksheet.Cells[2, i].Font.Bold = true;
                }

                for (int i = 1; i <= dgv_customer.Rows.Count; i++)
                {
                    for (int j = 1; j <= dgv_customer.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j] = dgv_customer.Rows[i - 1].Cells[j - 1].Value.ToString();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }


        private void fManage_customer_Load_1(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id_customer = (int)dgv_customer.Rows[e.RowIndex].Cells["Column1"].Value;
                this.id_customer = id_customer;

                // Chỉ cần id mình sẽ lấy thông tin từ trong database chứ không phải trong DGV_Customer
                Customer_DTO customer_info = Customer_BUS.Instance.Get_Info(this.Id_customer);

                // sau đó set cho lable
                lb_name.Text = customer_info.Name.ToString();
                if (customer_info.Sex == true) lb_sex.Text = "Men";
                else lb_sex.Text = "Woman";
                lb_address.Text = customer_info.Address.ToString();
                lb_email.Text = customer_info.Email.ToString();
                lb_phone.Text = customer_info.Phone.ToString();
            }
            catch
            {
                MessageBox.Show("Select error!");
            }
            

            // Không nên sử dụng
            //lb_name.Text = dgv_customer.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            //lb_sex.Text = dgv_customer.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            ////lb_passport.Text = dgv_customer.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
            //lb_address.Text = dgv_customer.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
            //lb_email.Text = dgv_customer.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
            //lb_phone.Text = dgv_customer.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
            //lb_company.Text = dgv_customer.Rows[e.RowIndex].Cells["Column8"].Value.ToString();
        }

        

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (this.id_customer > 0)
            {
                if (Customer_BUS.Instance.Lock_Customer(this.id_customer)) ;
                MessageBox.Show("Lock customer is sucess!");
                this.id_customer = 0;
                Load_Data();
            }
            else
            {
                MessageBox.Show("You must select customer");
            }
            this.id_customer =0;
            Load_Data();
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (id_customer > 0)
            {
                fEdit_customer frm = new fEdit_customer();
                frm.Id_customer = this.id_customer;
                frm.ShowDialog();
                Load_Data();
            }
            else
            {
                MessageBox.Show("You must choose an account!");
            }
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            // Phân quyển sử dụng chức năng
            if (this.id_customer != 0)
            {
                if (System_BUS.Instance.Get_Account(DTO.Session.username).Id_type == 1)
                {
                    fCustomer_info frm = new fCustomer_info();
                    frm.Id_customer = this.id_customer;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You don't have permission to view details!");
                    this.id_customer = 0;
                }
            }
            else
            {
                MessageBox.Show("You must select customer!");
            }
            
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            // Phân quyển sử dụng chức năng
            if (this.id_customer != 0)
            {
                if (System_BUS.Instance.Get_Account(DTO.Session.username).Id_type == 1)
                {
                    if (BUS.Customer_BUS.Instance.Lock_Customer(this.id_customer))
                    {
                        MessageBox.Show("Customer was locked!");
                        this.id_customer = 0;
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("You don't have permission to view details!");
                    this.id_customer = 0;
                }
            }
            else
            {
                MessageBox.Show("You must select customer!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool flat = true;
            if (txt_search.Text == "")
            {
                flat = false;
                MessageBox.Show("Error! Key word is not emtyl");
                return;
            }
            if (cb_search.SelectedIndex == -1)
            {
                flat = false;
                MessageBox.Show("Error! You must select option!");
                return;
            }

            if (flat)
            {

                this.dgv_customer.DataSource = null;

                List<Customer_DGV> list_customer_dgv = new List<Customer_DGV>();
                foreach (Customer_DTO customer in Customer_BUS.Instance.Search_Customer(txt_search.Text, (int)this.cb_search.SelectedIndex))
                {
                    Customer_DGV customer_dgv = new Customer_DGV(customer.Id_customer, customer.Name, customer.Sex, customer.Phone, customer.Id_history);
                    list_customer_dgv.Add(customer_dgv);
                }
                dgv_customer.DataSource = list_customer_dgv;
            }
        }

        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
