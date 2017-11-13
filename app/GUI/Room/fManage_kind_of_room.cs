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

namespace app.GUI.Room
{
    public partial class fManage_kind_of_room : Form
    {
        public fManage_kind_of_room()
        {
            InitializeComponent();
        }
        private int choose_kor;

        public int Choose_kor
        {
            get
            {
                return choose_kor;
            }

            set
            {
                choose_kor = value;
            }
        }

        private Kind_of_room_DTO Set_KoR()
        {
            Kind_of_room_DTO kor = new Kind_of_room_DTO();
            if (this.choose_kor != 0)
                kor.Id = this.Choose_kor;
            kor.Name = txt_name.Text;
            kor.Price = (decimal)nud_people.Value;
            kor.People = (int)nud_people.Value;
            return kor;
        }

        private void Clear_Data()
        {
            this.txt_name.ResetText();
            this.nud_price.Value = 0;
            this.nud_people.Value = 1;
        }

        private void Load_Data()
        {
            List<Kind_of_room_DTO> list_kor = Kind_of_room_BUS.Instance.Get_List();
            dgv_kor.DataSource = list_kor;
            //int x = 0;
            //foreach (Kind_of_room_DTO kor in list_kor)
            //{
            //    x++;
            //    dgv_kor.Rows[x].Cells[0].Value = kor.Id;
            //    dgv_kor.Rows[x].Cells[1].Value = kor.Name;
            //    dgv_kor.Rows[x].Cells[2].Value = Math.Round(kor.Price, 0);
            //    dgv_kor.Rows[x].Cells[3].Value = kor.Price;
            //}

        }

        private void fManage_kind_of_room_Load(object sender, EventArgs e)
        {
            this.Load_Data();
        }

        private void dgv_kor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_name.Text = dgv_kor.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                nud_price.Value = (decimal)dgv_kor.Rows[e.RowIndex].Cells["Price"].Value;
                nud_people.Value = (int)dgv_kor.Rows[e.RowIndex].Cells["People"].Value;
                this.choose_kor = (int)dgv_kor.Rows[e.RowIndex].Cells["Id"].Value;

            }
            catch
            {
                MessageBox.Show("Selected Error!");
            }
        }

        private void nud_people_ValueChanged(object sender, EventArgs e)
        {
            if (nud_people.Value < 1)
            {
                MessageBox.Show("Number people must not be less than 1");
                nud_people.Value = 1;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if((decimal) nud_price.Value > 0 )
            {
                if (Kind_of_room_BUS.Instance.Insert_KindofRom(this.Set_KoR()))
                {
                    MessageBox.Show("Insert data is success!");
                    this.Clear_Data();
                    this.Load_Data();
                }
                else
                {
                    MessageBox.Show("Error insert data!");
                }
            }
            else
            {
                MessageBox.Show("Error validate!");
            }
        }

        private void nud_price_ValueChanged(object sender, EventArgs e)
        {
            if (nud_people.Value < 1)
            {
                MessageBox.Show("Price must not be less than 1");
                nud_people.Value = 1;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(this.choose_kor != 0)
            {
                if (Kind_of_room_BUS.Instance.Edit_KindofRoom(this.Set_KoR()))
                {
                    MessageBox.Show("Update data is success!");
                    this.choose_kor = 0;
                    this.Clear_Data();
                    this.Load_Data();
                }
            }
            else
            {
                MessageBox.Show("You must select item!");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (this.choose_kor != 0)
            {
                if (Kind_of_room_BUS.Instance.Del_KindofRoom(this.choose_kor))
                {
                    MessageBox.Show("Delete data is success!");
                    this.choose_kor = 0;
                    this.Clear_Data();
                    this.Load_Data();
                }
            }
            else
            {
                MessageBox.Show("You must select item!");
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            this.choose_kor = 0;
            this.Clear_Data();
            this.Load_Data();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
