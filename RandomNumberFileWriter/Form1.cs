using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RandomNumberFileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create an application that writes random numbers to a file
        // Each random number should be in the range of 1 to 100
        // Let the user specify how many numbers to hold
        // Use a save dialog to set where file will be saved

        private void showNumbersButton_Click(object sender, EventArgs e)
        {
            // A try catch statement to catch and display any exceptions
            try
            {
                // Set up the variables
                int number;
                Random rand = new Random();
                int numOfNumbers = int.Parse(numOfNumbersTextBox.Text);

                // Loop through the number set by user
                for (int count = 0; count <= numOfNumbers; count++)
                {
                    // Each loop a random number is set and added to the listbox
                    number = rand.Next(100) + 1;
                    showNumbersListBox.Items.Add(number);
                }
            }
            // If there is an exception thrown display it in a messagebox
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // On click of button Clear, clear the app
        private void clearButton_Click(object sender, EventArgs e)
        {
            numOfNumbersTextBox.Text = "";
            showNumbersListBox.Items.Clear();
        }

        // On click of button Save, save the file
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Display a save dialog
            SaveFileDialog savefile = new SaveFileDialog();
            //// set a default file name
            //savefile.FileName = "unknown.txt";
            //// set filters - this can be done in properties as well
            //savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // if Save is clicked
            if (saveRandomNumFile.ShowDialog() == DialogResult.OK)
            {
                // Set up the StreamWriter to write to file
                using (StreamWriter sw = new StreamWriter(saveRandomNumFile.FileName))

                    // For each item in the ListBox write a line to 
                    // the new file you are saving
                    foreach (var item in showNumbersListBox.Items)
                    {
                        sw.WriteLine(item);
                    }                    
            }
            // Else if Cancel is clicked display a message box letting user
            // know what they have chosen
            else
            {
                MessageBox.Show("You clicked the Cancel button");
            }
        }

        // If exit is clicked close the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
