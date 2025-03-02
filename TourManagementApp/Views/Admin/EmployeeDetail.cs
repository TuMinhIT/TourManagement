using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManagementApp.Models;

namespace TourManagementApp.Views.Admin
{
    public partial class EmployeeDetail : Form
    {
        private Users _user;
        public EmployeeDetail(Users user)
        {
            this._user = user;
            InitializeComponent();
            generateData();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateData()
        {
            tb_note.Text = _user.note;
            tb_name.Text = _user.FullName;
            tb_code.Text = _user.UserID;
            tb_address.Text = _user.Address;
            tb_email.Text = _user.Email;
            tb_phone.Text = _user.Phone;
        }

        private void EmployeeDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
