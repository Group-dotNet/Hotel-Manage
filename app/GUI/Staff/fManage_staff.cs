using app.BUS;
using app.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        }

        #region Method
        private string username = "phuc";
        private string choose_username = null;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        private void Load_Data()
        {
            List<Staff_DGV> list_staff_dgv = new List<Staff_DGV>();
            foreach(Staff_DTO staff in Staff_BUS.Instance.List_Staff())
            {
                Staff_DGV staff_dgv = new Staff_DGV(staff.Username, staff.Name, staff.Sex, staff.Phone);
                list_staff_dgv.Add(staff_dgv);
            }
            dgv_staff.DataSource = list_staff_dgv;
        }


        #endregion

        #region Event

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(this.choose_username != null)
            {
                fProfile frm = new fProfile();
                frm.Username = this.choose_username;
                frm.ShowDialog();
                Load_Data();
            }
            else
            {
                MessageBox.Show("You must select staff!");
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Staff.fAdd_Staff frm = new GUI.Staff.fAdd_Staff();
            frm.ShowDialog();
            Load_Data();
        }





        #endregion

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.choose_username = dgv_staff.Rows[e.RowIndex].Cells[0].Value.ToString();
                Staff_DTO staff = Staff_BUS.Instance.Get_Info(this.choose_username);

                MemoryStream stream = new MemoryStream(staff.Image);
                pictureBox1.Image = Image.FromStream(stream);
                
                
                lb_name.Text = staff.Name;
                lb_position.Text = Staff_BUS.Instance.Get_Role(this.choose_username);
            }
            catch(Exception ex)
            {
                throw new Exception("Error!");
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (choose_username != null)
            {
                if (Staff_BUS.Instance.Ban_Account(this.choose_username))
                {
                    MessageBox.Show("Ban Account is successs!");
                }
                else
                {
                    MessageBox.Show("Error when ban!");
                }
            }
            else
            {
                MessageBox.Show("You must choose an account!");
            }
        }

        private void fManage_staff_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            if(this.choose_username != null)
            {
                if (System_BUS.Instance.Get_Account(this.username).Id_type == 1)
                {
                    fChange_pass frm = new fChange_pass();
                    frm.Username = this.choose_username;
                    frm.ShowDialog();
                }
                else
                {
                    if (this.choose_username == this.username)
                    {
                        fChange_pass frm = new fChange_pass();
                        frm.Username = this.choose_username;
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("You don't have permission to view details!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select staff!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.choose_username != null)
            {
                if (System_BUS.Instance.Get_Account(this.username).Id_type == 1)
                {
                    fChange_role frm = new fChange_role();
                    frm.Username = this.choose_username;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You don't have permission to view details!!");
                }
            }
            else
            {
                MessageBox.Show("You must select staff!");
            }
        }
    }
}
