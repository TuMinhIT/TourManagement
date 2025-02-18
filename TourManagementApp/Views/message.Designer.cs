namespace TourManagementApp.Views
{
    partial class message
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 46);
            label1.Name = "label1";
            label1.Size = new Size(324, 20);
            label1.TabIndex = 0;
            label1.Text = "xác nhận thao tác này sẽ không theerbhoanf tác";
            // 
            // button1
            // 
            button1.Location = new Point(99, 100);
            button1.Name = "button1";
            button1.Size = new Size(151, 36);
            button1.TabIndex = 1;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(274, 100);
            button2.Name = "button2";
            button2.Size = new Size(151, 36);
            button2.TabIndex = 2;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 197);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "message";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}