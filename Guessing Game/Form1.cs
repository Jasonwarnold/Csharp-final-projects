/*Jason Arnold
 * CIST 2341 C#
 * Semester Project Guessing game 
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

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int num = 0;
        int guesses = 0;
        int best = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            //validate guess between 1 and 100
            int number = Int32.Parse(guessInputTxtBox.Text);
            if (number >= 1 && number <= 100)
            {
                playGame();
            }
            else
            {
                MessageBox.Show("You must enter an integer between 1 and 100.");
            }
        }

        private void reset()
        {
            //reset all values back to 0
            guesses = 0;
            guessNumTxtBox.Text = "";
            num = 0;
            hintTxtBox.Text = "";
            lastGuessBox.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //exit confirmation with dialogue box
            var result = MessageBox.Show("Are you sure you would like to exit?", "Exit Confirmation", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void playGame()
        {
            //if number is 0, score has reset.  assign new random number
            if (num == 0)
            {
                num = rand.Next(1, 101);
            }
            guesses += 1;                                                       // add 1 to guess count
            guessNumTxtBox.Text = guesses.ToString();                           //update guess count display
            int guess = Int32.Parse(guessInputTxtBox.Text);                     //get guess from text box
            lastGuessBox.Text = guess.ToString();                               //update last guess text box
            guessInputTxtBox.Text = "";                                         //empty current guess text box
            // if guess too low, update hint box 
            if (guess < num)
            {
                hintTxtBox.Text = "Too low";
                lastGuessBox.Text = guess.ToString();
            }
            //if guess too high, update hint box
            else if (guess > num)
            {
                hintTxtBox.Text = "Too high";
                lastGuessBox.Text = guess.ToString();
            }
            //if guess correct, check score against best and update if better.
            else if (guess == num)
            {
                if (best == 0)
                {
                    best = guesses;
                    bestTxtBox.Text = best.ToString();
                }
                if (guesses < best)
                {
                    best = guesses;
                    bestTxtBox.Text = best.ToString();
                    Console.WriteLine(best);
                }
                //dispaly win message and reset game.
                MessageBox.Show("You have guessed the number! Press ok to play again!");
                reset();
            }
        }
    }
}
