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
    public partial class StaffForm : Form
    {
        Staff staff;
        Bug bug;
        public StaffForm(string a,string b)
        {
            InitializeComponent();
            staff = new Staff { StaffName = a, StaffPassword = b };

        }

        private void AssginBugButton_Click(object sender, EventArgs e)
        {
            int TicketNumber = int.Parse(TicketNubmerForAssginText.Text);
            string StaffName = StaffNameForAssginText.Text.ToString();
            if (staff.AssignBugToStaff(TicketNumber, StaffName) == true)
            {
                MessageBox.Show("Bug Assigned Succesfully..");
            }
            else
            {
                MessageBox.Show("Bug Assige Failed..");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ViewBugButton_Click(object sender, EventArgs e)
        {
            int ticketNuber = int.Parse(textTicket.Text);
            bug = staff.ViewBugFlow(ticketNuber);
            if (bug != null)
            {
                MessageBox.Show(bug.CustmerName + " \n" + bug.StaffName + " \n" + bug.Describtion + "\n" + bug.State);
            }
            else
            {
                MessageBox.Show("Wrong ticket Number...");
            }
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        
        }

        private void TicketNubmerForAssginText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewAssignedBugsButton_Click(object sender, EventArgs e)
        {
            AssignedBugsFormForStaff assignedBugsFormForStaffObject = new AssignedBugsFormForStaff(staff.StaffName, staff.StaffPassword);
            assignedBugsFormForStaffObject.Show();
            this.Hide();
        }

        private void UpdateStateButton_Click(object sender, EventArgs e)
        {
            int ticketNuber = int.Parse(TicketNumberForUPdateFlowtext.Text);
            string state = StateForUpdateStatetext.Text.ToString();
            if(staff.UpdateFlow(ticketNuber,state)==true)
            {
                MessageBox.Show("Updated succesfuly..");
            }
            else
            {
                MessageBox.Show("Update Failed!!");
            }
        }

        private void SendSolution_Click(object sender, EventArgs e)
        {
            string CustomerName = CustmerNameTextForSolutuin.Text;
            string Sulotuin = SulouionText.Text;
            if (staff.SendSolution(CustomerName, Sulotuin) == true)
            {
                MessageBox.Show("Sultion Sent");
            }
            else
            {
                MessageBox.Show("Failed to Send");
            }
        }
    }
}
