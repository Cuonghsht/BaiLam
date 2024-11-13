using BailamASMLAD3;
using NUnit.Framework;
using System;

namespace BaiLam
{
    [TestFixture]
    public class Bai4
    {
        [Test]
        public void B4TruyXuat()
        {
            Bai4asm t = new Bai4asm();
            int result = t.TruyXuat(2);
            int expected = 6;
            // kq = 3 ;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void B4TruyXuat2()
        {
            Bai4asm t = new Bai4asm();
            Assert.Throws<IndexOutOfRangeException>(() => t.TruyXuat(16));
        }

       
        [Test]
        public void B4TruyXuat3()
        {
            Bai4asm t = new Bai4asm();
            int result = t.TruyXuat(0);
            int expected = 1; 
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
