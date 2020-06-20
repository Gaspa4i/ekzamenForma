using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekzamen_forma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSrav_Click(object sender, EventArgs e)
        {
            double a1 = 0; double b1 = 0; double c1 = 0;
            double a2 = 0; double b2 = 0; double c2 = 0;
            double p1 = 0; double s1 = 0;
            double p2 = 0; double s2 = 0;
            bool corect = true;
            try
            {
                 a1 = Convert.ToDouble(txt1TrA.Text);  b1 = Convert.ToDouble(txt1TrB.Text);  c1 = Convert.ToDouble(txt1TrC.Text);
                 a2 = Convert.ToDouble(txt2TrA.Text);  b2 = Convert.ToDouble(txt2TrB.Text);  c2 = Convert.ToDouble(txt2TrC.Text);
            }
            catch
            {
                lblVivod.Text="Введены некорректные данные";
                corect = false;
            }
            if (corect)
            {
                p1 = (a1 + b1 + c1) / 2;
                p2 = (a2 + b2 + c2) / 2;
                s1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
                s2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

                if (s1 > s2) lblVivod.Text = "Площадь первого треугольника на " + (s1 - s2).ToString("0.00") + " больше второго";
                else if (s2 > s1) lblVivod.Text = "Площадь второго треугольника на " + (s2 - s1).ToString("0.00") + " больше первого";
                else lblVivod.Text = "Площади треугольников равны";

                if (a1 + b1 <= c1 || b1 + c1 <= a1 || c1 + a1 <= b1)
                    if (a2 + b2 <= c2 || b2 + c2 <= a2 || c2 + a2 <= b2) lblVivod.Text = "Оба треугольника невозможны";
                    else lblVivod.Text = "Первый треугольник невозможен";
                else
                    if (a2 + b2 <= c2 || b2 + c2 <= a2 || c2 + a2 <= b2) lblVivod.Text = "Второй треугольник невозможен";
            }
        }

        private void серыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void чёрныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
