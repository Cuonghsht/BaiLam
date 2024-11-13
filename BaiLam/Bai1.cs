using NUnit.Framework;
using System;
using BailamASMLAD3;

namespace BaiLam
{
    [TestFixture]
    public class Bai1
    {
        [Test]
        public void Bai1_1()
        {
            Bai1Asm tinh = new Bai1Asm();
            float result = tinh.Tich(4, 2);
            float expected = 8;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai1_2()
        {
            Bai1Asm tinh = new Bai1Asm();
            Assert.Throws<OverflowException>(() => tinh.Tich(int.MaxValue, 2));
        }

        [Test]
        public void Bai1_3()
        {
            Bai1Asm tinh = new Bai1Asm();
            float result = tinh.Tich(5, 2);
            float expected = 11;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai1_4()
        {
            Bai1Asm tinh = new Bai1Asm();
            float result = tinh.Tich(6, 2);
            float expected = 12;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai1_5()
        {
            Bai1Asm tinh = new Bai1Asm();
            float result = tinh.Tich(6, 1);
            float expected = 6;
            Assert.That(result, Is.EqualTo(expected));
        }

        
        [Test]
        public void Bai1_6()
        {
            Bai1Asm tinh = new Bai1Asm();
            float result = tinh.Tich(-4, -3);
            float expected = 12;
            Assert.That(result, Is.EqualTo(expected));
        }

       
        [Test]
        public void Bai1_7()
        {
            Bai1Asm tinh = new Bai1Asm();
            float result = tinh.Tich(-5, 3);
            float expected = -15;
            Assert.That(result, Is.EqualTo(expected));
        }

       
        [Test]
        public void Bai1_8()
        {
            Bai1Asm tinh = new Bai1Asm();
            float result = tinh.Tich(int.MaxValue, 1);
            float expected = (float)int.MaxValue;
            Assert.That(result, Is.EqualTo(expected));
        }

        
        [Test]
        public void Bai1_9()
        {
            Bai1Asm tinh = new Bai1Asm();
            float result = tinh.Tich(int.MinValue, 1);
            float expected = (float)int.MinValue;
            Assert.That(result, Is.EqualTo(expected));
        }

      
        [Test]
        public void Bai1_10()
        {
            Bai1Asm tinh = new Bai1Asm();
            float result = tinh.Tich(int.MaxValue, -1);
            float expected = -(float)int.MaxValue;
            Assert.That(result, Is.EqualTo(expected));
        }

        
        
            
        
    }
}
