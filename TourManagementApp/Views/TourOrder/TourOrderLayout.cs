using System;
using System.Collections.Generic;

using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Views.Schedule_form;
using TourManagementApp.Views.TourOrder;

namespace TourManagementApp.Views.Tour
{
    public partial class TourOrderLayout : Form
    {
        private BookingService _bookingService = new ImplBookingService();
        private readonly ScheduleService _scheduleService = new ImplScheduleService();
        private readonly Message message = new Message();
       
        private List<Booking> _bookingList = new List<Booking>();
        private string _customerID; //id khách hàng dang chọn
        private int _tourID;
        private int IDBooking;
        public TourOrderLayout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_list_Click(object sender, EventArgs e)
        {
            _bookingList = _bookingService.getAll();
            generate_data(_bookingList);
            cbb_status.Text = "Tất cã";
        }

        private void cbb_change(object sender, EventArgs e)
        {
            if (cbb_status.Text != "Tất cã")
            {
                List<Booking> list_status = new List<Booking>();
                list_status = _bookingService.GetByAttribute("Status", cbb_status.Text);
                generate_data(list_status);
            }
            else
            {
                _bookingList = _bookingService.getAll();
                generate_data(_bookingList);
            }

        }

        private void generate_data(List<Booking> list_Booking)
        {
            dataGridView.DataSource = list_Booking;
            custom_dataGitView();
          
        }

        #region custom cell click
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView.Columns[e.ColumnIndex].Name;

                // Lấy giá trị ID
                object IdValue = dataGridView.Rows[e.RowIndex].Cells["BookingID"].Value;
                int Id = int.Parse(IdValue.ToString());

                if (columnName == "Detail")
                {
                    //Show detail
                    if (Id != null)
                    {
                        Booking booking = _bookingService.GetByID(Id);
                        TourOrderDetail tourOrderDetail = new TourOrderDetail(booking);
                        tourOrderDetail.ShowDialog();
                    }

                }
                else if (columnName == "Delete")
                {
                    if (Id != null)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Order dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            if (_bookingService.DeleteById(Id))
                            {
                                _bookingList = _bookingService.getAll();
                                generate_data(_bookingList);
                            }
                        }
                    }
                }

                //Show button
                if (Id != null)
                {   
                    panel_schedule.Show();
                    _customerID = dataGridView.Rows[e.RowIndex].Cells["CustomerID"].Value?.ToString();
                    _tourID = int.Parse( dataGridView.Rows[e.RowIndex].Cells["TourID"].Value?.ToString());
                    tb_number.Text = _customerID;
                    IDBooking = Id;
                }
                else
                {
                    panel_schedule.Hide();
                }

            }
        }
        #endregion

        #region custom datagitview customers
        private void custom_dataGitView()
        {
            //căn chỉnh tiêu đề
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView.EnableHeadersVisualStyles = false;

            // Đổi tên cột
            dataGridView.Columns["CustomerID"].HeaderText = "MKH";
            dataGridView.Columns["CustomerName"].HeaderText = "Tên khách";
            dataGridView.Columns["TourID"].HeaderText = "Mã tour";
            dataGridView.Columns["TourName"].HeaderText = "Tên Tour";
            dataGridView.Columns["Status"].HeaderText = "Trạng thái";
            dataGridView.Columns["BookingID"].HeaderText = "ID";

            //ẩn date total

            dataGridView.Columns["BookingDate"].Visible = false;
            dataGridView.Columns["TotalAmount"].Visible = false;
            dataGridView.Columns["PrePay"].Visible = false;

            //// Chỉnh kích thước cột
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns["CustomerID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["CustomerID"].Width = 120;
            dataGridView.Columns["TourID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["TourID"].Width = 100;
            dataGridView.Columns["BookingID"].Width = 80;

            //vị trí
            dataGridView.AllowUserToOrderColumns = true;

            //// Chỉnh màu sắc
            dataGridView.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView.DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
            //màu header
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView.EnableHeadersVisualStyles = false;


            // thêm nút "Sửa" nếu chưa có
            if (!dataGridView.Columns.Contains("Detail"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Detail";
                btnEdit.HeaderText = "Act";
                btnEdit.Text = "Chi tiết";
                btnEdit.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(btnEdit);
                dataGridView.Columns["Detail"].Width = 80;
                dataGridView.Columns["Detail"].DisplayIndex = 7;

            }

            //  thêm nút "Xóa" nếu chưa có
            if (!dataGridView.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.HeaderText = " ";
                btnDelete.Text = "Xóa";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(btnDelete);
                dataGridView.Columns["Delete"].Width = 80;
                dataGridView.Columns["Delete"].DisplayIndex = 8;
            }
            dataGridView.CellClick -= dataGridView_CellClick;
            dataGridView.CellClick += dataGridView_CellClick;
        }
        #endregion

        private void TourOrderLayout_Load(object sender, EventArgs e)
        {
            _bookingList = _bookingService.getAll();
            generate_data(_bookingList);
            cbb_status.Text = "Tất cã";
        }

        private void btn_addSchedule_Click(object sender, EventArgs e)
        {
            if (_customerID == null)
            {
                return;
            }
            Schedule getSchedule = _scheduleService.getByTourID(_tourID, _customerID);            
            if (getSchedule == null)
            {
                if ( message.MessageOKCancel("Tour chưa có lịch trình bạn có muốn thêm không?"))
                {             
                    AddSchedule addSchedule = new AddSchedule(_bookingService.GetByID(IDBooking));
                    addSchedule.ShowDialog();
                }
            }
            else
            {
                EditSchedule editSchedule = new EditSchedule(getSchedule);
                editSchedule.ShowDialog();
            }
        }
    }
}
