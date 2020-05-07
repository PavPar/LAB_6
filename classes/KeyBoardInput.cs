using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_6.classes
{
    public class KeyBoardInput
    {
        KeysConverter kc;
        private IOManipulator Manipulator;
        public KeyBoardInput(IOManipulator Man)
        {
            Manipulator = Man;
            kc = new KeysConverter();
        }

        public void ReadData(KeyEventArgs e)
        {
            char val = ReadNumber(e);
            if ( val != '\0')
            {
                Manipulator.Notify(val, false);
            }
            val = ReadOperation(e);
            if (val != '\0')
            {
                Manipulator.Notify(val, true);
            }
        }

        public string ReadKey(KeyEventArgs e)
        {
            return kc.ConvertToString(e.KeyData);
        }

        public char ReadNumber(KeyEventArgs e)
        {
            string data = ReadKey(e);
            if (Char.IsDigit(data[data.Length - 1]) && (data[0] == 'N' || Char.IsDigit(data[0])))
            {
                return data[data.Length - 1];
            }
            return '\0';
        }

        public char ReadOperation(KeyEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "Add":
                    {
                        return '+';
                    }
                case "Subtract":
                    {
                        return '-';
                    }
                case "Divide":
                    {
                        return '/';
                    }
                case "Multiply":
                    {
                        return '*';
                    }
                case "Oemplus":
                    {
                        return '&';
                    }
                case "Back":
                    {
                        return 'd';
                    }
                case "Decimal":
                    {
                        return '.';
                    }
                case "Delete":
                    {
                        return 'C';
                    }
            }
            return '\0';
        }
    }
}
