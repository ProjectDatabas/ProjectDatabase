using System;
using SomerenLogic;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        private int ItemID = 0;

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
                // hide all other panels and components
                HideAllPanelsAndComponents();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                headerLabel.Text = "Students";

                // hide all other panels and components
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

                // show Stock
                pnlMaster.Show();

                EnableAndShowStockRadioButtons();

                try
                {
                    // fill the drink listview within the stock panel with a list of drinks
                    DrinkService drinkService = new DrinkService();
                    List<Drink> drinks = drinkService.GetAllDrinks();

                    // clear the listview before filling it again
                    listViewMaster.Clear();

                    listViewMaster.GridLines = true;
                    listViewMaster.View = View.Details;

                    //Add Column Header
                    listViewMaster.Columns.Add("DrinkId", 150);
                    listViewMaster.Columns.Add("Drink", 150);
                    listViewMaster.Columns.Add("Drink Price", 150);
                    listViewMaster.Columns.Add("Stock Amount", 150);
                    listViewMaster.Columns.Add("Sufficient", 150);

                    foreach (Drink d in drinks)
                    {
                        ListViewItem listViewItem = new ListViewItem((d.DrinkId).ToString());
                        listViewItem.SubItems.Add(d.DrinksName);
                        listViewItem.SubItems.Add(d.DrinksPrice.ToString());
                        listViewItem.SubItems.Add(d.Stock.ToString());
                        if (!d.IsSufficientStock)
                        {
                            listViewItem.SubItems.Add("Stock nearly depleted");
                        }
                        else
                        {
                            listViewItem.SubItems.Add("Stock sufficient");
                        }
                        listViewMaster.Items.Add(listViewItem);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Stock: " + e.Message);
                }
            }
            else if (panelName == "Drinks")
            {
                headerLabel.Text = "Drinks";

                // hide all other panels
                HideAllPanelsAndComponents();

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
                    DrinksListView.Columns.Add("Drink ID", 100);
                    DrinksListView.Columns.Add("Drink Name", 100);
                    DrinksListView.Columns.Add("Drink Price", 100);
                    DrinksListView.Columns.Add("Drink Stock", 100);

                    DrinksService drinkService = new DrinksService();
                    List<Drinks> drinksList = drinkService.GetDrinks();

                    foreach (Drinks d in drinksList)
                    {
                        ListViewItem liId = new ListViewItem(Convert.ToString(d.DrinkId));
                        liId.SubItems.Add(d.DrinkName);
                        liId.SubItems.Add(Convert.ToString(d.DrinkPrice));
                        liId.SubItems.Add(Convert.ToString(d.DrinkStock));
                        DrinksListView.Items.Add(liId);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Drinks: " + e.Message);
                }
            }
            else if(panelName == "Activities")
            {
                // hide all other panels
                HideAllPanelsAndComponents();

                //Create a new instance of the MDI child template form
                ActivitiesForm activityForm = new ActivitiesForm();

                //Set parent form for the child window
                activityForm.TopLevel = false;
                activityForm.Parent = this;


                //Set starting position
                activityForm.StartPosition = FormStartPosition.Manual;
                activityForm.Left = 100;
                activityForm.Top = 50;


                //Display the child window
                activityForm.Show();
            }
        }

        private void EnableAndShowStockRadioButtons()
        {
            ChangePriceRadioButton.Enabled = true;
            ChangeStockRadioButton.Enabled = true;
            ChangeDrinkNameRadioButton.Enabled = true;
            DeleteDrinkRadioButton.Enabled = true;

            ChangePriceRadioButton.Show();
            ChangeStockRadioButton.Show();
            ChangeDrinkNameRadioButton.Show();
            DeleteDrinkRadioButton.Show();

            NameNewDrinkTextBox.Show();
            PriceNewDrinkTextBox.Show();
            StockNewDrinkTextBox.Show();

            NameNewDrinkLabel.Show();
            PriceNewDrinkLabel.Show();
            StockNewDrinkLabel.Show();

            AddNewDrinkButton.Show();
        }

        private void HideAllPanelsAndComponents()
        {
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlMaster.Hide();
            pnlDrinks.Hide();
            pnlSupervisor.Hide();
            StockTextBoxAndButtonReset();
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
                    if (!ChangeStockRadioButton.Checked && !ChangeDrinkNameRadioButton.Checked && !ChangePriceRadioButton.Checked && !DeleteDrinkRadioButton.Checked)
                    {
                        listViewMaster.Clear();
                        showPanel("Stock");
                        MessageBox.Show("Please select an action first...");
                    }
                    if (ChangeStockRadioButton.Checked)
                    {
                        DisableRadioButtons();

                        ListViewItem item = listViewMaster.Items[i];
                        ItemID = Convert.ToInt32(item.SubItems[0].Text);

                        ChangeStockTextBox.Show();
                        ChangeStockButton.Show();
                    }
                    else if (ChangeDrinkNameRadioButton.Checked)
                    {
                        DisableRadioButtons();

                        ListViewItem item = listViewMaster.Items[i];
                        ItemID = Convert.ToInt32(item.SubItems[0].Text);

                        ChangeStockTextBox.Show();
                        ChangeDrinkNameButton.Show();
                    }
                    else if (ChangePriceRadioButton.Checked)
                    {
                        DisableRadioButtons();

                        ListViewItem item = listViewMaster.Items[i];
                        ItemID = Convert.ToInt32(item.SubItems[0].Text);

                        ChangeStockTextBox.Show();
                        ChangePriceButton.Show();
                    }
                    else if (DeleteDrinkRadioButton.Checked)
                    {
                        DisableRadioButtons();

                        ListViewItem item = listViewMaster.Items[i];
                        ItemID = Convert.ToInt32(item.SubItems[0].Text);

                        ChangeStockTextBox.Show();
                        ChangePriceButton.Show();
                    }
                }
            }
        }

        private void DisableRadioButtons()
        {
            ChangeStockRadioButton.Enabled = false;
            ChangeDrinkNameRadioButton.Enabled = false;
            ChangePriceRadioButton.Enabled = false;
            DeleteDrinkRadioButton.Enabled = false;
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

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void drinksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        //Ordering drinks
        private OrderService OD = new OrderService();

        private void StudentListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (StudentListView.SelectedItems.Count == 1)
            {
                for (int i = 0; i < StudentListView.Items.Count; i++)
                {
                    if (this.StudentListView.Items[i].Selected)
                    {
                        ListViewItem item = StudentListView.Items[i];
                        OD.student = Convert.ToInt32(item.SubItems[0].Text);
                    }
                }
            }
            else if (StudentListView.SelectedItems.Count == 2)
            {
                MessageBox.Show("Can't select multiple students");
            }
        }

        private void DrinksListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (DrinksListView.SelectedItems.Count >= 1)
            {
                for (int i = 0; i < DrinksListView.Items.Count; i++)
                {
                    if (this.DrinksListView.Items[i].Selected)
                    {
                        OD.drinksIds.Add(i + 1);
                    }
                }
            }
        }

        private void OrderButton_Click_1(object sender, EventArgs e)
        {
            Order order = new Order();
            order.StudentId = OD.student;
            order.DrinksIds = OD.drinksIds;

            int orderPrice = 0;

            foreach (int id in OD.drinksIds)
            {
                orderPrice += GetPrice(id);
            }


            MessageBox.Show($"Drink(s) ordered succesfully\nPrice {orderPrice} tickets");
            OD.SendOrder(order);

            StudentListView.Clear();
            DrinksListView.Clear();
            OD.drinksIds.Clear();
            showPanel("Drinks");
        }

        private int GetPrice(int id)
        {
            DrinksService drinkService = new DrinksService();
            List<Drinks> drinks = drinkService.GetDrinks();

            foreach(Drinks D in drinks)
            {
                if (id == D.DrinkId)
                {
                    return D.DrinkPrice;
                }
            }
            return 0;
        }

        private void changeStockTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangeStockButton.Enabled = true;
            ChangeDrinkNameButton.Enabled = true;
            ChangePriceButton.Enabled = true;
        }

        private void ChangeStockButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChangeStockTextBox.Text))
            {
                MessageBox.Show("No stock change filled in...");
                ChangeStockButton.Enabled = false;
            }
            else
            {
                DrinkService drinkService = new DrinkService();
                int stockChange = Convert.ToInt32(ChangeStockTextBox.Text);
                drinkService.ChangeStock(ItemID, stockChange);

                StockTextBoxAndButtonReset();

                listViewMaster.Clear();
                showPanel("Stock");

                MessageBox.Show($"Succesfully edited");
            }
        }

        private void ChangeDrinkNameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChangeStockTextBox.Text))
            {
                MessageBox.Show("No stock change filled in...");
                ChangeStockTextBox.Enabled = false;
            }
            else
            {
                DrinkService drinkService = new DrinkService();
                string newDrinkName = ChangeStockTextBox.Text;
                drinkService.ChangeDrinkName(ItemID, newDrinkName);

                StockTextBoxAndButtonReset();

                listViewMaster.Clear();
                showPanel("Stock");

                MessageBox.Show($"Succesfully edited");
            }
        }

        private void ChangePriceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChangeStockTextBox.Text))
            {
                MessageBox.Show("No stock change filled in...");
                ChangeStockTextBox.Enabled = false;
            }
            else
            {
                DrinkService drinkService = new DrinkService();
                int newDrinkPrice = Convert.ToInt32(ChangeStockTextBox.Text);
                drinkService.ChangeDrinkPrice(ItemID, newDrinkPrice);

                StockTextBoxAndButtonReset();

                listViewMaster.Clear();
                showPanel("Stock");

                MessageBox.Show($"Succesfully edited");
            }
        }

        private void StockTextBoxAndButtonReset()
        {
            ChangeStockTextBox.Clear();
            ChangeStockTextBox.Hide();

            ChangeDrinkNameButton.Enabled = false;
            ChangeDrinkNameButton.Hide();

            ChangePriceButton.Enabled = false;
            ChangePriceButton.Hide();

            ChangeStockButton.Enabled = false;
            ChangeStockButton.Hide();

            ChangeStockRadioButton.Checked = false;
            ChangeDrinkNameRadioButton.Checked = false;
            ChangePriceRadioButton.Checked = false;
            DeleteDrinkRadioButton.Checked = false;

            ChangeStockRadioButton.Hide();
            ChangeDrinkNameRadioButton.Hide();
            ChangePriceRadioButton.Hide();

            NameNewDrinkTextBox.Clear();
            PriceNewDrinkTextBox.Clear();
            StockNewDrinkTextBox.Clear();

            NameNewDrinkTextBox.Hide();
            PriceNewDrinkTextBox.Hide();
            StockNewDrinkTextBox.Hide();

            NameNewDrinkLabel.Hide();
            PriceNewDrinkLabel.Hide();
            StockNewDrinkLabel.Hide();

            AddNewDrinkButton.Hide();

            
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Cleared Succesfully");

            OD.drinksIds.Clear();
            StudentListView.Clear();
            DrinksListView.Clear();
            showPanel("Drinks");
        }

        private void AddNewDrinkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameNewDrinkTextBox.Text) && string.IsNullOrWhiteSpace(PriceNewDrinkTextBox.Text) && string.IsNullOrWhiteSpace(StockNewDrinkTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields before pressing 'Add New Drink'");
                
                StockTextBoxAndButtonReset();

                showPanel("Stock");
            }
            else
            {

                string newDrinkName = NameNewDrinkTextBox.Text;
                int newDrinkPrice = Convert.ToInt32(PriceNewDrinkTextBox.Text);
                int newDrinkStock = Convert.ToInt32(StockNewDrinkTextBox.Text);

                DrinkService drinkService = new DrinkService();
                drinkService.AddNewDrink(newDrinkName, newDrinkPrice, newDrinkStock);

                StockTextBoxAndButtonReset();

                listViewMaster.Clear();
                showPanel("Stock");

                MessageBox.Show($"Succesfully Added!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            drinkService.SetToTen();

            StockTextBoxAndButtonReset();
            listViewMaster.Clear();
            showPanel($"{headerLabel.Text}");
        }

        private void DeleteDrinkButton_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            drinkService.DeleteDrink(ItemID);

            StockTextBoxAndButtonReset();

            listViewMaster.Clear();
            showPanel("Stock");

            MessageBox.Show($"Succesfully deleted!");
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void supervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Supervisors");
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
