using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6.classes
{
    public class Calculator
    {
        public string calculate(float val1,float val2,char operation)
        {
            switch (operation)
            {
                case '+':
                    {
                        return (val1 + val2).ToString();
                    }
                case '-':
                    {
                        return (val1 - val2).ToString();
                    }
                case '*':
                    {
                        return (val1 * val2).ToString();
                    }
                case '/':
                    {
                        if(val2 == 0)
                        {
                            return "Err";
                        }
                        return (val1 / val2).ToString();
                    }
            }
            return "Err";
        }
    }
}
