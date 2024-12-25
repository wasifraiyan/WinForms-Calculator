using System.Diagnostics;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
                textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button13.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Double.Parse(textBox_Result.Text); // Get the current value from the TextBox
                double y = resultValue; // The previous value
                string operation = operationPerformed; // Get the operation

                // Create a process to run the Python script
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "python"; // Ensure Python is in your PATH
                start.Arguments = $"D:\\COMP 2210\\calculator.py {y} {x} {operation}"; // Path to the Python script and passing arguments
                start.UseShellExecute = false; // Do not use OS shell
                start.RedirectStandardOutput = true; // Redirect output to read the result
                start.CreateNoWindow = true; // Do not create a console window

                // Start the process and capture the output
                using (Process process = Process.Start(start))
                {
                    using (System.IO.StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd(); // Read the output from the Python script
                        textBox_Result.Text = result; // Display the result in the TextBox
                    }
                }

                isOperationPerformed = false; // Reset the operation flag
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        /*private void button13_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(textBox_Result.Text); // Get the value from the TextBox
            double y = resultValue; // Assuming 'result' holds the previous value
            string operation = ""; // Set the operation based on button clicks (you should have this already set)

            // Create a process to run the Python script
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python"; // Ensure Python is in your PATH
            start.Arguments = $"D:\\COMP 2210\\calculator.py {y} {x} {operation}"; // Full path to the script
            start.UseShellExecute = false; // Do not use OS shell
            start.RedirectStandardOutput = true; // Redirect output
            start.CreateNoWindow = true; // Do not create a console window

            using (Process process = Process.Start(start))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd(); // Read the output from the script
                    textBox_Result.Text = result; // Display the result in the TextBox
                }
            }

            isOperationPerformed = false;
        }

        /*{
            switch (operationPerformed)

            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;

            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
            }*/
    }


}