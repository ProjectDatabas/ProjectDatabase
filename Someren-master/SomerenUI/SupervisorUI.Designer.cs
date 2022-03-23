
namespace SomerenUI
{
    partial class SupervisorUI
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
            this.SupervisorsLabel = new System.Windows.Forms.Label();
            this.ActivitiesLabel = new System.Windows.Forms.Label();
            this.ActivityListView = new System.Windows.Forms.ListView();
            this.SupervisorListView = new System.Windows.Forms.ListView();
            this.AddSupervisorButton = new System.Windows.Forms.Button();
            this.AddSupervisorRadioButton = new System.Windows.Forms.RadioButton();
            this.RemoveSupervisorRadioButton = new System.Windows.Forms.RadioButton();
            this.RemoveSupervisorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SupervisorsLabel
            // 
            this.SupervisorsLabel.AutoSize = true;
            this.SupervisorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupervisorsLabel.Location = new System.Drawing.Point(464, 62);
            this.SupervisorsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SupervisorsLabel.Name = "SupervisorsLabel";
            this.SupervisorsLabel.Size = new System.Drawing.Size(216, 42);
            this.SupervisorsLabel.TabIndex = 0;
            this.SupervisorsLabel.Text = "Supervisors";
            // 
            // ActivitiesLabel
            // 
            this.ActivitiesLabel.AutoSize = true;
            this.ActivitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivitiesLabel.Location = new System.Drawing.Point(148, 62);
            this.ActivitiesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ActivitiesLabel.Name = "ActivitiesLabel";
            this.ActivitiesLabel.Size = new System.Drawing.Size(165, 42);
            this.ActivitiesLabel.TabIndex = 1;
            this.ActivitiesLabel.Text = "Activities";
            // 
            // ActivityListView
            // 
            this.ActivityListView.FullRowSelect = true;
            this.ActivityListView.HideSelection = false;
            this.ActivityListView.Location = new System.Drawing.Point(124, 118);
            this.ActivityListView.Name = "ActivityListView";
            this.ActivityListView.Size = new System.Drawing.Size(217, 494);
            this.ActivityListView.TabIndex = 2;
            this.ActivityListView.UseCompatibleStateImageBehavior = false;
            // 
            // SupervisorListView
            // 
            this.SupervisorListView.FullRowSelect = true;
            this.SupervisorListView.HideSelection = false;
            this.SupervisorListView.Location = new System.Drawing.Point(471, 118);
            this.SupervisorListView.Name = "SupervisorListView";
            this.SupervisorListView.Size = new System.Drawing.Size(861, 487);
            this.SupervisorListView.TabIndex = 3;
            this.SupervisorListView.UseCompatibleStateImageBehavior = false;
            // 
            // AddSupervisorButton
            // 
            this.AddSupervisorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddSupervisorButton.Location = new System.Drawing.Point(155, 650);
            this.AddSupervisorButton.Name = "AddSupervisorButton";
            this.AddSupervisorButton.Size = new System.Drawing.Size(158, 85);
            this.AddSupervisorButton.TabIndex = 4;
            this.AddSupervisorButton.Text = "Add Supervisor";
            this.AddSupervisorButton.UseVisualStyleBackColor = true;
            // 
            // AddSupervisorRadioButton
            // 
            this.AddSupervisorRadioButton.AutoSize = true;
            this.AddSupervisorRadioButton.Location = new System.Drawing.Point(319, 661);
            this.AddSupervisorRadioButton.Name = "AddSupervisorRadioButton";
            this.AddSupervisorRadioButton.Size = new System.Drawing.Size(190, 29);
            this.AddSupervisorRadioButton.TabIndex = 5;
            this.AddSupervisorRadioButton.TabStop = true;
            this.AddSupervisorRadioButton.Text = "Add Supervisor";
            this.AddSupervisorRadioButton.UseVisualStyleBackColor = true;
            // 
            // RemoveSupervisorRadioButton
            // 
            this.RemoveSupervisorRadioButton.AutoSize = true;
            this.RemoveSupervisorRadioButton.Location = new System.Drawing.Point(319, 696);
            this.RemoveSupervisorRadioButton.Name = "RemoveSupervisorRadioButton";
            this.RemoveSupervisorRadioButton.Size = new System.Drawing.Size(231, 29);
            this.RemoveSupervisorRadioButton.TabIndex = 6;
            this.RemoveSupervisorRadioButton.TabStop = true;
            this.RemoveSupervisorRadioButton.Text = "Remove Supervisor";
            this.RemoveSupervisorRadioButton.UseVisualStyleBackColor = true;
            // 
            // RemoveSupervisorButton
            // 
            this.RemoveSupervisorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemoveSupervisorButton.Location = new System.Drawing.Point(155, 650);
            this.RemoveSupervisorButton.Name = "RemoveSupervisorButton";
            this.RemoveSupervisorButton.Size = new System.Drawing.Size(158, 85);
            this.RemoveSupervisorButton.TabIndex = 7;
            this.RemoveSupervisorButton.Text = "Remove Supervisor";
            this.RemoveSupervisorButton.UseVisualStyleBackColor = true;
            // 
            // SupervisorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 804);
            this.Controls.Add(this.RemoveSupervisorButton);
            this.Controls.Add(this.RemoveSupervisorRadioButton);
            this.Controls.Add(this.AddSupervisorRadioButton);
            this.Controls.Add(this.AddSupervisorButton);
            this.Controls.Add(this.SupervisorListView);
            this.Controls.Add(this.ActivityListView);
            this.Controls.Add(this.ActivitiesLabel);
            this.Controls.Add(this.SupervisorsLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SupervisorUI";
            this.Text = "SupervisorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SupervisorsLabel;
        private System.Windows.Forms.Label ActivitiesLabel;
        private System.Windows.Forms.ListView ActivityListView;
        private System.Windows.Forms.ListView SupervisorListView;
        private System.Windows.Forms.Button AddSupervisorButton;
        private System.Windows.Forms.RadioButton AddSupervisorRadioButton;
        private System.Windows.Forms.RadioButton RemoveSupervisorRadioButton;
        private System.Windows.Forms.Button RemoveSupervisorButton;
    }
}