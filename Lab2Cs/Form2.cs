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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.value.ToString();
        }
        private int value;
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                value = int.Parse(textBox1.Text);
                if (value < 1 || value > 9999)
                    throw new Exception();
            }
            catch(FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Ограничения для n не соблюдены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(Logic.GrammarForMoney(Logic.GetMoney(value)), "Ответ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.value = value;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Properties.Settings.Default.Reset();
        }
    }
    public class Money
    {
        public int rubles;
        public int copecks;
    }
    class Logic
    {
        public static Money GetMoney(int value)
        {
            Money money = new Money();
            money.rubles = value / 100;
            money.copecks = value - money.rubles * 100;
            return money;
        }
        public static string GrammarForMoney(Money money)
        {
            string sr, sc;
            if (money.rubles % 10 == 1 && money.rubles % 100 != 11)
            {
                sr = " рубль";
            }
            else
            if (money.rubles % 10 < 5 && (money.rubles % 100 > 14 || money.rubles % 100 < 11) && money.rubles % 10 != 0)
            {
                sr = " рубля";
            }
            else
            {
                sr = " рублей";
            }

            if (money.copecks % 10 == 1 && money.copecks % 100 != 11)
            {
                sc = " копейка";
            }
            else
            if (money.copecks % 10 < 5 && (money.copecks % 100 > 14 || money.copecks % 100 < 11) && money.copecks % 10 != 0)
            {
                sc = " копейки";
            }
            else
            {
                sc = " копеек";
            }

            if (money.copecks == 0)
            {
                return (money.rubles + sr + " ровно");
            }
            else if (money.rubles == 0)
            {
                return (money.copecks + sc + " ровно");
            }
            else
            {
                return (money.rubles + sr + ' ' + money.copecks + sc);
            }
        }
    }
}
