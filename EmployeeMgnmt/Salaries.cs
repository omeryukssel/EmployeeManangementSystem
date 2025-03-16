using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgnmt
{
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "SELECT * FROM EmployeeTbl";
            EmployeeCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmployeeCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmployeeCb.DataSource = Con.GetData(Query);

        }
        int Dsal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "SELECT EmpSal FROM EmployeeTbl WHERE EmpId={0}";
            Query = string.Format(Query, EmployeeCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                Dsal = Convert.ToInt32(Con.GetData(Query).Columns["EmpSal"].ToString());
            }

            if (DaysTb.Text == "")
            {
                AmountTb.Text = (d * Dsal) + "$";
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = (d * Dsal) + "$";
            }


        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "SELECT * FROM SalaryTbl";
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = Dsal * Convert.ToInt32(DaysTb.Text);
                    int Days = Convert.ToInt32(DaysTb.Text);
                    string Query = "INSERT INTO SalaryTbl values({0},{1},'{2}',{3},'{4}')";
                    Query = string.Format(Query, EmployeeCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Salary Paid!!");
                    DaysTb.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void EmployeeCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }



        private void label7_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Depertmants obj = new Depertmants();
            obj.Show();
            this.Hide();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }
    }
}
