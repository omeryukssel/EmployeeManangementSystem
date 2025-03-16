namespace EmployeeMgnmt
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            UrNameTb = new TextBox();
            PasswordTb = new TextBox();
            LoginBtn = new Button();
            ResetBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 428);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(347, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 1;
            label1.Text = "Employee M S";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(347, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(255, 175);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(255, 250);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // UrNameTb
            // 
            UrNameTb.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            UrNameTb.Location = new Point(255, 208);
            UrNameTb.Name = "UrNameTb";
            UrNameTb.Size = new Size(264, 26);
            UrNameTb.TabIndex = 5;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PasswordTb.Location = new Point(255, 283);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(264, 26);
            PasswordTb.TabIndex = 6;
            // 
            // LoginBtn
            // 
            LoginBtn.FlatAppearance.BorderColor = Color.SeaGreen;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LoginBtn.ForeColor = Color.SeaGreen;
            LoginBtn.Location = new Point(276, 335);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(216, 32);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.FlatAppearance.BorderColor = Color.SeaGreen;
            ResetBtn.FlatStyle = FlatStyle.Flat;
            ResetBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ResetBtn.ForeColor = Color.SeaGreen;
            ResetBtn.Location = new Point(276, 385);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(216, 31);
            ResetBtn.TabIndex = 8;
            ResetBtn.Text = "RESET";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 133);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 0;
            label4.Text = "Employee MS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, 191);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 1;
            label5.Text = "SQL Server";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 163);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 2;
            label6.Text = "C#.NET";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(658, 428);
            Controls.Add(ResetBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTb);
            Controls.Add(UrNameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox UrNameTb;
        private TextBox PasswordTb;
        private Button LoginBtn;
        private Button ResetBtn;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}
