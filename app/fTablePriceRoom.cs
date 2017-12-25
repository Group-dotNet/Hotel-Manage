using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class fTablePriceRoom : Form
    {
        public fTablePriceRoom()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            List<DTO.Kind_of_room_DTO> list_kor = BUS.Kind_of_room_BUS.Instance.Get_List();
            dataGridView1.DataSource = list_kor;


            ListViewItem item = new ListViewItem("less 2h");
            item.SubItems.Add("25%");
            listView1.Items.Add(item);
            ListViewItem item1 = new ListViewItem("less 6h");
            item1.SubItems.Add("50%");
            listView1.Items.Add(item1);
            ListViewItem item2 = new ListViewItem("more 6h");
            item2.SubItems.Add("100%");
            listView1.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("less 6h");
            item3.SubItems.Add("0%");
            listView2.Items.Add(item3);
            ListViewItem item4 = new ListViewItem("more 6h");
            item4.SubItems.Add("50%");
            listView2.Items.Add(item4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int id_kor = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                List<DTO.Stuff_Detail_DGV> list_stuff_dgv = new List<DTO.Stuff_Detail_DGV>();
                foreach (DTO.Stuff_detail_DTO stuff in BUS.Stuff_detail_BUS.Instance.Get_List(id_kor))
                {
                    DTO.Stuff_Detail_DGV item = new DTO.Stuff_Detail_DGV(stuff.Stuff.Id_stuff, stuff.Stuff.Name_stuff, stuff.Number);
                    list_stuff_dgv.Add(item);
                }
                dataGridView2.DataSource = list_stuff_dgv;
            }
            catch
            {
                MessageBox.Show("Selected Error!");
            }
        }

        private void fTablePriceRoom_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}

