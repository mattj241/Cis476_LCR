using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConversionProgram
{
    public class ConversionRequest
    {
        public double Input { get; }
        public double Output { get; set; }

        public ConversionRequest(double input)
        {
            this.Input = input;
        }
    }
}
