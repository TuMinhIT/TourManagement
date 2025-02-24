using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourManagementApp.Views
{
    public class Message
    {
        //thông báo -- ok
        public void MessageOK(string tb)
        {
            MessageBox.Show(tb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //bạn có lưu không
        public bool MessageYN(string tb) {
            DialogResult result = MessageBox.Show(tb, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        //Bạn có chắc muốn thoát
        public bool MessageOKCancel(string tb) {
            DialogResult result = MessageBox.Show(tb, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            return result == DialogResult.OK;
         
        }

        //warning
        public void MessageWarning(string tb)
        {
            MessageBox.Show(tb, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //warning
 
        public bool MessageWarningYN(string tb)
        {
            DialogResult result = MessageBox.Show(tb, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;

        }

    }
}
