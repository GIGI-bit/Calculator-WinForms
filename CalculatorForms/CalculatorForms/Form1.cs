namespace CalculatorForms
{
    public partial class Form1 : Form
    {
        double total = 0;
        double current = 0;
        string currentSymb = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void changeLabelSize(int currentSize, int currentX)
        {
            lbl_current.Width = currentSize + 20;
            lbl_current.Location = new Point(currentX - 30, lbl_current.Location.Y);
        }

        private void changeLabel(int num)
        {
            if (int.Parse(lbl_current.Text) == 0) lbl_current.Text = num.ToString();
            else
            {
                changeLabelSize(lbl_current.Width, lbl_current.Location.X);
                int temp = int.Parse(lbl_current.Text) * 10 + num;
                lbl_current.Text = temp.ToString();
            }
        }

        private void calculate()
        {
            if (lbl_total.Text == "0")
            {
                lbl_total.Text = lbl_current.Text;
                lbl_current.Text = "0";
                return;
            }
            if (currentSymb == "-")
            {
                total -= int.Parse(lbl_current.Text);
                lbl_total.Text = total.ToString();
            }
            else if (currentSymb == "+")
            {
                total += int.Parse(lbl_current.Text);
                lbl_total.Text = total.ToString();
            }
            else if (currentSymb == "*")
            {
                total *= int.Parse(lbl_current.Text);
                lbl_total.Text = total.ToString();
            }
            else if (currentSymb == "/")
            {
                total /= int.Parse(lbl_current.Text);
                lbl_total.Text = total.ToString();
            }
            lbl_current.Text = "0";

        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "0";
            lbl_current.Location = new Point(304, 115);
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            currentSymb = "-";
            calculate();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            currentSymb = "/";
            calculate();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            currentSymb = "*";
            calculate();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            currentSymb = "+";
            calculate();
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            calculate();
            lbl_current.Text = total.ToString();
        }
    }
}