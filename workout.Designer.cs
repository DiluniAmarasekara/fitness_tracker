﻿namespace fitness_tracker
{
    partial class workout
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
            btnAdd = new Button();
            btnView = new Button();
            btnUpdate = new Button();
            wkPnlLoader = new Panel();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(154, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 32);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Workout";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(12, 12);
            btnView.Name = "btnView";
            btnView.Size = new Size(132, 32);
            btnView.TabIndex = 2;
            btnView.Text = "View Workout";
            btnView.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(296, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 32);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Workout";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // wkPnlLoader
            // 
            wkPnlLoader.Location = new Point(2, 50);
            wkPnlLoader.Name = "wkPnlLoader";
            wkPnlLoader.Size = new Size(580, 364);
            wkPnlLoader.TabIndex = 4;
            wkPnlLoader.Paint += workoutPnlLoader_Paint;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(438, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 32);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Workout";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // workout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(582, 415);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(wkPnlLoader);
            Controls.Add(btnUpdate);
            Controls.Add(btnView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "workout";
            Text = "workout";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Button btnView;
        private Button btnUpdate;
        private Panel wkPnlLoader;
        private Button btnDelete;
    }
}