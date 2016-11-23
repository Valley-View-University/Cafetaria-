namespace CafeteriaManagementSystem
{
    partial class Form1
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
            this.panHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panAuthenticate = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewFaculty = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panHome.SuspendLayout();
            this.panAuthenticate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHome
            // 
            this.panHome.BackgroundImage = global::CafeteriaManagementSystem.Properties.Resources.images;
            this.panHome.Controls.Add(this.label8);
            this.panHome.Controls.Add(this.label1);
            this.panHome.Controls.Add(this.panAuthenticate);
            this.panHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHome.Location = new System.Drawing.Point(0, 0);
            this.panHome.Name = "panHome";
            this.panHome.Size = new System.Drawing.Size(955, 472);
            this.panHome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(230, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "VALLEY VIEW UNIVERSITY";
            // 
            // panAuthenticate
            // 
            this.panAuthenticate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panAuthenticate.Controls.Add(this.label7);
            this.panAuthenticate.Controls.Add(this.label6);
            this.panAuthenticate.Controls.Add(this.label5);
            this.panAuthenticate.Controls.Add(this.label4);
            this.panAuthenticate.Controls.Add(this.btnNewFaculty);
            this.panAuthenticate.Controls.Add(this.btnNewStudent);
            this.panAuthenticate.Controls.Add(this.btnAuthenticate);
            this.panAuthenticate.Controls.Add(this.txtId);
            this.panAuthenticate.Controls.Add(this.label3);
            this.panAuthenticate.Controls.Add(this.label2);
            this.panAuthenticate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panAuthenticate.Location = new System.Drawing.Point(3, 91);
            this.panAuthenticate.Name = "panAuthenticate";
            this.panAuthenticate.Size = new System.Drawing.Size(365, 354);
            this.panAuthenticate.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Workers: Use your workers ID please";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Staff: Use your staff ID please";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Student: Use your student ID please";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Authentication Information";
            // 
            // btnNewFaculty
            // 
            this.btnNewFaculty.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFaculty.Location = new System.Drawing.Point(192, 205);
            this.btnNewFaculty.Name = "btnNewFaculty";
            this.btnNewFaculty.Size = new System.Drawing.Size(97, 23);
            this.btnNewFaculty.TabIndex = 5;
            this.btnNewFaculty.Text = "New Faculty";
            this.btnNewFaculty.UseVisualStyleBackColor = true;
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStudent.Location = new System.Drawing.Point(77, 205);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(97, 23);
            this.btnNewStudent.TabIndex = 4;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthenticate.Location = new System.Drawing.Point(118, 158);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(153, 23);
            this.btnAuthenticate.TabIndex = 3;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(118, 107);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(153, 22);
            this.txtId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "VVU ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Authentication";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(851, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "iCaff";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 472);
            this.Controls.Add(this.panHome);
            this.Name = "Form1";
            this.Text = "HOME PAGE";
            this.panHome.ResumeLayout(false);
            this.panHome.PerformLayout();
            this.panAuthenticate.ResumeLayout(false);
            this.panAuthenticate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHome;
        private System.Windows.Forms.Panel panAuthenticate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.Button btnNewFaculty;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;


    }
}

