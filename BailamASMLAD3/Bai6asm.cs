using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BailamASMLAD3
{
    public class Bai6asm
    {
        public int TruyXuat(int a)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            if (a < 0 || a >= list.Count)
            {
                throw new IndexOutOfRangeException("ERROR");
            }
            return list[a];
        }
        public int min(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new InvalidOperationException("NUll");
            }

            return list.Min();
        }
    }
}
