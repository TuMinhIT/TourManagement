using System;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Services;
using TourManagementApp.Utils;
using TourManagementApp.Models;

namespace TourManagementApp.Views.Tour
{
    public partial class AddNewTour : Form
    {
        private ImageService _imageService = new ImageService();
        private TourService _tourService=  new ImplTourService() ;
        Message message = new Message();
        private string imagePath = "";
        public AddNewTour()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_description.Text))
            {
                message.MessageWarning("Không bõ trống các thông tin! ");
                return;
            }

            int price;
            if (!int.TryParse(tb_price.Text, out price)) 
            {
                message.MessageWarning("Vui lòng nhập số nguyên hợp lệ!");
                tb_price.Clear();
                return;
            }
            Tours tour = new Tours();
            tour.TourName = tb_name.Text;
            tour.Transport =cbb_transport.SelectedItem.ToString();
            tour.TourType = cbb_type.SelectedItem.ToString();
            tour.Price = price.ToString();
            tour.LinkImage = imagePath;
            tour.Description = tb_description.Text;
            
            //add in database         
            if (_tourService.AddNew(tour))
            {
                if (message.MessageOKCancel("Thêm tour mới thành công bạn có muốn tiếp tục thêm!"))
                {
                    reset();
                } else { return; }
               
            }
            return;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reset()
        {
            tb_description.Clear();
            tb_price.Clear();
            tb_name.Clear();
            tb_price.Clear();
            pictureBox.Image = null;
        }
        //new path images
        private void btn_ImageLoad_Click(object sender, EventArgs e)
        {
            imagePath = _imageService.UploadImage();

            if (!string.IsNullOrEmpty(imagePath))
            {
                _imageService.ShowImage(pictureBox, imagePath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                _imageService.DeleteImage(imagePath);
            }
        }
    }
}
