using System;
using SomerenLogic;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SomerenUI
{
    public partial class ActivitiesForm : Form
    {
        private int ItemID = -1;
        public ActivitiesForm()
        {
            InitializeComponent();
        }

        private void ActivitiesForm_Load(object sender, EventArgs e)
        {
            EnableAndShowRadioButtons();

            try
            {
                LoadList();
            }
            catch (Exception a)
            {
                MessageBox.Show("Something went wrong while loading the Activities: " + a.Message);
            }
        }

        private void LoadList()
        {
            pnlAreYouSure.Hide();
            //activities
            ActivityService activityService = new ActivityService();
            List<Activity> activityList = activityService.GetActivities();

            // clear the listview before filling it again
            listViewActivities.Clear();

            listViewActivities.GridLines = true;
            listViewActivities.View = View.Details;
            listViewActivities.FullRowSelect = true;

            //Add Column Header
            listViewActivities.Columns.Add("ActivityId", 150);
            listViewActivities.Columns.Add("Activity", 150);

            foreach (Activity A in activityList)
            {
                ListViewItem listViewItem = new ListViewItem((A.ActivityId).ToString());
                listViewItem.SubItems.Add(A.ActivityName);
                listViewActivities.Items.Add(listViewItem);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddTextBox.Text))
            {
                MessageBox.Show("Please fill in field before pressing 'Add'");

                LoadList();
            }
            else
            {

                string newActivity = AddTextBox.Text;

                ActivityService activityService = new ActivityService();
                List<Activity> activities = activityService.GetActivities();
                foreach(Activity A in activities)
                {
                    if (A.ActivityName.ToLower() == newActivity.ToLower())
                    {
                        MessageBox.Show("Invalid, acitvity already exists.");
                        AddTextBox.Clear();
                        listViewActivities.Clear();
                        LoadList();
                        return;
                    }
                }

                activityService.AddNewActivity(newActivity);
                AddTextBox.Clear();
                listViewActivities.Clear();
                LoadList();

                MessageBox.Show($"Succesfully Added!");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (ItemID == -1)
            {
                MessageBox.Show("Select an item");
                ItemID = -1;
                listViewActivities.Clear();
                LoadList();
            }
            else 
            { 
                pnlAreYouSure.Show(); 
            }
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewActivities.Items.Count; i++)
            {
                if (this.listViewActivities.Items[i].Selected)
                {
                    ListViewItem item = listViewActivities.Items[i];
                    ItemID = Convert.ToInt32(item.SubItems[0].Text);

                    if (ItemID == -1)
                    {
                        MessageBox.Show("Select an item");
                    }
                }
            }
        }

        private void EnableAndShowRadioButtons()
        {
            AddTextBox.Show();
            ChangeTextBox.Show();

            AddLabel.Show();
            ChangeLabel.Show();

            AddButton.Show();
            ChangeButton.Show();
            DeleteButton.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            ActivityService activityService = new ActivityService();
            activityService.DeleteActivity(ItemID);

            listViewActivities.Clear();
            LoadList();

            MessageBox.Show($"Succesfully deleted!");
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            ItemID = -1;
            LoadList();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChangeTextBox.Text))
            {
                MessageBox.Show("Please fill in field before pressing 'Change'");

                LoadList();
                ItemID = -1;
            }
            else if (ItemID == -1)
            {
                ChangeTextBox.Clear();
                MessageBox.Show("Please select an item");
            }
            else
            {

                string newActivity = ChangeTextBox.Text;
                ActivityService activityService = new ActivityService();
                List<Activity> activities = activityService.GetActivities();
                foreach (Activity A in activities)
                {
                    if (A.ActivityName.ToLower() == newActivity.ToLower())
                    {
                        MessageBox.Show("Invalid, acitvity already exists.");
                        ChangeTextBox.Clear();
                        listViewActivities.Clear();
                        LoadList();
                        return;
                    }
                }


                activityService.ChangeActivity(newActivity, ItemID);

                listViewActivities.Clear();
                LoadList();

                MessageBox.Show($"Succesfully changed!");
                ItemID = -1;
                ChangeTextBox.Clear();
            }
            
        }
    }
}
