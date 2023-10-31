using System.Xml.Linq;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String Action = "";
        bool isAction = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void n_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isAction) ) 
                textBox.Clear();
            isAction = false;
            Button n = (Button)sender;
            if(n.Text == ".")
            {
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text;
            }else
            textBox.Text = textBox.Text + n.Text;

        }

        private void n_operation(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            Action = n.Text;
            resultValue = Double.Parse(textBox.Text);
            isCurrentOp.Text = resultValue + " " + Action;
            isAction = true;
            
        }

        private void n_result(object sender, EventArgs e)
        {
            switch (Action)
            {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "x":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;


            }
        }

        private void n_delete(object ender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void n_reset(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}