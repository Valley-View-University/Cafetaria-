namespace windows_Form_Application
{
    partial class StateUse
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
            this.comTravelType = new System.Windows.Forms.ComboBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtOffice = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.comDay = new System.Windows.Forms.ComboBox();
            this.comMonth = new System.Windows.Forms.ComboBox();
            this.comYear = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Travel Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID Number";
            // 
            // comTravelType
            // 
            this.comTravelType.FormattingEnabled = true;
            this.comTravelType.Items.AddRange(new object[] {
            "INTERNATIONAL",
            "DOMESTIC"});
            this.comTravelType.Location = new System.Drawing.Point(192, 18);
            this.comTravelType.Name = "comTravelType";
            this.comTravelType.Size = new System.Drawing.Size(203, 26);
            this.comTravelType.TabIndex = 7;
            this.comTravelType.Text = "Travel Type";
            this.comTravelType.SelectedIndexChanged += new System.EventHandler(this.comTravelType_SelectedIndexChanged);
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(192, 62);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(203, 26);
            this.txtDeparture.TabIndex = 8;
            this.txtDeparture.TextChanged += new System.EventHandler(this.txtDeparture_TextChanged);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(192, 104);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(203, 26);
            this.txtDestination.TabIndex = 9;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(192, 150);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(203, 26);
            this.txtOffice.TabIndex = 10;
            this.txtOffice.TextChanged += new System.EventHandler(this.txtOffice_TextChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(192, 204);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(203, 26);
            this.txtCode.TabIndex = 11;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(192, 302);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(203, 26);
            this.txtIdNumber.TabIndex = 12;
            this.txtIdNumber.TextChanged += new System.EventHandler(this.txtIdNumber_TextChanged);
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
            this.comDay.Location = new System.Drawing.Point(114, 258);
            this.comDay.Name = "comDay";
            this.comDay.Size = new System.Drawing.Size(58, 26);
            this.comDay.TabIndex = 13;
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
            this.comMonth.Location = new System.Drawing.Point(192, 258);
            this.comMonth.Name = "comMonth";
            this.comMonth.Size = new System.Drawing.Size(76, 26);
            this.comMonth.TabIndex = 14;
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
            this.comYear.Location = new System.Drawing.Point(286, 258);
            this.comYear.Name = "comYear";
            this.comYear.Size = new System.Drawing.Size(77, 26);
            this.comYear.TabIndex = 15;
            this.comYear.Text = "Year";
            this.comYear.SelectedIndexChanged += new System.EventHandler(this.comYear_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(114, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 48);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(273, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 48);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exist";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StateUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 472);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comYear);
            this.Controls.Add(this.comMonth);
            this.Controls.Add(this.comDay);
            this.Controls.Add(this.txtIdNumber);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtOffice);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.comTravelType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StateUse";
            this.Text = "StateUse";
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
        private System.Windows.Forms.ComboBox comTravelType;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtOffice;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.ComboBox comDay;
        private System.Windows.Forms.ComboBox comMonth;
        private System.Windows.Forms.ComboBox comYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}