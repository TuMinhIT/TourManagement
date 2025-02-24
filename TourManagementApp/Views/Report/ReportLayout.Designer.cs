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
            listView1 = new ListView();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            listView2 = new ListView();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(80, 62);
            listView1.Name = "listView1";
            listView1.Size = new Size(540, 259);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 18);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 1;
            label1.Text = "Biểu đồ doanh thu tháng";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listView2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listView1);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 663);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 350);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Bảng số liệu";
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
            // listView2
            // 
            listView2.Location = new Point(80, 373);
            listView2.Name = "listView2";
            listView2.Size = new Size(782, 209);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 18);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Năm";
            // 
            // ReportLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(962, 599);
            Controls.Add(panel1);
            Name = "ReportLayout";
            Text = "ReportLayout";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private ListView listView2;
        private Label label2;
        private Label label3;
    }
}