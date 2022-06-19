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
    public partial class AssignedBugsFormForStaff : Form
    {
        Staff staff;
        public AssignedBugsFormForStaff(string StaffNameForAssignedBugForm,string StaffPasswordForAssignedBugForm)
        {
            InitializeComponent();
            staff = new Staff { StaffName = StaffNameForAssignedBugForm, StaffPassword = StaffPasswordForAssignedBugForm };
            FillViewListWithData();
        }
        private void FillViewListWithData()
        {
            List<Bug> AllBugs = staff.ShowAssigndBugs().ToList();
            foreach (var bugobject in AllBugs)
            {
                ListViewItem item = new ListViewItem(bugobject.TicketNUmber.ToString());
                item.SubItems.Add(bugobject.CustmerName);
                item.SubItems.Add(bugobject.StaffName);
                item.SubItems.Add(bugobject.Describtion);
                item.SubItems.Add(bugobject.State);
                BugsListView.Items.Add(item);
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm( staff.StaffName, staff.StaffPassword);
            staffForm.Show();
            this.Hide();
        }

        private void AssignedBugsFormForStaff_Load(object sender, EventArgs e)
        {

        }

        private void BugsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
