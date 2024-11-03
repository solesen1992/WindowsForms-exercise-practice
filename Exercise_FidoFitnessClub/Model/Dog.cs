using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_FidoFitnessClub.Model
{
    public class Dog
    {
        // Properties
        public string Name { get; set; }
        public int FeeYear { get; set; }

        // Constructor
        public Dog(string name, int feeYear)
        {
            Name = name;
            FeeYear = feeYear;
        }

        public Dog(string name)
        {
            Name = name;
        }

        public Boolean IsFeeDue(int year)
        {
            return year > FeeYear;
            /*
             * boolean result = false;
             * if (year > this.feeYear) {
             *  result = true;
             * }
             * return result;
             */
        }

        public int DueYearsCount(int year)
        {
            return year - FeeYear;
            /*
             * int result = year - feeYear;
             * return result;
             */
        }

        //To string
        public override string ToString()
        {
            return $"Dog {Name}, feeYear = {FeeYear}";
        }

    }
}
