using Microsoft.VisualBasic.ApplicationServices;

using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Utils;

namespace TourManagementApp.Views.Tour
{
    public partial class TourItem : Form
    {
        private Tours _tour;
        private readonly ImageService _imageService = new ImageService();
        private readonly TourService _tourService = new ImplTourService();
        private readonly Message message = new Message();
        private string imagePath;
        public TourItem(Tours tuor)
        {
            InitializeComponent();
            _tour = tuor;
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            enable_control(true);
        }

        private void TourItem_Load(object sender, EventArgs e)
        {
            enable_control(false);
            _generate_data();
        }
        private void _generate_data()
        {
            tb_description.Text = _tour.Description;
            tb_name.Text = _tour.TourName;
            tb_price.Text = _tour.Price;
            cbb_transport.Text = _tour.Transport;
            cbb_type.Text = _tour.TourType;
            _imageService.ShowImage(pictureBox, _tour.LinkImage);
        }

        private void enable_control(bool flag)
        {
            if (!flag)
            {
                tb_description.Enabled = false;
                tb_name.Enabled = false;
                tb_price.Enabled = false;
                cbb_transport.Enabled = false;
                cbb_type.Enabled = false;
                btn_change.Hide();
                btn_save.Hide();
                btn_edit.Show();
            }
            else
            {

                tb_description.Enabled = true;
                tb_name.Enabled = true;
                tb_price.Enabled = true;
                cbb_transport.Enabled = true;
                cbb_type.Enabled = true;
                btn_change.Show();
                btn_save.Show();
                btn_edit.Hide();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Tour này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (_tourService.DeleteById(_tour.TourID))
                {
                    this.Close();
                }
                else
                {
                    message.MessageOK("sao ko xóa dc ");
                }

            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text)
                || string.IsNullOrEmpty(tb_description.Text)
                || string.IsNullOrEmpty(tb_price.Text))
            {
                string msg = "Vui lòng nhập đủ thông tin!";
                message.MessageOK(msg);
                return;
            }
            else
            {
                Tours newTour = new Tours();
                newTour.TourID = _tour.TourID;
                newTour.TourName = tb_name.Text;
                newTour.Transport = cbb_transport.SelectedItem.ToString();
                newTour.TourType = cbb_type.SelectedItem.ToString();
                newTour.Price = tb_price.Text;
                newTour.LinkImage = imagePath;
                newTour.Description = tb_description.Text;
                newTour.LinkImage= _tour.LinkImage;

                if (!string.IsNullOrEmpty(imagePath))
                {
                    newTour.LinkImage = imagePath;
                }
                
                if (_tourService.Update(newTour))
                {
                    _tour = newTour;
                    message.MessageOK("Cập nhật thông tin thành công");
                    enable_control(false);
                    return;
                }
            }           
        }
        private void btn_change_Click(object sender, EventArgs e)
        {
            imagePath = _imageService.UploadImage();

            if (!string.IsNullOrEmpty(imagePath))
            {
                _imageService.ShowImage(pictureBox, imagePath);
            }
        }
    }
}
