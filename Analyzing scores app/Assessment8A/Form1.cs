/*Ahmed Matoussi
 * email: ahmedgeek1@gmail.com
 * This application is to read the data from a file and store it in an array of the appropriate size, 
 * and then analyze the data in the array in a variety of ways and give the user a way to save the analysis
 */
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

namespace Assessment8A
{
    public partial class FormScoresAnalysis : Form
    {
        public FormScoresAnalysis()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenAndAnalyseFile_Click(object sender, EventArgs e)
        {

            try
            {
                //declare some variables to use 
                double averageScore, highScore, lowScore;

                // Declare a StreamReader variable.
                StreamReader inputFile;
                // set up initial open directory! 
                String UN = Environment.UserName; //variable for the username
                String FilePath = @"C:\Users\" + UN + @"\Documents\"; //concatinating the username with the path
                openFileDialogScores.InitialDirectory = FilePath;  //this folder is getting showed in the second replicate of the save dialogue window
                // show only files with .txt extension
                openFileDialogScores.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                //if the uyser click on open and open a file then
                if (openFileDialogScores.ShowDialog() == DialogResult.OK) 
                {
                    //number of lines in the file
                    var lineCount = File.ReadAllLines(openFileDialogScores.FileName).Length;
                    Boolean testRange = false;
                    if (lineCount <= 0)
                    {
                        MessageBox.Show("No records found in this file!");
                    }
                    else if (lineCount > 100)
                    {
                        MessageBox.Show("The Maximum of lines allowed per file is 100! Please select a file that has less than 100 line");
                    }
                    
                    else {
                        double[] arrayScores = new double[lineCount];
                        // openFile.ShowDialog();
                        inputFile = File.OpenText(openFileDialogScores.FileName);
                        //attempt to remove blank lines
                       // var lines = File.ReadAllLines(openFileDialogScores.FileName).Where(arg => !string.IsNullOrWhiteSpace(arg));
                      //  File.WriteAllLines(openFileDialogScores.FileName, lines);
                        for (int i = 0; i < lineCount; i++)
                        {
                            
                            
                            
                                arrayScores[i] = double.Parse(inputFile.ReadLine());
                                if (arrayScores[i] > 100 || arrayScores[i] < 0)
                                {
                                    testRange = true;
                                 }
                            
                        }
                        if (testRange == false) { 
                        //store the results from the methods in variables
                        averageScore = calculate_Average(arrayScores);
                        highScore = find_Highest_Score(arrayScores);
                        lowScore = find_Lowest_Score(arrayScores);

                        //display the results in the labels
                        lblAverageTestScoreOutput.Text = averageScore.ToString();
                        lblHighestTestScoreOutput.Text = highScore.ToString();
                        lblLowestTestScoreOutput.Text = lowScore.ToString();
                        lblTotalNumberOfScoreOutput.Text = lineCount.ToString();

                        //close the file
                        inputFile.Close();
                        }else
                        {
                            MessageBox.Show("All scores in the File should be in a range between 0 and 100");
                        }
                    }
                }
                else //if the user don't open a file then an error message is shown!
                {
                    MessageBox.Show("Operation cancelled!");
                }
                
            }
            catch (Exception ex)
            {
                //show the error message
                MessageBox.Show(ex.Message);
            }
        }

        private double calculate_Average(double[] fileArray)
        {//method to calculate the average of scores
            double avg;
            double sum = 0;
            for (int i = 0; i < fileArray.Length; i++)
            {
                sum = sum + fileArray[i];
            }
            avg = (double)sum / fileArray.Length; //calculate the avg
            return avg; //return the average
        }

        private double find_Highest_Score(double[] fileArray)
        {   //a method to find the highest score
            double HighestScore = 0;
            for (int i = 0; i < fileArray.Length; i++)
            {
                if (fileArray[i] > HighestScore)
                {
                    HighestScore = fileArray[i];
                }
            }
            //return the highest score
            return HighestScore;

        }

        private double find_Lowest_Score(double[] fileArray)
        {//a method to find the lowest score
            double LoweststScore = fileArray[0];
            for (int i = 0; i < fileArray.Length; i++)
            {
                if (fileArray[i] < LoweststScore)
                {
                    LoweststScore = fileArray[i];
                }
            }
            //return the lowest score
            return LoweststScore;

        }

        private void btnSaveFileAnalysis_Click(object sender, EventArgs e)
        {
          
            try
            {
                    //set the default path for saving the file
                    saveFileDialogScores.InitialDirectory = @"C:\Users\Public\Documents\";
                //add default extension
                // saveFileDialogScores.DefaultExt = ".txt";
                saveFileDialogScores.Filter = "Text Files (*.txt)|*.txt"/*"|RichText Files (*.rtf)|*.RTF|World Document (*.docx)|*.DOCX"*/;

                    // Declare a StreamWriter variable. 
                StreamWriter outputFile;
                    //int LineCount = int.Parse(lblTotalNumberOfScoreOutput.Text);
                    if(lblAverageTestScoreOutput.Text == "")
                {
                    MessageBox.Show("No data to generate!");
                }
                    else if (saveFileDialogScores.ShowDialog() == DialogResult.OK) //if the user click on save button
                    {

                        // Create and append the selected file.
                        outputFile = File.AppendText(saveFileDialogScores.FileName);
                        outputFile.WriteLine("The total Number of Scores is = " + lblTotalNumberOfScoreOutput.Text); //write the lines in the file
                        outputFile.WriteLine("The Average Score = " + lblAverageTestScoreOutput.Text); //write the lines in the file
                        outputFile.WriteLine("The Lowest score is = " + lblLowestTestScoreOutput.Text); //write the lines in the file
                        outputFile.WriteLine("The Highest Score is = " + lblHighestTestScoreOutput.Text); //write the lines in the file

                        outputFile.Close(); // Close the file

                        MessageBox.Show("Data generated and File saved successfully!");
                    }
                    else //if the user click on cancel button and didn't save any file
                    {
                        MessageBox.Show("Operation cancelled!");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all labels
            lblHighestTestScoreOutput.Text = "";
            lblLowestTestScoreOutput.Text = "";
            lblTotalNumberOfScoreOutput.Text = "";
            lblAverageTestScoreOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        private void FormScoresAnalysis_Load(object sender, EventArgs e)
        {

        }
    }
}
