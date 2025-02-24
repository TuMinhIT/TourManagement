using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Models;
using TourManagementApp.Views.Admin;
using Microsoft.VisualBasic.ApplicationServices;

namespace TourManagementApp.Views.Admin
{
    public partial class EmployeesLayout : Form
    {
        private UserService userService;
        private List<Users> listUser = new List<Users>();

        public EmployeesLayout()
        {
            InitializeComponent();
            userService = new ImplUserService();
            listUser = userService.getAllUsers();
            generate_data(listUser);
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            listUser = userService.getAllUsers();
            generate_data(listUser);
            tb_code.Text = "";
            tb_email.Text = "";
        }
        private void generate_data(List<Users> listUser)
        {         
            dataGridView.DataSource = listUser;
            custom_dataGitView();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView.Columns[e.ColumnIndex].Name;
              
                // Lấy giá trị "UserID"
                object userIdValue = dataGridView.Rows[e.RowIndex].Cells["UserID"].Value;
                string Id = userIdValue != null ? userIdValue.ToString() : "null"; 

                if (columnName == "Detail")
                {
                    //Show detail
                    if (Id!="null")
                    {
                        Users users = userService.GetById(Id);
                    }
                                    
                }
                else if (columnName == "Delete")
                {
                    if (Id != "null")
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            if (userService.DeleteById(Id))
                            {
                                listUser = userService.getAllUsers();
                                generate_data(listUser);
                            }                          
                        }
                    }
                }
            }
        }
        private void custom_dataGitView()
        {
            //căn chỉnh tiêu đề
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView.EnableHeadersVisualStyles = false;

            // Ẩn cột 
            dataGridView.Columns["Password"].Visible = false;
            dataGridView.Columns["Role"].Visible = false;
            dataGridView.Columns["link"].Visible = false;

            // Đổi tên cột
            dataGridView.Columns["UserID"].HeaderText = "Mã";
            dataGridView.Columns["Phone"].HeaderText = "Số điện thoại";
            dataGridView.Columns["FullName"].HeaderText = "Tên Người dùng";
            dataGridView.Columns["Email"].HeaderText = "Email";
            dataGridView.Columns["Address"].HeaderText = "Địa chỉ";

            //// Chỉnh kích thước cột
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns["UserID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["UserID"].Width = 100;

            //vị trí
            dataGridView.AllowUserToOrderColumns = true;
          


            //// Chỉnh màu sắc
            dataGridView.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView.DefaultCellStyle.BackColor = Color.LightYellow;
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);

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
            dataGridView.CellClick += dataGridView_CellClick;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.ShowDialog();
            listUser = userService.getAllUsers();
            generate_data(listUser);
        }

        private void EmployeesLayout_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //ko tìm kiếm nếu null
            if (string.IsNullOrEmpty(tb_email.Text) && string.IsNullOrEmpty(tb_code.Text))
            {
                return; 
            }

            Users userById = null;
            Users userByEmail = null;

            if (!string.IsNullOrEmpty(tb_code.Text))
            {
                userById = userService.GetById(tb_code.Text);
            }
            if (!string.IsNullOrEmpty(tb_email.Text))
            {
                userByEmail = userService.GetByEmail(tb_email.Text);
            }

            listUser = new List<Users>();

            if (userById != null && userByEmail != null && userById.UserID != userByEmail.UserID)
            {
                listUser.Add(userById);
                listUser.Add(userByEmail);
            }
            else
            {     
                if (userById != null)
                {
                    listUser.Add(userById);
                }
                else if (userByEmail != null)
                {
                    listUser.Add(userByEmail);
                }
            }

            generate_data(listUser); 
        }

    }
}
