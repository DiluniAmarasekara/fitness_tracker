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
    public partial class cheatSummary : Form
    {
        private DataSet dtSet;
        public cheatSummary()
        {
            InitializeComponent();
        }

        private void cheatSummary_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from cheat_meal", con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "CheatMeal");
            dataGridView1.DataSource = ds.Tables["CheatMeal"].DefaultView;
        }
    }
}
