
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
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SupervisorsLabel
            // 
            this.SupervisorsLabel.AutoSize = true;
            this.SupervisorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupervisorsLabel.Location = new System.Drawing.Point(180, 13);
            this.SupervisorsLabel.Name = "SupervisorsLabel";
            this.SupervisorsLabel.Size = new System.Drawing.Size(109, 24);
            this.SupervisorsLabel.TabIndex = 0;
            this.SupervisorsLabel.Text = "Supervisors";
            // 
            // ActivitiesLabel
            // 
            this.ActivitiesLabel.AutoSize = true;
            this.ActivitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivitiesLabel.Location = new System.Drawing.Point(22, 13);
            this.ActivitiesLabel.Name = "ActivitiesLabel";
            this.ActivitiesLabel.Size = new System.Drawing.Size(82, 24);
            this.ActivitiesLabel.TabIndex = 1;
            this.ActivitiesLabel.Text = "Activities";
            // 
            // ActivityListView
            // 
            this.ActivityListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ActivityListView.FullRowSelect = true;
            this.ActivityListView.HideSelection = false;
            this.ActivityListView.Location = new System.Drawing.Point(10, 42);
            this.ActivityListView.Margin = new System.Windows.Forms.Padding(2);
            this.ActivityListView.Name = "ActivityListView";
            this.ActivityListView.Size = new System.Drawing.Size(110, 259);
            this.ActivityListView.TabIndex = 2;
            this.ActivityListView.UseCompatibleStateImageBehavior = false;
            this.ActivityListView.SelectedIndexChanged += new System.EventHandler(this.ActivityListView_SelectedIndexChanged);
            // 
            // SupervisorListView
            // 
            this.SupervisorListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SupervisorListView.FullRowSelect = true;
            this.SupervisorListView.HideSelection = false;
            this.SupervisorListView.Location = new System.Drawing.Point(184, 42);
            this.SupervisorListView.Margin = new System.Windows.Forms.Padding(2);
            this.SupervisorListView.Name = "SupervisorListView";
            this.SupervisorListView.Size = new System.Drawing.Size(432, 255);
            this.SupervisorListView.TabIndex = 3;
            this.SupervisorListView.UseCompatibleStateImageBehavior = false;
            this.SupervisorListView.SelectedIndexChanged += new System.EventHandler(this.SupervisorListView_SelectedIndexChanged);
            // 
            // AddSupervisorButton
            // 
            this.AddSupervisorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddSupervisorButton.Location = new System.Drawing.Point(26, 319);
            this.AddSupervisorButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddSupervisorButton.Name = "AddSupervisorButton";
            this.AddSupervisorButton.Size = new System.Drawing.Size(79, 44);
            this.AddSupervisorButton.TabIndex = 4;
            this.AddSupervisorButton.Text = "Add Supervisor";
            this.AddSupervisorButton.UseVisualStyleBackColor = true;
            this.AddSupervisorButton.Click += new System.EventHandler(this.AddSupervisorButton_Click);
            // 
            // AddSupervisorRadioButton
            // 
            this.AddSupervisorRadioButton.AutoSize = true;
            this.AddSupervisorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddSupervisorRadioButton.Location = new System.Drawing.Point(108, 324);
            this.AddSupervisorRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddSupervisorRadioButton.Name = "AddSupervisorRadioButton";
            this.AddSupervisorRadioButton.Size = new System.Drawing.Size(97, 17);
            this.AddSupervisorRadioButton.TabIndex = 5;
            this.AddSupervisorRadioButton.TabStop = true;
            this.AddSupervisorRadioButton.Text = "Add Supervisor";
            this.AddSupervisorRadioButton.UseVisualStyleBackColor = true;
            // 
            // RemoveSupervisorRadioButton
            // 
            this.RemoveSupervisorRadioButton.AutoSize = true;
            this.RemoveSupervisorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemoveSupervisorRadioButton.Location = new System.Drawing.Point(108, 343);
            this.RemoveSupervisorRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveSupervisorRadioButton.Name = "RemoveSupervisorRadioButton";
            this.RemoveSupervisorRadioButton.Size = new System.Drawing.Size(118, 17);
            this.RemoveSupervisorRadioButton.TabIndex = 6;
            this.RemoveSupervisorRadioButton.TabStop = true;
            this.RemoveSupervisorRadioButton.Text = "Remove Supervisor";
            this.RemoveSupervisorRadioButton.UseVisualStyleBackColor = true;
            // 
            // RemoveSupervisorButton
            // 
            this.RemoveSupervisorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemoveSupervisorButton.Location = new System.Drawing.Point(26, 319);
            this.RemoveSupervisorButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveSupervisorButton.Name = "RemoveSupervisorButton";
            this.RemoveSupervisorButton.Size = new System.Drawing.Size(79, 44);
            this.RemoveSupervisorButton.TabIndex = 7;
            this.RemoveSupervisorButton.Text = "Remove Supervisor";
            this.RemoveSupervisorButton.UseVisualStyleBackColor = true;
            this.RemoveSupervisorButton.Click += new System.EventHandler(this.RemoveSupervisorButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ResetButton.Location = new System.Drawing.Point(535, 314);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(79, 44);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SupervisorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 6F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 375);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RemoveSupervisorRadioButton);
            this.Controls.Add(this.AddSupervisorRadioButton);
            this.Controls.Add(this.SupervisorListView);
            this.Controls.Add(this.ActivityListView);
            this.Controls.Add(this.ActivitiesLabel);
            this.Controls.Add(this.SupervisorsLabel);
            this.Controls.Add(this.RemoveSupervisorButton);
            this.Controls.Add(this.AddSupervisorButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.125F);
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
        private System.Windows.Forms.Button ResetButton;
    }
}