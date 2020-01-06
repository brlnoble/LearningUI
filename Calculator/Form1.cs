/* Very basic calculator using C# and Windows Form Application
 * 
 * Allows user to add, subtract, multiply, and divide numbers through 
 * buttons or typing into a textbox
 * 
 */

using System;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Basic Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>

        private void CEbutton_Click(object sender, EventArgs e)
        {
            this.userInputText.Clear(); //clears text from the user
            focusInputText();
        }

        /// <summary>
        /// Deletes the character before the cursor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delButton_Click(object sender, EventArgs e)
        {
            deleteTextValue();
        }
        #endregion

        #region Operator Methods

        private void divideButton_Click(object sender, EventArgs e)
        {
            insertTextValue("/");
            focusInputText();
        }

        private void multipyButton_Click(object sender, EventArgs e)
        {
            insertTextValue("*");
            focusInputText();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            insertTextValue("-");
            focusInputText();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            insertTextValue("+");
            focusInputText();
        }

        /// <summary>
        /// Calculates the result of the equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equalButton_Click(object sender, EventArgs e)
        {
            calculateEquation();
            focusInputText();
        }
        #endregion

        #region Number Methods

        private void zeroButton_Click(object sender, EventArgs e)
        {
            insertTextValue("0");
            focusInputText();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            insertTextValue("1");
            focusInputText();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            insertTextValue("2");
            focusInputText();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            insertTextValue("3");
            focusInputText();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            insertTextValue("4");
            focusInputText();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            insertTextValue("5");
            focusInputText();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            insertTextValue("6");
            focusInputText();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            insertTextValue("7");
            focusInputText();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            insertTextValue("8");
            focusInputText();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            insertTextValue("9");
            focusInputText();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            insertTextValue(".");
            focusInputText();
        }
        #endregion

        //-------------------------------------------------------

        /// <summary>
        /// Calculates the given equation and outputs answer to user
        /// </summary>
        private void calculateEquation()
        {

        }

        #region Private Helpers

        /// <summary>
        /// Focuses to the user input box
        /// </summary>
        private void focusInputText()
        {
            this.userInputText.Focus();
        }

        //-------------------------------------------------------

        /// <summary>
        /// Inserts given text into user textbox
        /// </summary>
        /// <param name="value"></param>
        /// 
        private void insertTextValue(string value)
        {
            var selectionStart = this.userInputText.SelectionStart; //remember cursor position
            this.userInputText.Text = this.userInputText.Text.Insert(this.userInputText.SelectionStart, value);
            this.userInputText.SelectionStart = selectionStart + value.Length; //maintain cursor position after insert
            this.userInputText.SelectionLength = 0; //do not highlight any characters
        }
        //-------------------------------------------------------

        /// <summary>
        /// Deletes character from the user textbox
        /// </summary>
        private void deleteTextValue()
        {
            if (this.userInputText.Text.Length == 0) //if nothing to delete in textbox
            {
                focusInputText();
                return;
            }
            var selectionStart = this.userInputText.SelectionStart; //remember cursor position
            this.userInputText.Text = this.userInputText.Text.Remove(this.userInputText.SelectionStart - 1, 1); //remove character
            this.userInputText.SelectionStart = selectionStart; //maintain cursor position after deletion
            this.userInputText.SelectionLength = 0; //do not highlight any characters
            focusInputText();
        }
        #endregion
    }
}