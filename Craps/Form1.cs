/*Jason Arnold
 * CIST 2341 C#
 * Semester Project Craps game 
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

namespace Craps
{
    public partial class Form1 : Form
    {
        int rollnum = 0;                                                    //global roll number
        int point = 0;                                                      //global point

        public Form1()
        {
            InitializeComponent();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            playCraps();
        }

        private void reset()
        {
            //reset variables to 0 and images to default for new game
            rollnum = 0;
            point = 0;
            pointTxtBox.Text = "";
            die1Img.Image = Craps.Properties.Resources.one;
            die2Img.Image = Craps.Properties.Resources.one;
        }
        //obtain 2 random numbers and assign picture boxes for results, returns int sum of both die rolls.
        private int roll()
        {
            Random rand = new Random();
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);
            if (die1 == 1)
            {
                die1Img.Image = Craps.Properties.Resources.one;
            }
            else if (die1 == 2)
            {
                die1Img.Image = Craps.Properties.Resources.two;
            }
            else if (die1 == 3)
            {
                die1Img.Image = Craps.Properties.Resources.three;
            }
            else if (die1 == 4)
            {
                die1Img.Image = Craps.Properties.Resources.four;
            }
            else if (die1 == 5)
            {
                die1Img.Image = Craps.Properties.Resources.five;
            }
            else if (die1 == 6)
            {
                die1Img.Image = Craps.Properties.Resources.six;
            }
            if (die2 == 1)
            {
                die2Img.Image = Craps.Properties.Resources.one;
            }
            else if (die2 == 2)
            {
                die2Img.Image = Craps.Properties.Resources.two;
            }
            else if (die2 == 3)
            {
                die2Img.Image = Craps.Properties.Resources.three;
            }
            else if (die2 == 4)
            {
                die2Img.Image = Craps.Properties.Resources.four;
            }
            else if (die2 == 5)
            {
                die2Img.Image = Craps.Properties.Resources.five;
            }
            else if (die2 == 6)
            {
                die2Img.Image = Craps.Properties.Resources.six;
            }
            int dice = die1 + die2;
            resultTxtBox.Text = dice.ToString();
            return dice;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //exit confirmation with dialogue box
            var result = MessageBox.Show("Are you sure you would like to exit?", "Exit Confirmation", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void playCraps()
        {
            int dice = roll();                                                                      //get dice rolls
            rollnum += 1;                                                                           //add 1 to roll count
            
            // first roll rules, if 7 or 11, win. if 2, 3, or 12, lose. otherwise, set roll as "point".
            if (rollnum == 1)
            {
                if (dice == 7 || dice == 11)
                {
                    MessageBox.Show("YOU WIN! Press OK to play again.");
                    reset();
                }
                else if (dice == 2 || dice == 3 || dice == 12)
                {
                    MessageBox.Show("YOU LOSE! Press OK to play again.");
                    reset();
                }
                else
                {
                    point = dice;
                    pointTxtBox.Text = point.ToString();
                }
            }
            //all subsequent rolls, compare dice rolls to point, of match, win.  if die roll is 7, lose.
            if (rollnum > 1)
            {
                if (dice == point)
                {
                    MessageBox.Show("YOU WIN! Press OK to play again.");
                    reset();
                }
                else if (dice == 7)
                {
                    MessageBox.Show("YOU LOSE! Press OK to play again.");
                    reset();
                }
            }
            
        }
    }
}
