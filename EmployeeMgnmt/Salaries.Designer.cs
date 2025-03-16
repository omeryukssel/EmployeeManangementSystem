namespace EmployeeMgnmt
{
    partial class Salaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            label9 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            UpdateBtn = new Button();
            AddBtn = new Button();
            PeriodTb = new DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            SalaryList = new DataGridView();
            DaysTb = new TextBox();
            EmployeeCb = new ComboBox();
            AmountTb = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold);
            label9.ForeColor = Color.SeaGreen;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(767, 158);
            label9.Name = "label9";
            label9.Size = new Size(121, 19);
            label9.TabIndex = 60;
            label9.Text = "Manage Salary";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 15.75F, FontStyle.Bold);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(553, 27);
            label8.Name = "label8";
            label8.Size = new Size(372, 30);
            label8.TabIndex = 1;
            label8.Text = "Employee Manangment System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 683);
            panel2.Name = "panel2";
            panel2.Size = new Size(1524, 90);
            panel2.TabIndex = 58;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.SeaGreen;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.ImeMode = ImeMode.NoControl;
            UpdateBtn.Location = new Point(151, 502);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(93, 35);
            UpdateBtn.TabIndex = 57;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.SeaGreen;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            AddBtn.ForeColor = Color.White;
            AddBtn.ImeMode = ImeMode.NoControl;
            AddBtn.Location = new Point(48, 502);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(81, 35);
            AddBtn.TabIndex = 56;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // PeriodTb
            // 
            PeriodTb.CalendarFont = new Font("Arial", 12F, FontStyle.Bold);
            PeriodTb.CalendarForeColor = Color.SeaGreen;
            PeriodTb.CalendarMonthBackground = Color.SeaGreen;
            PeriodTb.CalendarTitleBackColor = Color.SeaGreen;
            PeriodTb.CalendarTitleForeColor = Color.SeaGreen;
            PeriodTb.CalendarTrailingForeColor = Color.SeaGreen;
            PeriodTb.Location = new Point(51, 402);
            PeriodTb.Name = "PeriodTb";
            PeriodTb.Size = new Size(200, 23);
            PeriodTb.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ForeColor = Color.SeaGreen;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(48, 380);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 48;
            label5.Text = "Period";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.SeaGreen;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(48, 305);
            label3.Name = "label3";
            label3.Size = new Size(101, 19);
            label3.TabIndex = 46;
            label3.Text = "Days Attend";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.SeaGreen;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(48, 242);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 44;
            label2.Text = "Employee ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(82, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(553, 30);
            label1.Name = "label1";
            label1.Size = new Size(372, 30);
            label1.TabIndex = 1;
            label1.Text = "Employee Manangment System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.ForeColor = Color.SeaGreen;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(48, 435);
            label6.Name = "label6";
            label6.Size = new Size(120, 19);
            label6.TabIndex = 49;
            label6.Text = "Salary Amount";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1524, 100);
            panel1.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.ForeColor = Color.SeaGreen;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(1135, 111);
            label7.Name = "label7";
            label7.Size = new Size(64, 19);
            label7.TabIndex = 68;
            label7.Text = "Logout";
            label7.Click += label7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(1097, 106);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 67;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.SeaGreen;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(989, 111);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 66;
            label4.Text = "Salary";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(951, 106);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 65;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold);
            label10.ForeColor = Color.SeaGreen;
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(790, 111);
            label10.Name = "label10";
            label10.Size = new Size(98, 19);
            label10.TabIndex = 64;
            label10.Text = "Departmant";
            label10.Click += label10_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(752, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 63;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold);
            label11.ForeColor = Color.SeaGreen;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(591, 111);
            label11.Name = "label11";
            label11.Size = new Size(85, 19);
            label11.TabIndex = 62;
            label11.Text = "Employee";
            label11.Click += label11_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(553, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            // 
            // SalaryList
            // 
            SalaryList.BackgroundColor = Color.White;
            SalaryList.BorderStyle = BorderStyle.None;
            SalaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalaryList.Location = new Point(383, 197);
            SalaryList.Name = "SalaryList";
            SalaryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalaryList.Size = new Size(1017, 462);
            SalaryList.TabIndex = 69;
            SalaryList.CellContentClick += SalaryList_CellContentClick;
            // 
            // DaysTb
            // 
            DaysTb.BackColor = Color.White;
            DaysTb.Font = new Font("Arial", 12F, FontStyle.Bold);
            DaysTb.Location = new Point(51, 327);
            DaysTb.Name = "DaysTb";
            DaysTb.Size = new Size(196, 26);
            DaysTb.TabIndex = 70;
            // 
            // EmployeeCb
            // 
            EmployeeCb.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            EmployeeCb.FormattingEnabled = true;
            EmployeeCb.Location = new Point(51, 264);
            EmployeeCb.Name = "EmployeeCb";
            EmployeeCb.Size = new Size(196, 27);
            EmployeeCb.TabIndex = 71;
            EmployeeCb.SelectionChangeCommitted += EmployeeCb_SelectionChangeCommitted;
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.White;
            AmountTb.Font = new Font("Arial", 12F, FontStyle.Bold);
            AmountTb.Location = new Point(51, 457);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(196, 26);
            AmountTb.TabIndex = 72;
            // 
            // Salaries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1524, 773);
            Controls.Add(AmountTb);
            Controls.Add(EmployeeCb);
            Controls.Add(DaysTb);
            Controls.Add(SalaryList);
            Controls.Add(label7);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label10);
            Controls.Add(pictureBox3);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(PeriodTb);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salaries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salaries";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private Panel panel2;
        private Button UpdateBtn;
        private Button AddBtn;
        private DateTimePicker PeriodTb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label10;
        private PictureBox pictureBox3;
        private Label label11;
        private PictureBox pictureBox2;
        private DataGridView SalaryList;
        private TextBox DaysTb;
        private ComboBox EmployeeCb;
        private TextBox AmountTb;
    }
}