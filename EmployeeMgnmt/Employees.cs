using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeMgnmt
{

    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();
        }

        private void ShowEmp()
        {
            string Query = "SELECT * FROM EmployeeTbl";
            EmployeeList.DataSource = Con.GetData(Query);
        }
        private void GetDepartment()
        {
            string Query = "SELECT * FROM DepartmentTbl";
            DepCb.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource = Con.GetData(Query);

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EmpNameTB.Text) || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || string.IsNullOrEmpty(DailySalTb.Text))
                {
                    MessageBox.Show("Eksik Veri!");
                    return;
                }

                string Name = EmpNameTB.Text;
                string Gender = GenCb.SelectedItem.ToString();
                int Dep = Convert.ToInt32(DepCb.SelectedValue);
                string DOB = DOBTb.Value.ToString("yyyy-MM-dd");
                string JDate = JDateTb.Value.ToString("yyyy-MM-dd");
                int Salary = Convert.ToInt32(DailySalTb.Text);

                string Query = @"INSERT INTO EmployeeTbl 
                        (EmpName, EmpGen, EmpDep, EmpDDB, EmpJDate, EmpSal) 
                        VALUES ('{0}','{1}',{2},'{3}','{4}',{5})";

                Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                Con.SetData(Query);

                MessageBox.Show("Çalışan Eklendi!");
                ShowEmp();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            EmpNameTB.Text = "";
            DailySalTb.Text = "";
            GenCb.SelectedIndex = -1;
            DepCb.SelectedIndex = -1;
            DOBTb.Value = DateTime.Now;
            JDateTb.Value = DateTime.Now;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EmpNameTB.Text) || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || string.IsNullOrEmpty(DailySalTb.Text))
                {
                    MessageBox.Show("Eksik Veri!");
                    return;
                }

                string Name = EmpNameTB.Text;
                string Gender = GenCb.SelectedItem.ToString();
                int Dep = Convert.ToInt32(DepCb.SelectedValue);
                string DOB = DOBTb.Value.ToString("yyyy-MM-dd");
                string JDate = JDateTb.Value.ToString("yyyy-MM-dd");
                int Salary = Convert.ToInt32(DailySalTb.Text);


                string Query = @"UPDATE EmployeeTbl SET EmpName='{0}',EmpDep='{1}',EmpDep={2},EmpDOB='{3}',EmpJDate='{4}',EmpSal= {5} WHERE EmpID= {6}";

                Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary, key);
                Con.SetData(Query);

                MessageBox.Show("Çalışan Eklendi!");
                ShowEmp();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Eksik Veri!");
                    return;
                }

                string Query = @"DELETE FROM EmployeeTbl WHERE EmpID= {0}";

                Query = string.Format(Query, key);
                Con.SetData(Query);
                ShowEmp();
                MessageBox.Show("Employee Deleted!");
                EmpNameTB.Text = "";
                DailySalTb.Text = "";
                GenCb.SelectedIndex = -1;
                DepCb.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        int key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTB.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.SelectedValue = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[6].Value);
            DOBTb.Value = DateTime.Parse(EmployeeList.SelectedRows[0].Cells[3].Value.ToString());
            JDateTb.Value = DateTime.Parse(EmployeeList.SelectedRows[0].Cells[4].Value.ToString());
            DailySalTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();

            if (EmpNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }



        private void label10_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Depertmants obj = new Depertmants();
            obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Salaries obj = new Salaries();
            obj.Show();
            this.Hide();
        }
    }
}
