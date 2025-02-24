using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourManagementApp.Utils;
using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;

namespace TourManagementApp.Views.Account
{
    public partial class AccountLayout : Form
    {
        private Users _user;
        private ImageService imageService = new ImageService();
        private Message message = new Message();
        public AccountLayout(Users user)
        {
            InitializeComponent();
            this._user = user;
        }
        public AccountLayout()
        {
            InitializeComponent();
        }

        private void AccountLayout_Load(object sender, EventArgs e)
        {
            tb_address.Text = string.IsNullOrEmpty(_user.Address) ? "<Trống>" : _user.Address;
            tb_code.Text = _user.UserID;
            tb_email.Text = _user.Email;
            tb_name.Text = _user.FullName;
            tb_phone.Text = string.IsNullOrEmpty(_user.Phone) ? "<Trống>" : _user.Phone;
            imageService.ShowImage(pic_avatar, _user.link.Trim());

            //if (!string.IsNullOrEmpty(_user.link))
            //{
            //    imageService.ShowImage(pic_avatar, _user.link.Trim());
            //}
            enable_Pannel(false);
        }

        //new path images
        private string imagePath = "";

        private void btn_changeAva_Click(object sender, EventArgs e)
        {
            imagePath = imageService.UploadImage();

            if (!string.IsNullOrEmpty(imagePath))
            {
                imageService.ShowImage(pic_avatar, imagePath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                imageService.DeleteImage(imagePath);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //check the text

            if (string.IsNullOrEmpty(tb_name.Text)|| string.IsNullOrEmpty(tb_phone.Text))
            {
                message.MessageWarning("Không bõ trống các thông tin! ");
                return;
            }

            UserService userService = new ImplUserService();
            Users user = _user;
            user.Address = tb_address.Text;
            user.FullName = tb_name.Text;
            user.Phone = tb_phone.Text;
            if (!string.IsNullOrEmpty(imagePath))
            {
                user.link = imagePath;
            }
            //update in database         
            if (userService.UpdateUser(user))
            {
                _user= user;
                message.MessageOK("Cập nhật thông tin thành công");       
            }
            enable_Pannel(false);
            //reload
            //this.InitializeComponent();
            return;
        }

        private void enable_Pannel(bool flag) {
            if (flag)
            {
                panel.Enabled = true;
                btn_fix.Enabled = false;
                btn_changeAva.Show();
                btn_update.Show();
            }
            else
            {
                panel.Enabled = false;
                btn_fix.Enabled = true;
                btn_changeAva.Hide();
                btn_update.Hide();
            }
        }


        private void btn_fix_Click(object sender, EventArgs e)
        {
            enable_Pannel(true);
        }
    }

}
