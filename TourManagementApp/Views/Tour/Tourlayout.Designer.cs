namespace TourManagementApp.Views.Tour
{
    partial class Tourlayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            panel8 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 68);
            panel1.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(542, 57);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(339, 57);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(3, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 432);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 180);
            label6.Name = "label6";
            label6.Size = new Size(255, 20);
            label6.TabIndex = 1;
            label6.Text = "Danh sách tour sẽ hiển thị trong đaya";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(874, 392);
            dataGridView1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(30, 31, 68);
            panel8.Controls.Add(iconButton8);
            panel8.Controls.Add(iconButton6);
            panel8.Controls.Add(iconButton3);
            panel8.Controls.Add(iconButton5);
            panel8.Controls.Add(iconButton4);
            panel8.Controls.Add(comboBox1);
            panel8.Controls.Add(comboBox2);
            panel8.Controls.Add(comboBox3);
            panel8.Location = new Point(3, 64);
            panel8.Name = "panel8";
            panel8.Size = new Size(944, 95);
            panel8.TabIndex = 9;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = SystemColors.ButtonFace;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton2.IconColor = SystemColors.ButtonFace;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(528, 11);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(146, 46);
            iconButton2.TabIndex = 12;
            iconButton2.Text = "Thêm mới";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.ButtonFace;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconButton1.IconColor = SystemColors.ButtonFace;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(260, 11);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(204, 46);
            iconButton1.TabIndex = 11;
            iconButton1.Text = "Danh sách tour";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            iconButton4.ForeColor = SystemColors.ButtonFace;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Filter;
            iconButton4.IconColor = SystemColors.ButtonFace;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.Location = new Point(19, 22);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(77, 43);
            iconButton4.TabIndex = 12;
            iconButton4.Text = "Lọc";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            iconButton5.ForeColor = SystemColors.ButtonFace;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
            iconButton5.IconColor = SystemColors.ButtonFace;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 32;
            iconButton5.Location = new Point(156, 8);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(136, 43);
            iconButton5.TabIndex = 13;
            iconButton5.Text = "Loại tour";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            iconButton3.ForeColor = SystemColors.ButtonFace;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            iconButton3.IconColor = SystemColors.ButtonFace;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.Location = new Point(339, 11);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(134, 43);
            iconButton3.TabIndex = 14;
            iconButton3.Text = "Mức giá";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            iconButton6.ForeColor = SystemColors.ButtonFace;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.TruckPlane;
            iconButton6.IconColor = SystemColors.ButtonFace;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 32;
            iconButton6.Location = new Point(528, 11);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(165, 43);
            iconButton6.TabIndex = 15;
            iconButton6.Text = "Phương tiện";
            iconButton6.TextAlign = ContentAlignment.MiddleLeft;
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.FromArgb(255, 128, 0);
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            iconButton8.ForeColor = SystemColors.ButtonFace;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            iconButton8.IconColor = SystemColors.ButtonFace;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 32;
            iconButton8.Location = new Point(751, 33);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(127, 42);
            iconButton8.TabIndex = 16;
            iconButton8.Text = "Tìm kiếm";
            iconButton8.TextAlign = ContentAlignment.MiddleLeft;
            iconButton8.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton8.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(904, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 13;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Tourlayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(970, 580);
            ControlBox = false;
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(970, 580);
            Name = "Tourlayout";
            Text = "Tourlayout";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Panel panel2;
        private Panel panel8;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton8;
        private Button button1;
    }
}