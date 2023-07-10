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

namespace fitness_tracker
{
    public partial class addWorkout : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public addWorkout(int buttonFlag)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            InitializeComponent();
            if (buttonFlag == 1)
            {
                checklist_Load(con);
                workoutId_Load(con);
                goalId_Load(con);
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                workoutId.Enabled = false;
            }
            else if (buttonFlag == 2)
            {
                btnDelete.Visible = false;
                btnSubmit.Visible = false;
            }
            else if (buttonFlag == 3)
            {
                btnUpdate.Visible = false;
                btnSubmit.Visible = false;
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

        private void checklist_Load(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from exercise", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                checkedListExercise.Items.Add(dt.Rows[i]["exercise_name"].ToString());

            }
        }


        private void addWorkout_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void checkedListExercise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
