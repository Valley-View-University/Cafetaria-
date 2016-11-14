namespace windows_Form_Application
{
    partial class International
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBic = new System.Windows.Forms.TextBox();
            this.comChildren = new System.Windows.Forms.ComboBox();
            this.comTicketType = new System.Windows.Forms.ComboBox();
            this.comDay = new System.Windows.Forms.ComboBox();
            this.comMonth = new System.Windows.Forms.ComboBox();
            this.comYear = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Children";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ticket Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Day";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Account Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 415);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "BIC";
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(172, 32);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(160, 26);
            this.txtDeparture.TabIndex = 9;
            this.txtDeparture.TextChanged += new System.EventHandler(this.txtDeparture_TextChanged);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(172, 75);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(160, 26);
            this.txtDestination.TabIndex = 10;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 26);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(172, 214);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(160, 26);
            this.txtNumber.TabIndex = 12;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(172, 361);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(160, 26);
            this.txtAccountNumber.TabIndex = 13;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            // 
            // txtBic
            // 
            this.txtBic.Location = new System.Drawing.Point(172, 408);
            this.txtBic.Name = "txtBic";
            this.txtBic.Size = new System.Drawing.Size(160, 26);
            this.txtBic.TabIndex = 14;
            this.txtBic.TextChanged += new System.EventHandler(this.txtBic_TextChanged);
            // 
            // comChildren
            // 
            this.comChildren.FormattingEnabled = true;
            this.comChildren.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "More"});
            this.comChildren.Location = new System.Drawing.Point(172, 116);
            this.comChildren.Name = "comChildren";
            this.comChildren.Size = new System.Drawing.Size(160, 26);
            this.comChildren.TabIndex = 15;
            this.comChildren.Text = "Children";
            this.comChildren.SelectedIndexChanged += new System.EventHandler(this.comChildren_SelectedIndexChanged);
            // 
            // comTicketType
            // 
            this.comTicketType.FormattingEnabled = true;
            this.comTicketType.Items.AddRange(new object[] {
            "FLY ONE WAY",
            "FLY LUXURIOUSLY",
            "FLY COACH AND BUSINESS CLASS"});
            this.comTicketType.Location = new System.Drawing.Point(172, 266);
            this.comTicketType.Name = "comTicketType";
            this.comTicketType.Size = new System.Drawing.Size(160, 26);
            this.comTicketType.TabIndex = 16;
            this.comTicketType.Text = "Ticket Type";
            this.comTicketType.SelectedIndexChanged += new System.EventHandler(this.comTicketType_SelectedIndexChanged);
            // 
            // comDay
            // 
            this.comDay.FormattingEnabled = true;
            this.comDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comDay.Location = new System.Drawing.Point(119, 310);
            this.comDay.Name = "comDay";
            this.comDay.Size = new System.Drawing.Size(51, 26);
            this.comDay.TabIndex = 17;
            this.comDay.Text = "Day";
            this.comDay.SelectedIndexChanged += new System.EventHandler(this.comDay_SelectedIndexChanged);
            // 
            // comMonth
            // 
            this.comMonth.FormattingEnabled = true;
            this.comMonth.Items.AddRange(new object[] {
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.comMonth.Location = new System.Drawing.Point(197, 310);
            this.comMonth.Name = "comMonth";
            this.comMonth.Size = new System.Drawing.Size(72, 26);
            this.comMonth.TabIndex = 18;
            this.comMonth.Text = "Month";
            this.comMonth.SelectedIndexChanged += new System.EventHandler(this.comMonth_SelectedIndexChanged);
            // 
            // comYear
            // 
            this.comYear.FormattingEnabled = true;
            this.comYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comYear.Location = new System.Drawing.Point(294, 310);
            this.comYear.Name = "comYear";
            this.comYear.Size = new System.Drawing.Size(69, 26);
            this.comYear.TabIndex = 19;
            this.comYear.Text = "Year";
            this.comYear.SelectedIndexChanged += new System.EventHandler(this.comYear_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(119, 436);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 45);
            this.btnSend.TabIndex = 20;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(262, 436);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(84, 45);
            this.btnExist.TabIndex = 21;
            this.btnExist.Text = "Exit";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "International Booking Page";
            // 
            // International
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 484);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.comYear);
            this.Controls.Add(this.comMonth);
            this.Controls.Add(this.comDay);
            this.Controls.Add(this.comTicketType);
            this.Controls.Add(this.comChildren);
            this.Controls.Add(this.txtBic);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "International";
            this.Text = "International";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtBic;
        private System.Windows.Forms.ComboBox comChildren;
        private System.Windows.Forms.ComboBox comTicketType;
        private System.Windows.Forms.ComboBox comDay;
        private System.Windows.Forms.ComboBox comMonth;
        private System.Windows.Forms.ComboBox comYear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Label label10;
    }
}