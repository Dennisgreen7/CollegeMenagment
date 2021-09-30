namespace CollegeManagment
{
    partial class CoursesActions
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
            this.CourseBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.NOLBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FNSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseBox
            // 
            this.CourseBox.FormattingEnabled = true;
            this.CourseBox.Items.AddRange(new object[] {
            ".Net core",
            "OOP",
            "Core",
            "CSS",
            "HTML"});
            this.CourseBox.Location = new System.Drawing.Point(356, 169);
            this.CourseBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(240, 28);
            this.CourseBox.TabIndex = 44;
            this.CourseBox.Tag = "";
            this.CourseBox.SelectedIndexChanged += new System.EventHandler(this.CourseBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Course Name";
            // 
            // DateBox
            // 
            this.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBox.Location = new System.Drawing.Point(356, 225);
            this.DateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(240, 26);
            this.DateBox.TabIndex = 46;
            this.DateBox.ValueChanged += new System.EventHandler(this.DateBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Starting Date";
            // 
            // NOLBox
            // 
            this.NOLBox.Location = new System.Drawing.Point(356, 288);
            this.NOLBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NOLBox.Name = "NOLBox";
            this.NOLBox.Size = new System.Drawing.Size(240, 26);
            this.NOLBox.TabIndex = 48;
            this.NOLBox.TextChanged += new System.EventHandler(this.IdBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Number Of Lessons";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Save.Location = new System.Drawing.Point(677, 386);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(88, 36);
            this.Save.TabIndex = 60;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Delete.Location = new System.Drawing.Point(565, 386);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(106, 36);
            this.Delete.TabIndex = 59;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Add.Location = new System.Drawing.Point(474, 386);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 36);
            this.Add.TabIndex = 58;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(21, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 36);
            this.button1.TabIndex = 57;
            this.button1.Text = "Search By Name";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FNSearch
            // 
            this.FNSearch.Location = new System.Drawing.Point(172, 386);
            this.FNSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FNSearch.Multiline = true;
            this.FNSearch.Name = "FNSearch";
            this.FNSearch.Size = new System.Drawing.Size(240, 35);
            this.FNSearch.TabIndex = 56;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.payementsToolStripMenuItem});
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
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.actionsToolStripMenuItem.Text = "Actions";
            this.actionsToolStripMenuItem.Click += new System.EventHandler(this.actionsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
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
            this.newCourseToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.newCourseToolStripMenuItem.Text = "New Course";
            this.newCourseToolStripMenuItem.Click += new System.EventHandler(this.newCourseToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // payementsToolStripMenuItem
            // 
            this.payementsToolStripMenuItem.Name = "payementsToolStripMenuItem";
            this.payementsToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.payementsToolStripMenuItem.Text = "Payements";
            this.payementsToolStripMenuItem.Click += new System.EventHandler(this.payementsToolStripMenuItem_Click);
            // 
            // CoursesActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FNSearch);
            this.Controls.Add(this.NOLBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CoursesActions";
            this.Size = new System.Drawing.Size(820, 509);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CourseBox;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NOLBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FNSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payementsToolStripMenuItem;
    }
}
