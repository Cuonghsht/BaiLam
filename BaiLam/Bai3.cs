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

    public class Bai3
    {
        [Test]
        public void B3TrungBinhCong()
        {
            Bai3Asm calculator = new Bai3Asm();
            List<int> emptyList = new List<int>();
            Assert.Throws<ArithmeticException>(() => calculator.CalculateAverage(emptyList));
        }
        [Test]
        public void B3TrungBinhCongVoiDanhSachCoPhanTu()
        {
            Bai3Asm calculator = new Bai3Asm();
            List<int> numbers = new List<int> { 10, 20, 30 };
            double result = calculator.CalculateAverage(numbers);
            double expected = 10;
            // kq=20
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
