using System;

using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Utils;
using TourManagementApp.Views.Customers;

namespace TourManagementApp.Views.Tour
{
    public partial class Tourlayout : Form
    {
        private TourService _tourService = new ImplTourService();
        private readonly ImageService _imageService = new ImageService();
        private List<Tours> list_tour = new List<Tours>();
        private readonly Message message = new Message();
        public Tourlayout()
        {
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_add_new_Click(object sender, EventArgs e)
        {
            AddNewTour addNewTour = new AddNewTour();
            addNewTour.ShowDialog();
            list_tour = _tourService.getAll();
            generate_data(list_tour);
        }
        private void btn_list_Click(object sender, EventArgs e)
        {
            list_tour = _tourService.getAll();
            generate_data(list_tour);
            cbb_price.Text = "Tất cã";
            cbb_transport.Text = "Tất cã";
            cbb_type.Text = "Tất cã";
        }

        private void generate_data(List<Tours> list_tour)
        {
            panel_main.Controls.Clear();
            foreach (Tours item in list_tour)
            {
                TourItem subForm = new TourItem(item);
                subForm.TopLevel = false;
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Top;
                panel_main.Controls.Add(subForm);
                subForm.Show();
            }
        }

        private void Tourlayout_Load(object sender, EventArgs e)
        {
            list_tour = _tourService.getAll();
            generate_data(list_tour);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbb_price.Text == "Tất cã" && cbb_transport.Text == "Tất cã" && cbb_type.Text == "Tất cã")
            {
                list_tour = _tourService.getAll();
                generate_data(list_tour);
                return;
            }

            #region search by price
            List<Tours> list_price = new List<Tours>();
            switch (cbb_price.Text)
            {
                case "Dưới 200$":
                    list_price = _tourService.GetByPrice(0, 200);
                    break;
                case "Từ 200$ đến 400$":
                    list_price = _tourService.GetByPrice(200, 400);
                    break;
                case "Từ 400$ đến 800$":
                    list_price = _tourService.GetByPrice(400, 800);
                    break;
                case "Trên 800$":
                    list_price = _tourService.GetByPrice(800, 10000000);
                    break;
                default:
                    list_price = list_tour; 
                    break;
            }

            #endregion

            #region search by type
            List<Tours> list_type = new List<Tours>();
            if (cbb_type.Text != "Tất cã")
            {
                list_type = _tourService.GetByAttribute("TourType", cbb_type.SelectedItem.ToString());
            }
            else
            {
                list_type = list_tour;
            }

            #endregion

            List<Tours> list_transport = new List<Tours>();
            if (cbb_transport.Text != "Tất cã")
            {
                list_transport = _tourService.GetByAttribute("Transport", cbb_transport.SelectedItem.ToString());
            }
            else
            {
                list_transport = list_tour;
            }

            var list_distinct = list_price
                .Select(t => t.TourID)
                .Intersect(list_type.Select(t => t.TourID))
                .Intersect(list_transport.Select(t => t.TourID))
                .ToList();

            var result = list_tour
                .Where(t => list_distinct.Contains(t.TourID))
                .ToList();


            if (result == null ||result.Count == 0)
            {
                panel_main.Controls.Clear();
                message.MessageOKCancel("Không có dữ liệu phù hợp! ");
            }
            else
            {            
                generate_data(result);
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            List<Tours> list_tour = new List<Tours>();
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    list_tour = FileInteraction.ImportTourFromExcel(ofd.FileName);
                }
            }

            if (list_tour.Count > 0)
            {
                foreach (Tours tour in list_tour)
                {
                    _tourService.AddNew(tour);
                }
                message.MessageOK("Nhập dữ liệu thành công! ");
                list_tour = _tourService.getAll();
                generate_data(list_tour);
            }
        }
        
    }
}
