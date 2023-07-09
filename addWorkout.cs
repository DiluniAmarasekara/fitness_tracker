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
    public partial class addWorkout : Form
    {
        public addWorkout(int buttonFlag)
        {
            InitializeComponent();
            if (buttonFlag == 1)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if(buttonFlag == 2)
            {
                btnDelete.Enabled = false;
                btnSubmit.Enabled = false;
            }
            else if (buttonFlag == 3)
            {
                btnUpdate.Enabled = false;
                btnSubmit.Enabled = false;
            }
        }

        private void addWorkout_Load(object sender, EventArgs e)
        {

        }
    }
}
