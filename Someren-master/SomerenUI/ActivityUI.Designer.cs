namespace SomerenUI
{
    partial class ActivitiesForm
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
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.ChangeRadioButton = new System.Windows.Forms.RadioButton();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.DeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.AddLabel = new System.Windows.Forms.Label();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.pnlAreYouSure = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.pnlAreYouSure.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewActivities
            // 
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(43, 103);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(470, 360);
            this.listViewActivities.TabIndex = 0;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.SelectedIndexChanged += new System.EventHandler(this.listViewActivities_SelectedIndexChanged);
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ActivityLabel.Location = new System.Drawing.Point(37, 40);
            this.ActivityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(105, 32);
            this.ActivityLabel.TabIndex = 2;
            this.ActivityLabel.Text = "Activity";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(542, 383);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 38);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(542, 133);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 36);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Location = new System.Drawing.Point(542, 103);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(108, 24);
            this.AddRadioButton.TabIndex = 5;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "AddCheck";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(675, 138);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(169, 26);
            this.AddTextBox.TabIndex = 6;
            this.AddTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChangeRadioButton
            // 
            this.ChangeRadioButton.AutoSize = true;
            this.ChangeRadioButton.Location = new System.Drawing.Point(542, 220);
            this.ChangeRadioButton.Name = "ChangeRadioButton";
            this.ChangeRadioButton.Size = new System.Drawing.Size(135, 24);
            this.ChangeRadioButton.TabIndex = 7;
            this.ChangeRadioButton.TabStop = true;
            this.ChangeRadioButton.Text = "ChangeCheck";
            this.ChangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(542, 251);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(101, 38);
            this.ChangeButton.TabIndex = 8;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Location = new System.Drawing.Point(675, 257);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.Size = new System.Drawing.Size(169, 26);
            this.ChangeTextBox.TabIndex = 9;
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.AutoSize = true;
            this.DeleteRadioButton.Location = new System.Drawing.Point(542, 353);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(126, 24);
            this.DeleteRadioButton.TabIndex = 10;
            this.DeleteRadioButton.TabStop = true;
            this.DeleteRadioButton.Text = "DeleteCheck";
            this.DeleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Location = new System.Drawing.Point(699, 105);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(122, 20);
            this.AddLabel.TabIndex = 11;
            this.AddLabel.Text = "Add new activity";
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Location = new System.Drawing.Point(699, 224);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(116, 20);
            this.ChangeLabel.TabIndex = 12;
            this.ChangeLabel.Text = "Change activity";
            // 
            // pnlAreYouSure
            // 
            this.pnlAreYouSure.Controls.Add(this.NoButton);
            this.pnlAreYouSure.Controls.Add(this.YesButton);
            this.pnlAreYouSure.Controls.Add(this.label1);
            this.pnlAreYouSure.Location = new System.Drawing.Point(314, 182);
            this.pnlAreYouSure.Name = "pnlAreYouSure";
            this.pnlAreYouSure.Size = new System.Drawing.Size(222, 127);
            this.pnlAreYouSure.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure?";
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(31, 62);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(65, 31);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(132, 62);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(67, 31);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // ActivitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 518);
            this.Controls.Add(this.pnlAreYouSure);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.DeleteRadioButton);
            this.Controls.Add(this.ChangeTextBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ChangeRadioButton);
            this.Controls.Add(this.AddTextBox);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ActivityLabel);
            this.Controls.Add(this.listViewActivities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActivitiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activities";
            this.Load += new System.EventHandler(this.ActivitiesForm_Load);
            this.pnlAreYouSure.ResumeLayout(false);
            this.pnlAreYouSure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.RadioButton ChangeRadioButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox ChangeTextBox;
        private System.Windows.Forms.RadioButton DeleteRadioButton;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Panel pnlAreYouSure;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label label1;
    }
}