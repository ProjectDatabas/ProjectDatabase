using System;
using SomerenLogic;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "Dashboard")
            {
                // hide all other panels
                HideAllPanelsAndComponents();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                headerLabel.Text = "Students";

                // hide all other panels
                HideAllPanelsAndComponents();
                // show students
                pnlMaster.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    // clear the listview before filling it again
                    listViewMaster.Clear();

                    listViewMaster.GridLines = true;
                    listViewMaster.View = View.Details;

                    //Add Column Header

                    listViewMaster.Columns.Add("Student Id", 150);
                    listViewMaster.Columns.Add("First Name", 150);
                    listViewMaster.Columns.Add("Last Name", 150);

                    foreach (Student s in studentList)
                    {
                        ListViewItem liId = new ListViewItem(Convert.ToString(s.Number));
                        liId.SubItems.Add(s.FirstName);
                        liId.SubItems.Add(s.LastName);
                        listViewMaster.Items.Add(liId);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Teachers")
            {
                headerLabel.Text = "Teachers";

                // hide all other panels
                HideAllPanelsAndComponents();

                // show dashboard
                pnlMaster.Show();
                try
                {
                    // fill the teacher listview within the teachers panel with a list of teachers
                    TeacherService teacherService = new TeacherService(); ;
                    List<Teacher> teachers = teacherService.GetAllTeachers(); ;

                    // clear the listview before filling it again
                    listViewMaster.Clear();

                    listViewMaster.GridLines = true;
                    listViewMaster.View = View.Details;

                    //Add Column Header

                    listViewMaster.Columns.Add("Teacher ID", 150);
                    listViewMaster.Columns.Add("Supervisor", 150);
                    listViewMaster.Columns.Add("First Name", 150);
                    listViewMaster.Columns.Add("Last Name", 150);
                    listViewMaster.Columns.Add("Room ID", 150);

                    foreach (Teacher t in teachers)
                    {
                        ListViewItem listViewItem = new ListViewItem(Convert.ToString(t.Number));
                        listViewItem.SubItems.Add(Convert.ToString((t.Supervisor)));
                        listViewItem.SubItems.Add(t.FirstName);
                        listViewItem.SubItems.Add(t.LastName);
                        listViewItem.SubItems.Add(Convert.ToString(t.RoomID));

                        listViewMaster.Items.Add(listViewItem);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Teachers: " + e.Message);
                }
            }
            else if (panelName == "Stock")
            {
                headerLabel.Text = "Stock";

                // hide all other panels
                HideAllPanelsAndComponents();
                // show students
                pnlMaster.Show();

                try
                {
                    // fill the teacher listview within the teachers panel with a list of teachers
                    DrinkService drinkService = new DrinkService(); ;
                    List<Drink> drinks = drinkService.GetAllDrinks(); ;

                    // clear the listview before filling it again
                    listViewMaster.Clear();

                    listViewMaster.GridLines = true;
                    listViewMaster.View = View.Details;

                    //Add Column Header
                    listViewMaster.Columns.Add("DrinkId", 150);
                    listViewMaster.Columns.Add("Drink", 150);
                    listViewMaster.Columns.Add("Drink Price", 150);
                    listViewMaster.Columns.Add("Stock Amount", 150);
                    listViewMaster.Columns.Add("Sufficiënt", 150);

                    foreach (Drink d in drinks)
                    {
                        ListViewItem listViewItem = new ListViewItem((d.DrinkId).ToString());
                        listViewItem.SubItems.Add(d.DrinksName);
                        listViewItem.SubItems.Add(d.DrinksPrice.ToString());
                        listViewItem.SubItems.Add(d.Stock.ToString());
                        listViewItem.SubItems.Add(d.IsSufficientStock.ToString());

                        listViewMaster.Items.Add(listViewItem);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Stock: " + e.Message);
                }
            }
        }

        private void HideAllPanelsAndComponents()
        {
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlMaster.Hide();
            ChangeStockButton.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void listViewMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewMaster.Items.Count; i++)
            {
                if (this.listViewMaster.Items[i].Selected && headerLabel.Text == "Stock")
                {
                    ChangeStockButton.Show();
                }
            }
        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Stock");
        }

        private void ChangeStockButton_Click(object sender, EventArgs e)
        {

        }
    }
}
