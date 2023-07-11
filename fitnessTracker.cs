namespace fitness_tracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public partial class fitnessTracker : Form
{
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

    private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
         int nHeightEllipse

      );
    public fitnessTracker()
    {
        InitializeComponent();
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        pnlNav.Height = btnDashboard.Height;
        pnlNav.Top = btnDashboard.Top;
        pnlNav.Left = btnDashboard.Left;
        btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

        lblTitle.Text = "Dashboard";
        this.pnlFormLoader.Controls.Clear();
        dashboard FrmDashboard_Vrb = new dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
        this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
        FrmDashboard_Vrb.Show();
    }

    private void btnDashboard_Click(object sender, EventArgs e)
    {
        btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        pnlNav.Height = btnDashboard.Height;
        pnlNav.Top = btnDashboard.Top;
        pnlNav.Left = btnDashboard.Left;

        lblTitle.Text = "Dashboard";
        this.pnlFormLoader.Controls.Clear();
        dashboard FrmDashboard_Vrb = new dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
        this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
        FrmDashboard_Vrb.Show();
    }

    private void btnWorkout_Click(object sender, EventArgs e)
    {
        btnWorkout.BackColor = Color.FromArgb(46, 51, 73);
        pnlNav.Height = btnWorkout.Height;
        pnlNav.Top = btnWorkout.Top;

        lblTitle.Text = "Workout Management";
        this.pnlFormLoader.Controls.Clear();
        workout FrmDashboard_Vrb = new workout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
        this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
        FrmDashboard_Vrb.Show();
    }

    private void btnMeal_Click(object sender, EventArgs e)
    {
        btnMeal.BackColor = Color.FromArgb(46, 51, 73);
        pnlNav.Height = btnMeal.Height;
        pnlNav.Top = btnMeal.Top;

        lblTitle.Text = "Cheat Meal Management";
        this.pnlFormLoader.Controls.Clear();
        cheatMeal FrmDashboard_Vrb = new cheatMeal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
        this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
        FrmDashboard_Vrb.Show();
    }

    private void btnAnalytics_Click(object sender, EventArgs e)
    {
        btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        pnlNav.Height = btnAnalytics.Height;
        pnlNav.Top = btnAnalytics.Top;

        lblTitle.Text = "Analytics";
    }

    private void btnDashboard_Leave(object sender, EventArgs e)
    {
        btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void btnWorkout_Leave(object sender, EventArgs e)
    {
        btnWorkout.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void btnMeal_Leave(object sender, EventArgs e)
    {
        btnMeal.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void btnAnalytics_Leave(object sender, EventArgs e)
    {
        btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void buttonExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnReport_Click(object sender, EventArgs e)
    {
        btnReport.BackColor = Color.FromArgb(46, 51, 73);
        pnlNav.Height = btnReport.Height;
        pnlNav.Top = btnReport.Top;

        lblTitle.Text = "Reports Generate";
        this.pnlFormLoader.Controls.Clear();
        report FrmReport_Vrb = new report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmReport_Vrb.FormBorderStyle = FormBorderStyle.None;
        this.pnlFormLoader.Controls.Add(FrmReport_Vrb);
        FrmReport_Vrb.Show();
    }

    private void btnReport_Leave(object sender, EventArgs e)
    {
        btnReport.BackColor = Color.FromArgb(24, 30, 54);
    }
}
