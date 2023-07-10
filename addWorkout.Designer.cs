namespace fitness_tracker
{
    partial class addWorkout
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
            label4 = new Label();
            dateFrom = new DateTimePicker();
            dateTo = new DateTimePicker();
            label5 = new Label();
            checkedListExercise = new CheckedListBox();
            btnSubmit = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            goalName = new ComboBox();
            workoutId = new ComboBox();
            btnReset = new Button();
            btnDelete = new Button();
            errorProviderWk = new ErrorProvider(components);
            label6 = new Label();
            workoutName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProviderWk).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Workout Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 75);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 133);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Exercise";
            // 
            // dateFrom
            // 
            dateFrom.Location = new Point(446, 75);
            dateFrom.Margin = new Padding(3, 4, 3, 4);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(205, 27);
            dateFrom.TabIndex = 4;
            // 
            // dateTo
            // 
            dateTo.Location = new Point(446, 133);
            dateTo.Margin = new Padding(3, 4, 3, 4);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(205, 27);
            dateTo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 133);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 5;
            label5.Text = "To";
            // 
            // checkedListExercise
            // 
            checkedListExercise.FormattingEnabled = true;
            checkedListExercise.Location = new Point(117, 133);
            checkedListExercise.Margin = new Padding(3, 4, 3, 4);
            checkedListExercise.Name = "checkedListExercise";
            checkedListExercise.Size = new Size(137, 114);
            checkedListExercise.TabIndex = 7;
            checkedListExercise.SelectedIndexChanged += checkedListExercise_SelectedIndexChanged;
            checkedListExercise.Validating += checkedListExercise_Validating;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(219, 339);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 31);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(337, 339);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 10;
            label2.Text = "Goal";
            // 
            // goalName
            // 
            goalName.FormattingEnabled = true;
            goalName.Location = new Point(115, 68);
            goalName.Margin = new Padding(3, 4, 3, 4);
            goalName.Name = "goalName";
            goalName.Size = new Size(138, 28);
            goalName.TabIndex = 11;
            goalName.Validating += goalName_Validating;
            // 
            // workoutId
            // 
            workoutId.FormattingEnabled = true;
            workoutId.Location = new Point(115, 12);
            workoutId.Margin = new Padding(3, 4, 3, 4);
            workoutId.Name = "workoutId";
            workoutId.Size = new Size(138, 28);
            workoutId.TabIndex = 12;
            workoutId.SelectedIndexChanged += workoutId_SelectedIndexChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(100, 339);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(457, 339);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // errorProviderWk
            // 
            errorProviderWk.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 16);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 15;
            label6.Text = "Workout Name";
            // 
            // workoutName
            // 
            workoutName.Location = new Point(446, 13);
            workoutName.Name = "workoutName";
            workoutName.Size = new Size(125, 27);
            workoutName.TabIndex = 16;
            // 
            // addWorkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(663, 485);
            Controls.Add(workoutName);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(workoutId);
            Controls.Add(goalName);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(checkedListExercise);
            Controls.Add(dateTo);
            Controls.Add(label5);
            Controls.Add(dateFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "addWorkout";
            Text = "addWorkout";
            Load += addWorkout_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderWk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private Label label5;
        private CheckedListBox checkedListExercise;
        private Button btnSubmit;
        private Button btnUpdate;
        private Label label2;
        private ComboBox goalName;
        private ComboBox workoutId;
        private Button btnReset;
        private Button btnDelete;
        private ErrorProvider errorProviderWk;
        private TextBox workoutName;
        private Label label6;
    }
}