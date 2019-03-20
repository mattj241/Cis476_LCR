using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthConversionProgram
{
    public partial class Client : Form
    {
        string[] units = { "Mile", "Yard", "Foot" };

        private ConversionHandler mileHandler;
        private ConversionHandler yardHandler;
        private ConversionHandler footHandler;
        private ConversionRequest conversionRequest;

        public Client()
        {
            InitializeComponent();
            Spinner.Items.AddRange(units);
            mileHandler = new MileHandler();
            yardHandler = new YardHandler();
            footHandler = new FootHandler();
            mileHandler.SetSuccessor(yardHandler);
            yardHandler.SetSuccessor(footHandler);
        }

        private void ConverBtn_Click(object sender, EventArgs e)
        {
            bool isGoodParse = Double.TryParse(kiloTextBox.Text, out double input);
            if (!isGoodParse)
            {
                MessageBox.Show("Not Valid Input!");
            }
            else
            {
                conversionRequest = new ConversionRequest(input);
                mileHandler.HandleConversion(Spinner.Text, conversionRequest);
                SolutionBox.Text = conversionRequest.Output.ToString();
            }
        }
    }
}
