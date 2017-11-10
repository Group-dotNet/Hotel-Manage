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

namespace app.GUI.Staff
{
    public partial class fManage_staff : Form
    {
        public fManage_staff()
        {
            InitializeComponent();
            Load_Data();
        }

        #region Method
        private string choose_username = null;

        private void Load_Data()
        {
            List<Staff_DTO> list_staff = Staff_BUS.Instance.List_Staff();
            dgv_staff.DataSource = list_staff;
        }


        #endregion

        #region Event

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(choose_username != null)
            {
                fChange_pass frm = new fChange_pass();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose an account!");
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Staff.fAdd_account frm = new GUI.Staff.fAdd_account();
            frm.ShowDialog();
        }





        #endregion

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lb_name.Text = dgv_staff.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                lb_position.Text = Staff_BUS.Instance.Get_Role(dgv_staff.Rows[e.RowIndex].Cells["Username"].Value.ToString());
                this.choose_username = dgv_staff.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                
            }
            catch
            {
                MessageBox.Show("Selected Error!");
            }
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            fShow_profile frm = new fShow_profile();
            if (this.choose_username == null)
                MessageBox.Show("You must select staff!");
            else
            {
                frm.Type = 2;
                frm.Username = this.choose_username;
                frm.ShowDialog();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
