using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fitness_tracker.models;
using System.Globalization;
using System.Security.Cryptography;
using System.Diagnostics;

namespace fitness_tracker
{
    public partial class addWorkout : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        List<Exercise> exerciseItems = new List<Exercise>();
        List<Goal> goalItems = new List<Goal>();
        List<WorkoutSchedule> workoutItems = new List<WorkoutSchedule>();
        int eventFlag = 1;

        public addWorkout(int buttonFlag)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            InitializeComponent();

            checklist_Load(con);
            goalId_Load(con);

            if (buttonFlag == 1)
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                workoutId.Enabled = false;
                workoutId_Load(con);
            }
            else if (buttonFlag == 2)
            {
                eventFlag = 2;
                btnDelete.Visible = false;
                btnSubmit.Visible = false;
                workLoadIds_Load(con);
            }
            else if (buttonFlag == 3)
            {
                eventFlag = 3;
                btnUpdate.Visible = false;
                btnSubmit.Visible = false;
                workLoadIds_Load(con);
            }
        }

        private void goalId_Load(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from goal", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Goal goal = new Goal((Int64)dt.Rows[i]["goal_id"], dt.Rows[i]["purpose"].ToString(), (int)dt.Rows[i]["age"], (double)dt.Rows[i]["current_height"],
                    (double)dt.Rows[i]["current_weight"], (double)dt.Rows[i]["bmi"], (double)dt.Rows[i]["goal_weight"]);
                goalItems.Add(goal);
                goalName.Items.Add(dt.Rows[i]["purpose"].ToString());
            }
        }

        private void workoutId_Load(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from workout", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            workoutId.Items.Add(dt.Rows.Count + 1);
            workoutId.SelectedIndex = 0;
        }

        private void workLoadIds_Load(SqlConnection con)
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

        private void checklist_Load(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from exercise", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Exercise exsercise = new Exercise((Int64)dt.Rows[i]["exercise_id"], dt.Rows[i]["exercise_name"].ToString(), (int)dt.Rows[i]["reps"]);
                exerciseItems.Add(exsercise);
                checkedListExercise.Items.Add(dt.Rows[i]["exercise_name"]);

            }
        }

        private void addWorkout_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);

            long goalId = goalItems.FirstOrDefault(i => i.getPurpose() == goalName.Text).getGoalId();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cmd = new SqlCommand("insert into workout values(@from_date, @to_date, @workout_name, @goal_id)", cn);
            cmd.Parameters.AddWithValue("from_date", Convert.ToDateTime(dateFrom.Value));
            cmd.Parameters.AddWithValue("to_date", Convert.ToDateTime(dateTo.Value));
            cmd.Parameters.AddWithValue("workout_name", workoutName.Text);
            cmd.Parameters.AddWithValue("goal_id", goalId);
            cmd.ExecuteNonQuery();

            List<Exercise> itemsSelected = new List<Exercise>();

            exerciseItems.ForEach(ex =>
            {
                if (checkedListExercise.CheckedItems.Contains(ex.getExerciseName()))
                {
                    itemsSelected.Add(ex);
                }
            });

            itemsSelected.ForEach((ex) =>
            {
                cmd = new SqlCommand("insert into workout_exercise values(@workout_id, @exercise_id)", cn);
                cmd.Parameters.AddWithValue("exercise_id", ex.getExerciseId());
                cmd.Parameters.AddWithValue("workout_id", workoutId.Text);
                cmd.ExecuteNonQuery();
            });
            MessageBox.Show("Your workout plan has been added!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkedListExercise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void goalName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(goalName.Text))
            {
                e.Cancel = true;
                goalName.Focus();
                errorProviderWk.SetError(goalName, "Please choose the Goal!");
            }
            else
            {
                e.Cancel = false;
                errorProviderWk.SetError(goalName, "");
            }
        }

        private void checkedListExercise_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(checkedListExercise.Text))
            {
                e.Cancel = true;
                checkedListExercise.Focus();
                errorProviderWk.SetError(checkedListExercise, "Please choose the Goal!");
            }
            else
            {
                e.Cancel = false;
                errorProviderWk.SetError(checkedListExercise, "");
            }
        }

        private void workoutId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventFlag == 2)
            {
                WorkoutSchedule workoutSchedule = workoutItems.FirstOrDefault(i => i.getWorkoutId() == workoutId.SelectedIndex + 1);
                Goal goal = goalItems.FirstOrDefault(i => i.getGoalId() == workoutSchedule.getGoalId());

                for (int i = 0; i < checkedListExercise.CheckedIndices.Count; i++)
                {
                    checkedListExercise.SetItemChecked(checkedListExercise.CheckedIndices[i], false);
                }

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select e.exercise_name, e.reps from exercise e left join workout_exercise we on e.exercise_id=we.exercise_id where we.workout_id=@workout_id", con);
                cmd.Parameters.AddWithValue("workout_id", workoutId.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int index = checkedListExercise.FindStringExact(dt.Rows[i]["exercise_name"].ToString());
                    checkedListExercise.SetItemChecked(index, true);
                }
                goalName.SelectedIndex = (int)goal.getGoalId() - 1;
                workoutName.Text = workoutSchedule.getWorkoutName();
                dateFrom.Value = workoutSchedule.getFromDate();
                dateTo.Value = workoutSchedule.getToDate();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);

            long goalId = goalItems.FirstOrDefault(i => i.getPurpose() == goalName.Text).getGoalId();
            long workoutScheId = workoutItems.FirstOrDefault(i => i.getWorkoutId() == workoutId.SelectedIndex + 1).getWorkoutId();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cmd = new SqlCommand("update workout set from_date=@from_date, to_date=@to_date, workout_name=@workout_name, goal_id=@goal_id where workout_id=@workout_id", cn);
            cmd.Parameters.AddWithValue("from_date", Convert.ToDateTime(dateFrom.Value));
            cmd.Parameters.AddWithValue("to_date", Convert.ToDateTime(dateTo.Value));
            cmd.Parameters.AddWithValue("workout_name", workoutName.Text);
            cmd.Parameters.AddWithValue("goal_id", goalId);
            cmd.Parameters.AddWithValue("workout_id", workoutScheId);
            cmd.ExecuteNonQuery();

            List<Exercise> itemsSelected = new List<Exercise>();

            exerciseItems.ForEach(ex =>
            {
                if (checkedListExercise.CheckedItems.Contains(ex.getExerciseName()))
                {
                    itemsSelected.Add(ex);
                }
            });

            cmd = new SqlCommand("delete from workout_exercise where workout_id=@workout_id", cn);
            cmd.Parameters.AddWithValue("workout_id", workoutId.Text);
            cmd.ExecuteNonQuery();

            itemsSelected.ForEach((ex) =>
            {
                cmd = new SqlCommand("insert into workout_exercise values(@workout_id, @exercise_id)", cn);
                cmd.Parameters.AddWithValue("exercise_id", ex.getExerciseId());
                cmd.Parameters.AddWithValue("workout_id", workoutId.Text);
                cmd.ExecuteNonQuery();
            });
            MessageBox.Show("Your workout plan has been updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
