using System.Drawing.Text;

namespace IntroToMethods
{
    public partial class Form1 : Form
    {
        Single num1, num2, answer;

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
            answer = num1 + num2;
            MessageBox.Show(answer.ToString());
        }

        //method 2, a method that takes in parameters  
        private void Subtract(float number1, float number2)
        {
            answer = number1 + number2;
            MessageBox.Show(answer.ToString());
        }

        //method 3, a method that takes in parameters and returns a result 
        private float Divide(float number1, float number2)
        {
            answer = num1 + num2;
            return answer;
        }

        //method 1, a method that just uses local variables, parameters , and returns a result 
        private string Multiply(float number1, float number2)
        {
            answer = num1 + num2;
            return answer.ToString();


        }



    }
}
