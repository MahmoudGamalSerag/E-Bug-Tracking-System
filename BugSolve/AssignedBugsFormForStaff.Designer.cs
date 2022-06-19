namespace BugSolve
{
    partial class AssignedBugsFormForStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BugsListView = new System.Windows.Forms.ListView();
            this.TicketNumberCoulomn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustmerNamecoulomn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffNameCuolomn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionCoulomn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BugsListView
            // 
            this.BugsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TicketNumberCoulomn,
            this.CustmerNamecoulomn,
            this.StaffNameCuolomn,
            this.DescriptionCoulomn,
            this.StateColumn});
            this.BugsListView.HideSelection = false;
            this.BugsListView.Location = new System.Drawing.Point(29, 2);
            this.BugsListView.Name = "BugsListView";
            this.BugsListView.Size = new System.Drawing.Size(743, 447);
            this.BugsListView.TabIndex = 1;
            this.BugsListView.UseCompatibleStateImageBehavior = false;
            this.BugsListView.View = System.Windows.Forms.View.Details;
            this.BugsListView.SelectedIndexChanged += new System.EventHandler(this.BugsListView_SelectedIndexChanged);
            // 
            // TicketNumberCoulomn
            // 
            this.TicketNumberCoulomn.Text = "TicketNumber";
            this.TicketNumberCoulomn.Width = 81;
            // 
            // CustmerNamecoulomn
            // 
            this.CustmerNamecoulomn.Text = "CustmerName";
            this.CustmerNamecoulomn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustmerNamecoulomn.Width = 150;
            // 
            // StaffNameCuolomn
            // 
            this.StaffNameCuolomn.Text = "Staffname";
            this.StaffNameCuolomn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StaffNameCuolomn.Width = 150;
            // 
            // DescriptionCoulomn
            // 
            this.DescriptionCoulomn.Text = "Description";
            this.DescriptionCoulomn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DescriptionCoulomn.Width = 232;
            // 
            // StateColumn
            // 
            this.StateColumn.Text = "State";
            this.StateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StateColumn.Width = 158;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DarkRed;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(331, 459);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AssignedBugsFormForStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 494);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BugsListView);
            this.Name = "AssignedBugsFormForStaff";
            this.Text = "AssignedBugsFormForStaff";
            this.Load += new System.EventHandler(this.AssignedBugsFormForStaff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BugsListView;
        private System.Windows.Forms.ColumnHeader TicketNumberCoulomn;
        private System.Windows.Forms.ColumnHeader CustmerNamecoulomn;
        private System.Windows.Forms.ColumnHeader StaffNameCuolomn;
        private System.Windows.Forms.ColumnHeader DescriptionCoulomn;
        private System.Windows.Forms.ColumnHeader StateColumn;
        private System.Windows.Forms.Button BackButton;
    }
}