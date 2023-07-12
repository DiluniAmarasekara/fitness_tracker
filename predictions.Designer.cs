namespace fitness_tracker
{
    partial class predictions
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
            panelChart = new Panel();
            labelInsight = new Label();
            SuspendLayout();
            // 
            // panelChart
            // 
            panelChart.Location = new Point(12, 85);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(641, 396);
            panelChart.TabIndex = 0;
            // 
            // labelInsight
            // 
            labelInsight.AutoSize = true;
            labelInsight.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelInsight.ForeColor = Color.Gray;
            labelInsight.Location = new Point(12, 20);
            labelInsight.Name = "labelInsight";
            labelInsight.Size = new Size(65, 21);
            labelInsight.TabIndex = 1;
            labelInsight.Text = "Insights";
            // 
            // predictions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(665, 553);
            Controls.Add(labelInsight);
            Controls.Add(panelChart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "predictions";
            Text = "Predictions";
            Load += predictions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelChart;
        private Label labelInsight;
    }
}