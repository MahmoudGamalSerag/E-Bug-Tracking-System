using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSolve
{
    public partial class LoginForm : Form
    {
        Login user = new Login();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernametext.Text.ToString();
            string password = passwordtext.Text.ToString();
            string type = user.login(username, password);
            if(type.Substring(0,7)=="Custmer")
            {
                CustmerFunctionCall(username, password);
            }
            else if(type.Substring(0, 5) == "Admin")
            {
                AdminFunctionCall(username, password);
            }
            else if (type.Substring(0, 5) == "Staff")
            {
                StaffFunctionCall(username, password);
            }
            else
            {
                MessageBox.Show(type);
            }
            
        }
        void CustmerFunctionCall(string username,string password)
        {
            MessageBox.Show("Custmer Login Acces...");
            CustmerForm custmer = new CustmerForm(username,password);
            custmer.Show();
            this.Hide();
        }
        void AdminFunctionCall(string username, string password)
        {
            MessageBox.Show("Admin Login Acces...");
            AdminForm adminForm = new AdminForm(username,password);
            adminForm.Show();
            this.Hide();
        }
        void StaffFunctionCall(string username, string password)
        {
            MessageBox.Show("Staff Login Acces...");
            StaffForm staffForm = new StaffForm(username, password);
            staffForm.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
