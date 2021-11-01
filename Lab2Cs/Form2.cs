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
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int value;
            try
            {
                value = int.Parse(textBox1.Text);
            }
            catch(FormatException)
            {
                return;
            }
            MessageBox.Show(Logic.GrammarForMoney(Logic.GetMoney(value)));
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
            else
            {
                return (money.rubles + sr + ' ' + money.copecks + sc);
            }
        }
    }
}
