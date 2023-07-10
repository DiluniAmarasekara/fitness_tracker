using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness_tracker
{
    public partial class workout : Form
    {
        public workout()
        {
            InitializeComponent();

            this.wkPnlLoader.Controls.Clear();
            workoutSummary ViewWorkout = new workoutSummary() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ViewWorkout.FormBorderStyle = FormBorderStyle.None;
            this.wkPnlLoader.Controls.Add(ViewWorkout);
            ViewWorkout.Show();
        }

        private void workoutPnlLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.wkPnlLoader.Controls.Clear();
            addWorkout FrmAddWorkout = new addWorkout(1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAddWorkout.FormBorderStyle = FormBorderStyle.None;
            this.wkPnlLoader.Controls.Add(FrmAddWorkout);
            FrmAddWorkout.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.wkPnlLoader.Controls.Clear();
            addWorkout FrmUpdateWorkout = new addWorkout(2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmUpdateWorkout.FormBorderStyle = FormBorderStyle.None;
            this.wkPnlLoader.Controls.Add(FrmUpdateWorkout);
            FrmUpdateWorkout.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.wkPnlLoader.Controls.Clear();
            addWorkout FrmDeleteWorkout = new addWorkout(3) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDeleteWorkout.FormBorderStyle = FormBorderStyle.None;
            this.wkPnlLoader.Controls.Add(FrmDeleteWorkout);
            FrmDeleteWorkout.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.wkPnlLoader.Controls.Clear();
            workoutSummary ViewWorkout = new workoutSummary() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ViewWorkout.FormBorderStyle = FormBorderStyle.None;
            this.wkPnlLoader.Controls.Add(ViewWorkout);
            ViewWorkout.Show();
        }

        private void workout_Load(object sender, EventArgs e)
        {

        }
    }
}
