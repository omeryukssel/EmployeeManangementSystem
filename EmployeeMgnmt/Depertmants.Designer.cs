namespace EmployeeMgnmt
{
    partial class Depertmants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depertmants));
            DepList = new DataGridView();
            panel2 = new Panel();
            label8 = new Label();
            EditBtn = new Button();
            AddBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            DepNameTb = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            Emplbl = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            Salarylbl = new Label();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // DepList
            // 
            DepList.BackgroundColor = Color.White;
            DepList.BorderStyle = BorderStyle.None;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepList.Location = new Point(442, 205);
            DepList.Name = "DepList";
            DepList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DepList.Size = new Size(1017, 462);
            DepList.TabIndex = 39;
            DepList.CellContentClick += DepList_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 683);
            panel2.Name = "panel2";
            panel2.Size = new Size(1524, 90);
            panel2.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 15.75F, FontStyle.Bold);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(576, 29);
            label8.Name = "label8";
            label8.Size = new Size(372, 30);
            label8.TabIndex = 1;
            label8.Text = "Employee Manangment System";
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.SeaGreen;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            EditBtn.ForeColor = Color.White;
            EditBtn.ImeMode = ImeMode.NoControl;
            EditBtn.Location = new Point(154, 306);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(93, 35);
            EditBtn.TabIndex = 37;
            EditBtn.Text = "Update";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.SeaGreen;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            AddBtn.ForeColor = Color.White;
            AddBtn.ImeMode = ImeMode.NoControl;
            AddBtn.Location = new Point(51, 306);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(81, 35);
            AddBtn.TabIndex = 36;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DepNameTb
            // 
            DepNameTb.BackColor = Color.White;
            DepNameTb.Font = new Font("Arial", 12F, FontStyle.Bold);
            DepNameTb.Location = new Point(51, 264);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(196, 26);
            DepNameTb.TabIndex = 25;
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
            label2.Size = new Size(146, 19);
            label2.TabIndex = 24;
            label2.Text = "Departmant Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(82, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(576, 34);
            label1.Name = "label1";
            label1.Size = new Size(372, 30);
            label1.TabIndex = 1;
            label1.Text = "Employee Manangment System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1524, 100);
            panel1.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.SeaGreen;
            label9.Location = new Point(709, 146);
            label9.Name = "label9";
            label9.Size = new Size(202, 22);
            label9.TabIndex = 40;
            label9.Text = "Manage Departmant ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.SeaGreen;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(857, 178);
            label3.Name = "label3";
            label3.Size = new Size(171, 24);
            label3.TabIndex = 41;
            label3.Text = "Departmant List";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(540, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // Emplbl
            // 
            Emplbl.AutoSize = true;
            Emplbl.BackColor = Color.White;
            Emplbl.Font = new Font("Arial", 12F, FontStyle.Bold);
            Emplbl.ForeColor = Color.SeaGreen;
            Emplbl.ImeMode = ImeMode.NoControl;
            Emplbl.Location = new Point(578, 111);
            Emplbl.Name = "Emplbl";
            Emplbl.Size = new Size(85, 19);
            Emplbl.TabIndex = 43;
            Emplbl.Text = "Employee";
            Emplbl.Click += Emplbl_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ForeColor = Color.SeaGreen;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(777, 111);
            label5.Name = "label5";
            label5.Size = new Size(98, 19);
            label5.TabIndex = 45;
            label5.Text = "Departmant";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(739, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // Salarylbl
            // 
            Salarylbl.AutoSize = true;
            Salarylbl.BackColor = Color.White;
            Salarylbl.Font = new Font("Arial", 12F, FontStyle.Bold);
            Salarylbl.ForeColor = Color.SeaGreen;
            Salarylbl.ImeMode = ImeMode.NoControl;
            Salarylbl.Location = new Point(976, 111);
            Salarylbl.Name = "Salarylbl";
            Salarylbl.Size = new Size(57, 19);
            Salarylbl.TabIndex = 47;
            Salarylbl.Text = "Salary";
            Salarylbl.Click += Salarylbl_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(938, 106);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.ForeColor = Color.SeaGreen;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(1122, 111);
            label7.Name = "label7";
            label7.Size = new Size(64, 19);
            label7.TabIndex = 49;
            label7.Text = "Logout";
            label7.Click += label7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(1084, 106);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 48;
            pictureBox5.TabStop = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.SeaGreen;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.ImeMode = ImeMode.NoControl;
            DeleteBtn.Location = new Point(101, 385);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(93, 35);
            DeleteBtn.TabIndex = 50;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Depertmants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1524, 773);
            Controls.Add(DeleteBtn);
            Controls.Add(label7);
            Controls.Add(pictureBox5);
            Controls.Add(Salarylbl);
            Controls.Add(pictureBox4);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(Emplbl);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(DepList);
            Controls.Add(panel2);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(DepNameTb);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Depertmants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Depertmants";
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DepList;
        private Panel panel2;
        private Label label8;
        private Button EditBtn;
        private Button AddBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox DepNameTb;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label9;
        private Label label3;
        private PictureBox pictureBox2;
        private Label Emplbl;
        private Label label5;
        private PictureBox pictureBox3;
        private Label Salarylbl;
        private PictureBox pictureBox4;
        private Label label7;
        private PictureBox pictureBox5;
        private Button DeleteBtn;
    }
}