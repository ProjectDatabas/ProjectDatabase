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
                pnlMaster.Hide();
                pnlDrinks.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                headerLabel.Text = "Students";

                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlDrinks.Hide();

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
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlDrinks.Hide();

                // show dashboard
                pnlMaster.Show();
                try
                {
                    // fill the students listview within the students panel with a list of students
                    TeacherService lecturerService = new TeacherService(); ;
                    List<Teacher> teachers = lecturerService.GetAllTeachers(); ;

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
            else if (panelName == "Drinks")
            {
                headerLabel.Text = "Drinks";

                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlMaster.Hide();

                // show dashboard
                pnlDrinks.Show();

                try
                {
                    //students
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService();
                    List<Student> studentList = studService.GetStudents();

                    // clear the listview before filling it again
                    StudentListView.Clear();

                    StudentListView.GridLines = true;
                    StudentListView.View = View.Details;
                    StudentListView.FullRowSelect = true;

                    //Add Column Header
                    StudentListView.Columns.Add("Student ID", 150);
                    StudentListView.Columns.Add("Student Name", 150);

                    foreach (Student s in studentList)
                    {
                        ListViewItem liId = new ListViewItem(Convert.ToString(s.Number));
                        liId.SubItems.Add(s.FullName);
                        StudentListView.Items.Add(liId);
                    }

                    //drinks
                    // clear the listview before filling it again
                    DrinksListView.Clear();

                    DrinksListView.GridLines = true;
                    DrinksListView.View = View.Details;
                    DrinksListView.FullRowSelect = true;

                    //Add Column Header
                    DrinksListView.Columns.Add("Drink ID", 150);
                    DrinksListView.Columns.Add("Drink Name", 150);
                    DrinksListView.Columns.Add("Alcoholic", 150);

                    DrinksService drinkService = new DrinksService();
                    List<Drinks> drinksList = drinkService.GetDrinks();

                    foreach (Drinks d in drinksList)
                    {
                        ListViewItem liId = new ListViewItem(Convert.ToString(d.DrinkId));
                        liId.SubItems.Add(d.DrinkName);
                        liId.SubItems.Add(Convert.ToString(d.IsAlcoholic));
                        //liId.SubItems.Add(d.IsAlcoholic);
                        DrinksListView.Items.Add(liId);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Drinks: " + e.Message);
                }
            }

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

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Ordering drinks
        private int IndexOfStudent;
        private int IndexOfDrink;

        private void OrderButton_Click(object sender, EventArgs e)
        {
            StudentService studService = new StudentService();
            List<Student> studentList = studService.GetStudents();

            DrinksService drinkService = new DrinksService();
            List<Drinks> drinksList = drinkService.GetDrinks();

            


            MessageBox.Show($"{IndexOfDrink} {IndexOfStudent}");
            //MessageBox.Show($"Drink ordered succesfully \n {studentList[IndexOfStudent].FullName} {drinksList[IndexOfDrink].DrinkName}");
        }

        private void DrinksListView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
