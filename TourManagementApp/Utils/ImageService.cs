using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TourManagementApp.Utils
{
    public class ImageService
    {
        private readonly string imageFolderPath;

        public ImageService()
        {
            string projectRoot = Directory.GetParent(Application.StartupPath).Parent.FullName;
            imageFolderPath = Path.Combine(projectRoot, "Image");
            if (!Directory.Exists(imageFolderPath))
            {
                Directory.CreateDirectory(imageFolderPath);
            }
        }


        public string UploadImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh đại diện";
                openFileDialog.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                //if (openFileDialog.ShowDialog() == DialogResult.OK)
                //{
                //    string fileName = Path.GetFileName(openFileDialog.FileName);
                //    string savePath = Path.Combine(imageFolderPath, fileName);

                //    File.Copy(openFileDialog.FileName, savePath, true);
                //    return fileName;
                //}
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(openFileDialog.FileName);
                    string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName); 
                    string uniqueName = $"{fileName}_{Guid.NewGuid().ToString().Substring(0, 8)}{extension}";
                    string savePath = Path.Combine(imageFolderPath, uniqueName);

                    File.Copy(openFileDialog.FileName, savePath, true);
                    return uniqueName;
                }
            }
            return null;
        }
        public void ShowImage(PictureBox pictureBox, string imageName)
        {
            string imagePath = Path.Combine(imageFolderPath, imageName);

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                return;
                //MessageBox.Show("Không tìm thấy ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteImage(string imageName)
        {
            string imagePath = Path.Combine(imageFolderPath, imageName);

            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
                //MessageBox.Show("Ảnh đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return ;
                //MessageBox.Show("Ảnh không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
