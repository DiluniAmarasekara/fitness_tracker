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
            panel1.Controls.Add(btnAnalytics);
            panel1.Controls.Add(btnMeal);
            panel1.Controls.Add(btnWorkout);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 450);
            panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 147);
            pnlNav.Location = new Point(1, 68);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(10, 137);
            pnlNav.TabIndex = 1;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnalytics.ForeColor = Color.FromArgb(0, 126, 147);
            btnAnalytics.Location = new Point(0, 171);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(218, 35);
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
            btnMeal.Location = new Point(0, 136);
            btnMeal.Name = "btnMeal";
            btnMeal.Size = new Size(218, 35);
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
            btnWorkout.Location = new Point(0, 101);
            btnWorkout.Name = "btnWorkout";
            btnWorkout.Size = new Size(218, 35);
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
            btnDashboard.Location = new Point(0, 66);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(218, 35);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 66);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 147);
            label2.Location = new Point(66, 35);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Tech Lead";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 147);
            label1.Location = new Point(66, 15);
            label1.Name = "label1";
            label1.Size = new Size(143, 16);
            label1.TabIndex = 1;
            label1.Text = "Diluni Amarasekara";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.LightGray;
            lblTitle.Location = new Point(224, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(83, 19);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Dashboard";
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Bottom;
            pnlFormLoader.Location = new Point(218, 35);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(582, 415);
            pnlFormLoader.TabIndex = 3;
            // 
            // buttonExit
            // 
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.LightGray;
            buttonExit.Location = new Point(765, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(35, 35);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // fitnessTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(pnlFormLoader);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fitnessTracker";
            Text = "Fitness Tracker";
            Load += fitnessTracker_Load;
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
        private Panel pnlNav;
        private Label lblTitle;
        private Panel pnlFormLoader;
        private Button buttonExit;
    }
}