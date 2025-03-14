namespace TourManagementApp.Views.Schedule_form
{
    partial class ScheduleItem
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
            btn_delete = new FontAwesome.Sharp.IconButton();
            panel = new Panel();
            tb_description = new TextBox();
            btn_detail = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            tb_customerName = new TextBox();
            tb_tourName = new TextBox();
            panel2 = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Green;
            btn_delete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btn_delete.IconColor = Color.White;
            btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_delete.IconSize = 30;
            btn_delete.Location = new Point(882, 17);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 41);
            btn_delete.TabIndex = 0;
            btn_delete.Text = "Xóa";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(41, 128, 185);
            panel.Controls.Add(tb_description);
            panel.Controls.Add(btn_detail);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Controls.Add(tb_customerName);
            panel.Controls.Add(tb_tourName);
            panel.Controls.Add(btn_delete);
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(1013, 150);
            panel.TabIndex = 3;
            panel.Paint += panel_Paint;
            // 
            // tb_description
            // 
            tb_description.Location = new Point(388, 26);
            tb_description.Multiline = true;
            tb_description.Name = "tb_description";
            tb_description.Size = new Size(438, 84);
            tb_description.TabIndex = 11;
            // 
            // btn_detail
            // 
            btn_detail.BackColor = Color.OrangeRed;
            btn_detail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_detail.ForeColor = Color.White;
            btn_detail.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_detail.IconColor = Color.White;
            btn_detail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_detail.IconSize = 30;
            btn_detail.Location = new Point(882, 69);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(119, 41);
            btn_detail.TabIndex = 10;
            btn_detail.Text = "Chi tiết";
            btn_detail.TextAlign = ContentAlignment.MiddleLeft;
            btn_detail.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_detail.UseVisualStyleBackColor = false;
            btn_detail.Click += btn_detail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 56);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "Khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 3);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 4;
            label1.Text = "Tour";
            // 
            // tb_customerName
            // 
            tb_customerName.Location = new Point(13, 83);
            tb_customerName.Name = "tb_customerName";
            tb_customerName.Size = new Size(333, 27);
            tb_customerName.TabIndex = 3;
            // 
            // tb_tourName
            // 
            tb_tourName.Location = new Point(13, 26);
            tb_tourName.Name = "tb_tourName";
            tb_tourName.Size = new Size(333, 27);
            tb_tourName.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.FromArgb(0, 0, 192);
            panel2.Location = new Point(0, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(1013, 10);
            panel2.TabIndex = 4;
            // 
            // ScheduleItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 150);
            Controls.Add(panel2);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScheduleItem";
            Text = "ScheduleItem";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_delete;
        private Panel panel;
        private TextBox tb_customerName;
        private TextBox tb_tourName;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btn_detail;
        private TextBox tb_description;
        private Panel panel2;
    }
}