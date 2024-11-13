using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BailamASMLAD3
{
    public class Bai2asm
    {
        public float Chia2So(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            throw new ArgumentException("b phai khac 0");
        }
    }
}
