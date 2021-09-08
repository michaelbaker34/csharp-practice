using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculate
    {
        public double Add(params int[] numbers)
        {
            double sum = 0;

            foreach(double number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Subtract(params int[] numbers)
        {
            double difference = 0;
            
            foreach(double number in numbers)
            {
                difference -= number;
            }
            return difference;
        }
    }
}
