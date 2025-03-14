using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourManagementApp.Views
{
    public partial class About : Form
    {
        private List<Image> images = new List<Image>();
        private int currentImageIndex = 0;
        private System.Windows.Forms.Timer imageTimer;

        private System.Windows.Forms.Timer typingTimer;
        private string fullText = "Hãy đến với Tripverse";
        private int currentCharIndex = 0;
        public About()
        {
            InitializeComponent();
            LoadImages();
            SetupImageTimer();
            SetupTypingEffect();
        }
        private void LoadImages()
        {
            images.Add(Properties.Resources.halong_bay_4646615_640);
            images.Add(Properties.Resources.Nam_phu_quoc_6);
            images.Add(Properties.Resources.Du_Lich_2);
            images.Add(Properties.Resources.hon_doi_moi_phu_quoc_1);
            
            images.Add(Properties.Resources.thanh_lap_cong_ty_lu_hanh_quoc_te_01);

            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            if (images.Count > 0)
            {
                panel5.BackgroundImage = images[currentImageIndex];
            }
        }
        private void SetupImageTimer()
        {
            imageTimer = new System.Windows.Forms.Timer();
            imageTimer.Interval = 3000;
            imageTimer.Tick += ImageTimer_Tick;
            imageTimer.Start();
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            if (images.Count == 0) return;

            currentImageIndex = (currentImageIndex + 1) % images.Count;
            panel5.BackgroundImage = images[currentImageIndex];
        }

        // label
        private void SetupTypingEffect()
        {
            label3.Text = "";

            typingTimer = new System.Windows.Forms.Timer();
            typingTimer.Interval = 100;
            typingTimer.Tick += TypingTimer_Tick;
            typingTimer.Start();
        }

        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            if (currentCharIndex < fullText.Length)
            {
                label3.Text += fullText[currentCharIndex];
                currentCharIndex++;
            }
            else
            {
                typingTimer.Stop();
                System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
                {
                    this.Invoke(new Action(() =>
                    {
                        label3.Text = "";
                        currentCharIndex = 0;
                        typingTimer.Start();
                    }));
                });
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void lableLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
