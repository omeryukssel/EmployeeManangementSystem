namespace EmployeeMgnmt
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UrNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UrNameTb.Text=="" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else if (UrNameTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                Employees obj= new Employees();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password!!");
                UrNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }
    }
}
