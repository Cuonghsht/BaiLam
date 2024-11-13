using BailamASMLAD3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLam
{
    [TestFixture]

    public class Bai6
    {

        [Test]
        public void Bai6_1()
        {
            Bai6asm t = new Bai6asm();
            int result = t.TruyXuat(2);
            int expected = 3;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Bai6_2()
        {
            Bai6asm t = new Bai6asm();
            Assert.Throws<IndexOutOfRangeException>(() => t.TruyXuat(16));
        }
        [Test]
        public void bai6_3()
        {
            Bai6asm t = new Bai6asm();
            List<int> aaaa = new List<int>() { 1, 2, 3, 4, 56, 7 };
            int result = t.min(aaaa);

            int expected = 1; 
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
