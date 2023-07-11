namespace fitness_tracker
{
    partial class fitnessTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fitnessTracker));
            panel1 = new Panel();
            pnlNav = new Panel();
            btnReport = new Button();
            btnAnalytics = new Button();
            btnMeal = new Button();
            btnWorkout = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            pnlFormLoader = new Panel();
            buttonExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnAnalytics);
            panel1.Controls.Add(btnMeal);
            panel1.Controls.Add(btnWorkout);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 600);
            panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 147);
            pnlNav.Location = new Point(1, 88);
            pnlNav.Margin = new Padding(3, 4, 3, 4);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(11, 235);
            pnlNav.TabIndex = 2;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.FromArgb(0, 126, 147);
            btnReport.Location = new Point(0, 276);
            btnReport.Margin = new Padding(3, 4, 3, 4);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(249, 47);
            btnReport.TabIndex = 5;
            btnReport.Text = "Reports";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            btnReport.Leave += btnReport_Leave;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnalytics.ForeColor = Color.FromArgb(0, 126, 147);
            btnAnalytics.Location = new Point(0, 229);
            btnAnalytics.Margin = new Padding(3, 4, 3, 4);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(249, 47);
            btnAnalytics.TabIndex = 4;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += btnAnalytics_Click;
            btnAnalytics.Leave += btnAnalytics_Leave;
            // 
            // btnMeal
            // 
            btnMeal.Dock = DockStyle.Top;
            btnMeal.FlatAppearance.BorderSize = 0;
            btnMeal.FlatStyle = FlatStyle.Flat;
            btnMeal.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeal.ForeColor = Color.FromArgb(0, 126, 147);
            btnMeal.Location = new Point(0, 182);
            btnMeal.Margin = new Padding(3, 4, 3, 4);
            btnMeal.Name = "btnMeal";
            btnMeal.Size = new Size(249, 47);
            btnMeal.TabIndex = 3;
            btnMeal.Text = "Cheat Meal";
            btnMeal.UseVisualStyleBackColor = true;
            btnMeal.Click += btnMeal_Click;
            btnMeal.Leave += btnMeal_Leave;
            // 
            // btnWorkout
            // 
            btnWorkout.Dock = DockStyle.Top;
            btnWorkout.FlatAppearance.BorderSize = 0;
            btnWorkout.FlatStyle = FlatStyle.Flat;
            btnWorkout.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnWorkout.ForeColor = Color.FromArgb(0, 126, 147);
            btnWorkout.Location = new Point(0, 135);
            btnWorkout.Margin = new Padding(3, 4, 3, 4);
            btnWorkout.Name = "btnWorkout";
            btnWorkout.Size = new Size(249, 47);
            btnWorkout.TabIndex = 2;
            btnWorkout.Text = "Workout";
            btnWorkout.UseVisualStyleBackColor = true;
            btnWorkout.Click += btnWorkout_Click;
            btnWorkout.Leave += btnWorkout_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 147);
            btnDashboard.Location = new Point(0, 88);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(249, 47);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Leave += btnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 88);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 147);
            label2.Location = new Point(75, 47);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Tech Lead";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 147);
            label1.Location = new Point(75, 20);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 1;
            label1.Text = "Diluni Amarasekara";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.LightGray;
            lblTitle.Location = new Point(256, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 24);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Dashboard";
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Bottom;
            pnlFormLoader.Location = new Point(249, 47);
            pnlFormLoader.Margin = new Padding(3, 4, 3, 4);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(665, 553);
            pnlFormLoader.TabIndex = 3;
            // 
            // buttonExit
            // 
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.LightGray;
            buttonExit.Location = new Point(874, 0);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(40, 47);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // fitnessTracker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(914, 600);
            Controls.Add(buttonExit);
            Controls.Add(pnlFormLoader);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fitnessTracker";
            Text = "Fitness Tracker";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnDashboard;
        private Button btnAnalytics;
        private Button btnMeal;
        private Button btnWorkout;
        private Panel pnlNav1;
        private Label lblTitle;
        private Panel pnlFormLoader;
        private Button buttonExit;
        private Button btnReport;
        private Panel pnlNav;
    }
}