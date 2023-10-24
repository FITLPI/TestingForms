using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool CheckInt(string value)
        {
            int result;
                
            if (!int.TryParse(value, out result) || result <= 0)
            {
                MessageBox.Show("Данное значение не может быть стороной треугольника");
                return false;
            }
            return true;

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            int a, b , c;

            if (CheckInt(textBoxA.Text) && CheckInt(textBoxB.Text) && CheckInt(textBoxC.Text))
            {
                a = int.Parse(textBoxA.Text);
                b = int.Parse(textBoxB.Text);
                c = int.Parse(textBoxC.Text);

                if (a + b <= c || c + b <= a || a + c <= b) labelView.Text = "Ваш треугольник:\nне существует";
                else if (a == b && a == c) labelView.Text = "Ваш треугольник:\nровносторонний";
                else if (b == c && b != a || a == c && b != a || b == a && c != a) labelView.Text = "Ваш треугольник:\nравнобедренный";
                else if (a != b && b != c && c != a) labelView.Text = "Ваш треугольник:\nразносторонний";
            }
        }
    }
}
