using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Cs
{
    public partial class Form3 : Form
    {
        private void tb_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        public Form3()
        {
            InitializeComponent();
            textA.Text = Properties.Settings.Default.A.ToString();
            textB.Text = Properties.Settings.Default.B.ToString();
            textC.Text = Properties.Settings.Default.C.ToString();

            textA.KeyUp += tb_KeyUp;
            textB.KeyUp += tb_KeyUp;
            textC.KeyUp += tb_KeyUp;
            doA.KeyUp += tb_KeyUp;
            doB.KeyUp += tb_KeyUp;
            saveAll.KeyUp += tb_KeyUp;
        }
        private double A, B, C;
        private void doA_Click(object sender, EventArgs e)
        {
            try
            {
                A = double.Parse(textA.Text);
                B = double.Parse(textB.Text);
                if(B <= (A*Logic2.rate) || A == 0)
                    throw new Exception();
            }
            catch(FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Выражение не имеет смысла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(Logic2.toDoA(A, B), "Ответ");
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.B = B;
            Properties.Settings.Default.Save();
        }

        private void saveC_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.C = C;
            Properties.Settings.Default.Save();
        }

        private void deleteA_Click(object sender, EventArgs e)
        {
            textA.Text = "";
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            textB.Text = "";
        }

        private void deleteC_Click(object sender, EventArgs e)
        {
            textC.Text = "";
        }

        private void saveAll_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.A = A;
            Properties.Settings.Default.B = B;
            Properties.Settings.Default.C = C;
            Properties.Settings.Default.Save();
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            textA.Text = "";
            textB.Text = "";
            textC.Text = "";
            Properties.Settings.Default.Save();
        }

        private void doB_Click(object sender, EventArgs e)
        {
            try
            {
                A = double.Parse(textA.Text);
                C = double.Parse(textC.Text);
                if (C <= A || A == 0)
                    throw new Exception();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Выражение не имеет смысла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(Logic2.toDoB(A, C), "Ответ");
        }

        private void saveA_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.A = A;
            Properties.Settings.Default.Save();
        }
    }
    public class Logic2
    {
        public static double rate = 0.02;
        public static string toDoA(double value, double B)
        {
            int n = 0; // счетчик месяцев
            string mounth = "";

            while (value * rate <= B)
            {
                n++;
                value += value * rate;
            }
            switch (n % 12)
            {
                case 0:
                    mounth = "март";
                    break;
                case 1:
                    mounth = "апрель";
                    break;
                case 2:
                    mounth = "май";
                    break;
                case 3:
                    mounth = "июнь";
                    break;
                case 4:
                    mounth = "июль";
                    break;
                case 5:
                    mounth = "август";
                    break;
                case 6:
                    mounth = "сентябрь";
                    break;
                case 7:
                    mounth = "октябрь";
                    break;
                case 8:
                    mounth = "ноябрь";
                    break;
                case 9:
                    mounth = "декабрь";
                    break;
                case 10:
                    mounth = "январь";
                    break;
                case 11:
                    mounth = "февраль";
                    break;
            }
            return ("За " + mounth + " " + (DateTime.Now.Year + n / 12) + " года величина ежемесячного увеличения вклада превысит " + B + " руб");
        }
        public static string toDoB(double value, double C)
        {
            string mounth = "", year = "";
            int m, y;
            for (m = 0; value <= C; m++)
            {
                value += value * rate;
            }
            y = m / 12;
            m = m % 12;
            if(y != 0)
            {
                if (y == 1)
                    year = y + " год ";
                if (y > 1 && y < 5)
                    year = y + " года ";
                if (y > 4)
                    year = y + " лет ";
            }
            if (m != 0)
            {
                if (m == 1)
                    mounth = m + " месяц ";
                if (m > 1 && m < 5)
                    mounth = m + " месяца ";
                if(m > 4)
                    mounth = m + " месяцев ";
            }
            return ("Через " + year + mounth + "размер вклада превысит " + C + " руб");
        }
    }
}
