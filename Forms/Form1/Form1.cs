using System;
using System.Drawing;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class Form1 : Form
    {
        int value = 3000000;
        int thank = 60000;
        int time = 20;
        double procent = 10;
        double procentmouth = 0;
        double totalrate = 0;
        double everymouth = 0;
        double sum = 0;
        int sum1 = 0;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#B3E8E5");
            textBox1.BackColor = ColorTranslator.FromHtml("#82DBD8");
            textBox1.ForeColor = ColorTranslator.FromHtml("#02475E");
            textBox2.BackColor = ColorTranslator.FromHtml("#82DBD8");
            textBox2.ForeColor = ColorTranslator.FromHtml("#02475E");
            textBox3.BackColor = ColorTranslator.FromHtml("#82DBD8");
            textBox3.ForeColor = ColorTranslator.FromHtml("#02475E");
            textBox4.BackColor = ColorTranslator.FromHtml("#82DBD8");
            textBox4.ForeColor = ColorTranslator.FromHtml("#02475E");
            label1.ForeColor = ColorTranslator.FromHtml("#02475E");
            label2.ForeColor = ColorTranslator.FromHtml("#02475E");
            label3.ForeColor = ColorTranslator.FromHtml("#02475E");
            label4.ForeColor = ColorTranslator.FromHtml("#02475E");
            label5.ForeColor = ColorTranslator.FromHtml("#02475E");
            label6.ForeColor = ColorTranslator.FromHtml("#02475E");
            label7.ForeColor = ColorTranslator.FromHtml("#02475E");
            label8.ForeColor = ColorTranslator.FromHtml("#02475E");
            label9.ForeColor = ColorTranslator.FromHtml("#02475E");
            label10.ForeColor = ColorTranslator.FromHtml("#02475E");
            label11.ForeColor = ColorTranslator.FromHtml("#02475E");
            label12.ForeColor = ColorTranslator.FromHtml("#02475E");
            label13.ForeColor = ColorTranslator.FromHtml("#02475E");
            label14.ForeColor = ColorTranslator.FromHtml("#02475E");
            label15.ForeColor = ColorTranslator.FromHtml("#02475E");
            button1.BackColor = ColorTranslator.FromHtml("#3BACB6");
            button1.ForeColor = ColorTranslator.FromHtml("#82DBD8");
            radioButton1.ForeColor = ColorTranslator.FromHtml("#02475E");
            trackBar1.LargeChange = 25000;
            sum1 = value - thank;
            procentmouth = procent / 12 / 100;
            totalrate = Math.Pow((1 + procentmouth), (time * 12));
            sum = thank / (value / 100);
            if (radioButton1.Checked == true)
            {
                everymouth = (sum1) * procentmouth * totalrate / (totalrate - 1);
            }
            else
            {
                everymouth = sum1 / (time * 12);
            }
            totalrate = Math.Pow((1 + procentmouth), (time * 12));
            label15.Text = $"{Convert.ToInt32(everymouth)} ₽";
            label6.Text = $"{sum1} ₽";
            label7.Text = $"({sum} %)";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int result;
            if(!int.TryParse(textBox1.Text, out result))
            {
                MessageBox.Show("Вы ввели символ, а не число!");
            }
            else
            {
                value = Convert.ToInt32(textBox1.Text);
            }
            if (value < 375000)
            {
                textBox1.Text = "375000";
            }
            if(value > 100000000)
            {
                textBox1.Text = "100000000";
            }
            trackBar1.Value = value;
            sum1 = value - thank;
            procentmouth = procent / 12 / 100;
            totalrate = Math.Pow((1 + procentmouth), (time * 12));
            sum = thank / (value / 100);
            if (radioButton1.Checked == true)
            {
                everymouth = (sum1) * procentmouth * totalrate / (totalrate - 1);
            }
            else
            {
                everymouth = sum1 / (time * 12);
            }
            label7.Text = $"({sum} %)";
            label6.Text = $"{trackBar1.Value - thank} ₽";
            label15.Text = $"{Convert.ToInt32(everymouth)} ₽";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            value = trackBar1.Value;
            textBox1.Text = Convert.ToString(value);
            sum1 = value - thank;
            procentmouth = procent / 12 / 100;
            totalrate = Math.Pow((1 + procentmouth), (time * 12));
            sum = thank / (value / 100);
            if (radioButton1.Checked == true)
            {
                everymouth = (sum1) * procentmouth * totalrate / (totalrate - 1);
            }
            else
            {
                everymouth = sum1 / (time * 12);
            }
            label7.Text = $"({sum} %)";
            label6.Text = $"{trackBar1.Value - thank} ₽";
            label15.Text = $"{Convert.ToInt32(everymouth)} ₽";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(textBox2.Text, out result))
            {
                MessageBox.Show("Вы ввели символ, а не число!");
            }
            else
            {
                thank = Convert.ToInt32(textBox2.Text);
            }
            if(thank < 56300)
            {
                textBox2.Text = "56300";
            }
            if(thank > 75000)
            {
                textBox2.Text = "75000";
            }
            trackBar2.Value = thank;
            sum1 = value - thank;
            procentmouth = procent / 12 / 100;
            totalrate = Math.Pow((1 + procentmouth), (time * 12));
            sum = thank / (value / 100);
            if (radioButton1.Checked == true)
            {
                everymouth = (sum1) * procentmouth * totalrate / (totalrate - 1);
            }
            else
            {
                everymouth = sum1 / (time * 12);
            }
            label7.Text = $"({sum} %)";
            label6.Text = $"{trackBar1.Value - thank} ₽";
            label15.Text = $"{Convert.ToInt32(everymouth)} ₽";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            thank = trackBar2.Value;
            textBox2.Text = Convert.ToString(thank);
            sum1 = value - thank;
            procentmouth = procent / 12 / 100;
            totalrate = Math.Pow((1 + procentmouth), (time * 12));
            sum = thank / (value / 100);
            if (radioButton1.Checked == true)
            {
                everymouth = (sum1) * procentmouth * totalrate / (totalrate - 1);
            }
            else
            {
                everymouth = sum1 / (time * 12);
            }
            label7.Text = $"({sum} %)";
            label6.Text = $"{trackBar1.Value - thank} ₽";
            label15.Text = $"{Convert.ToInt32(everymouth)} ₽";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(textBox3.Text, out result))
            {
                MessageBox.Show("Вы ввели символ, а не число!");
            }
            else
            {
                time = Convert.ToInt32(textBox3.Text);
            }
            if (time < 1)
            {
                textBox2.Text = "1";
            }
            if (time > 30)
            {
                time = 30;
                textBox2.Text = "30";
            }
            trackBar3.Value = time;
            sum1 = value - thank;
            procentmouth = procent / 12 / 100;
            totalrate = Math.Pow((1 + procentmouth), (time * 12));
            sum = thank / (value / 100);
            if (radioButton1.Checked == true)
            {
                everymouth = (sum1) * procentmouth * totalrate / (totalrate - 1);
            }
            else
            {
                everymouth = sum1 / (time * 12);
            }
            label7.Text = $"({sum} %)";
            label6.Text = $"{trackBar1.Value - thank} ₽";
            label15.Text = $"{Convert.ToInt32(everymouth)} ₽";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            time = trackBar3.Value;
            textBox3.Text = Convert.ToString(trackBar3.Value);
            sum1 = value - thank;
            procentmouth = procent / 12 / 100;
            totalrate = Math.Pow((1 + procentmouth), (time * 12));
            sum = thank / (value / 100);
            if (radioButton1.Checked == true)
            {
                everymouth = (sum1) * procentmouth * totalrate / (totalrate - 1);
            }
            else
            {
                everymouth = sum1 / (time * 12);
            }
            label7.Text = $"({sum} %)";
            label6.Text = $"{trackBar1.Value - thank} ₽";
            label15.Text = $"{Convert.ToInt32(everymouth)} ₽";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(textBox4.Text, out result))
            {
                MessageBox.Show("Вы ввели символ, а не число!");
            }
            else
            {
                procent = Convert.ToInt32(textBox4.Text);
            }
            if (procent < 1)
            {
                procent = 1;
                textBox4.Text = "1";
            }
            if (procent > 100)
            {
                procent = 100;
                textBox4.Text = "100";
            }
            sum1 = value - thank;
            procentmouth = procent / 12 / 100;
            totalrate = Math.Pow((1 + procentmouth), (time * 12));
            sum = thank / (value / 100);
            if (radioButton1.Checked == true)
            {
                everymouth = (sum1) * procentmouth * totalrate / (totalrate - 1);
            }
            else
            {
                everymouth = sum1 / (time * 12);
            }
            label7.Text = $"({sum} %)";
            label6.Text = $"{trackBar1.Value - thank} ₽";
            label15.Text = $"{Convert.ToInt32(everymouth)} ₽";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var year = DateTime.Now.Year;
            var mouth = DateTime.Now.Month;
            var procentmouth = procent / 12 / 100;
            var totalrate = Math.Pow((1 + procentmouth), (time * 12));
            var lostdebt = value - thank;
            var number = (time * 12) + 1;
            var everymouth = 0.0;
            Form2 form = new Form2();
            if (radioButton1.Checked == true)
            {
                form.label13.Text = "Аннуитетный";
                everymouth = (value - thank) * procentmouth * totalrate / (totalrate - 1);
                for (var i = 0; i < number; i++)
                {
                    var moneyprocent = lostdebt * procentmouth;
                    var basicmoney = everymouth - moneyprocent;
                    lostdebt = lostdebt - Convert.ToInt32(basicmoney);
                    form.dataGridView1.Rows.Add(Date(mouth, year), Convert.ToInt32(moneyprocent), Convert.ToInt32(basicmoney), Convert.ToInt32(lostdebt), "Аннуитетный");
                    mouth += 1;
                    if (mouth >= 12)
                    {
                        year += 1;
                        mouth = 1;
                    }
                }
            }
            else
            {
                var moneyprocent = lostdebt * procentmouth;
                var basicmoney = everymouth - moneyprocent;
                form.label13.Text = "Дифференцированный";
                everymouth = basicmoney + moneyprocent;
                for (var i = 0; i < number; i++)
                {
                    everymouth = sum1 / (time * 12);
                    moneyprocent = lostdebt * procentmouth;
                    basicmoney = everymouth - moneyprocent;
                    lostdebt = lostdebt - Convert.ToInt32(basicmoney);
                    form.dataGridView1.Rows.Add(Date(mouth, year), Convert.ToInt32(moneyprocent), Convert.ToInt32(basicmoney), Convert.ToInt32(lostdebt), "Дифференцированный");
                    mouth += 1;
                    if (mouth >= 12)
                    {
                        year += 1;
                        mouth = 1;
                    }
                }
            }
            form.label2.Text = $"{value - thank} ₽";
            form.label4.Text = $"{time} лет";
            form.label6.Text = $"{Convert.ToInt32(everymouth * (time * 12) - (value - thank))} ₽";
            form.label8.Text = $"{procent}%";
            form.label10.Text = $"{Convert.ToInt32(everymouth)} ₽";
            this.Hide();
            form.Show();
        }

        private string Date(int mouth, int year)
        {
            var himouth = "";
            switch (mouth)
            {
                case 1:
                    himouth = "Январь";
                    break;
                case 2:
                    himouth = "Февраль";
                    break;
                case 3:
                    himouth = "Март";
                    break;
                case 4:
                    himouth = "Апрель";
                    break;
                case 5:
                    himouth = "Май";
                    break;
                case 6:
                    himouth = "Июнь";
                    break;
                case 7:
                    himouth = "Июль";
                    break;
                case 8:
                    himouth = "Август";
                    break;
                case 9:
                    himouth = "Сентябрь";
                    break;
                case 10:
                    himouth = "Октябрь";
                    break;
                case 11:
                    himouth = "Ноябрь";
                    break;
                case 12:
                    himouth = "Декабрь";
                    break;
                case 0:
                    himouth = "Незаполнено!";
                    break;
            }
            return $"{year} {himouth}";
        }

    }
}
