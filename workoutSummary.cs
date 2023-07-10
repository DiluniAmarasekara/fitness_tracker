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

namespace fitness_tracker
{
    public partial class workoutSummary : Form
    {
        private DataSet dtSet;
        public workoutSummary()
        {
            InitializeComponent();
        }

        private void workoutSummary_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from workout", con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Workout");
            dataGridView1.DataSource = ds.Tables["Workout"].DefaultView;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select e.exercise_name, e.reps from exercise e left join workout_exercise we on e.exercise_id=we.exercise_id where we.workout_id=@workout_id", con);
            cmd.Parameters.AddWithValue("workout_id", e.RowIndex+1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Excecises");
            dataGridView2.DataSource = ds.Tables["Excecises"].DefaultView;
        }
    }
}
