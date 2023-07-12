using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fitness_tracker.models;
using System.Windows.Forms.DataVisualization.Charting;

namespace fitness_tracker
{
    public partial class predictions : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        Dictionary<Int64, Weight> weightMap = new Dictionary<Int64, Weight>();
        List<Weight> itemWeights = new List<Weight>();

        public predictions()
        {
            InitializeComponent();
            load_weightData();
            predictionsForWeight();
        }

        private void load_weightData()
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from weight", cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string format = "M/d/yyyy h:mm:ss tt";
                Weight weightObj = new Weight((Int64)dt.Rows[i]["weight_id"], DateTime.ParseExact(dt.Rows[i]["log_date"].ToString(), format, CultureInfo.InvariantCulture), (double)dt.Rows[i]["log_weight"]);
                itemWeights.Add(weightObj);
            }
            weightMap = itemWeights.ToDictionary(weight => weight.getweightId());

        }

        private void predictionsForWeight()
        {
            // Assuming you have a list of weight observations with corresponding time points
            List<Int64> timePoints = new List<Int64>(weightMap.Keys);
            List<double> weights = new List<double>();

            foreach (KeyValuePair<Int64, Weight> pair in weightMap)
            {
                weights.Add(pair.Value.getLogWeight());
            }

            // Predict future weight values
            List<int> futureTimePoints = Enumerable.Range(timePoints.Count, timePoints.Count + 50).ToList();
            List<double> predictedWeights = PredictWeights(weights, timePoints, futureTimePoints);

            // Create and configure a Chart control
            Chart chart = new Chart();
            chart.Size = new Size(641, 396);

            // Create a new series for observed weights
            Series observedSeries = new Series("Observed");
            observedSeries.ChartType = SeriesChartType.Line;
            observedSeries.Color = Color.Blue;

            // Add observed weight data points to the series
            for (int i = 0; i < timePoints.Count; i++)
            {
                observedSeries.Points.AddXY(timePoints[i], weights[i]);
                observedSeries.Points[i].MarkerStyle = MarkerStyle.Circle; // Set the marker style
                observedSeries.Points[i].MarkerColor = Color.Blue; // Set the marker color
            }

            // Create a new series for predicted weights
            Series predictedSeries = new Series("Predicted");
            predictedSeries.ChartType = SeriesChartType.Line;
            predictedSeries.Color = Color.Red;

            // Add predicted weight data points to the series
            for (int i = 0; i < futureTimePoints.Count; i++)
            {
                predictedSeries.Points.AddXY(futureTimePoints[i], predictedWeights[i]);
                predictedSeries.Points[i].MarkerStyle = MarkerStyle.Circle; // Set the marker style
                predictedSeries.Points[i].MarkerColor = Color.Red; // Set the marker color
            }

            // Add the series to the chart
            chart.Series.Add(observedSeries);
            chart.Series.Add(predictedSeries);

            // Set chart properties
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Days";
            chartArea.AxisY.Title = "Weight (Kg)";
            chart.ChartAreas.Add(chartArea);

            // Show the chart in a panel control
            panelChart.Controls.Add(chart);

            predictFutureHealthStatus(predictedWeights[0], predictedWeights[predictedWeights.Count - 1]);
        }

        private void predictFutureHealthStatus(double first, double last)
        {
            if (first <= last)
            {
                labelInsight.Text = "You do not have any progress in your weight loss journey.\nPlan your workouts and cheat meals. Good luck!";
            }
            else
            {
                labelInsight.Text = "You have a progress in your weight loss journey. Keep it up!";
            }
        }

        private void predictions_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        static List<double> PredictWeights(List<double> weights, List<Int64> timePoints, List<int> futureTimePoints)
        {
            // Perform linear regression
            double[] x = timePoints.Select(Convert.ToDouble).ToArray();
            double[] y = weights.ToArray();

            double sumX = x.Sum();
            double sumY = y.Sum();
            double sumXY = x.Zip(y, (a, b) => a * b).Sum();
            double sumXX = x.Zip(x, (a, b) => a * b).Sum();
            double n = weights.Count;

            double slope = (n * sumXY - sumX * sumY) / (n * sumXX - sumX * sumX);
            double intercept = (sumY - slope * sumX) / n;

            // Predict the weights at future time points using the regression equation
            List<double> predictedWeights = new List<double>();
            foreach (int futureTimePoint in futureTimePoints)
            {
                double predictedWeight = intercept + slope * futureTimePoint;
                predictedWeights.Add(predictedWeight);
            }
            return predictedWeights;
        }

    }
}
