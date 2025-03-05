namespace TourManagementApp.Views.Schedule_form
{
    partial class ScheduleLayout
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
            panel_main = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.AutoScroll = true;
            panel_main.Location = new Point(0, 47);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1013, 553);
            panel_main.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(344, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(242, 29);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Danh sách lịch trình";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // ScheduleLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1012, 602);
            Controls.Add(iconButton1);
            Controls.Add(panel_main);
            MaximumSize = new Size(1030, 649);
            Name = "ScheduleLayout";
            Text = "ScheduleLayout";
            Load += ScheduleLayout_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}