using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Views;
namespace TourManagementApp.Views.Customers
{
    public partial class CustomerLayout : Form
    {
        private CustomerService _customerService;
        private List<Customer> _customerList;
        private Message message = new Message();
        public CustomerLayout()
        {
            InitializeComponent();
            _customerService = new ImplCustomerService();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            addNewCustomer.ShowDialog();
        }
        private void btn_list_Click(object sender, EventArgs e)
        {
            _customerList = _customerService.getAllCustomer();
            generate_data(_customerList);
            tb_search.Text = "";
            cbb_type.Text = "Tên";
        }
        private void generate_data(List<Customer> list_Customer)
        {
            dataGridView.DataSource = list_Customer;
            custom_dataGitView();
        }

        #region custom cell click
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView.Columns[e.ColumnIndex].Name;

                // Lấy giá trị ID
                object IdValue = dataGridView.Rows[e.RowIndex].Cells["CustomerID"].Value;
                string Id = IdValue != null ? IdValue.ToString() : "null";

                if (columnName == "Detail")
                {
                    //Show detail
                    if (Id != "null")
                    {
                        Customer customer = _customerService.GetById(Id);
                        CustomerDetail customerDetail = new CustomerDetail(customer);
                        customerDetail.ShowDialog();

                        _customerList = _customerService.getAllCustomer();
                        generate_data(_customerList);
                    }

                }
                else if (columnName == "Delete")
                {
                    if (Id != "null")
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            if (_customerService.DeleteById(Id))
                            {
                                _customerList = _customerService.getAllCustomer();
                                generate_data(_customerList);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region custom datagitview customers
        private void custom_dataGitView()
        {
            //căn chỉnh tiêu đề
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dataGridView.EnableHeadersVisualStyles = false;

            // Đổi tên cột
            dataGridView.Columns["CustomerID"].HeaderText = "Mã";
            dataGridView.Columns["FullName"].HeaderText = "Tên khách hàng";
            dataGridView.Columns["Gender"].HeaderText = "Giới tính";
            dataGridView.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            dataGridView.Columns["Email"].HeaderText = "Email";
            dataGridView.Columns["Address"].HeaderText = "Địa chỉ";

            //ẩn
            dataGridView.Columns["Address"].Visible = false;
            dataGridView.Columns["Note"].Visible = false;
            dataGridView.Columns["Nationality"].Visible = false;

            //// Chỉnh kích thước cột
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns["CustomerID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["CustomerID"].Width = 120;

            //vị trí
            dataGridView.AllowUserToOrderColumns = true;

            //// Chỉnh màu sắc
            dataGridView.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView.DefaultCellStyle.BackColor = Color.LightYellow;
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
                btnEdit.Text = "Xem";
                btnEdit.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(btnEdit);
                dataGridView.Columns["Detail"].Width = 80;
                dataGridView.Columns["Detail"].DisplayIndex = 0;

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
                dataGridView.Columns["Delete"].DisplayIndex = 1;
            }
            dataGridView.CellClick -= dataGridView_CellClick;
            dataGridView.CellClick += dataGridView_CellClick;
        }
        #endregion

        private void btn_add_Click(object sender, EventArgs e)
        {

            AddNewCustomer addNewCustomer1 = new AddNewCustomer();
            addNewCustomer1.ShowDialog();
            _customerList = _customerService.getAllCustomer();
            generate_data(_customerList);
        }

        private void CustomerLayout_Load(object sender, EventArgs e)
        {
            _customerList = _customerService.getAllCustomer();
            generate_data(_customerList);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //ko tìm kiếm nếu null
            if (string.IsNullOrEmpty(tb_search.Text) || cbb_type.SelectedItem.ToString() == "<trống>")
            {
                message.MessageWarning(" Hãy chọn loại dữ liệu và nhập nội dung cần tìm kiếm!");
                return;
            }
            List<Customer> listCustomer = new List<Customer>();

            if (!string.IsNullOrEmpty(tb_search.Text))
            {
                switch (cbb_type.Text)
                {
                    case "Mã khách hàng":
                        Customer customer1 = _customerService.GetById(tb_search.Text);
                        listCustomer.Add(customer1);
                        break;

                    case "Tên":
                        listCustomer = _customerService.GetByName(tb_search.Text);
                        break;

                    case "Địa chỉ":
                        listCustomer = _customerService.GetByAddess(tb_search.Text);
                        break;

                    case "Số điện thoại":
                        listCustomer = _customerService.GetByPhone(tb_search.Text);
                        break;

                    default:
                        message.MessageOK("Lỗi ngoại lệ trong Switch case");
                        break;
                }
            }

            generate_data(listCustomer);
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bool success = FileInteraction.ExportToExcel(dataGridView, sfd.FileName);
                    if (success)
                    {
                        MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            List<Customer> list_customer = new List<Customer>();    
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    list_customer  = FileInteraction.ImportCustomersFromExcel(ofd.FileName);                  
                }
            }

            if (list_customer.Count > 0)
            {
                foreach (Customer customer in list_customer)
                {
                    _customerService.AddNew(customer);
                }
                message.MessageOK("Nhập dữ liệu thành công! ");
                _customerList = _customerService.getAllCustomer();
                generate_data(_customerList);
            }
        }

    }
}

