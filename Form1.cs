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

        private void button1_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], false);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], true);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], true);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], true);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], true);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], true);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], true);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Manipulator.Notify((sender as Button).Text[0], true);
        }
       
    }
}
