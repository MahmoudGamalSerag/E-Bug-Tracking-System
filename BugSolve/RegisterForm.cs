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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string UserName = UserNameText.Text.ToString();
            string Password = PasswordText.Text.ToString();
            Custmer RegisterCustmer = new Custmer();
           if( RegisterCustmer.register(UserName, Password)==true)
            {
                MessageBox.Show("Registration success..");
                BackToLoginForm();
            }
           else
            {
                MessageBox.Show("Registration Failed..");
            }
        }
        void BackToLoginForm()
        {
            LoginForm Back = new LoginForm();
            Back.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackToLoginForm();
        }
    }
}
