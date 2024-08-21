namespace Talskrivare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startnumber = 0;
        int endnumber = 0;
        int numbertowrite = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out startnumber);
            int.TryParse(textBox2.Text, out endnumber);

            richTextBox1.Text = startnumber.ToString();
            numbertowrite = startnumber + 1;

            while (numbertowrite <= endnumber)
            {
                richTextBox1.Text += " ";
                richTextBox1.Text += numbertowrite.ToString();
                numbertowrite++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out endnumber);
            int.TryParse(textBox2.Text, out startnumber);

            richTextBox1.Text = startnumber.ToString();
            numbertowrite = startnumber - 1;

            while (numbertowrite >= endnumber)
            {
                richTextBox1.Text += " ";
                richTextBox1.Text += numbertowrite.ToString();
                numbertowrite--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out startnumber);
            int.TryParse(textBox2.Text, out endnumber);

            richTextBox1.Text = startnumber.ToString();
            numbertowrite = startnumber + 1;

            while (numbertowrite <= endnumber)
            {
                if (numbertowrite % 2 == 0)
                {
                    numbertowrite++;
                }
                else if (numbertowrite % 2 != 0)
                {
                    richTextBox1.Text += " ";
                    richTextBox1.Text += numbertowrite.ToString();
                    numbertowrite++;
                }
            }
        }
    }
}
