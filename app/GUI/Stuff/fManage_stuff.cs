using app.BUS;
using app.DTO;
using app.DAO;
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
    public partial class fManage_Stuff : Form
    {
        public fManage_Stuff()
        {
            InitializeComponent();
            
        }
        private int id_stuff;


        public int Id_stuff
        {
            get
            {
                return id_stuff;
            }

            set
            {
                id_stuff = value;
            }
        }

        private void Load_Data()
        {
            List<Stuff_DTO> List_Stuff = Stuff_BUS.Instance.Get_List();
            dgv_stuff.DataSource = List_Stuff;
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void fManage_Stuff_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Stuff.fAdd_Stuff frm = new GUI.Stuff.fAdd_Stuff();
            frm.ShowDialog();
            Load_Data();
        }
        private void dgv_stuff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                try
            {
                int id_stuff = (int)dgv_stuff.Rows[e.RowIndex].Cells["Column1"].Value;
                this.id_stuff = id_stuff;
                lb_id_stuff.Text = dgv_stuff.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                lb_stuff.Text = dgv_stuff.Rows[e.RowIndex].Cells["Column2"].Value.ToString();

            }

            catch
            {
                MessageBox.Show("Selected Error!");
            }
        }

        
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.id_stuff != 0)
            {
                GUI.Stuff.fEdit_Stuff frm = new GUI.Stuff.fEdit_Stuff();
                //Cần truyền và form fedit_stuff 1 mã vật tư đã chọn
                frm.Id_stuff = this.id_stuff;
                frm.ShowDialog();
                Load_Data();
            }
            else
            {
                MessageBox.Show("You must choose an id!");
            }

        }
        private void btn_delete_Click(object sender, EventArgs e) // Không có nghĩa là xóa vật tư. Vật tư vẫn tồn tại trong database
        {
            if (this.id_stuff != 0)
            {
                if (Stuff_BUS.Instance.Del_Stuff(this.id_stuff))
                {
                    MessageBox.Show("Deleted sucessful");
                    this.id_stuff = 0;
                    Load_Data();
                }
            }
            else
            {
                MessageBox.Show("Deleted error");
            }
            this.id_stuff = 0;

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

                this.dgv_stuff.DataSource = null;
                List<Stuff_DTO> list_stuff = Stuff_BUS.Instance.Search_Stuff( txt_search.Text, (int)this.cb_search.SelectedIndex);
                dgv_stuff.DataSource=list_stuff; 
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
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgv_stuff.Columns.Count]].Merge();
                worksheet.Cells[1, 1].Value = "List Stuff";
                worksheet.Cells[1, 1].Font.Size = 20;

                for (int i = 1; i <= dgv_stuff.Columns.Count; i++)
                {
                    worksheet.Cells[2, i] = dgv_stuff.Columns[i - 1].HeaderText;

                    worksheet.Cells[2, i].Font.Bold = true;
                }

                for (int i = 1; i <= dgv_stuff.Rows.Count; i++)
                {
                    for (int j = 1; j <= dgv_stuff.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j] = dgv_stuff.Rows[i - 1].Cells[j - 1].Value.ToString();
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
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void ptb_print_Click(object sender, EventArgs e)
        {
            try
            {
                int heght = dgv_stuff.Height;
                dgv_stuff.Height = dgv_stuff.RowCount * dgv_stuff.RowTemplate.Height * 2;
                bmp = new Bitmap(dgv_stuff.Width, dgv_stuff.Height);
                dgv_stuff.DrawToBitmap(bmp, new Rectangle(0, 0, dgv_stuff.Width, dgv_stuff.Height));
                dgv_stuff.Height = heght;
                printPreviewDialog1.ShowDialog();
                dgv_stuff.Height = 182;
                dgv_stuff.Width = 471;
            }
            catch
            {
                MessageBox.Show("Not find data!");
                dgv_stuff.Height = 182;
                dgv_stuff.Width = 471;
            }
        }
    }
}
