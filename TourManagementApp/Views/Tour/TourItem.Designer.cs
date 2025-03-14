namespace TourManagementApp.Views.Tour
{
    partial class TourItem
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
            pictureBox = new PictureBox();
            btn_edit = new FontAwesome.Sharp.IconButton();
            tb_name = new TextBox();
            lb_id = new Label();
            label2 = new Label();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            tb_price = new TextBox();
            label5 = new Label();
            cbb_transport = new ComboBox();
            tb_description = new TextBox();
            cbb_type = new ComboBox();
            btn_delete = new FontAwesome.Sharp.IconButton();
            btn_change = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btn_order = new FontAwesome.Sharp.IconButton();
            btn_save = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.LightYellow;
            pictureBox.Location = new Point(31, 16);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(132, 140);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.DeepSkyBlue;
            btn_edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_edit.ForeColor = SystemColors.ButtonFace;
            btn_edit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_edit.IconColor = SystemColors.ButtonFace;
            btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_edit.IconSize = 25;
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(852, 71);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(105, 39);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "Edit";
            btn_edit.TextAlign = ContentAlignment.MiddleLeft;
            btn_edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_name.Location = new Point(209, 16);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(394, 30);
            tb_name.TabIndex = 2;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.ForeColor = SystemColors.Control;
            lb_id.Location = new Point(179, 324);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(0, 20);
            lb_id.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(821, 195);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 44;
            label2.Text = "$";
            // 
            // iconButton7
            // 
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton7.IconColor = Color.Yellow;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 25;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(209, 46);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(117, 35);
            iconButton7.TabIndex = 43;
            iconButton7.Text = "Mô tả";
            iconButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            iconButton5.IconColor = Color.Yellow;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 25;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(651, 150);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(79, 35);
            iconButton5.TabIndex = 42;
            iconButton5.Text = "Giá";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TruckPlane;
            iconButton2.IconColor = Color.Yellow;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 25;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(651, 75);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(150, 35);
            iconButton2.TabIndex = 41;
            iconButton2.Text = "Phương tiện";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
            iconButton4.IconColor = Color.Yellow;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(651, 0);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(79, 35);
            iconButton4.TabIndex = 40;
            iconButton4.Text = "Loại";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // tb_price
            // 
            tb_price.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_price.Location = new Point(651, 190);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(164, 30);
            tb_price.TabIndex = 35;
            tb_price.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(158, 345);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 38;
            // 
            // cbb_transport
            // 
            cbb_transport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cbb_transport.FormattingEnabled = true;
            cbb_transport.Items.AddRange(new object[] { "Car", "Airplane" });
            cbb_transport.Location = new Point(651, 116);
            cbb_transport.Name = "cbb_transport";
            cbb_transport.Size = new Size(164, 31);
            cbb_transport.TabIndex = 36;
            cbb_transport.Text = "Car";
            // 
            // tb_description
            // 
            tb_description.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_description.Location = new Point(209, 87);
            tb_description.Multiline = true;
            tb_description.Name = "tb_description";
            tb_description.Size = new Size(394, 107);
            tb_description.TabIndex = 37;
            // 
            // cbb_type
            // 
            cbb_type.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cbb_type.FormattingEnabled = true;
            cbb_type.Items.AddRange(new object[] { "Luxury", "Standard", "Budget" });
            cbb_type.Location = new Point(651, 41);
            cbb_type.Name = "cbb_type";
            cbb_type.Size = new Size(164, 31);
            cbb_type.TabIndex = 34;
            cbb_type.Text = "Standard";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(192, 0, 0);
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_delete.ForeColor = SystemColors.ButtonFace;
            btn_delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btn_delete.IconColor = SystemColors.ButtonFace;
            btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_delete.IconSize = 25;
            btn_delete.Location = new Point(852, 16);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(105, 42);
            btn_delete.TabIndex = 46;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_change
            // 
            btn_change.BackColor = Color.LightGoldenrodYellow;
            btn_change.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_change.IconColor = Color.Black;
            btn_change.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_change.Location = new Point(49, 171);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(105, 34);
            btn_change.TabIndex = 47;
            btn_change.Text = "change";
            btn_change.UseVisualStyleBackColor = false;
            btn_change.Click += btn_change_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btn_order);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(tb_description);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_change);
            panel1.Controls.Add(iconButton7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_edit);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(tb_price);
            panel1.Controls.Add(iconButton5);
            panel1.Controls.Add(tb_name);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(cbb_transport);
            panel1.Controls.Add(cbb_type);
            panel1.Location = new Point(0, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 234);
            panel1.TabIndex = 48;
            // 
            // btn_order
            // 
            btn_order.BackColor = Color.Tomato;
            btn_order.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_order.ForeColor = SystemColors.ButtonFace;
            btn_order.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_order.IconColor = SystemColors.ButtonFace;
            btn_order.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_order.IconSize = 25;
            btn_order.Location = new Point(852, 131);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(105, 44);
            btn_order.TabIndex = 49;
            btn_order.Text = "Order";
            btn_order.TextAlign = ContentAlignment.MiddleLeft;
            btn_order.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_order.UseVisualStyleBackColor = false;
            btn_order.Click += btn_order_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.DarkCyan;
            btn_save.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_save.ForeColor = SystemColors.ButtonFace;
            btn_save.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btn_save.IconColor = SystemColors.ButtonFace;
            btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_save.IconSize = 25;
            btn_save.Location = new Point(852, 71);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(105, 45);
            btn_save.TabIndex = 48;
            btn_save.Text = "Save";
            btn_save.TextAlign = ContentAlignment.MiddleLeft;
            btn_save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // TourItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(984, 247);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(lb_id);
            Name = "TourItem";
            Text = "TourItem";
            Load += TourItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private FontAwesome.Sharp.IconButton btn_edit;
        private TextBox tb_name;
        private Label lb_id;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox tb_price;
        private Label label5;
        private ComboBox cbb_transport;
        private TextBox tb_description;
        private ComboBox cbb_type;
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_change;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_order;
    }
}