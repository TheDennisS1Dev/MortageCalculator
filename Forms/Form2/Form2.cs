using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace MortgageCalculator
{
    public partial class Form2 : Form
    {
        public int mouthyear;
        public Form2()
        {
            Form1 form = new Form1();
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#B3E8E5");
            saveFileDialog1.Filter = "Книга Excel(*.xlxs)|*.xlxs|All files(*.*)|*.*";
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
            label12.ForeColor = ColorTranslator.FromHtml("#02475E");
            label13.ForeColor = ColorTranslator.FromHtml("#02475E");
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#82DBD8");
            panel1.BackColor = ColorTranslator.FromHtml("#82DBD8");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog1.FileName;
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, filename)))
                    {
                        helper.Set(column: "A", row: 1, data: "Месяц");
                        helper.Set(column: "C", row: 1, data: "Проценты");
                        helper.Set(column: "D", row: 1, data: "Долг");
                        helper.Set(column: "E", row: 1, data: "Остаток");
                        helper.Set(column: "F", row: 1, data: "Тип платежа");
                        for (var i = 2; i < dataGridView1.RowCount; i++)
                        {
                            var info = dataGridView1[0, i - 1].Value.ToString();
                            helper.Set(column: "A", row: i, data: info);
                            var info1 = dataGridView1[1, i - 1].Value.ToString();
                            helper.Set(column: "C", row: i, data: info1);
                            var info2 = dataGridView1[2, i - 1].Value.ToString();
                            helper.Set(column: "D", row: i, data: info2);
                            var info3 = dataGridView1[3, i - 1].Value.ToString();
                            helper.Set(column: "E", row: i, data: info3);
                            var info4 = dataGridView1[4, i - 1].Value.ToString();
                            helper.Set(column: "F", row: i, data: info4);
                        }
                        helper.Save();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show($"Файл успешно загружен!\nИщите тут: {filename}");
        }
    }
}
