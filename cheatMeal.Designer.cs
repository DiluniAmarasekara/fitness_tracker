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
            btnDelete.Location = new Point(439, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 32);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Cheat Meals";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(155, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 32);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Cheat Meals";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(297, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 32);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Cheat Meals";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(13, 12);
            btnView.Name = "btnView";
            btnView.Size = new Size(132, 32);
            btnView.TabIndex = 7;
            btnView.Text = "View Cheat Meals";
            btnView.UseVisualStyleBackColor = true;
            // 
            // cmPnlLoader
            // 
            cmPnlLoader.Location = new Point(1, 50);
            cmPnlLoader.Name = "cmPnlLoader";
            cmPnlLoader.Size = new Size(580, 364);
            cmPnlLoader.TabIndex = 10;
            // 
            // cheatMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(582, 415);
            Controls.Add(cmPnlLoader);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnView);
            FormBorderStyle = FormBorderStyle.None;
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