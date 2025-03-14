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
            btn_import = new FontAwesome.Sharp.IconButton();
            btn_add_new = new FontAwesome.Sharp.IconButton();
            btn_list = new FontAwesome.Sharp.IconButton();
            cbb_transport = new ComboBox();
            cbb_price = new ComboBox();
            cbb_type = new ComboBox();
            panel_main = new Panel();
            panel8 = new Panel();
            btn_search = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(btn_import);
            panel1.Controls.Add(btn_add_new);
            panel1.Controls.Add(btn_list);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 57);
            panel1.TabIndex = 0;
            // 
            // btn_import
            // 
            btn_import.FlatAppearance.BorderSize = 0;
            btn_import.FlatStyle = FlatStyle.Flat;
            btn_import.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_import.ForeColor = Color.WhiteSmoke;
            btn_import.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            btn_import.IconColor = Color.WhiteSmoke;
            btn_import.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_import.IconSize = 25;
            btn_import.Location = new Point(753, 11);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(201, 36);
            btn_import.TabIndex = 0;
            btn_import.Text = "Nhập dữ liệu excel";
            btn_import.TextAlign = ContentAlignment.MiddleLeft;
            btn_import.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_import.UseVisualStyleBackColor = true;
            btn_import.Click += btn_import_Click;
            // 
            // btn_add_new
            // 
            btn_add_new.FlatAppearance.BorderSize = 0;
            btn_add_new.FlatStyle = FlatStyle.Flat;
            btn_add_new.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_new.ForeColor = SystemColors.ButtonFace;
            btn_add_new.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_add_new.IconColor = SystemColors.ButtonFace;
            btn_add_new.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add_new.IconSize = 32;
            btn_add_new.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add_new.Location = new Point(245, 3);
            btn_add_new.Name = "btn_add_new";
            btn_add_new.Size = new Size(146, 46);
            btn_add_new.TabIndex = 12;
            btn_add_new.Text = "Thêm mới";
            btn_add_new.TextAlign = ContentAlignment.MiddleLeft;
            btn_add_new.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_add_new.UseVisualStyleBackColor = true;
            btn_add_new.Click += btn_add_new_Click;
            // 
            // btn_list
            // 
            btn_list.FlatAppearance.BorderSize = 0;
            btn_list.FlatStyle = FlatStyle.Flat;
            btn_list.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_list.ForeColor = SystemColors.ButtonFace;
            btn_list.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btn_list.IconColor = SystemColors.ButtonFace;
            btn_list.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_list.IconSize = 32;
            btn_list.ImageAlign = ContentAlignment.MiddleLeft;
            btn_list.Location = new Point(19, 3);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(204, 46);
            btn_list.TabIndex = 11;
            btn_list.Text = "Danh sách tour";
            btn_list.TextAlign = ContentAlignment.MiddleLeft;
            btn_list.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_list.UseVisualStyleBackColor = true;
            btn_list.Click += btn_list_Click;
            // 
            // cbb_transport
            // 
            cbb_transport.FormattingEnabled = true;
            cbb_transport.Items.AddRange(new object[] { "Car", "Airplane", "Tất cã" });
            cbb_transport.Location = new Point(528, 73);
            cbb_transport.Name = "cbb_transport";
            cbb_transport.Size = new Size(182, 28);
            cbb_transport.TabIndex = 4;
            cbb_transport.Text = "Tất cã";
            // 
            // cbb_price
            // 
            cbb_price.FormattingEnabled = true;
            cbb_price.Items.AddRange(new object[] { "Dưới 200$", "Từ 200$ đến 400$", "Từ 400$ đến 800$", "Trên 800$", "Tất cã" });
            cbb_price.Location = new Point(279, 73);
            cbb_price.Name = "cbb_price";
            cbb_price.Size = new Size(184, 28);
            cbb_price.TabIndex = 2;
            cbb_price.Text = "Tất cã";
            // 
            // cbb_type
            // 
            cbb_type.FormattingEnabled = true;
            cbb_type.Items.AddRange(new object[] { "Luxury", "Standard", "Budget", "Tất cã" });
            cbb_type.Location = new Point(31, 73);
            cbb_type.Name = "cbb_type";
            cbb_type.Size = new Size(192, 28);
            cbb_type.TabIndex = 0;
            cbb_type.Text = "Tất cã";
            // 
            // panel_main
            // 
            panel_main.AutoScroll = true;
            panel_main.BackColor = SystemColors.ActiveCaption;
            panel_main.Location = new Point(3, 199);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(963, 377);
            panel_main.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Navy;
            panel8.Controls.Add(btn_search);
            panel8.Controls.Add(iconButton6);
            panel8.Controls.Add(iconButton3);
            panel8.Controls.Add(iconButton5);
            panel8.Controls.Add(cbb_type);
            panel8.Controls.Add(cbb_price);
            panel8.Controls.Add(cbb_transport);
            panel8.Location = new Point(3, 56);
            panel8.Name = "panel8";
            panel8.Size = new Size(966, 137);
            panel8.TabIndex = 9;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(255, 128, 0);
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_search.ForeColor = SystemColors.ButtonFace;
            btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            btn_search.IconColor = SystemColors.ButtonFace;
            btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_search.IconSize = 32;
            btn_search.Location = new Point(791, 64);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(127, 42);
            btn_search.TabIndex = 16;
            btn_search.Text = "Tìm kiếm";
            btn_search.TextAlign = ContentAlignment.MiddleLeft;
            btn_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
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
            iconButton6.Location = new Point(518, 11);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(165, 43);
            iconButton6.TabIndex = 15;
            iconButton6.Text = "Phương tiện";
            iconButton6.TextAlign = ContentAlignment.MiddleLeft;
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
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
            iconButton3.Location = new Point(279, 11);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(134, 43);
            iconButton3.TabIndex = 14;
            iconButton3.Text = "Mức giá";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
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
            iconButton5.Location = new Point(31, 11);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(136, 43);
            iconButton5.TabIndex = 13;
            iconButton5.Text = "Loại tour";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // Tourlayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(967, 602);
            Controls.Add(panel8);
            Controls.Add(panel_main);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1030, 649);
            MinimumSize = new Size(980, 646);
            Name = "Tourlayout";
            Text = "Tourlayout";
            Load += Tourlayout_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbb_transport;
        private ComboBox cbb_price;
        private ComboBox cbb_type;
        private Panel panel_main;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton btn_add_new;
        private FontAwesome.Sharp.IconButton btn_list;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton btn_import;
    }
}