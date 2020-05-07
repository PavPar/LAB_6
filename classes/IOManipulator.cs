using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LAB_6.classes
{
    public class IOManipulator : DataReader
    {
        Calculator Calc;

        private readonly Label numberOutput;
        private readonly Label operationOutput;
        private readonly Label oldNumberOutput;
        private string currValue;//aka first number
        private string storedValue;//aka second number
        private char currOperation;
        public IOManipulator(Label numOutput, Label olnumOutput, Label opOutput, Calculator calc)
        {
            numberOutput = numOutput;
            operationOutput = opOutput;
            oldNumberOutput = olnumOutput;
            currValue = "0";
            storedValue = "";
            currOperation = '\0';
            this.Calc = calc;
            numberOutput.Text = currValue;
            operationOutput.Text = currOperation.ToString();
            oldNumberOutput.Text = storedValue;
        }

        public void Notify(char value, bool operation)
        {
            if (operation)
            {

                switch (value)
                {
                    case '=':
                        {
                            if (storedValue != "" && currValue != "" && currOperation != '\0')
                            {
                                currValue = Calc.calculate(float.Parse(storedValue), float.Parse(currValue), currOperation);
                                storedValue = "";
                                currOperation = '\0';
                                Clipboard.SetData(DataFormats.Text, (Object)currValue);
                            }
                            break;
                        }
                    case 'd':
                        {
                            if (currValue.Length == 1)
                            {
                                currValue = "0";
                            }
                            else
                            {
                                currValue = currValue.Substring(0, currValue.Length - 1);
                            }
                            break;
                        }
                    case '.':
                        {
                            if (!currValue.Contains(","))
                            {
                                currValue += ',';
                            }
                            break;
                        }
                    case 'C':
                        {
                            currValue = "0";
                            storedValue = "";
                            currOperation = '\0';
                            break;
                        }
                    default:
                        {
                            if (currValue == "Err")
                            {
                                currValue = "0";
                            }

                            if (storedValue == "")
                            {
                                storedValue = currValue;
                                currValue = "0";
                            }
                            currOperation = value;
                            break;
                        }
                }
            }
            else
            {
                if ((currValue[0] == '0' && currValue.Length == 1) || currValue == "Err")
                {
                    currValue = value.ToString();
                }
                else
                {
                    currValue += value;
                }
                numberOutput.Text = currValue;
            }
            numberOutput.Text = currValue;
            operationOutput.Text = currOperation.ToString();
            oldNumberOutput.Text = storedValue;
        }
    }
}
