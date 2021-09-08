using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        private double firstUserInput;
        private double nextUserInput;
        private double finalResult;

        public double FirstUserInput
        {
            get { return firstUserInput; }
            set
            {
                firstUserInput = value;
            }
        }

        public double NextUserInput
        {
            get { return nextUserInput; }
            set
            {
                nextUserInput = value;
            }
        }

        public double FinalResult
        {
            get { return finalResult; }
            set
            {
                finalResult = value;
            }
        }

        public Calculator()
        {
        }

        public Calculator(double firstUserInput, double nextUserInput)
        {
            firstUserInput = FirstUserInput;
            nextUserInput = NextUserInput;
        }


        
    }
}
