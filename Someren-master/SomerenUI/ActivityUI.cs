using System;
using SomerenLogic;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SomerenUI
{
    public partial class ActivitiesForm : Form
    {
        private int ItemID = 0;
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
            if (string.IsNullOrWhiteSpace(AddTextBox.Text) || !AddRadioButton.Checked)
            {
                MessageBox.Show("Please fill in field before pressing 'Add'");

                AddRadioButton.Checked = false;

                LoadList();
            }
            else
            {

                string newActivity = AddTextBox.Text;

                ActivityService activityService = new ActivityService();
                activityService.AddNewActivity(newActivity);

                AddRadioButton.Checked = false;

                AddTextBox.Clear();
                listViewActivities.Clear();
                LoadList();

                MessageBox.Show($"Succesfully Added!");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            pnlAreYouSure.Show();
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewActivities.Items.Count; i++)
            {
                if (this.listViewActivities.Items[i].Selected)
                {
                    if (!AddRadioButton.Checked && !ChangeRadioButton.Checked && !DeleteRadioButton.Checked)
                    {
                        listViewActivities.Clear();
                        LoadList();
                        AddButton.Show();
                        AddTextBox.Show();
                        AddLabel.Show();
                        MessageBox.Show("Please select an action first...");
                    }
                    else if (ChangeRadioButton.Checked)
                    {
                        ListViewItem item = listViewActivities.Items[i];
                        ItemID = Convert.ToInt32(item.SubItems[0].Text);
                    }
                    else if (DeleteRadioButton.Checked)
                    {
                        ListViewItem item = listViewActivities.Items[i];
                        ItemID = Convert.ToInt32(item.SubItems[0].Text);
                    }
                }
            }
        }

        private void EnableAndShowRadioButtons()
        {
            AddRadioButton.Enabled = true;
            ChangeRadioButton.Enabled = true;
            DeleteRadioButton.Enabled = true;

            AddRadioButton.Show();
            ChangeRadioButton.Show();
            DeleteRadioButton.Show();

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

            DeleteRadioButton.Checked = false;

            listViewActivities.Clear();
            LoadList();

            MessageBox.Show($"Succesfully deleted!");
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DeleteRadioButton.Checked = false;
            LoadList();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string newActivity = ChangeTextBox.Text;
            ActivityService activityService = new ActivityService();
            activityService.ChangeActivity(newActivity, ItemID);

            ChangeRadioButton.Checked = false;

            listViewActivities.Clear();
            LoadList();

            MessageBox.Show($"Succesfully changed!");
        }
    }
}
