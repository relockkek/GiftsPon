namespace Планировщик_Подарков
{
    partial class NewHolidays
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
            label5 = new Label();
            NameHolidays = new TextBox();
            label7 = new Label();
            OverviewHolidays = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dateGift = new DateTimePicker();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(153, 20);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 16;
            label5.Text = "Праздники";
            // 
            // NameHolidays
            // 
            NameHolidays.Location = new Point(12, 93);
            NameHolidays.Name = "NameHolidays";
            NameHolidays.Size = new Size(351, 23);
            NameHolidays.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(23, 60);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 18;
            label7.Text = "Название";
            // 
            // OverviewHolidays
            // 
            OverviewHolidays.Location = new Point(12, 165);
            OverviewHolidays.Name = "OverviewHolidays";
            OverviewHolidays.Size = new Size(351, 23);
            OverviewHolidays.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(23, 130);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 20;
            label8.Text = "Описание";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(23, 207);
            label9.Name = "label9";
            label9.Size = new Size(44, 21);
            label9.TabIndex = 21;
            label9.Text = "Дата";
            // 
            // dateGift
            // 
            dateGift.Location = new Point(12, 243);
            dateGift.Name = "dateGift";
            dateGift.Size = new Size(351, 23);
            dateGift.TabIndex = 27;
            // 
            // NewHolidays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 430);
            Controls.Add(dateGift);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(OverviewHolidays);
            Controls.Add(label7);
            Controls.Add(NameHolidays);
            Controls.Add(label5);
            Name = "NewHolidays";
            Text = "NewHolidays";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox NameHolidays;
        private Label label7;
        private TextBox OverviewHolidays;
        private Label label8;
        private Label label9;
        private DateTimePicker dateGift;
    }
}