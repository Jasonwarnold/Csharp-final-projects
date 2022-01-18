/*Jason Arnold
 * CIST 2341 C#
 * Semester Project 21 game 
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

namespace Twenty_One
{
    public partial class Form1 : Form
    {
        int total;                                                                      //global total

        public Form1()
        {
            InitializeComponent();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //check if game has been reset
            if (this.total >= 21)
            {
                //prompt user to reset game
                MessageBox.Show("GAME OVER!  Press \'Play Again\' to reset and play again.");
            }
            //roll only 1 die if score over 15
            else if (this.total >= 15)
            {
                int roll1 = rand.Next(1, 7);                                    //get die roll
                Console.WriteLine(roll1);
                //set die image for die1 picture box based on random value
                if (roll1 == 1)
                {
                    die1.Image = Twenty_One.Properties.Resources.one;
                }
                else if (roll1 == 2)
                {
                    die1.Image = Twenty_One.Properties.Resources.two;
                }
                else if (roll1 == 3)
                {
                    die1.Image = Twenty_One.Properties.Resources.three;
                }
                else if (roll1 == 4)
                {
                    die1.Image = Twenty_One.Properties.Resources.four;
                }
                else if (roll1 == 5)
                {
                    die1.Image = Twenty_One.Properties.Resources.five;
                }
                else if (roll1 == 6)
                {
                    die1.Image = Twenty_One.Properties.Resources.six;
                }
                this.total += roll1;                                                            //add die roll to total
                totalTxtBox.Text = total.ToString();                                            //output total to text box
                //win condition
                if (total == 21)
                {
                    MessageBox.Show("YOU HAVE WON!");
                }
                //lose condition
                else if (total >21)
                {
                    MessageBox.Show("BUSTED! You have gone over 21!");
                }
            }
            //roll 2 dice if total less than 15
            else if (this.total < 15)
            {
                //die 1 roll and assign die image to die1 picture box
                int roll1 = rand.Next(1, 7);
                Console.WriteLine(roll1);
                if (roll1 == 1)
                {
                    die1.Image = Twenty_One.Properties.Resources.one;
                }
                else if (roll1 == 2)
                {
                    die1.Image = Twenty_One.Properties.Resources.two;
                }
                else if (roll1 == 3)
                {
                    die1.Image = Twenty_One.Properties.Resources.three;
                }
                else if (roll1 == 4)
                {
                    die1.Image = Twenty_One.Properties.Resources.four;
                }
                else if (roll1 == 5)
                {
                    die1.Image = Twenty_One.Properties.Resources.five;
                }
                else if (roll1 == 6)
                {
                    die1.Image = Twenty_One.Properties.Resources.six;
                }
                //get die2 roll and assign image to die2 picture box
                int roll2 = rand.Next(1, 7);
                Console.WriteLine(roll2);
                if (roll2 == 1)
                {
                    die2.Image = Twenty_One.Properties.Resources.one;
                }
                else if (roll2 == 2)
                {
                    die2.Image = Twenty_One.Properties.Resources.two;
                }
                else if (roll2 == 3)
                {
                    die2.Image = Twenty_One.Properties.Resources.three;
                }
                else if (roll2 == 4)
                {
                    die2.Image = Twenty_One.Properties.Resources.four;
                }
                else if (roll2 == 5)
                {
                    die2.Image = Twenty_One.Properties.Resources.five;
                }
                else if (roll2 == 6)
                {
                    die2.Image = Twenty_One.Properties.Resources.six;
                }
                //add die rolls to total and update total text box
                this.total += roll1;
                this.total += roll2;
                totalTxtBox.Text = total.ToString();
                if (total >= 15)
                {
                    die2.Visible = false;                                           //make 2nd die picture box invisible if score over 15
                }
                //win condition
                if (total == 21)
                {
                    MessageBox.Show("YOU HAVE WON!");
                }
                //lose condition
                else if (total > 21)
                {
                    MessageBox.Show("BUSTED! You have gone over 21!");
                }

            }
        }

        private void againBtn_Click(object sender, EventArgs e)
        {
            this.total = 0;                                                 //reset total to 0
            totalTxtBox.Text = total.ToString();                            //reset total text box
            die1.Image = Twenty_One.Properties.Resources.one;               //reset die1 picture box image
            die2.Image = Twenty_One.Properties.Resources.one;               //reset die2 picture box image
            die2.Visible = true;                                            //make die2 picture box visible
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
    }
}
