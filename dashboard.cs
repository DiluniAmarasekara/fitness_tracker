using fitness_tracker.models;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace fitness_tracker
{
    public partial class dashboard : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public dashboard()
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cn.Open();
            InitializeComponent();
            loadData();
            calculateBmi();
        }

        private void calculateBmi()
        {
            string[] parts = height.Text.Split('.');
            int feet = int.Parse(parts[0]);
            int inches = int.Parse(parts[1]);
            int totalInches = feet * 12 + inches;
            double meters = totalInches * 0.0254;
            double currentBMI = double.Parse(weight.Text) / (meters * meters);

            if (currentBMI < 18.5)
            {
                bmiPred.Text = "Underweight";
                panelBmi.BackColor = Color.OrangeRed;
            }
            else if (currentBMI >= 18.5 && currentBMI < 25)
            {
                bmiPred.Text = "Normal weight";
                panelBmi.BackColor = Color.Green;
            }
            else if (currentBMI >= 25 && currentBMI < 30)
            {
                bmiPred.Text = "Overweight";
                panelBmi.BackColor = Color.Orange;
            }
            else
            {
                bmiPred.Text = "Obese";
                panelBmi.BackColor = Color.Red;
            }

        }

        private void loadData()
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from goal", cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            goalId.Text = dt.Rows[0]["goal_id"].ToString();
            age.Text = dt.Rows[0]["age"].ToString();
            height.Text = dt.Rows[0]["current_height"].ToString();
            weight.Text = dt.Rows[0]["current_weight"].ToString();
            bmi.Text = dt.Rows[0]["bmi"].ToString();
            purpose.Text = dt.Rows[0]["purpose"].ToString();
            goalWeight.Text = dt.Rows[0]["goal_weight"].ToString();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);

            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cn.Open();

            cmd = new SqlCommand("update goal set current_weight=@current_weight where goal_id=@goal_id", cn);
            cmd.Parameters.AddWithValue("current_weight", todayWeight.Text);
            cmd.Parameters.AddWithValue("goal_id", goalId.Text);
            cmd.ExecuteNonQuery();

            DateTimePicker dateTimePicker = new DateTimePicker();
            DateTime n = DateTime.Now;

            cmd = new SqlCommand("insert into weight values(@log_date, @log_weight, @goal_id)", cn);
            cmd.Parameters.AddWithValue("log_date", DateTime.Now);
            cmd.Parameters.AddWithValue("log_weight", todayWeight.Text);
            cmd.Parameters.AddWithValue("goal_id", goalId.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Today weight has been added!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetComponents();
        }

        private void resetComponents()
        {
            loadData();
            todayWeight.Clear();
            calculateBmi();
        }

        private void todayWeight_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(todayWeight.Text))
            {
                e.Cancel = true;
                todayWeight.Focus();
                errorProviderDash.SetError(todayWeight, "Please add the weight!");
            }
            else
            {
                e.Cancel = false;
                errorProviderDash.SetError(todayWeight, "");
            }
        }
    }
}
