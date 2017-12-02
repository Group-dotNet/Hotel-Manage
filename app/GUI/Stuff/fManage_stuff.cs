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

        }
    }
}
