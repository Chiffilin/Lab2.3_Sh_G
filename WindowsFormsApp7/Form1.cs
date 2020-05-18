using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Triangle triangle;
        bool isSecondNumber;
        public Form1()
        {
            InitializeComponent();
            triangle = new Triangle();
            isSecondNumber = false;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*|Bitmap files(*.bmp)|*.bmp|Binary files(*.bin)|*.bin";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*|Bitmap files(*.bmp)|*.bmp|Binary files(*.bin)|*.bin";
        }

        public void AddDigit(String digit)
        {
            if (display.Text.Equals("0") || isSecondNumber)
                display.Text = digit;
            else
                display.Text += digit;

            isSecondNumber = false;
        }
        public void ChooseOperation(object sender, EventArgs e)
        {

            triangle.OperationCode = 1;
             

            triangle.Number = Convert.ToDouble(display.Text);
            this.isSecondNumber = true;


        }

        private void Enter_Click(object sender, EventArgs e)
        {

            triangle.Number = Convert.ToDouble(display.Text);
            triangle.Number2 = Convert.ToDouble(display2.Text);
            triangle.Number3 = Convert.ToDouble(display3.Text);
           
            triangle.Triangleg();
            Answer.Text = triangle.Result;

        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            AddDigit(((Button)sender).Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            display.Text = " ";
            display2.Text = " ";
            display3.Text = " ";

            Answer.Text = " ";
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);

            Answer.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл

          
           
            System.IO.File.WriteAllText(filename, Answer.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}