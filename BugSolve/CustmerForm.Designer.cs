namespace BugSolve
{
    partial class CustmerForm
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
            this.ViewBugButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textTicket = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateBugButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewBugButton
            // 
            this.ViewBugButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ViewBugButton.Location = new System.Drawing.Point(172, 35);
            this.ViewBugButton.Name = "ViewBugButton";
            this.ViewBugButton.Size = new System.Drawing.Size(96, 51);
            this.ViewBugButton.TabIndex = 0;
            this.ViewBugButton.Text = "View Bug Flow";
            this.ViewBugButton.UseVisualStyleBackColor = false;
            this.ViewBugButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textTicket
            // 
            this.textTicket.Location = new System.Drawing.Point(0, 51);
            this.textTicket.Name = "textTicket";
            this.textTicket.Size = new System.Drawing.Size(166, 20);
            this.textTicket.TabIndex = 2;
            this.textTicket.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(0, 263);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(166, 96);
            this.Description.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // GenerateBugButton
            // 
            this.GenerateBugButton.BackColor = System.Drawing.Color.Coral;
            this.GenerateBugButton.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBugButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.GenerateBugButton.Location = new System.Drawing.Point(182, 291);
            this.GenerateBugButton.Name = "GenerateBugButton";
            this.GenerateBugButton.Size = new System.Drawing.Size(96, 52);
            this.GenerateBugButton.TabIndex = 5;
            this.GenerateBugButton.Text = "GenerateBug";
            this.GenerateBugButton.UseVisualStyleBackColor = false;
            this.GenerateBugButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Crimson;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(372, 386);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(79, 33);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CustmerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 431);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.GenerateBugButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewBugButton);
            this.Name = "CustmerForm";
            this.Text = "CustmerForm";
            this.Load += new System.EventHandler(this.CustmerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewBugButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTicket;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateBugButton;
        private System.Windows.Forms.Button BackButton;
    }
}