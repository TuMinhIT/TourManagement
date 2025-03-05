namespace TourManagementApp.Views.Report
{
    partial class ReportLayout
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
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 581);
            panel1.TabIndex = 2;
            // 
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(487, 536);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(169, 29);
            iconButton4.TabIndex = 22;
            iconButton4.Text = "Thoát";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(147, 536);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(169, 29);
            iconButton3.TabIndex = 21;
            iconButton3.Text = "In báo cáo";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 270);
            label7.Name = "label7";
            label7.Size = new Size(212, 20);
            label7.TabIndex = 20;
            label7.Text = "DataGridView hiển thị báo cáo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(228, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 204);
            dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Loại tour";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số lượng Tours";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tổng doanh thu";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(525, 224);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(169, 29);
            iconButton2.TabIndex = 18;
            iconButton2.Text = "Xuất excel";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(179, 236);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(169, 29);
            iconButton1.TabIndex = 17;
            iconButton1.Text = "Lọc báo cáo";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(586, 145);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 147);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 15;
            label6.Text = "Đến ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 152);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 14;
            label5.Text = "Từ ngày";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 147);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(711, 74);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(450, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(618, 77);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 10;
            label4.Text = "Chọn năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 77);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 9;
            label3.Text = "Chọn tháng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 77);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 8;
            label2.Text = "Chọn loại tour";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 13);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 6;
            label1.Text = "Báo cáo doanh thu";
            // 
            // button1
            // 
            button1.Location = new Point(739, 603);
            button1.Name = "button1";
            button1.Size = new Size(123, 30);
            button1.TabIndex = 4;
            button1.Text = "Xuất excel ";
            button1.UseVisualStyleBackColor = true;
            // 
            // ReportLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(962, 599);
            Controls.Add(panel1);
            Name = "ReportLayout";
            Text = "Báo cáo doanh thu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label3;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}