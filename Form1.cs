using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB_6.classes;

namespace LAB_6
{
    public partial class Form1 : Form
    {
        KeyBoardInput Reader;
        IOManipulator Manipulator;
        public Form1()
        {
            InitializeComponent();
            Calculator calc = new Calculator();
            Manipulator = new IOManipulator(label1, label2, label3,calc);
            Reader = new KeyBoardInput(Manipulator);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Reader.ReadData(e);
        }

    }
}
