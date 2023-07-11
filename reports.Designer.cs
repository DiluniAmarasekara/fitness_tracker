namespace fitness_tracker
{
    partial class report
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
            dataGridTable = new DataGridView();
            dateFrom = new DateTimePicker();
            dateTo = new DateTimePicker();
            selectCombo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSearch = new Button();
            btnDownload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTable).BeginInit();
            SuspendLayout();
            // 
            // dataGridTable
            // 
            dataGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTable.Location = new Point(12, 133);
            dataGridTable.Name = "dataGridTable";
            dataGridTable.RowHeadersWidth = 51;
            dataGridTable.RowTemplate.Height = 29;
            dataGridTable.Size = new Size(641, 238);
            dataGridTable.TabIndex = 0;
            // 
            // dateFrom
            // 
            dateFrom.Location = new Point(94, 22);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(188, 27);
            dateFrom.TabIndex = 1;
            // 
            // dateTo
            // 
            dateTo.Location = new Point(94, 73);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(188, 27);
            dateTo.TabIndex = 2;
            // 
            // selectCombo
            // 
            selectCombo.FormattingEnabled = true;
            selectCombo.Items.AddRange(new object[] { "Workout", "Exercise", "Cheat Meal", "Weight" });
            selectCombo.Location = new Point(459, 24);
            selectCombo.Name = "selectCombo";
            selectCombo.Size = new Size(151, 28);
            selectCombo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 26);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Select Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 24);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 5;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 73);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 6;
            label3.Text = "To";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(459, 74);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(459, 397);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(151, 48);
            btnDownload.TabIndex = 8;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(665, 553);
            Controls.Add(btnDownload);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(selectCombo);
            Controls.Add(dateTo);
            Controls.Add(dateFrom);
            Controls.Add(dataGridTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "report";
            Text = "reports";
            ((System.ComponentModel.ISupportInitialize)dataGridTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridTable;
        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private ComboBox selectCombo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSearch;
        private Button btnDownload;
    }
}