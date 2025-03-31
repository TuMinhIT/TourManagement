namespace TourManagementApp.Views.Admin
{
    partial class EmployeesLayout
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
            btn_search = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            icon_MNV = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            tb_code = new TextBox();
            panel_mid = new Panel();
            tb_email = new TextBox();
            panel_main = new Panel();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            dataGridView = new DataGridView();
            btn_add = new FontAwesome.Sharp.IconButton();
            btn_list = new FontAwesome.Sharp.IconButton();
            panel_top = new Panel();
            panel_mid.SuspendLayout();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel_top.SuspendLayout();
            SuspendLayout();
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
            btn_search.Location = new Point(757, 41);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(134, 36);
            btn_search.TabIndex = 15;
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
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.PlaneArrival;
            iconButton6.IconColor = SystemColors.ButtonFace;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 32;
            iconButton6.Location = new Point(393, 6);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(161, 43);
            iconButton6.TabIndex = 13;
            iconButton6.Text = "Email";
            iconButton6.TextAlign = ContentAlignment.MiddleLeft;
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // icon_MNV
            // 
            icon_MNV.FlatAppearance.BorderSize = 0;
            icon_MNV.FlatStyle = FlatStyle.Flat;
            icon_MNV.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            icon_MNV.ForeColor = SystemColors.ButtonFace;
            icon_MNV.IconChar = FontAwesome.Sharp.IconChar.Signature;
            icon_MNV.IconColor = SystemColors.ButtonFace;
            icon_MNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_MNV.IconSize = 32;
            icon_MNV.Location = new Point(147, 8);
            icon_MNV.Name = "icon_MNV";
            icon_MNV.Size = new Size(180, 42);
            icon_MNV.TabIndex = 12;
            icon_MNV.Text = "Mã nhân viên";
            icon_MNV.TextAlign = ContentAlignment.MiddleLeft;
            icon_MNV.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_MNV.UseVisualStyleBackColor = true;
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
            iconButton4.Location = new Point(12, 20);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(77, 43);
            iconButton4.TabIndex = 11;
            iconButton4.Text = "Lọc";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // tb_code
            // 
            tb_code.Location = new Point(147, 50);
            tb_code.Name = "tb_code";
            tb_code.PlaceholderText = "<Tất cã>";
            tb_code.Size = new Size(201, 27);
            tb_code.TabIndex = 9;
            // 
            // panel_mid
            // 
            panel_mid.BackColor = SystemColors.MenuHighlight;
            panel_mid.Controls.Add(tb_email);
            panel_mid.Controls.Add(btn_search);
            panel_mid.Controls.Add(iconButton6);
            panel_mid.Controls.Add(icon_MNV);
            panel_mid.Controls.Add(iconButton4);
            panel_mid.Controls.Add(tb_code);
            panel_mid.Dock = DockStyle.Top;
            panel_mid.Location = new Point(0, 44);
            panel_mid.Name = "panel_mid";
            panel_mid.Size = new Size(1111, 94);
            panel_mid.TabIndex = 13;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(404, 50);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "<Tất cã>";
            tb_email.Size = new Size(273, 27);
            tb_email.TabIndex = 16;
            // 
            // panel_main
            // 
            panel_main.BackColor = SystemColors.MenuHighlight;
            panel_main.Controls.Add(iconButton11);
            panel_main.Controls.Add(dataGridView);
            panel_main.Location = new Point(-2, 127);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1113, 472);
            panel_main.TabIndex = 12;
            // 
            // iconButton11
            // 
            iconButton11.FlatAppearance.BorderSize = 0;
            iconButton11.FlatStyle = FlatStyle.Flat;
            iconButton11.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton11.ForeColor = SystemColors.ButtonFace;
            iconButton11.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton11.IconColor = SystemColors.ButtonFace;
            iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton11.IconSize = 32;
            iconButton11.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton11.Location = new Point(12, 0);
            iconButton11.Name = "iconButton11";
            iconButton11.Size = new Size(146, 46);
            iconButton11.TabIndex = 6;
            iconButton11.Text = "Chi tiết";
            iconButton11.TextAlign = ContentAlignment.MiddleLeft;
            iconButton11.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton11.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 45);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1101, 393);
            dataGridView.TabIndex = 5;
            // 
            // btn_add
            // 
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = SystemColors.ButtonFace;
            btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_add.IconColor = SystemColors.ButtonFace;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.IconSize = 32;
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(517, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(146, 46);
            btn_add.TabIndex = 4;
            btn_add.Text = "Thêm mới";
            btn_add.TextAlign = ContentAlignment.MiddleLeft;
            btn_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
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
            btn_list.Location = new Point(129, 0);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(146, 46);
            btn_list.TabIndex = 3;
            btn_list.Text = "Danh sách";
            btn_list.TextAlign = ContentAlignment.MiddleLeft;
            btn_list.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_list.UseVisualStyleBackColor = true;
            btn_list.Click += btn_list_Click;
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(41, 128, 185);
            panel_top.Controls.Add(btn_add);
            panel_top.Controls.Add(btn_list);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1111, 44);
            panel_top.TabIndex = 11;
            // 
            // EmployeesLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1012, 602);
            Controls.Add(panel_mid);
            Controls.Add(panel_main);
            Controls.Add(panel_top);
            MinimumSize = new Size(1030, 649);
            Name = "EmployeesLayout";
            Text = "EmployeesLayout";
            Load += EmployeesLayout_Load;
            panel_mid.ResumeLayout(false);
            panel_mid.PerformLayout();
            panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton icon_MNV;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox tb_code;
        private Panel panel_mid;
        private Panel panel_main;
        private DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_list;
        private Panel panel_top;
        private FontAwesome.Sharp.IconButton iconButton11;
        private TextBox tb_email;
    }
}