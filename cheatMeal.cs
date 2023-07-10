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
    public partial class cheatMeal : Form
    {
        public cheatMeal()
        {
            InitializeComponent();

            this.cmPnlLoader.Controls.Clear();
            cheatSummary ViewCheatMeal = new cheatSummary() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ViewCheatMeal.FormBorderStyle = FormBorderStyle.None;
            this.cmPnlLoader.Controls.Add(ViewCheatMeal);
            ViewCheatMeal.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.cmPnlLoader.Controls.Clear();
            addCheatMeal FrmAddCheatMeal = new addCheatMeal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAddCheatMeal.FormBorderStyle = FormBorderStyle.None;
            this.cmPnlLoader.Controls.Add(FrmAddCheatMeal);
            FrmAddCheatMeal.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.cmPnlLoader.Controls.Clear();
            addCheatMeal FrmUpdateCheatMeal = new addCheatMeal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmUpdateCheatMeal.FormBorderStyle = FormBorderStyle.None;
            this.cmPnlLoader.Controls.Add(FrmUpdateCheatMeal);
            FrmUpdateCheatMeal.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.cmPnlLoader.Controls.Clear();
            addCheatMeal FrmDeleteCheatMeal = new addCheatMeal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDeleteCheatMeal.FormBorderStyle = FormBorderStyle.None;
            this.cmPnlLoader.Controls.Add(FrmDeleteCheatMeal);
            FrmDeleteCheatMeal.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.cmPnlLoader.Controls.Clear();
            cheatSummary ViewCheatMeal = new cheatSummary() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ViewCheatMeal.FormBorderStyle = FormBorderStyle.None;
            this.cmPnlLoader.Controls.Add(ViewCheatMeal);
            ViewCheatMeal.Show();
        }
    }
}
