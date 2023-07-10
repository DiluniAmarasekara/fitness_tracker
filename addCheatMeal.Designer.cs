namespace fitness_tracker
{
    partial class addCheatMeal
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
            label1 = new Label();
            label3 = new Label();
            dateWorkout = new DateTimePicker();
            label4 = new Label();
            workoutId = new ComboBox();
            mealName = new TextBox();
            label5 = new Label();
            btnReset = new Button();
            btnSubmit = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cheatId = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Cheat Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 151);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Cheat Date";
            // 
            // dateWorkout
            // 
            dateWorkout.Location = new Point(128, 151);
            dateWorkout.Name = "dateWorkout";
            dateWorkout.Size = new Size(250, 27);
            dateWorkout.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 85);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 4;
            label4.Text = "Workout Id";
            // 
            // workoutId
            // 
            workoutId.FormattingEnabled = true;
            workoutId.Location = new Point(128, 82);
            workoutId.Name = "workoutId";
            workoutId.Size = new Size(151, 28);
            workoutId.TabIndex = 5;
            // 
            // mealName
            // 
            mealName.Location = new Point(128, 220);
            mealName.Name = "mealName";
            mealName.Size = new Size(125, 27);
            mealName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 223);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 7;
            label5.Text = "Meal";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(39, 358);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(205, 358);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(366, 358);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(527, 358);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // cheatId
            // 
            cheatId.FormattingEnabled = true;
            cheatId.Location = new Point(128, 21);
            cheatId.Name = "cheatId";
            cheatId.Size = new Size(151, 28);
            cheatId.TabIndex = 12;
            // 
            // addCheatMeal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(663, 485);
            Controls.Add(cheatId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(btnReset);
            Controls.Add(label5);
            Controls.Add(mealName);
            Controls.Add(workoutId);
            Controls.Add(label4);
            Controls.Add(dateWorkout);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addCheatMeal";
            Text = "addCheatMeal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DateTimePicker dateWorkout;
        private Label label4;
        private ComboBox workoutId;
        private TextBox mealName;
        private Label label5;
        private Button btnReset;
        private Button btnSubmit;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cheatId;
    }
}