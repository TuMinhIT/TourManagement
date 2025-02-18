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
            panel2 = new Panel();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 105);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 350);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(710, 73);
            button2.Name = "button2";
            button2.Size = new Size(181, 29);
            button2.TabIndex = 1;
            button2.Text = "Thêm đơn";
            button2.UseVisualStyleBackColor = true;
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
            // button3
            // 
            button3.Location = new Point(742, 516);
            button3.Name = "button3";
            button3.Size = new Size(181, 29);
            button3.TabIndex = 2;
            button3.Text = "Xem chi tiết";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(334, 47);
            button4.Name = "button4";
            button4.Size = new Size(151, 29);
            button4.TabIndex = 3;
            button4.Text = "Tìm kiếm mã đơn";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 4;
            // 
            // TourOrder1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 579);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private Button button2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
    }
}