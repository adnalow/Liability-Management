using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liability_Management
{
    public partial class Form2 : Form
    {
        public string loggedUsername { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loggedIn.Text = loggedUsername;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Gather liability data from form controls
            string id = Guid.NewGuid().ToString();
            string assigneeName = asignee.Text;
            string userName = name.Text;
            string desc = description.Text;
            decimal liabPrice = decimal.Parse(price.Text);
            string due = dueDate.Text;

            // Create a Liability object
            Liability liability = new Liability
            {
                Id = id,
                AssigneeName = assigneeName,
                Name = userName,
                Description = desc,
                Price = liabPrice,
                DueDate = due
            };

            // Write liability to CSV file
            WriteToCsv(liability);

            MessageBox.Show("Liability submitted successfully.");

            
        }

        private void WriteToCsv(Liability liability)
        {
            string csvFilePath = "liabilities.csv";

            using (StreamWriter writer = new StreamWriter(csvFilePath, true))
            using (CsvWriter csvWriter = new CsvWriter(writer, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
            {
                csvWriter.WriteRecord(liability);
                writer.WriteLine(); // Add newline after writing the record
            }
        }


        public class Liability
        {
            public string Id { get; set; }
            public string AssigneeName { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string DueDate { get; set; }
        }

    }
}
