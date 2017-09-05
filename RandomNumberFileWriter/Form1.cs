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

             //int numOfNums = int.Parse(numOfNumbersTextBox.Text);
        }

        // Create an application that writes random numbers to a file
        // Each random number should be in the range of 1 to 100
        // Let the user specify how many numbers to hold
        // Use a save dialog to set where file will be saved

        

        private void showNumbersButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number;
                Random rand = new Random();
                int numOfNumbers = int.Parse(numOfNumbersTextBox.Text);

                for (int count = 0; count <= numOfNumbers; count++)
                {

                    number = rand.Next(100) + 1;
                    //showNumbersListBox.Items.Add(number);
                    StreamWriter outputFile;

                    if (saveRandomNumFile.ShowDialog() == DialogResult.OK)
                    {
                        outputFile = File.CreateText(saveRandomNumFile.FileName);
                        //outputFile = File.CreateText("five.txt");
                    }
                    else
                    {
                        MessageBox.Show("You clicked the Cancel button");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numOfNumbersTextBox.Text = "";
            showNumbersListBox.Items.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            StreamWriter outputFile;

            //if (saveRandomNumFile.ShowDialog() == DialogResult.OK)
            //{
            //    outputFile = File.CreateText(saveRandomNumFile.FileName);
            //    //outputFile = File.CreateText("five.txt");
            //}
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "unknown.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveRandomNumFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveRandomNumFile.FileName))
                    
                    sw.WriteLine("Hello World!");
            }
            else
            {
                MessageBox.Show("You clicked the Cancel button");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
