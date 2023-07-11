using fitness_tracker.models;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fitness_tracker
{
    public partial class addCheatMeal : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        List<WorkoutSchedule> workoutItems = new List<WorkoutSchedule>();
        List<CheatMeals> cheatmealItems = new List<CheatMeals>();
        int eventFlag = 1;
        public addCheatMeal(int buttonFlag)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");

            InitializeComponent();
            workoutIds_Load(con);

            if (buttonFlag == 1)
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                cheatId.Enabled = false;
                cheatId_Load(con);
            }
            else if (buttonFlag == 2)
            {
                eventFlag = 2;
                btnDelete.Visible = false;
                btnSubmit.Visible = false;
                cheatIds_Load(con);
            }
            else if (buttonFlag == 3)
            {
                eventFlag = 3;
                btnUpdate.Visible = false;
                btnSubmit.Visible = false;

                cheatIds_Load(con);
                workoutId.Enabled = false;
                dateCheat.Enabled = false;
                calories.Enabled = false;
            }
        }

        private void cheatId_Load(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from cheat_meal", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cheatId.Items.Add(dt.Rows.Count + 1);
            cheatId.SelectedIndex = 0;
        }

        private void cheatIds_Load(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from cheat_meal", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cheatId.Items.Add(dt.Rows[i]["cheat_id"].ToString());

                string format = "M/d/yyyy h:mm:ss tt";
                CheatMeals cheatmealObj = new CheatMeals((Int64)dt.Rows[i]["cheat_id"],
                    DateTime.ParseExact(dt.Rows[i]["date_of_cheat"].ToString(), format, CultureInfo.InvariantCulture),
                    dt.Rows[i]["meal"].ToString(), (Int64)dt.Rows[i]["workout_id"]);
                cheatmealItems.Add(cheatmealObj);
            }
        }

        private void workoutIds_Load(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from workout", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                workoutId.Items.Add(dt.Rows[i]["workout_id"].ToString());

                string format = "M/d/yyyy h:mm:ss tt";
                WorkoutSchedule workoutObj = new WorkoutSchedule((Int64)dt.Rows[i]["workout_id"], dt.Rows[i]["workout_name"].ToString(),
                    DateTime.ParseExact(dt.Rows[i]["from_date"].ToString(), format, CultureInfo.InvariantCulture),
                    DateTime.ParseExact(dt.Rows[i]["to_date"].ToString(), format, CultureInfo.InvariantCulture), (Int64)dt.Rows[i]["goal_id"]);
                workoutItems.Add(workoutObj);
            }
        }

        private void addCheatMeal_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void workoutId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(workoutId.Text))
            {
                e.Cancel = true;
                workoutId.Focus();
                errorProviderCm.SetError(workoutId, "Please choose the Workout!");
            }
            else
            {
                e.Cancel = false;
                errorProviderCm.SetError(workoutId, "");
            }
        }

        private void dateWorkout_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateCheat.Text))
            {
                e.Cancel = true;
                dateCheat.Focus();
                errorProviderCm.SetError(dateCheat, "Please choose the cheat meal day!");
            }
            else
            {
                e.Cancel = false;
                errorProviderCm.SetError(dateCheat, "");
            }
        }

        private void calories_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(calories.Text))
            {
                e.Cancel = true;
                calories.Focus();
                errorProviderCm.SetError(calories, "Please add the calories!");
            }
            else
            {
                e.Cancel = false;
                errorProviderCm.SetError(calories, "");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);

            long cheatMealNo = cheatmealItems.FirstOrDefault(i => i.getCheatId() == cheatId.SelectedIndex + 1).getCheatId();
            long workoutNo = workoutItems.FirstOrDefault(i => i.getWorkoutId() == workoutId.SelectedIndex + 1).getWorkoutId();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cmd = new SqlCommand("update cheat_meal set date_of_cheat=@date_of_cheat, meal=@meal, workout_id=@workout_id where cheat_id=@cheat_id", cn);
            cmd.Parameters.AddWithValue("date_of_cheat", Convert.ToDateTime(dateCheat.Value));
            cmd.Parameters.AddWithValue("meal", calories.Text);
            cmd.Parameters.AddWithValue("workout_id", workoutNo);
            cmd.Parameters.AddWithValue("cheat_id", cheatMealNo);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Your cheatmeal has been updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetComponents();
        }

        private void resetComponents()
        {
            this.Controls.Clear();
            addCheatMeal ResetCheatMeal = new addCheatMeal(eventFlag) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ResetCheatMeal.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(ResetCheatMeal);
            ResetCheatMeal.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);
            long workoutNo = workoutItems.FirstOrDefault(i => i.getWorkoutId() == workoutId.SelectedIndex + 1).getWorkoutId();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cmd = new SqlCommand("insert into cheat_meal values(@date_of_cheat, @meal, @workout_id)", cn);
            cmd.Parameters.AddWithValue("date_of_cheat", Convert.ToDateTime(dateCheat.Value));
            cmd.Parameters.AddWithValue("meal", calories.Text);
            cmd.Parameters.AddWithValue("workout_id", workoutNo);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Your cheatmeal has been added!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetComponents();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetComponents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from cheat_meal where cheat_id=@cheat_id", cn);
            cmd.Parameters.AddWithValue("cheat_id", cheatId.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Your cheatmeal has been deleted!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetComponents();
        }

        private void cheatId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventFlag == 2 || eventFlag == 3)
            {
                CheatMeals cheatMealObj = cheatmealItems.FirstOrDefault(i => i.getCheatId() == cheatId.SelectedIndex + 1);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from cheat_meal where cheat_id=@cheat_id", con);
                cmd.Parameters.AddWithValue("cheat_id", cheatId.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                workoutId.SelectedIndex = (int)cheatMealObj.getWorkoutId() - 1;
                calories.Text = cheatMealObj.getCalories();
                dateCheat.Value = cheatMealObj.getDateOfCheat();
            }
        }
    }
}
