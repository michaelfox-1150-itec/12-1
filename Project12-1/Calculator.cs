using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12_1
{
    public class Calculator
    {
        public Decimal enteredValue;
        public Decimal calculatedValue;

        public void Add(Decimal enteredValue)
        {
            calculatedValue += enteredValue;
        }

        public void Subtract(Decimal enteredValue)
        {
            calculatedValue -= enteredValue;
        }

        public void Multiply(Decimal enteredValue)
        {
            calculatedValue *= enteredValue;
        }

        public void Divide(Decimal enteredValue)
        {
            calculatedValue /= enteredValue;
        }

        public void SquareRoot(Decimal enteredValue)
        {
            calculatedValue = (decimal)Math.Sqrt(Convert.ToDouble(enteredValue));
        }

        public void Reciprocal(Decimal enteredValue)
        {
            calculatedValue = 1 / enteredValue;
        }

        public decimal Equals(Decimal enteredValue)
        {
            return calculatedValue;
        }

        public void Clear()
        {
            calculatedValue = 0;
            enteredValue = 0;
        }

        public decimal CalculatedValue
        {
            get
            {
                return calculatedValue;
            }
        }

        
    }
}
