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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            workoutPnlLoader = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 12);
            button1.Name = "button1";
            button1.Size = new Size(132, 32);
            button1.TabIndex = 1;
            button1.Text = "Add Workout";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(225, 12);
            button2.Name = "button2";
            button2.Size = new Size(132, 32);
            button2.TabIndex = 2;
            button2.Text = "View Workout";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(418, 12);
            button3.Name = "button3";
            button3.Size = new Size(132, 32);
            button3.TabIndex = 3;
            button3.Text = "Update Workout";
            button3.UseVisualStyleBackColor = true;
            // 
            // workoutPnlLoader
            // 
            workoutPnlLoader.Location = new Point(2, 50);
            workoutPnlLoader.Name = "workoutPnlLoader";
            workoutPnlLoader.Size = new Size(580, 364);
            workoutPnlLoader.TabIndex = 4;
            // 
            // workout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(582, 415);
            Controls.Add(workoutPnlLoader);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "workout";
            Text = "workout";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel workoutPnlLoader;
    }
}