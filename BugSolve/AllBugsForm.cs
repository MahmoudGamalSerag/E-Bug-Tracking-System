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
    public partial class AllBugsForm : Form
    {
        Admin admin;
        public AllBugsForm(string AdminNameForBugForm,string AdminPasswordForBugForm)
        {
            InitializeComponent();
            admin = new Admin { AdminName = AdminNameForBugForm, AdminPassword = AdminPasswordForBugForm };

            FillViewListWithData();
        }
        private void FillViewListWithData()
        {
            List<Bug> AllBugs = admin.ViewAllBugs().ToList();
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
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(admin.AdminName,admin.AdminPassword);
            adminForm.Show();
            this.Hide();
        }

        private void AllBugsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
