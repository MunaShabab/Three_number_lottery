using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryLoopRandom_MunaShabab
{
    //Author: Muna Shabab
    //ID: 624191
    //Date:11-7-19
    //Goal: To generate three random numbers and compare them to a user input numbers. If a match is found the numbers are
    // displayed and the search stops or it will stop after 1000 attempts
    //loops, random generator and listBox are used

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //declare variables
            int firstWinNum, secondWinNum, thirdWinNum, winningNumber, genFirstNum,genSecondNum, genThirdNum,genNumber;
            int numOfAttempts = 0;
            bool match=false;
            decimal prize = 500m;

            //create a random object
            Random myRandom = new Random();

            //clear the listBox
            historyListBox.Items.Clear();

            //get the first number from user and validate
            if(int.TryParse(firstNumTextBox.Text, out firstWinNum)&&(firstWinNum>=0)&&(firstWinNum<=9))
            {
                //get the second number from user and validate
                if(int.TryParse(secondNumTextBox.Text, out secondWinNum)&&(secondWinNum>=0)&&(secondWinNum<=9))
                {
                    //get the third number from user and validate
                    if (int.TryParse(thirdNumTextBox.Text, out thirdWinNum)&&(thirdWinNum>=0)&&(thirdWinNum<=9))
                    {
                        winningNumber = firstWinNum * 100 + secondWinNum * 10 + thirdWinNum;
                        //loop while less than 1000 and no match
                        while((numOfAttempts<1000) &&(!match))
                        {
                            //increment counter
                            numOfAttempts += 1;

                            // generate random numbers
                            genFirstNum = myRandom.Next(10);
                            genSecondNum = myRandom.Next(10);
                            genThirdNum = myRandom.Next(10);
                            genNumber = genFirstNum * 100 + genSecondNum * 10 + genThirdNum;
                            
                            //display the number
                            genFirstNumLabel.Text = genFirstNum.ToString();
                            genSecondNumLabel.Text = genSecondNum.ToString();
                            genThirdNumLabel.Text = genThirdNum.ToString();

                            //compare to winning number
                            if (genNumber==winningNumber)
                            {
                                //change match to true
                                match = true;
                               
                                // change back color to green and display success
                                genFirstNumLabel.BackColor = Color.LightGreen;
                                genSecondNumLabel.BackColor = Color.LightGreen;
                                genThirdNumLabel.BackColor = Color.LightGreen;
                                historyListBox.Items.Add("Attempt #" + numOfAttempts + " SUCCESS! " + winningNumber + " vs " + genNumber);
  
                            }

                            else
                            {
                                // change back color to red and display failed
                                genFirstNumLabel.BackColor = Color.Red;
                                genSecondNumLabel.BackColor = Color.Red;
                                genThirdNumLabel.BackColor = Color.Red;
                                historyListBox.Items.Add("Attempt #" + numOfAttempts + " Failed " + winningNumber + " vs " + genNumber.ToString("d3"));
                            }

                            attemptNumLabel.Text = numOfAttempts.ToString();
                            payLabel.Text = prize.ToString("c");

                        }
                        if (match)
                        {
                            //display winning message
                            MessageBox.Show("Congratulations! Match found for all 3 digits, it took "+numOfAttempts+" tries");

                        }
                        else
                        {
                            //display lost message
                            MessageBox.Show("Sorry, no match found after "+numOfAttempts+ " tries");
                        }

                    }
                   
                   

                    //display an error message for third number
                    else
                    {
                        MessageBox.Show("Please enter a valid third number between 0 and 9");
                        thirdNumTextBox.Focus();                   
                    }

                }

                //display an error message for second number
                else
                {
                    MessageBox.Show("Please enter a valid second number between 0 and 9");
                    secondNumTextBox.Focus();

                }
                
            }

            //display an error message for first number
            else
            {
                MessageBox.Show("Please enter a valid  first number between 0 and 9");
                firstNumTextBox.Focus();

            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all the lables and reset the backColor for the display lable
            firstNumTextBox.Text = "";
            secondNumTextBox.Text = "";
            thirdNumTextBox.Text = "";
            genFirstNumLabel.Text = "";
            genSecondNumLabel.Text = "";
            genThirdNumLabel.Text = "";
            attemptNumLabel.Text = "";
            payLabel.Text = "";
            historyListBox.Items.Clear();
            genFirstNumLabel.BackColor = SystemColors.Control;
            genSecondNumLabel.BackColor = SystemColors.Control;
            genThirdNumLabel.BackColor = SystemColors.Control;
        }
    }
}
