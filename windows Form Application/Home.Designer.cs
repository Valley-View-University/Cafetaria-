namespace windows_Form_Application
{
    partial class Home
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
            this.btnInternational = new System.Windows.Forms.Button();
            this.btnDomestic = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInternational
            // 
            this.btnInternational.Location = new System.Drawing.Point(39, 93);
            this.btnInternational.Margin = new System.Windows.Forms.Padding(4);
            this.btnInternational.Name = "btnInternational";
            this.btnInternational.Size = new System.Drawing.Size(158, 64);
            this.btnInternational.TabIndex = 0;
            this.btnInternational.Text = "International";
            this.btnInternational.UseVisualStyleBackColor = true;
            this.btnInternational.Click += new System.EventHandler(this.btnInternational_Click);
            // 
            // btnDomestic
            // 
            this.btnDomestic.Location = new System.Drawing.Point(212, 93);
            this.btnDomestic.Margin = new System.Windows.Forms.Padding(4);
            this.btnDomestic.Name = "btnDomestic";
            this.btnDomestic.Size = new System.Drawing.Size(158, 64);
            this.btnDomestic.TabIndex = 1;
            this.btnDomestic.Text = "Domestic";
            this.btnDomestic.UseVisualStyleBackColor = true;
            this.btnDomestic.Click += new System.EventHandler(this.btnDomestic_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 176);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "State Use";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(212, 176);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(158, 64);
            this.btnReservation.TabIndex = 3;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(150, 285);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 46);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Star Bow Airline Home Page";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDomestic);
            this.Controls.Add(this.btnInternational);
            this.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInternational;
        private System.Windows.Forms.Button btnDomestic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}