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
                    break;
            }

            #endregion

            #region search by type
            List<Tours> list_type = new List<Tours>();  
            if (cbb_type.Text != "Tất cã")
            {
               list_type = _tourService.GetByAttribute("TourType", cbb_type.SelectedItem.ToString());
            }

            #endregion


            List<Tours> list_transport = new List<Tours>();
            if (cbb_transport.Text != "Tất cã")
            {
                list_transport = _tourService.GetByAttribute("Transport", cbb_transport.SelectedItem.ToString());
            }

            List <Tours> list_distinct = list_price.Union(list_type).ToList();
            list_distinct =list_distinct.Union(list_transport).ToList();

            generate_data(list_distinct);

        }
    }
}
