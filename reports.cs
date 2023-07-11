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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace fitness_tracker
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Documents\MSc\Enterprise\cw1\fitness_tracker\Database.mdf;Integrated Security=True");

            if (selectCombo.Text == "Workout")
            {
                SqlCommand cmd = new SqlCommand("select * from workout where from_date > @RangeFrom and to_date < @RangeTill", con);
                cmd.Parameters.AddWithValue("RangeTill", Convert.ToDateTime(dateTo.Value));
                cmd.Parameters.AddWithValue("RangeFrom", Convert.ToDateTime(dateFrom.Value));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Workout");
                dataGridTable.DataSource = ds.Tables["Workout"].DefaultView;
            }
            else if (selectCombo.Text == "Exercise")
            {
                SqlCommand cmd = new SqlCommand("select * from exercise", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Exercise");
                dataGridTable.DataSource = ds.Tables["Exercise"].DefaultView;
            }
            else if (selectCombo.Text == "Cheat Meal")
            {
                SqlCommand cmd = new SqlCommand("select * from cheat_meal where date_of_cheat > @RangeFrom and date_of_cheat < @RangeTill", con);
                cmd.Parameters.AddWithValue("RangeTill", Convert.ToDateTime(dateTo.Value));
                cmd.Parameters.AddWithValue("RangeFrom", Convert.ToDateTime(dateFrom.Value));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "CheatMeal");
                dataGridTable.DataSource = ds.Tables["CheatMeal"].DefaultView;
            }
            else if (selectCombo.Text == "Weight")
            {
                SqlCommand cmd = new SqlCommand("select * from weight where log_date > @RangeFrom and log_date < @RangeTill", con);
                cmd.Parameters.AddWithValue("RangeTill", Convert.ToDateTime(dateTo.Value));
                cmd.Parameters.AddWithValue("RangeFrom", Convert.ToDateTime(dateFrom.Value));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Weight");
                dataGridTable.DataSource = ds.Tables["Weight"].DefaultView;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

            // Create a new PDF document
            Document document = new Document();

            string filePath = @"C:\Users\DELL\Downloads\fitnessReport.pdf"; 

            // Create a new PDF writer
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Open the PDF document
            document.Open();

            // Create a new PDF table with the number of columns equal to the DataGridView column count
            PdfPTable table = new PdfPTable(dataGridTable.Columns.Count);

            // Add the column headers from the DataGridView to the PDF table
            foreach (DataGridViewColumn column in dataGridTable.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                table.AddCell(cell);
            }

            // Add the data rows from the DataGridView to the PDF table
            foreach (DataGridViewRow row in dataGridTable.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value?.ToString());
                }
            }

            // Add the PDF table to the PDF document
            document.Add(table);

            // Close the PDF document
            document.Close();
            MessageBox.Show("Data exported to PDF successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
