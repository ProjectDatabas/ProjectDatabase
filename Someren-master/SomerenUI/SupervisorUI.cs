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
        }

        private void LoadListViews()
        {
            throw new NotImplementedException();
        }
       
        private void ReloadAll()
        {
            ActivityListView.Clear();
            SupervisorListView.Clear();

            LoadListViews();

            AddSupervisorRadioButton.Checked = false;
            RemoveSupervisorRadioButton.Checked = false;

            AddSupervisorButton.Hide();
            RemoveSupervisorButton.Hide();
        }
        
        private void ActivityListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ActivityListView.Items.Count; i++)
            {
                if (!AddSupervisorRadioButton.Checked && !RemoveSupervisorRadioButton.Checked)
                {
                    ReloadAll();
                    MessageBox.Show("Please select an action first...");
                }
                else if (AddSupervisorRadioButton.Checked)
                {
                    AddSupervisorRadioButton.Enabled = false;
                    RemoveSupervisorRadioButton.Enabled = false;

                    AddSupervisorButton.Show();

                    if (ActivityListView.SelectedItems.Count >= 1 && SupervisorListView.SelectedItems.Count >= 1)
                    {
                        AddSupervisorButton.Enabled = true;
                    }
                }
                else if (RemoveSupervisorRadioButton.Checked)
                {
                    AddSupervisorRadioButton.Enabled = false;
                    RemoveSupervisorRadioButton.Enabled = false;

                    RemoveSupervisorButton.Show();

                    if (ActivityListView.SelectedItems.Count >= 1 && SupervisorListView.SelectedItems.Count >= 1)
                    {
                        AddSupervisorButton.Enabled = true;
                    }
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
                }
                else if (AddSupervisorRadioButton.Checked)
                {
                    AddSupervisorRadioButton.Enabled = false;
                    RemoveSupervisorRadioButton.Enabled = false;

                    AddSupervisorButton.Show();

                    if (ActivityListView.SelectedItems.Count >= 1 && SupervisorListView.SelectedItems.Count >= 1)
                    {
                        AddSupervisorButton.Enabled = true;
                    }
                }
                else if (RemoveSupervisorRadioButton.Checked)
                {
                    AddSupervisorRadioButton.Enabled = false;
                    RemoveSupervisorRadioButton.Enabled = false;

                    RemoveSupervisorButton.Show();

                    if (ActivityListView.SelectedItems.Count >= 1 && SupervisorListView.SelectedItems.Count >= 1)
                    {
                        AddSupervisorButton.Enabled = true;
                    }
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ReloadAll();
        }
    }
}
