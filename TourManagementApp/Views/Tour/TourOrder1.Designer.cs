namespace TourManagementApp.Views.Tour
{
    partial class TourOrder1
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
            textBox1 = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton8);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 105);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 350);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(789, 309);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(912, 0);
            button1.Name = "button1";
            button1.Size = new Size(35, 38);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            iconButton8.Location = new Point(354, 38);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(214, 42);
            iconButton8.TabIndex = 16;
            iconButton8.Text = "Tìm kiếm mã đơn";
            iconButton8.TextAlign = ContentAlignment.MiddleLeft;
            iconButton8.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton8.UseVisualStyleBackColor = false;
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
            iconButton2.Location = new Point(745, 59);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(146, 46);
            iconButton2.TabIndex = 17;
            iconButton2.Text = "Thêm đơn";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(41, 128, 185);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            iconButton1.ForeColor = SystemColors.ButtonFace;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconButton1.IconColor = SystemColors.ButtonFace;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(746, 490);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(160, 42);
            iconButton1.TabIndex = 18;
            iconButton1.Text = "Xem chi tiết";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // TourOrder1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 544);
            ControlBox = false;
            Controls.Add(iconButton1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TourOrder1";
            Text = "TourOrder1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}