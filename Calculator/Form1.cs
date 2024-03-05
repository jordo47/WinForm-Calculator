namespace Calculator
{
    public partial class Form1 : Form
    {
        String prevEntry = "";

        //Add=0, Subtract=1, Multiply=2, Divide=3
        int operation;

        bool isNewOp = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNewOp) 
            { 
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isNewOp)
            {
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isNewOp)
            {
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isNewOp)
            {
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isNewOp)
            {
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isNewOp)
            {
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isNewOp)
            {
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isNewOp)
            {
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isNewOp)
            {
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (isNewOp)
            {
                textBox1.Text = "";
                isNewOp = false;
            }
            textBox1.Text += "0";
        }

        private void clear(object sender, EventArgs e)
        {
            isNewOp = false;
            prevEntry = "";
            textBox1.Text = "";
        }

        private void clearEntry(object sender, EventArgs e)
        {
            isNewOp = false;
            textBox1.Text = "";
        }

        private void add(object sender, EventArgs e)
        {
            isNewOp = false;
            prevEntry = textBox1.Text;
            textBox1.Text = "";
            operation = 0;
        }

        private void subtract(object sender, EventArgs e)
        {
            isNewOp = false;
            prevEntry = textBox1.Text;
            textBox1.Text = "";
            operation = 1;
        }

        private void multiply(object sender, EventArgs e)
        {
            isNewOp = false;
            prevEntry = textBox1.Text;
            textBox1.Text = "";
            operation = 2;
        }

        private void divide(object sender, EventArgs e)
        {
            isNewOp = false;
            prevEntry = textBox1.Text;
            textBox1.Text = "";
            operation = 3;
        }

        private void equals(object sender, EventArgs e)
        {
            if (prevEntry == "")
                return;

            if (operation < 0 || operation > 3)
            {
                textBox1.Text = "ERROR";
                return;
            }

            if (operation == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + int.Parse(prevEntry)).ToString();

            if (operation == 1)
                textBox1.Text = (int.Parse(prevEntry) - int.Parse(textBox1.Text)).ToString();

            if (operation == 2)
                textBox1.Text = (int.Parse(textBox1.Text) * int.Parse(prevEntry)).ToString();

            if (operation == 3)
                textBox1.Text = (int.Parse(prevEntry) / int.Parse(textBox1.Text)).ToString();

            isNewOp = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
