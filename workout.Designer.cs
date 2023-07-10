namespace fitness_tracker
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
            btnAdd.Location = new Point(176, 16);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Workout";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(14, 16);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(151, 43);
            btnView.TabIndex = 2;
            btnView.Text = "View Workout";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(338, 16);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 43);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Workout";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // wkPnlLoader
            // 
            wkPnlLoader.Location = new Point(2, 67);
            wkPnlLoader.Margin = new Padding(3, 4, 3, 4);
            wkPnlLoader.Name = "wkPnlLoader";
            wkPnlLoader.Size = new Size(663, 485);
            wkPnlLoader.TabIndex = 4;
            wkPnlLoader.Paint += workoutPnlLoader_Paint;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(501, 16);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 43);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Workout";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // workout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(665, 553);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(wkPnlLoader);
            Controls.Add(btnUpdate);
            Controls.Add(btnView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "workout";
            Text = "workout";
            Load += workout_Load;
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