using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BailamASMLAD3
{
    public class Bai3Asm
    {
        public double CalculateAverage(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArithmeticException("ERROR");
            }

            int tong = 0;
            foreach (var number in numbers)
            {
                tong += number;
            }
            return (double)tong / numbers.Count;
        }
    }
}
