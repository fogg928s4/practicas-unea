using CalculatorService;
using static CalculatorService.CalculatorSoapClient;

namespace SoapTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Part of the CalculatorService namespace
        // Inside the parameter for the constructor que have to add a shit from the CalcuatorService.EndpointConfiguration enum
        private CalculatorSoapClient client =
                new CalculatorSoapClient(
                    EndpointConfiguration.CalculatorSoap12,
                    "http://www.dneonline.com/calculator.asmx"
               );

        private void sendBtn_Click(object sender, EventArgs e) {
            int result = 0;
            switch (operationBox.SelectedIndex)
            {
                case 0:
                    result = client.Add(
                        (int) num1.Value, (int) num2.Value
                        ); 
                    break;
                case 1:
                    result = client.Multiply(
                        (int)num1.Value, (int)num2.Value
                        );
                    break;
                case 2:
                    result = client.Divide(
                        (int)num1.Value, (int)num2.Value
                        );
                    break;
                case 3:
                    result = client.Subtract(
                        (int)num1.Value, (int)num2.Value
                        );
                    break;
                default:
                    result = 0; 
                break;
            }
            ShowResultMessageBox($"{result}");

        }
        private enum AvailableOperations : int
        {
            Add,
            Substract,
            Divide,
            Multiply
        }
        private void ShowResultMessageBox(string message)
        {
            MessageBox.Show(message, "Result");
        }
    }
}