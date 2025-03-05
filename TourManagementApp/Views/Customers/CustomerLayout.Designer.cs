namespace TourManagementApp.Views.Customers
{
    partial class CustomerLayout
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
            tb_search = new TextBox();
            lb_type = new Label();
            cbb_type = new ComboBox();
            btn_search = new FontAwesome.Sharp.IconButton();
            btn_list = new FontAwesome.Sharp.IconButton();
            btn_add = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btn_import = new FontAwesome.Sharp.IconButton();
            btn_excel = new FontAwesome.Sharp.IconButton();
            dataGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(tb_search);
            panel1.Controls.Add(lb_type);
            panel1.Controls.Add(cbb_type);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(btn_list);
            panel1.Controls.Add(btn_add);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 130);
            panel1.TabIndex = 0;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(344, 78);
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Nội dung tìm kiếm";
            tb_search.Size = new Size(350, 27);
            tb_search.TabIndex = 20;
            // 
            // lb_type
            // 
            lb_type.AutoSize = true;
            lb_type.ForeColor = SystemColors.Control;
            lb_type.Location = new Point(30, 78);
            lb_type.Name = "lb_type";
            lb_type.Size = new Size(37, 20);
            lb_type.TabIndex = 19;
            lb_type.Text = "Loại";
            // 
            // cbb_type
            // 
            cbb_type.FormattingEnabled = true;
            cbb_type.Items.AddRange(new object[] { "Số điện thoại", "Mã khách hàng", "Địa chỉ", "Tên" });
            cbb_type.Location = new Point(73, 78);
            cbb_type.Name = "cbb_type";
            cbb_type.Size = new Size(179, 28);
            cbb_type.TabIndex = 18;
            cbb_type.Text = "<trống>";
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
            btn_search.Location = new Point(747, 69);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(127, 42);
            btn_search.TabIndex = 15;
            btn_search.Text = "Tìm kiếm";
            btn_search.TextAlign = ContentAlignment.MiddleLeft;
            btn_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
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
            btn_list.Location = new Point(3, 3);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(146, 46);
            btn_list.TabIndex = 3;
            btn_list.Text = "Danh sách";
            btn_list.TextAlign = ContentAlignment.MiddleLeft;
            btn_list.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_list.UseVisualStyleBackColor = true;
            btn_list.Click += btn_list_Click;
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
            btn_add.Location = new Point(208, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(146, 46);
            btn_add.TabIndex = 4;
            btn_add.Text = "Thêm mới";
            btn_add.TextAlign = ContentAlignment.MiddleLeft;
            btn_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(btn_import);
            panel2.Controls.Add(btn_excel);
            panel2.Controls.Add(dataGridView);
            panel2.Location = new Point(1, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 506);
            panel2.TabIndex = 5;
            // 
            // btn_import
            // 
            btn_import.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_import.IconColor = Color.Black;
            btn_import.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_import.Location = new Point(797, 390);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(138, 35);
            btn_import.TabIndex = 22;
            btn_import.Text = "Nhập file";
            btn_import.UseVisualStyleBackColor = true;
            btn_import.Click += btn_import_Click;
            // 
            // btn_excel
            // 
            btn_excel.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_excel.IconColor = Color.Black;
            btn_excel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_excel.Location = new Point(797, 431);
            btn_excel.Name = "btn_excel";
            btn_excel.Size = new Size(145, 34);
            btn_excel.TabIndex = 21;
            btn_excel.Text = "Xuất Excel";
            btn_excel.UseVisualStyleBackColor = true;
            btn_excel.Click += btn_excel_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 8);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1009, 470);
            dataGridView.TabIndex = 5;
            // 
            // CustomerLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1012, 602);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1030, 649);
            Name = "CustomerLayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerLayout";
            Load += CustomerLayout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton btn_list;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_search;
        private TextBox tb_search;
        private Label lb_type;
        private ComboBox cbb_type;
        private FontAwesome.Sharp.IconButton btn_excel;
        private FontAwesome.Sharp.IconButton btn_import;
    }
}