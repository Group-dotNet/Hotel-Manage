using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.GUI.Analytic
{
    public partial class fAnalytic : Form
    {
        public fAnalytic()
        {
            InitializeComponent();
        }
        private int choose = 1;

        public int Choose
        {
            get
            {
                return choose;
            }

            set
            {
                choose = value;
            }
        }

        public DateTime Input_date
        {
            get
            {
                return input_date;
            }

            set
            {
                input_date = value;
            }
        }

        private DateTime input_date = DateTime.Now;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Load_Data()
        {
            switch (this.choose)
            {
                case 1:
                    {
                        lb_title.Text = "Reservation";
                        List<DTO.Reservation_DGV> list_reservation = BUS.Analytic_BUS.Instance.Get_Analytic_Reservation(dateTimePicker1.Value);

                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = list_reservation;
                        dataGridView1.Columns.Clear();

                        DataGridViewColumn col = new DataGridViewTextBoxColumn();
                        col.DataPropertyName = "id_reservation";
                        col.HeaderText = "ID Reservation";
                        col.Name = "id_reservation";
                        dataGridView1.Columns.Add(col);

                        DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                        col1.DataPropertyName = "customer";
                        col1.HeaderText = "Customer";
                        col1.Name = "customer";
                        dataGridView1.Columns.Add(col1);

                        DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                        col2.DataPropertyName = "is_group";
                        col2.HeaderText = "Group";
                        col2.Name = "is_group";
                        dataGridView1.Columns.Add(col2);

                        DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
                        col3.DataPropertyName = "people";
                        col3.HeaderText = "People";
                        col3.Name = "people";
                        dataGridView1.Columns.Add(col3);

                        DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
                        col4.DataPropertyName = "staff";
                        col4.HeaderText = "Staff";
                        col4.Name = "staff";
                        dataGridView1.Columns.Add(col4);

                        DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
                        col5.DataPropertyName = "status";
                        col5.HeaderText = "Status Reservation";
                        col5.Name = "status";
                        dataGridView1.Columns.Add(col5);
    
                        
                       
                    }
                    break;
                case 2:
                    {
                        lb_title.Text = "Bill";
                        List<DTO.Bill_DGV> list_bill = BUS.Analytic_BUS.Instance.Get_Analytic_Bill(dateTimePicker1.Value);
                        dataGridView1.DataSource = list_bill;
                        dataGridView1.Columns.Clear();

                        DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
                        col5.DataPropertyName = "id_bill";
                        col5.HeaderText = "ID Bill";
                        col5.Name = "id_bill";
                        dataGridView1.Columns.Add(col5);

                        DataGridViewColumn col = new DataGridViewTextBoxColumn();
                        col.DataPropertyName = "total";
                        col.HeaderText = "Total money";
                        col.Name = "total";
                        dataGridView1.Columns.Add(col);

                        DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                        col1.DataPropertyName = "username";
                        col1.HeaderText = "Staff";
                        col1.Name = "staff";
                        dataGridView1.Columns.Add(col1);

                        DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                        col2.DataPropertyName = "confirm";
                        col2.HeaderText = "Confirm";
                        col2.Name = "confirm";
                        dataGridView1.Columns.Add(col2);

                        DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
                        col3.DataPropertyName = "created";
                        col3.HeaderText = "Created";
                        col3.Name = "created";
                        dataGridView1.Columns.Add(col3);

                       
                    }
                    break;
                case 3:
                    {
                        lb_title.Text = "Room Emty";
                        List<DTO.Room_DGV> list_room = BUS.Analytic_BUS.Instance.Get_Analytic_Room_Emty();
                        dataGridView1.DataSource = list_room;
                        dataGridView1.Columns.Clear();

                        DataGridViewColumn col = new DataGridViewTextBoxColumn();
                        col.DataPropertyName = "id_room";
                        col.HeaderText = "ID Room";
                        col.Name = "id_room";
                        dataGridView1.Columns.Add(col);

                        DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                        col1.DataPropertyName = "name";
                        col1.HeaderText = "Name Room";
                        col1.Name = "name";
                        dataGridView1.Columns.Add(col1);

                        DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                        col2.DataPropertyName = "num_floor";
                        col2.HeaderText = "Floor";
                        col2.Name = "num_floor";
                        dataGridView1.Columns.Add(col2);

                        DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
                        col3.DataPropertyName = "num_order";
                        col3.HeaderText = "Order";
                        col3.Name = "num_order";
                        dataGridView1.Columns.Add(col3);

                        DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
                        col4.DataPropertyName = "kind_of_room";
                        col4.HeaderText = "Kind of room";
                        col4.Name = "kind_of_room";
                        dataGridView1.Columns.Add(col4);

                        DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
                        col5.DataPropertyName = "staff";
                        col5.HeaderText = "Staff";
                        col5.Name = "staff";
                        dataGridView1.Columns.Add(col5);
                    }
                    break;
                case 4:
                    {
                        lb_title.Text = "Room Using";
                        List<DTO.Room_DGV> list_room = BUS.Analytic_BUS.Instance.Get_Analytic_Room_Using();
                        dataGridView1.DataSource = list_room;
                        dataGridView1.Columns.Clear();

                        DataGridViewColumn col = new DataGridViewTextBoxColumn();
                        col.DataPropertyName = "id_room";
                        col.HeaderText = "ID Room";
                        col.Name = "id_room";
                        dataGridView1.Columns.Add(col);

                        DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                        col1.DataPropertyName = "name";
                        col1.HeaderText = "Name Room";
                        col1.Name = "name";
                        dataGridView1.Columns.Add(col1);

                        DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                        col2.DataPropertyName = "num_floor";
                        col2.HeaderText = "Floor";
                        col2.Name = "num_floor";
                        dataGridView1.Columns.Add(col2);

                        DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
                        col3.DataPropertyName = "num_order";
                        col3.HeaderText = "Order";
                        col3.Name = "num_order";
                        dataGridView1.Columns.Add(col3);

                        DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
                        col4.DataPropertyName = "kind_of_room";
                        col4.HeaderText = "Kind of room";
                        col4.Name = "kind_of_room";
                        dataGridView1.Columns.Add(col4);

                        DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
                        col5.DataPropertyName = "staff";
                        col5.HeaderText = "Staff";
                        col5.Name = "staff";
                        dataGridView1.Columns.Add(col5);
                    }
                    break;
                case 5:
                    {
                        lb_title.Text = "Service";
                        List<DTO.Service_DGV> list_service = BUS.Analytic_BUS.Instance.Get_Analytic_Service(dateTimePicker1.Value);
                        dataGridView1.DataSource = list_service;
                        dataGridView1.Columns.Clear();

                        DataGridViewColumn col = new DataGridViewTextBoxColumn();
                        col.DataPropertyName = "id_service";
                        col.HeaderText = "ID Service";
                        col.Name = "id_service";
                        dataGridView1.Columns.Add(col);

                        DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                        col1.DataPropertyName = "name_service";
                        col1.HeaderText = "Name Service";
                        col1.Name = "name_service";
                        dataGridView1.Columns.Add(col1);

                        DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                        col2.DataPropertyName = "price";
                        col2.HeaderText = "Price";
                        col2.Name = "price";
                        dataGridView1.Columns.Add(col2);

                        DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
                        col3.DataPropertyName = "number";
                        col3.HeaderText = "Number";
                        col3.Name = "number";
                        dataGridView1.Columns.Add(col3);

                        DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
                        col4.DataPropertyName = "date_use";
                        col4.HeaderText = "Date use";
                        col4.Name = "date_use";
                        dataGridView1.Columns.Add(col4);

                        DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
                        col5.DataPropertyName = "room";
                        col5.HeaderText = "Room";
                        col5.Name = "room";
                        dataGridView1.Columns.Add(col5);
                    }
                    break;
                case 6:
                    {
                        lb_title.Text = "Customer";
                        List<DTO.Customer_DGV> list_customer_dgv = new List<DTO.Customer_DGV>();
                        foreach (DTO.Customer_DTO customer in BUS.Customer_BUS.Instance.Get_List())
                        {
                            DTO.Customer_DGV customer_dgv = new DTO.Customer_DGV(customer.Id_customer, customer.Name, customer.Sex, customer.Phone, customer.Id_history);
                            list_customer_dgv.Add(customer_dgv);
                        }
                        dataGridView1.DataSource = list_customer_dgv;

                        dataGridView1.Columns.Clear();

                        DataGridViewColumn col = new DataGridViewTextBoxColumn();
                        col.DataPropertyName = "id_customer";
                        col.HeaderText = "ID Customer";
                        col.Name = "id_service";
                        dataGridView1.Columns.Add(col);

                        DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                        col1.DataPropertyName = "name_customer";
                        col1.HeaderText = "Name Customer";
                        col1.Name = "name_customer";
                        dataGridView1.Columns.Add(col1);

                        DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                        col2.DataPropertyName = "sex";
                        col2.HeaderText = "Sex";
                        col2.Name = "sex";
                        dataGridView1.Columns.Add(col2);

                        DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
                        col3.DataPropertyName = "phone";
                        col3.HeaderText = "Phone";
                        col3.Name = "phone";
                        dataGridView1.Columns.Add(col3);

                        DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
                        col4.DataPropertyName = "history";
                        col4.HeaderText = "History";
                        col4.Name = "history";
                        dataGridView1.Columns.Add(col4);

                    }
                    break;
                case 7:
                    {
                        List<DTO.Staff_DGV> list_staff_dgv = new List<DTO.Staff_DGV>();
                        foreach (DTO.Staff_DTO staff in BUS.Staff_BUS.Instance.List_Staff())
                        {
                            DTO.Staff_DGV staff_dgv = new DTO.Staff_DGV(staff.Username, staff.Name, staff.Sex, staff.Phone);
                            list_staff_dgv.Add(staff_dgv);
                        }
                        dataGridView1.DataSource = list_staff_dgv;

                        dataGridView1.Columns.Clear();

                        DataGridViewColumn col = new DataGridViewTextBoxColumn();
                        col.DataPropertyName = "username";
                        col.HeaderText = "Username";
                        col.Name = "username";
                        dataGridView1.Columns.Add(col);

                        DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                        col1.DataPropertyName = "name";
                        col1.HeaderText = "Name";
                        col1.Name = "name";
                        dataGridView1.Columns.Add(col1);

                        DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                        col2.DataPropertyName = "sex";
                        col2.HeaderText = "Sex";
                        col2.Name = "sex";
                        dataGridView1.Columns.Add(col2);

                        DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
                        col3.DataPropertyName = "phone";
                        col3.HeaderText = "Phone";
                        col3.Name = "phone";
                        dataGridView1.Columns.Add(col3);
                    }
                    break;
            }

        }

        private void fAnalytic_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = this.input_date;
            Load_Data();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            this.choose = 1;
            Load_Data();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            this.choose = 2;
            Load_Data();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            this.choose = 3;
            Load_Data();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            this.choose = 5;
            Load_Data();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            this.choose = 6;
            Load_Data();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            this.choose = 7;
            Load_Data();
        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.choose == 7)
                {
                    string username = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    GUI.Staff.fShow_profile frm = new Staff.fShow_profile();
                    frm.Username = username;
                    frm.Type = 2;
                    frm.ShowDialog();
                }
                else
                {
                    int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    switch (this.choose)
                    {
                        case 1:
                            {
                                GUI.Reservation.fReservation_info frm = new Reservation.fReservation_info();
                                frm.Id_reservation = id;
                                frm.ShowDialog();
                            }break;
                        case 2:
                            {
                                GUI.Bill.fBill_info frm = new Bill.fBill_info();
                                frm.Id_bill = id;
                                frm.ShowDialog();
                            }
                            break;
                        case 3:
                            {
                                GUI.Room.fRoom_info frm = new Room.fRoom_info();
                                frm.Id_room = id;
                                frm.ShowDialog();
                            }
                            break;
                        case 4:
                            {
                                GUI.Room.fRoom_info frm = new Room.fRoom_info();
                                frm.Id_room = id;
                                frm.ShowDialog();
                            }
                            break;
                        case 5:
                            {
                                GUI.Service.fService_info frm = new Service.fService_info();
                                frm.Id_service = id;
                                frm.ShowDialog();
                            }
                            break;
                        case 6:
                            {
                                GUI.Customer.fCustomer_info frm = new Customer.fCustomer_info();
                                frm.Id_customer = id;
                                frm.ShowDialog();
                            }
                            break;
                    }
                }
                
                
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.choose = 4;
            Load_Data();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Load_Data();
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
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dataGridView1.Columns.Count]].Merge();
                worksheet.Cells[1, 1].Value = "List Data";
                worksheet.Cells[1, 1].Font.Size = 20;

                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[2, i] = dataGridView1.Columns[i - 1].HeaderText;
                    
                    worksheet.Cells[2, i].Font.Bold = true;
                }

                for (int i = 1; i <= dataGridView1.Rows.Count; i++)
                {
                    for(int j = 1; j <= dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j] = dataGridView1.Rows[i - 1].Cells[j-1].Value.ToString();
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
                int heght = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                dataGridView1.Height = heght;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = 377;
                dataGridView1.Width = 678;
            }
            catch
            {
                MessageBox.Show("Not find data!");
                dataGridView1.Height = 377;
                dataGridView1.Width = 678;
            }
            
        }
    }
}
