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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label3 = new Label();
            dateCheat = new DateTimePicker();
            label4 = new Label();
            workoutId = new ComboBox();
            calories = new TextBox();
            label5 = new Label();
            btnReset = new Button();
            btnSubmit = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cheatId = new ComboBox();
            errorProviderCm = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderCm).BeginInit();
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
            // dateCheat
            // 
            dateCheat.Location = new Point(128, 151);
            dateCheat.Name = "dateCheat";
            dateCheat.Size = new Size(250, 27);
            dateCheat.TabIndex = 3;
            dateCheat.Validating += dateWorkout_Validating;
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
            workoutId.Validating += workoutId_Validating;
            // 
            // calories
            // 
            calories.Location = new Point(128, 220);
            calories.Name = "calories";
            calories.Size = new Size(125, 27);
            calories.TabIndex = 6;
            calories.Validating += calories_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 223);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 7;
            label5.Text = "Calories";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(39, 358);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(205, 358);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(366, 358);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(527, 358);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cheatId
            // 
            cheatId.FormattingEnabled = true;
            cheatId.Location = new Point(128, 21);
            cheatId.Name = "cheatId";
            cheatId.Size = new Size(151, 28);
            cheatId.TabIndex = 12;
            // 
            // errorProviderCm
            // 
            errorProviderCm.ContainerControl = this;
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
            Controls.Add(calories);
            Controls.Add(workoutId);
            Controls.Add(label4);
            Controls.Add(dateCheat);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addCheatMeal";
            Text = "addCheatMeal";
            Load += addCheatMeal_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderCm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DateTimePicker dateCheat;
        private Label label4;
        private ComboBox workoutId;
        private TextBox calories;
        private Label label5;
        private Button btnReset;
        private Button btnSubmit;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cheatId;
        private ErrorProvider errorProviderCm;
    }
}