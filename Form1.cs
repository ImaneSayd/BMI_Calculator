namespace BMI_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text) / 100;
            double result = 0.0;

            result = weight / (height * height);

            if (result < 16.0)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.##") + "\r\n" + "You are Underweight (Severely thin)";
            }
            else if (result >= 16.0 & result <= 16.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.##") + "\r\n" + "You are Underweight (Moderately thin)";
            }
            else if (result >= 17.0 & result <= 18.4)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.##") + "\r\n" + "You are Underweight (Mildly thin)";
            }
            else if (result >= 18.5 & result <= 24.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.##") + "\r\n" + "You are in Normal range";
            }
            else if (result >= 25.0 & result <= 29.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.##") + "\r\n" + "You are Overweight (Pre-obese)";
            }
            else if (result >= 30.0 & result <= 34.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.##") + "\r\n" + "You are Obese (Class I)";
            }
            else if (result >= 35.0 & result <= 39.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.##") + "\r\n" + "You are Obese (Class II)";
            }
            else if (result >= 40.0)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.##") + "\r\n" + "You are Obese (Class III)";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Text = "";
            txtHeight.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }
    }
}
