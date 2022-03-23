using System;
using SomerenLogic;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SomerenUI
{
    public partial class ActivitiesForm : Form
    {
        public ActivitiesForm()
        {
            InitializeComponent();
        }

        private void ActivitiesForm_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception b)
            {

                throw new Exception("Problem loading the activities Form: " + b.Message);
            }

            try
            {
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
            catch (Exception a)
            {
                MessageBox.Show("Something went wrong while loading the Activities: " + a.Message);
            }
        }
    }
}
