namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.listViewMaster = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.DrinksListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderDrinks = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgDashboard
            // 
            this.imgDashboard.Location = new System.Drawing.Point(705, 0);
            this.imgDashboard.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(350, 332);
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            this.imgDashboard.Click += new System.EventHandler(this.imgDashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.drinksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1443, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 50);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 50);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(94, 50);
            this.lecturersToolStripMenuItem.Text = "Teachers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.teachersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 50);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(84, 50);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(78, 50);
            this.drinksToolStripMenuItem.Text = "Drinks";
            this.drinksToolStripMenuItem.Click += new System.EventHandler(this.drinksToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lbl_Dashboard);
            this.pnlDashboard.Controls.Add(this.imgDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(18, 42);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1407, 717);
            this.pnlDashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(20, 20);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(275, 20);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMaster
            // 
            this.pnlMaster.Controls.Add(this.listViewMaster);
            this.pnlMaster.Controls.Add(this.pictureBox1);
            this.pnlMaster.Controls.Add(this.headerLabel);
            this.pnlMaster.Location = new System.Drawing.Point(18, 42);
            this.pnlMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(1407, 717);
            this.pnlMaster.TabIndex = 8;
            // 
            // listViewMaster
            // 
            this.listViewMaster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMaster.HideSelection = false;
            this.listViewMaster.Location = new System.Drawing.Point(24, 65);
            this.listViewMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewMaster.Name = "listViewMaster";
            this.listViewMaster.Size = new System.Drawing.Size(1147, 470);
            this.listViewMaster.TabIndex = 5;
            this.listViewMaster.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date of Birth";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1208, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(15, 15);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(151, 39);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Students";
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.OrderButton);
            this.pnlDrinks.Controls.Add(this.StudentListView);
            this.pnlDrinks.Controls.Add(this.DrinksListView);
            this.pnlDrinks.Controls.Add(this.HeaderDrinks);
            this.pnlDrinks.Location = new System.Drawing.Point(18, 42);
            this.pnlDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(1407, 717);
            this.pnlDrinks.TabIndex = 9;
            // 
            // DrinksListView
            // 
            this.DrinksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.DrinksListView.HideSelection = false;
            this.DrinksListView.Location = new System.Drawing.Point(554, 65);
            this.DrinksListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DrinksListView.Name = "DrinksListView";
            this.DrinksListView.Size = new System.Drawing.Size(690, 378);
            this.DrinksListView.TabIndex = 5;
            this.DrinksListView.UseCompatibleStateImageBehavior = false;
            this.DrinksListView.SelectedIndexChanged += new System.EventHandler(this.DrinksListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of Birth";
            // 
            // HeaderDrinks
            // 
            this.HeaderDrinks.AutoSize = true;
            this.HeaderDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderDrinks.Location = new System.Drawing.Point(15, 15);
            this.HeaderDrinks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderDrinks.Name = "HeaderDrinks";
            this.HeaderDrinks.Size = new System.Drawing.Size(114, 39);
            this.HeaderDrinks.TabIndex = 3;
            this.HeaderDrinks.Text = "Drinks";
            this.HeaderDrinks.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(672, 473);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(473, 88);
            this.OrderButton.TabIndex = 7;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date of Birth";
            // 
            // StudentListView
            // 
            this.StudentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.StudentListView.HideSelection = false;
            this.StudentListView.Location = new System.Drawing.Point(22, 65);
            this.StudentListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StudentListView.Name = "StudentListView";
            this.StudentListView.Size = new System.Drawing.Size(462, 378);
            this.StudentListView.TabIndex = 6;
            this.StudentListView.UseCompatibleStateImageBehavior = false;
            this.StudentListView.SelectedIndexChanged += new System.EventHandler(this.StudentListView_SelectedIndexChanged);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 777);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.pnlMaster);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlMaster.ResumeLayout(false);
            this.pnlMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDrinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.ListView listViewMaster;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.ListView DrinksListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label HeaderDrinks;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.ListView StudentListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

