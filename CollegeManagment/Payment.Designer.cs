namespace CollegeManagment
{
    partial class Payment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.FNSearch = new System.Windows.Forms.TextBox();
            this.PaidBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PayBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentUpdate = new System.Windows.Forms.Button();
            this.StFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ToPay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(162, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 36);
            this.button1.TabIndex = 47;
            this.button1.Text = "Search By Id";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FNSearch
            // 
            this.FNSearch.Location = new System.Drawing.Point(346, 56);
            this.FNSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FNSearch.Multiline = true;
            this.FNSearch.Name = "FNSearch";
            this.FNSearch.Size = new System.Drawing.Size(240, 35);
            this.FNSearch.TabIndex = 46;
            // 
            // PaidBox
            // 
            this.PaidBox.Location = new System.Drawing.Point(346, 199);
            this.PaidBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaidBox.Name = "PaidBox";
            this.PaidBox.Size = new System.Drawing.Size(240, 26);
            this.PaidBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "How Much Paid";
            // 
            // PayBox
            // 
            this.PayBox.Location = new System.Drawing.Point(346, 266);
            this.PayBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PayBox.Name = "PayBox";
            this.PayBox.Size = new System.Drawing.Size(240, 26);
            this.PayBox.TabIndex = 53;
            this.PayBox.TextChanged += new System.EventHandler(this.PayBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "How Much need to Pay";
            // 
            // PaymentUpdate
            // 
            this.PaymentUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PaymentUpdate.Location = new System.Drawing.Point(300, 398);
            this.PaymentUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PaymentUpdate.Name = "PaymentUpdate";
            this.PaymentUpdate.Size = new System.Drawing.Size(153, 36);
            this.PaymentUpdate.TabIndex = 54;
            this.PaymentUpdate.Text = "Update";
            this.PaymentUpdate.UseVisualStyleBackColor = false;
            this.PaymentUpdate.Click += new System.EventHandler(this.PaymentUpdate_Click);
            // 
            // StFName
            // 
            this.StFName.Location = new System.Drawing.Point(346, 129);
            this.StFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StFName.Name = "StFName";
            this.StFName.Size = new System.Drawing.Size(240, 26);
            this.StFName.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Student Name";
            // 
            // ToPay
            // 
            this.ToPay.Location = new System.Drawing.Point(346, 332);
            this.ToPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToPay.Name = "ToPay";
            this.ToPay.Size = new System.Drawing.Size(240, 26);
            this.ToPay.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Pay";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.lecturersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 33);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.listToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.studentToolStripMenuItem.Text = "Students";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCourseToolStripMenuItem});
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // newCourseToolStripMenuItem
            // 
            this.newCourseToolStripMenuItem.Name = "newCourseToolStripMenuItem";
            this.newCourseToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.newCourseToolStripMenuItem.Text = "New Course";
            this.newCourseToolStripMenuItem.Click += new System.EventHandler(this.newCourseToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.actionsToolStripMenuItem.Text = "Actions";
            this.actionsToolStripMenuItem.Click += new System.EventHandler(this.actionsToolStripMenuItem_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ToPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StFName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaymentUpdate);
            this.Controls.Add(this.PayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaidBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FNSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(820, 509);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FNSearch;
        private System.Windows.Forms.TextBox PaidBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PayBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PaymentUpdate;
        private System.Windows.Forms.TextBox StFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ToPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
    }
}
