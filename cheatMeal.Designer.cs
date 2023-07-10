namespace fitness_tracker
{
    partial class cheatMeal
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
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnView = new Button();
            cmPnlLoader = new Panel();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(502, 16);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 43);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Cheat Meals";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(177, 16);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 43);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Cheat Meals";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(339, 16);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Cheat Meals";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(15, 16);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(151, 43);
            btnView.TabIndex = 7;
            btnView.Text = "View Cheat Meals";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // cmPnlLoader
            // 
            cmPnlLoader.Location = new Point(1, 67);
            cmPnlLoader.Margin = new Padding(3, 4, 3, 4);
            cmPnlLoader.Name = "cmPnlLoader";
            cmPnlLoader.Size = new Size(663, 485);
            cmPnlLoader.TabIndex = 10;
            // 
            // cheatMeal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(665, 553);
            Controls.Add(cmPnlLoader);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "cheatMeal";
            Text = "cheatMeal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnView;
        private Panel cmPnlLoader;
    }
}