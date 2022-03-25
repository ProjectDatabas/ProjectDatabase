using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SupervisorUI : Form
    {
        public SupervisorUI()
        {
            InitializeComponent();
            ReloadAll();
        }

        private void LoadListViews()
        {
            try
            {
                LoadActivities();
            }
            catch (Exception a)
            {
                MessageBox.Show("Something went wrong while loading the Activities: " + a.Message);
            }

            try
            {
                LoadTeachers();
            }
            catch (Exception a)
            {
                MessageBox.Show("Something went wrong while loading the Teachers: " + a.Message);
            }
        }

        private void LoadTeachers()
        {
            // fill the teacher listview within the teachers panel with a list of teachers
            TeacherService teacherService = new TeacherService(); ;
            List<Teacher> teachers = teacherService.GetAllTeachers(); ;

            // clear the listview before filling it again
            SupervisorListView.Clear();

            SupervisorListView.GridLines = true;
            SupervisorListView.View = View.Details;

            //Add Column Header

            SupervisorListView.Columns.Add("Teacher ID", 150);
            SupervisorListView.Columns.Add("Supervisor", 150);

            foreach (Teacher t in teachers)
            {
                ListViewItem listViewItem = new ListViewItem(Convert.ToString(t.FullName));
                listViewItem.SubItems.Add($"{t.IsSupervisor(1)}");

                SupervisorListView.Items.Add(listViewItem);
            }
        }

        private void LoadTeachersByActivityID(int ActivityID)
        {
            //Fill the teacher listview within the teachers panel with a list of teachers
            TeacherService teacherService = new TeacherService(); ;
            List<Teacher> teachers = teacherService.GetAllTeachers(); ;

            //Clear the listview before filling it again
            SupervisorListView.Clear();

            SupervisorListView.GridLines = true;
            SupervisorListView.View = View.Details;

            //Add Column Header
            SupervisorListView.Columns.Add("Teacher ID", 150);
            SupervisorListView.Columns.Add("Supervisor", 150);

            foreach (Teacher t in teachers)
            {
                ListViewItem listViewItem = new ListViewItem(Convert.ToString(t.FullName));
                listViewItem.SubItems.Add($"{t.IsSupervisor(ActivityID)}");

                SupervisorListView.Items.Add(listViewItem);
            }
        }

        private void LoadActivities()
        {
            //activities
            ActivityService activityService = new ActivityService();
            List<Activity> activityList = activityService.GetActivities();

            // clear the listview before filling it again
            ActivityListView.Clear();

            ActivityListView.GridLines = true;
            ActivityListView.View = View.Details;
            ActivityListView.FullRowSelect = true;

            //Add Column Header
            ActivityListView.Columns.Add("Activity ID", 100);
            ActivityListView.Columns.Add("Activity", 150);

            foreach (Activity A in activityList)
            {
                ListViewItem listViewItem = new ListViewItem(Convert.ToString(A.ActivityId));
                listViewItem.SubItems.Add(Convert.ToString(A.ActivityName));
                ActivityListView.Items.Add(listViewItem);
            }
        }

        private void ReloadAll()
        {
            ActivityListView.Clear();
            SupervisorListView.Clear();

            LoadListViews();

            AddSupervisorRadioButton.Checked = false;
            RemoveSupervisorRadioButton.Checked = false;

            AddSupervisorRadioButton.Enabled = true;
            RemoveSupervisorRadioButton.Enabled = true;

            AddSupervisorButton.Hide();
            RemoveSupervisorButton.Hide();

            AddSupervisorButton.Enabled = false;
            RemoveSupervisorButton.Enabled = false;

            AddSupervisorButton.Hide();
            RemoveSupervisorButton.Hide();
        }
        
        private void ActivityListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The selected activity loads the Supervisors
            for (int i = 0; i < ActivityListView.Items.Count; i++)
            {
                if (ActivityListView.Items[i].Selected == true)
                {
                    ListViewItem item = ActivityListView.Items[i];
                    int ActivityID = Convert.ToInt32(item.SubItems[0].Text);
                    LoadTeachersByActivityID(ActivityID);
                }
            }
        }

        private void SupervisorListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SupervisorListView.Items.Count; i++)
            {
                if (!AddSupervisorRadioButton.Checked && !RemoveSupervisorRadioButton.Checked)
                {
                    ReloadAll();
                    MessageBox.Show("Please select an action first...");
                    return;
                }
                else if (AddSupervisorRadioButton.Checked)
                {
                    AddSupervisorRadioButton.Enabled = false;
                    RemoveSupervisorRadioButton.Enabled = false;

                    AddSupervisorButton.Show();

                    if (SupervisorListView.SelectedItems.Count >= 1)
                    {
                        AddSupervisorButton.Enabled = true;
                    }
                }
                else if (RemoveSupervisorRadioButton.Checked)
                {
                    AddSupervisorRadioButton.Enabled = false;
                    RemoveSupervisorRadioButton.Enabled = false;

                    RemoveSupervisorButton.Show();

                    if (SupervisorListView.SelectedItems.Count >= 1)
                    {
                        RemoveSupervisorButton.Enabled = true;
                    }
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void AddSupervisorButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveSupervisorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
