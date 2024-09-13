using System.Drawing.Text;

namespace IntroToMethods
{
    public partial class Form1 : Form
    {
        //global variables
        Single num1, num2, answer;
        Single runningTotal;


        public Form1()
        {
            InitializeComponent();
        }

        //Add
        //Subtract
        //Divide
        //Multiply



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //pass in the two numbers
            num1 = Convert.ToSingle(txtNum1.Text);
            num2 = Convert.ToSingle(txtNum2.Text);

            string operation = cbxOperation.SelectedItem.ToString();

            if (operation == "Add")
            {
                Add();
            }

            if (operation == "Subtract")
            {
                Subtract(num1, num2);
            }

            if (operation == "Divide")
            {
                float ans = Divide(num1, num2);
                MessageBox.Show(ans.ToString());
            }

            if (operation == "Multiply")
            {
                var number1 = num1;
                var number2 = num2;
                MessageBox.Show(Multiply(number1, number2));
            }
        }

        //method 1, a method that just uses global variables, and no parameters  
        private void Add()
        {
            //do the calculation
            answer = num1 + num2;
            //show the output
            MessageBox.Show(answer.ToString());
        }

        //method 2, a method that takes in parameters  
        //takes in 2 parameters name them whatever you want. 
        private void Subtract(float number1, float number2)
        {
            //do the calculation
            answer = number1 + number2;
            //show the output
            MessageBox.Show(answer.ToString());
        }

        //method 3, a method that takes in parameters and returns a result 
        private float Divide(float number1, float number2)
        {
            //do the calculation
            answer = number1 + number2;
            return answer; //send back the result
        }

        //method 4, a method that just uses local variables, parameters , and returns a result 
        private string Multiply(float number1, float number2)
        {
            //do the calculation
            float answer = number1 + number2;
            //format the output for use as a string
            return answer.ToString();
        }

        private void btnRunningTotal_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(txtNum1.Text);
            lblRt.Text = RunningTotal(num1);

        }

        private string RunningTotal(float rt)
        {
            runningTotal += rt;
            return runningTotal.ToString();
        }
    }
}
