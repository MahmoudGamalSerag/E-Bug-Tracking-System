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
    public partial class CustmerForm : Form
    {
       
        Custmer custmer;
        Bug bugObject;
        public CustmerForm(string CustmerNameForForm,string CustmerPasswordForForm)
        {
            InitializeComponent();
            custmer = new Custmer { CustmerName = CustmerNameForForm, CustmerPassword = CustmerPasswordForForm };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int ticketNuber = int.Parse(textTicket.Text);
             bugObject = custmer.ViewBugFlow(ticketNuber);
            if (bugObject != null )
            {
              MessageBox.Show(bugObject.CustmerName+" \n"+ bugObject.StaffName+" \n"+ bugObject.Describtion+"\n"+ bugObject.State);
            }
            else
            {
                MessageBox.Show("Wrong ticket Number...");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustmerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string description = Description.Text.ToString();
            int teckitnumber = custmer.GenerateBug(description);
            if(teckitnumber>0)
            MessageBox.Show("your ticket number is:\n" + teckitnumber);
            else
                MessageBox.Show("please enter valid data" );

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
