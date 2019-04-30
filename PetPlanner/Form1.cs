using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PetPlanner
{
    public partial class Form1 : Form
    {
        public int newTextBoxPosition = 12;
        public int labelCount = 1;
        public int mainCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка записи в файл из текстбокса
        {
            /* 
            * Всё вместить в массив и сделать вывод
            */
            string lines = textBox1.Text + "\n"; 
            File.WriteAllText(@"E:\Projects\PetPlanner\SaveHere\text.txt", lines);
            textBox1.Text = "";
            MessageBox.Show("Сохранение прошло успешно!");

        }

        private void button2_Click(object sender, EventArgs e) //Кнопка открытия файла из текстбокса
        {
            Process.Start(@"E:\Projects\PetPlanner\SaveHere\text.txt");
        }

        private void button3_Click(object sender, EventArgs e) //Кнопка добавления задачи 
        {
            /* 
            * Добавляем поле TextBox
            */
            newTextBoxPosition += 26;
            string textBoxName = "textBox" + mainCount;
            this.Controls.Add(new TextBox() { Name = textBoxName, Location = new Point(71, newTextBoxPosition), Text = "", Size = new Size(331, 20) });

            /* 
            * Добавляем Label
            */

            labelCount += 1;

            string labelName = "label" + mainCount;
            this.Controls.Add(new Label() { Name = labelName, Location = new Point(52, newTextBoxPosition + 3), Text = labelCount.ToString() });
            

            mainCount += 1;
        }
    }

}

