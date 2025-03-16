namespace EmployeeMgnmt
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            EmpNameTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DailySalTb = new TextBox();
            label7 = new Label();
            GenCb = new ComboBox();
            DepCb = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            DOBTb = new DateTimePicker();
            JDateTb = new DateTimePicker();
            AddBtn = new Button();
            UpdateBtn = new Button();
            panel2 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            label12 = new Label();
            pictureBox3 = new PictureBox();
            label13 = new Label();
            pictureBox2 = new PictureBox();
            EmployeeList = new DataGridView();
            DeleteBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.White;
            label2.ForeColor = Color.SeaGreen;
            label2.Name = "label2";
            // 
            // EmpNameTB
            // 
            EmpNameTB.BackColor = Color.White;
            resources.ApplyResources(EmpNameTB, "EmpNameTB");
            EmpNameTB.Name = "EmpNameTB";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.White;
            label3.ForeColor = Color.SeaGreen;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.White;
            label4.ForeColor = Color.SeaGreen;
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.White;
            label5.ForeColor = Color.SeaGreen;
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.White;
            label6.ForeColor = Color.SeaGreen;
            label6.Name = "label6";
            // 
            // DailySalTb
            // 
            DailySalTb.BackColor = Color.White;
            resources.ApplyResources(DailySalTb, "DailySalTb");
            DailySalTb.Name = "DailySalTb";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.BackColor = Color.White;
            label7.ForeColor = Color.SeaGreen;
            label7.Name = "label7";
            // 
            // GenCb
            // 
            resources.ApplyResources(GenCb, "GenCb");
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { resources.GetString("GenCb.Items"), resources.GetString("GenCb.Items1") });
            GenCb.Name = "GenCb";
            // 
            // DepCb
            // 
            resources.ApplyResources(DepCb, "DepCb");
            DepCb.FormattingEnabled = true;
            DepCb.Name = "DepCb";
            // 
            // DOBTb
            // 
            resources.ApplyResources(DOBTb, "DOBTb");
            DOBTb.CalendarForeColor = Color.SeaGreen;
            DOBTb.CalendarMonthBackground = Color.SeaGreen;
            DOBTb.CalendarTitleBackColor = Color.SeaGreen;
            DOBTb.CalendarTitleForeColor = Color.SeaGreen;
            DOBTb.CalendarTrailingForeColor = Color.SeaGreen;
            DOBTb.Format = DateTimePickerFormat.Short;
            DOBTb.Name = "DOBTb";
            // 
            // JDateTb
            // 
            resources.ApplyResources(JDateTb, "JDateTb");
            JDateTb.Format = DateTimePickerFormat.Short;
            JDateTb.MinDate = new DateTime(2025, 3, 16, 0, 0, 0, 0);
            JDateTb.Name = "JDateTb";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.SeaGreen;
            AddBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(AddBtn, "AddBtn");
            AddBtn.ForeColor = Color.White;
            AddBtn.Name = "AddBtn";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.SeaGreen;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(UpdateBtn, "UpdateBtn");
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(label8);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.BackColor = Color.White;
            label9.ForeColor = Color.SeaGreen;
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.BackColor = Color.White;
            label10.ForeColor = Color.SeaGreen;
            label10.Name = "label10";
            label10.Click += label10_Click;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.BackColor = Color.White;
            label11.ForeColor = Color.SeaGreen;
            label11.Name = "label11";
            label11.Click += label11_Click;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.BackColor = Color.White;
            label12.ForeColor = Color.SeaGreen;
            label12.Name = "label12";
            label12.Click += label12_Click;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.BackColor = Color.White;
            label13.ForeColor = Color.SeaGreen;
            label13.Name = "label13";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // EmployeeList
            // 
            EmployeeList.BackgroundColor = Color.White;
            EmployeeList.BorderStyle = BorderStyle.None;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(EmployeeList, "EmployeeList");
            EmployeeList.Name = "EmployeeList";
            EmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(DeleteBtn, "DeleteBtn");
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Employees
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(DeleteBtn);
            Controls.Add(EmployeeList);
            Controls.Add(label10);
            Controls.Add(pictureBox5);
            Controls.Add(label11);
            Controls.Add(pictureBox4);
            Controls.Add(label12);
            Controls.Add(pictureBox3);
            Controls.Add(label13);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(JDateTb);
            Controls.Add(DOBTb);
            Controls.Add(DepCb);
            Controls.Add(GenCb);
            Controls.Add(DailySalTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmpNameTB);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox EmpNameTB;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox DailySalTb;
        private Label label7;
        private ComboBox GenCb;
        private ComboBox DepCb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker DOBTb;
        private DateTimePicker JDateTb;
        private Button AddBtn;
        private Button UpdateBtn;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox5;
        private Label label11;
        private PictureBox pictureBox4;
        private Label label12;
        private PictureBox pictureBox3;
        private Label label13;
        private PictureBox pictureBox2;
        private DataGridView EmployeeList;
        private Button DeleteBtn;
    }
}