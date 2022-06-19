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
    public partial class AdminForm : Form
    {
        Admin admin ;
        Bug bug;
        public AdminForm(string AdminNameForForm,string AdminPasswordForForm)
        {
            InitializeComponent();
            admin = new Admin { AdminName = AdminNameForForm, AdminPassword = AdminPasswordForForm };
        }

        private void AssginBugButton_Click(object sender, EventArgs e)
        {
            int TicketNumber = int.Parse(TicketNubmerForAssginText.Text);
            string StaffName = StaffNameForAssginText.Text.ToString();
            if(admin.AssignBugToStaff(TicketNumber,StaffName)==true)
            {
                MessageBox.Show("Bug Assigned Succesfully..");
            }
            else
            {
                MessageBox.Show("Bug Assige Failed..");
            }
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            string StaffName = StaffNameTextForAdd.Text.ToString();
            string StaffPassword = StaffPasswordTextForAdd.Text.ToString();
            if (admin.AddStuff(StaffName,StaffPassword) == true)
            {
                MessageBox.Show("Staff Added Succesfully..");
            }
            else
            {
                MessageBox.Show("Staff Add Failed..");
            }
        }

        private void ViewBugButton_Click(object sender, EventArgs e)
        {
            int ticketNuber = int.Parse(textTicket.Text);
            bug = admin.ViewBugFlow(ticketNuber);
            if (bug != null)
            {
                MessageBox.Show(bug.CustmerName + " \n" + bug.StaffName + " \n" + bug.Describtion + "\n" + bug.State);
            }
            else
            {
                MessageBox.Show("Wrong ticket Number...");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ViewAllBugsButton_Click(object sender, EventArgs e)
        {
            AllBugsForm bugsForm = new AllBugsForm(admin.AdminName, admin.AdminPassword);
            bugsForm.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CustomerName = CustmerNameTextForSolutuin.Text;
            string Sulotuin = SulouionText.Text;
            if(admin.SendSolution(CustomerName,Sulotuin)==true)
            {
                MessageBox.Show("Sultion Sent");
            }
            else
            {
                MessageBox.Show("Failed to Send");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            string CustomerName = CustomerNameTextForMessage.Text;
            string Message = MessageText.Text;
            if (admin.SendNormalMessage(CustomerName, Message) == true)
            {
                MessageBox.Show("Message Sent");
            }
            else
            {
                MessageBox.Show("Failed to Send");
            }
        }
    }
}
