/* Very basic calculator using C# and Windows Form Application
 * 
 * Allows user to add, subtract, multiply, and divide numbers through 
 * buttons or typing into a textbox
 * 
 */

using System;
using System.Windows.Forms;
using System.Linq;

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
            
            calculationResultText.Text = $"Result: " + ParseOperation();
            focusInputText();
        }

        /// <summary>
        /// Parses the user's input equation, determining the result 
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try //catch exceptions to inform user rather than crashing the program
            {
                var input = userInputText.Text; //get user's input equation

                //Remove all spaces in equation
                input = input.Replace(" ", "");

                var operation = new Operation();
                var leftSide = true;

                for(int i=0; i<input.Length; i++) //loop through each character in input, from left to right
                {
                    //TO DO: HANDLE ORDER PRIORITY TO FOLLOW BEDMAS
                    if("0123456789.".Any(c => input[i] == c)) //check if current character is a number
                    {
                        if(leftSide)
                        {
                            operation.leftSide = AddNumberPart(operation.leftSide, input[i]);
                        }
                        else //if not on left side of operaiton, must be on right side
                        {
                            operation.rightSide = AddNumberPart(operation.rightSide, input[i]);
                        }
                    }
                    else if("+-*/".Any(c => input[i] == c)) //check if current character is an operator
                    {
                        //If on right side already, calcuate current operatin and set to leftSide
                        if(!leftSide)
                        {
                            var operatorType = GetOperationType(input[i]);

                            if (operation.rightSide.Length == 0)
                            {
                                //Check if a negative number is being represented
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operation specified before number");

                                //Append negative to rightSide
                                operation.rightSide += input[i];
                            }
                            else
                            {
                                operation.leftSide = CalculateOperation(operation); //calculate operation so far

                                //Clear previous right side
                                operation.rightSide = string.Empty;
                            }
                        }

                        else
                        {
                            var operatorType = GetOperationType(input[i]); //determine operation to be performd
                            if(operation.leftSide.Length == 0)
                            {
                                //Check if a negative number is being represented
                                if(operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operation specified before number");

                                //Append negative to leftSide
                                operation.leftSide += input[i];
                            }
                            else
                            {
                                //Left side number is present and operator has been determined
                                operation.Operationtype = operatorType;
                                leftSide = false; //Move to right side

                            }
                        }
                    }
                }

                //Calculate operation
                return CalculateOperation(operation);
            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculate a <see cref="Operation"/> and returns result
        /// </summary>
        /// <param name="operation">Operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            decimal left = 0, right = 0;

            //Check if valid left side number and right side number
            if (string.IsNullOrEmpty(operation.leftSide) || !decimal.TryParse(operation.leftSide, out left))
                throw new InvalidOperationException($"Left side of operator not a number: {operation.leftSide}");
            if (string.IsNullOrEmpty(operation.rightSide) || !decimal.TryParse(operation.rightSide, out right))
                throw new InvalidOperationException($"Left side of operator not a number: {operation.rightSide}");

            try
            {
                switch(operation.Operationtype)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating: {operation.Operationtype}");
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.leftSide} {operation.Operationtype} {operation.rightSide}. {ex.Message}");
            }
        }

        /// <summary>
        /// Takes in character and returns the <see cref="OperationType"/> 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private OperationType GetOperationType(char c)
        {
            switch(c)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Divide;
                default: //throw exception if invalid character
                    throw new InvalidOperationException($"Unknown operator type {c}");  
            }
        }

        /// <summary>
        /// Attempts to add a new character to current number, checking for invalids
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="currentCharacter">New character to append</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            if(newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} contains multiple .'s");
            return currentNumber + newCharacter;
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
