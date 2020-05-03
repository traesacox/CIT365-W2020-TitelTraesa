using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traesa_Titel_Math_Quiz
{
    public partial class MathQuiz : Form
    {

        //Creat a Random object called randomizer
        //to generate ramndom numbers.
        Random randomizer = new Random();

        //Create a variable to track number of correct answers
        int numRight=0;

        //These integer variables store tht numbers
        //for the addition problem.
        int addend1;
        int addend2;

        //These integer variables store the number 
        //for the subtration problem.
        int minuend;
        int subtrahend;

        //These integer variables store the numbers 
        //for the multiplication problem
        int multiplicand;
        int multiplier;

        //These integer variables store the numbers
        //for the division problem
        int dividend;
        int divisor;

        //This integer variable keep strack of the remaining time
        int timeLeft;

        //Start the quiz by filling in all of the problems & starting the timer.
        public void StartTheQuiz()
        {
            //Clear the Results Field
            results.Text = "";
            timeLabel.BackColor = Color.Gold;

            //Reset ttlRight to 0
            numRight = 0;
            ttlRight.Text = "Total Correct: " + numRight;


            /*Fill in the addition problem 
            *Generate two random numbers to add
            *Store the values in the variable 'addend1' and 'addend2' 
            */
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            /*Convert the two randomly generated number into strings so
             *that they can be displayed in the lable controls
             */
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            /*'sum' is the name of the numericUpDown control.
             * This step makes sure its value is zero before adding values to it
             */
            sum.Value = 0;

            //Fill in the subtraction problem
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            //Fill in the multipication problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //Fill in the division problem
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            divideLeftLabel.Text = dividend.ToString();
            divideRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            //Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

        }

        /*Check the answer to see if the user go everything right.
         * <returns> True if the answer is correct, false if it is incorrect
         */
         private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)&& (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend/divisor == quotient.Value))
                return true;
            else
                return false;
        }



        public MathQuiz()
        {
            InitializeComponent();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void MathQuiz_Load(object sender, EventArgs e)
        {
            currDate.Text = GetCurrDate();
            results.Text = "";
        }

        private string GetCurrDate()
        {
            string strDateNow = DateTime.Now.ToString("d MMMM yyyy");
            return strDateNow;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                //If CheckTheAnswer() returns true, then the user  goo the answer right.
                //Stop the time and sho a MessageBox.
                timer1.Stop();
                results.Text = "You got all the answers right! Congrats!";
                startButton.Enabled = true;
            }
            else if (timeLeft >0)
            {
                //If CheckTheAnswer() returns false, keep counting down.
                //Display the new time left by updating the time Left Label
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                //If the user ran out of time, stop the timer, 
                //show a MessageBox, and fil in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's Up!";
                results.Text = "You didn't finish in time. Sorry!";
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }

            if(timeLeft <6)
            {
                timeLabel.BackColor = Color.Red;
            }

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the whole answer in the NumericUpDown control
            NumericUpDown answerBox = sender as NumericUpDown;

            if(answerBox!=null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
            {
                sum.ForeColor = Color.Green;
                if (timeLeft > 0)
                {
                    numRight++;
                    ttlRight.Text = "Total Correct: " + numRight;
                }
            }
            else
            {
                sum.ForeColor = Color.Red;
            }

        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            if(minuend - subtrahend == difference.Value)
            { 
                difference.ForeColor = Color.Green;
                if (timeLeft > 0)
                {
                    numRight++;
                    ttlRight.Text = "Total Correct: " + numRight;
                }
            }
            else
            {
                difference.ForeColor = Color.Red;
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == product.Value)
            {
                product.ForeColor = Color.Green;
                if (timeLeft > 0)
                {
                    numRight++;
                    ttlRight.Text = "Total Correct: " + numRight;
                }
            }
            else
            {
                product.ForeColor = Color.Red;
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if (dividend / divisor == quotient.Value)
            {
                quotient.ForeColor = Color.Green;
                if (timeLeft > 0)
                {
                    numRight++;
                    ttlRight.Text = "Total Correct: " + numRight;
                }
            }
            else
            {
                quotient.ForeColor = Color.Red;
            }
        }

        private void sum_ValueChanged_1(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
            {
                sum.ForeColor = Color.Green;
                numRight++;
                ttlRight.Text = "Total Correct: " + numRight;
            }
            else
            {
                sum.ForeColor = Color.Red;
            }

        }
    }
}
