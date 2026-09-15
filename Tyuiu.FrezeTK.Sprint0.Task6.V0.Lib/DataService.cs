using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FrezeTK.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;
        }
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            var i = 0;
            while (i < numbers.Length)
            {
                total = total - numbers[i];
                i++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1; 
            var i = 0;
            if (numbers.Length == 0) return 0; 

            do
            {
                total = total * numbers[i];
                i++;
            } while (i < numbers.Length);

            return total;
        }
    }
}