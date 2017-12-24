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

namespace app.GUI.Service
{
    public partial class fManage_service : Form
    {
        public fManage_service()
        {
            InitializeComponent();
            Load_Data();
        }

        private int id_service;


        public int Id_service
        {
            get
            {
                return id_service;
            }

            set
            {
                id_service = value;
            }
        }



        private void Load_Data()
        {
            List<Service_DTO> list_service = Service_BUS.Instance.Get_List();
            dgv_service.DataSource = list_service;

        }
        private void fManage_service_Load(object sender, EventArgs e)
        {
            Load_Data();
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_service_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int id_service = (int)dgv_service.Rows[e.RowIndex].Cells["Column1"].Value;
                this.id_service = id_service;

                lb_name.Text = dgv_service.Rows[e.RowIndex].Cells["Column2"].Value.ToString();

                lb_price.Text = dgv_service.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                lb_unit.Text = dgv_service.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Selected Error!");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            GUI.Service.fAdd_Service frm = new GUI.Service.fAdd_Service();
            frm.ShowDialog();
            Load_Data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.id_service != 0)
            {
                if (Service_BUS.Instance.Del_Service(this.id_service))
                {
                    MessageBox.Show("Delete service is success!");
                    this.id_service = 0;
                    Load_Data();
                }

            }
            else
            {
                MessageBox.Show("You must select room!");
            }

            this.id_service = 0;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.id_service != 0)
            {
                GUI.Service.fEdit_Service frm = new GUI.Service.fEdit_Service();
                frm.Id_service = this.id_service;
                frm.ShowDialog();
                Load_Data();
            }
            else
            {
                MessageBox.Show("You must choose an id!");
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

                this.dgv_service.DataSource = null;
                List<Service_DTO> list_service = Service_BUS.Instance.Search_Service(txt_search.Text, this.cb_search.SelectedIndex);
                dgv_service.DataSource = list_service;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.id_service != 0)
            {
                if (System_BUS.Instance.Get_Account(DTO.Session.username).Id_type == 1)
                {
                    fService_info frm = new fService_info();
                    frm.Id_service = this.id_service;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You don't have permission to view details!");
                    this.id_service = 0;
                }
            }
            else
            {
                MessageBox.Show("You must select service!");
                this.id_service = 0;
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
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgv_service.Columns.Count]].Merge();
                worksheet.Cells[1, 1].Value = "List Data";
                worksheet.Cells[1, 1].Font.Size = 20;

                for (int i = 1; i <= dgv_service.Columns.Count; i++)
                {
                    worksheet.Cells[2, i] = dgv_service.Columns[i - 1].HeaderText;

                    worksheet.Cells[2, i].Font.Bold = true;
                }

                for (int i = 1; i <= dgv_service.Rows.Count; i++)
                {
                    for (int j = 1; j <= dgv_service.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j] = dgv_service.Rows[i - 1].Cells[j - 1].Value.ToString();
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
                int heght = dgv_service.Height;
                dgv_service.Height = dgv_service.RowCount * dgv_service.RowTemplate.Height * 2;
                bmp = new Bitmap(dgv_service.Width, dgv_service.Height);
                dgv_service.DrawToBitmap(bmp, new Rectangle(0, 0, dgv_service.Width, dgv_service.Height));
                dgv_service.Height = heght;
                printPreviewDialog1.ShowDialog();
                dgv_service.Height = 182;
                dgv_service.Width = 471;
            }
            catch
            {
                MessageBox.Show("Not find data!");
                dgv_service.Height = 182;
                dgv_service.Width = 471;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
