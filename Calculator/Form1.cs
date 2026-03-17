namespace Calculator
{


    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op = "";

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void RemoveFocus()
        {
            this.ActiveControl = null; 
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                if (num.Text == ".")
                    txtResult.Text += num.Text;
                else
                    txtResult.Text = "";

            if (txtResult.Text == "+" || txtResult.Text == "/" || txtResult.Text == "*" || txtResult.Text == "-")
                txtResult.Text = "";

            if (num.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text += num.Text;

            }
            else
            {
                txtResult.Text += num.Text;
            }
            RemoveFocus();
        }

        private void numberOperators(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (op == "")
            {
                enterFirstValue = Convert.ToDouble(txtResult.Text);
                op = num.Text;
                txtResult.Text = num.Text;
            }
            RemoveFocus();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                enterSecondValue = Convert.ToDouble(txtResult.Text);
                switch (op)
                {
                    case "+":
                        txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                        break;
                    case "-":
                        txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                        break;
                    case "*":
                        txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                        break;
                    case "/":
                        if (enterSecondValue == 0)
                        {
                            MessageBox.Show("Impartirea la 0 nu este operatie valida, incearca alta operatie.");
                            btnClear.PerformClick();
                        }
                        else
                            txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                        break;
                    default:
                        break;
                }
                op = "";
            }
            enterFirstValue = Convert.ToDouble(txtResult.Text);
            RemoveFocus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            enterFirstValue = 0;
            enterSecondValue = 0;
            op = "";
            RemoveFocus();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            RemoveFocus();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                double q = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(-1 * q);
            }
            RemoveFocus();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            else
            { txtResult.Text = "0"; }
            RemoveFocus();
        }

        private void ClickNumberButton(string number)
        {
            switch (number)
            {
                case "0": btn0.PerformClick(); break;
                case "1": btn1.PerformClick(); break;
                case "2": btn2.PerformClick(); break;
                case "3": btn3.PerformClick(); break;
                case "4": btn4.PerformClick(); break;
                case "5": btn5.PerformClick(); break;
                case "6": btn6.PerformClick(); break;
                case "7": btn7.PerformClick(); break;
                case "8": btn8.PerformClick(); break;
                case "9": btn9.PerformClick(); break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (e.KeyCode == Keys.D8)
                {
                    if (e.Shift)
                        btnMult.PerformClick();
                    else
                    {
                        string key = ((char)e.KeyCode).ToString();
                        ClickNumberButton(key);
                    }
                }
                else
                {
                    string key = ((char)e.KeyCode).ToString();
                    ClickNumberButton(key);
                }
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                string key = (e.KeyCode - Keys.NumPad0).ToString();
                ClickNumberButton(key);
            }

            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        btnEqual.PerformClick();
                        break;

                    case Keys.Add:
                        btnAdd.PerformClick();
                        break;

                    case Keys.Oemplus:
                        if (e.Shift)
                            btnAdd.PerformClick();
                        else
                            btnEqual.PerformClick();
                        break;

                    case Keys.Subtract:
                        btnSub.PerformClick();
                        break;

                    case Keys.OemMinus:
                        if (e.Shift)
                            break;
                        btnSub.PerformClick();
                        break;

                    case Keys.Multiply:
                        btnMult.PerformClick();
                        break;

                    case Keys.Divide:
                        btnDiv.PerformClick();
                        break;

                    case Keys.Oem2:
                        btnDiv.PerformClick();
                        break;

                    case Keys.Decimal:
                        btnDot.PerformClick();
                        break;

                    case Keys.OemPeriod:
                        btnDot.PerformClick();
                        break;

                    case Keys.Back:
                        btnBS.PerformClick();
                        break;

                    case Keys.Delete:
                        btnClearEntry.PerformClick();
                        break;

                    case Keys.Escape:
                        btnClear.PerformClick();
                        break;
                }
            }
        }
    }
}
