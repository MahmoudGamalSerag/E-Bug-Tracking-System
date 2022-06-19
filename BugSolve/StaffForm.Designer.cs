namespace BugSolve
{
    partial class StaffForm
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
            this.StaffNameLabelForAssgin = new System.Windows.Forms.Label();
            this.TicketNumberLabel = new System.Windows.Forms.Label();
            this.AssginBugButton = new System.Windows.Forms.Button();
            this.StaffNameForAssginText = new System.Windows.Forms.TextBox();
            this.TicketNubmerForAssginText = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.textTicket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewBugButton = new System.Windows.Forms.Button();
            this.ViewAssignedBugsButton = new System.Windows.Forms.Button();
            this.UpdateStateButton = new System.Windows.Forms.Button();
            this.StateLabelForUpdateBug = new System.Windows.Forms.Label();
            this.TicketNumberLabelForUpdateBug = new System.Windows.Forms.Label();
            this.TicketNumberForUPdateFlowtext = new System.Windows.Forms.TextBox();
            this.StateForUpdateStatetext = new System.Windows.Forms.TextBox();
            this.SolutionLabel = new System.Windows.Forms.Label();
            this.CustmerNameLabelForSolution = new System.Windows.Forms.Label();
            this.SulouionText = new System.Windows.Forms.TextBox();
            this.CustmerNameTextForSolutuin = new System.Windows.Forms.TextBox();
            this.SendSolution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffNameLabelForAssgin
            // 
            this.StaffNameLabelForAssgin.AutoSize = true;
            this.StaffNameLabelForAssgin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StaffNameLabelForAssgin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameLabelForAssgin.ForeColor = System.Drawing.Color.Crimson;
            this.StaffNameLabelForAssgin.Location = new System.Drawing.Point(28, 49);
            this.StaffNameLabelForAssgin.Name = "StaffNameLabelForAssgin";
            this.StaffNameLabelForAssgin.Size = new System.Drawing.Size(73, 16);
            this.StaffNameLabelForAssgin.TabIndex = 5;
            this.StaffNameLabelForAssgin.Text = "StaffName:";
            // 
            // TicketNumberLabel
            // 
            this.TicketNumberLabel.AutoSize = true;
            this.TicketNumberLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TicketNumberLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketNumberLabel.ForeColor = System.Drawing.Color.Crimson;
            this.TicketNumberLabel.Location = new System.Drawing.Point(28, 97);
            this.TicketNumberLabel.Name = "TicketNumberLabel";
            this.TicketNumberLabel.Size = new System.Drawing.Size(96, 16);
            this.TicketNumberLabel.TabIndex = 6;
            this.TicketNumberLabel.Text = "Ticket Number:";
            // 
            // AssginBugButton
            // 
            this.AssginBugButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.AssginBugButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssginBugButton.ForeColor = System.Drawing.Color.Coral;
            this.AssginBugButton.Location = new System.Drawing.Point(79, 144);
            this.AssginBugButton.Name = "AssginBugButton";
            this.AssginBugButton.Size = new System.Drawing.Size(106, 27);
            this.AssginBugButton.TabIndex = 7;
            this.AssginBugButton.Text = "AssignBug";
            this.AssginBugButton.UseVisualStyleBackColor = false;
            this.AssginBugButton.Click += new System.EventHandler(this.AssginBugButton_Click);
            // 
            // StaffNameForAssginText
            // 
            this.StaffNameForAssginText.Location = new System.Drawing.Point(164, 49);
            this.StaffNameForAssginText.Name = "StaffNameForAssginText";
            this.StaffNameForAssginText.Size = new System.Drawing.Size(124, 20);
            this.StaffNameForAssginText.TabIndex = 8;
            // 
            // TicketNubmerForAssginText
            // 
            this.TicketNubmerForAssginText.Location = new System.Drawing.Point(164, 96);
            this.TicketNubmerForAssginText.Name = "TicketNubmerForAssginText";
            this.TicketNubmerForAssginText.Size = new System.Drawing.Size(124, 20);
            this.TicketNubmerForAssginText.TabIndex = 9;
            this.TicketNubmerForAssginText.TextChanged += new System.EventHandler(this.TicketNubmerForAssginText_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DarkRed;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(698, 415);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // textTicket
            // 
            this.textTicket.Location = new System.Drawing.Point(143, 233);
            this.textTicket.Name = "textTicket";
            this.textTicket.Size = new System.Drawing.Size(166, 20);
            this.textTicket.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(28, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ticket Number:";
            // 
            // ViewBugButton
            // 
            this.ViewBugButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.ViewBugButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBugButton.ForeColor = System.Drawing.Color.Coral;
            this.ViewBugButton.Location = new System.Drawing.Point(108, 273);
            this.ViewBugButton.Name = "ViewBugButton";
            this.ViewBugButton.Size = new System.Drawing.Size(108, 29);
            this.ViewBugButton.TabIndex = 15;
            this.ViewBugButton.Text = "View Bug Flow";
            this.ViewBugButton.UseVisualStyleBackColor = false;
            this.ViewBugButton.Click += new System.EventHandler(this.ViewBugButton_Click);
            // 
            // ViewAssignedBugsButton
            // 
            this.ViewAssignedBugsButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.ViewAssignedBugsButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAssignedBugsButton.ForeColor = System.Drawing.Color.Coral;
            this.ViewAssignedBugsButton.Location = new System.Drawing.Point(79, 385);
            this.ViewAssignedBugsButton.Name = "ViewAssignedBugsButton";
            this.ViewAssignedBugsButton.Size = new System.Drawing.Size(137, 53);
            this.ViewAssignedBugsButton.TabIndex = 18;
            this.ViewAssignedBugsButton.Text = "View Assigned Bugs";
            this.ViewAssignedBugsButton.UseVisualStyleBackColor = false;
            this.ViewAssignedBugsButton.Click += new System.EventHandler(this.ViewAssignedBugsButton_Click);
            // 
            // UpdateStateButton
            // 
            this.UpdateStateButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.UpdateStateButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStateButton.ForeColor = System.Drawing.Color.Coral;
            this.UpdateStateButton.Location = new System.Drawing.Point(582, 148);
            this.UpdateStateButton.Name = "UpdateStateButton";
            this.UpdateStateButton.Size = new System.Drawing.Size(123, 35);
            this.UpdateStateButton.TabIndex = 19;
            this.UpdateStateButton.Text = "Update state";
            this.UpdateStateButton.UseVisualStyleBackColor = false;
            this.UpdateStateButton.Click += new System.EventHandler(this.UpdateStateButton_Click);
            // 
            // StateLabelForUpdateBug
            // 
            this.StateLabelForUpdateBug.AutoSize = true;
            this.StateLabelForUpdateBug.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StateLabelForUpdateBug.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabelForUpdateBug.ForeColor = System.Drawing.Color.Crimson;
            this.StateLabelForUpdateBug.Location = new System.Drawing.Point(490, 103);
            this.StateLabelForUpdateBug.Name = "StateLabelForUpdateBug";
            this.StateLabelForUpdateBug.Size = new System.Drawing.Size(53, 19);
            this.StateLabelForUpdateBug.TabIndex = 20;
            this.StateLabelForUpdateBug.Text = "State";
            // 
            // TicketNumberLabelForUpdateBug
            // 
            this.TicketNumberLabelForUpdateBug.AutoSize = true;
            this.TicketNumberLabelForUpdateBug.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TicketNumberLabelForUpdateBug.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketNumberLabelForUpdateBug.ForeColor = System.Drawing.Color.Crimson;
            this.TicketNumberLabelForUpdateBug.Location = new System.Drawing.Point(447, 53);
            this.TicketNumberLabelForUpdateBug.Name = "TicketNumberLabelForUpdateBug";
            this.TicketNumberLabelForUpdateBug.Size = new System.Drawing.Size(96, 16);
            this.TicketNumberLabelForUpdateBug.TabIndex = 21;
            this.TicketNumberLabelForUpdateBug.Text = "Ticket Number:";
            // 
            // TicketNumberForUPdateFlowtext
            // 
            this.TicketNumberForUPdateFlowtext.Location = new System.Drawing.Point(582, 53);
            this.TicketNumberForUPdateFlowtext.Name = "TicketNumberForUPdateFlowtext";
            this.TicketNumberForUPdateFlowtext.Size = new System.Drawing.Size(143, 20);
            this.TicketNumberForUPdateFlowtext.TabIndex = 22;
            // 
            // StateForUpdateStatetext
            // 
            this.StateForUpdateStatetext.Location = new System.Drawing.Point(582, 105);
            this.StateForUpdateStatetext.Multiline = true;
            this.StateForUpdateStatetext.Name = "StateForUpdateStatetext";
            this.StateForUpdateStatetext.Size = new System.Drawing.Size(143, 16);
            this.StateForUpdateStatetext.TabIndex = 23;
            // 
            // SolutionLabel
            // 
            this.SolutionLabel.AutoSize = true;
            this.SolutionLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SolutionLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionLabel.ForeColor = System.Drawing.Color.Crimson;
            this.SolutionLabel.Location = new System.Drawing.Point(493, 287);
            this.SolutionLabel.Name = "SolutionLabel";
            this.SolutionLabel.Size = new System.Drawing.Size(79, 18);
            this.SolutionLabel.TabIndex = 28;
            this.SolutionLabel.Text = "Solution :";
            // 
            // CustmerNameLabelForSolution
            // 
            this.CustmerNameLabelForSolution.AutoSize = true;
            this.CustmerNameLabelForSolution.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CustmerNameLabelForSolution.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustmerNameLabelForSolution.ForeColor = System.Drawing.Color.DarkMagenta;
            this.CustmerNameLabelForSolution.Location = new System.Drawing.Point(483, 247);
            this.CustmerNameLabelForSolution.Name = "CustmerNameLabelForSolution";
            this.CustmerNameLabelForSolution.Size = new System.Drawing.Size(97, 16);
            this.CustmerNameLabelForSolution.TabIndex = 27;
            this.CustmerNameLabelForSolution.Text = "CustmerName";
            // 
            // SulouionText
            // 
            this.SulouionText.Location = new System.Drawing.Point(582, 273);
            this.SulouionText.Multiline = true;
            this.SulouionText.Name = "SulouionText";
            this.SulouionText.Size = new System.Drawing.Size(174, 44);
            this.SulouionText.TabIndex = 26;
            // 
            // CustmerNameTextForSolutuin
            // 
            this.CustmerNameTextForSolutuin.Location = new System.Drawing.Point(582, 247);
            this.CustmerNameTextForSolutuin.Name = "CustmerNameTextForSolutuin";
            this.CustmerNameTextForSolutuin.Size = new System.Drawing.Size(100, 20);
            this.CustmerNameTextForSolutuin.TabIndex = 25;
            // 
            // SendSolution
            // 
            this.SendSolution.BackColor = System.Drawing.SystemColors.ControlText;
            this.SendSolution.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendSolution.ForeColor = System.Drawing.Color.Coral;
            this.SendSolution.Location = new System.Drawing.Point(582, 333);
            this.SendSolution.Name = "SendSolution";
            this.SendSolution.Size = new System.Drawing.Size(137, 33);
            this.SendSolution.TabIndex = 24;
            this.SendSolution.Text = "SendSolution";
            this.SendSolution.UseVisualStyleBackColor = false;
            this.SendSolution.Click += new System.EventHandler(this.SendSolution_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SolutionLabel);
            this.Controls.Add(this.CustmerNameLabelForSolution);
            this.Controls.Add(this.SulouionText);
            this.Controls.Add(this.CustmerNameTextForSolutuin);
            this.Controls.Add(this.SendSolution);
            this.Controls.Add(this.StateForUpdateStatetext);
            this.Controls.Add(this.TicketNumberForUPdateFlowtext);
            this.Controls.Add(this.TicketNumberLabelForUpdateBug);
            this.Controls.Add(this.StateLabelForUpdateBug);
            this.Controls.Add(this.UpdateStateButton);
            this.Controls.Add(this.ViewAssignedBugsButton);
            this.Controls.Add(this.textTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewBugButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TicketNubmerForAssginText);
            this.Controls.Add(this.StaffNameForAssginText);
            this.Controls.Add(this.AssginBugButton);
            this.Controls.Add(this.TicketNumberLabel);
            this.Controls.Add(this.StaffNameLabelForAssgin);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaffNameLabelForAssgin;
        private System.Windows.Forms.Label TicketNumberLabel;
        private System.Windows.Forms.Button AssginBugButton;
        private System.Windows.Forms.TextBox StaffNameForAssginText;
        private System.Windows.Forms.TextBox TicketNubmerForAssginText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox textTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewBugButton;
        private System.Windows.Forms.Button ViewAssignedBugsButton;
        private System.Windows.Forms.Button UpdateStateButton;
        private System.Windows.Forms.Label StateLabelForUpdateBug;
        private System.Windows.Forms.Label TicketNumberLabelForUpdateBug;
        private System.Windows.Forms.TextBox TicketNumberForUPdateFlowtext;
        private System.Windows.Forms.TextBox StateForUpdateStatetext;
        private System.Windows.Forms.Label SolutionLabel;
        private System.Windows.Forms.Label CustmerNameLabelForSolution;
        private System.Windows.Forms.TextBox SulouionText;
        private System.Windows.Forms.TextBox CustmerNameTextForSolutuin;
        private System.Windows.Forms.Button SendSolution;
    }
}