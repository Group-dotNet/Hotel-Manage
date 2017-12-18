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
    }
}
