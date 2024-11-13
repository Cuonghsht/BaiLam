using BailamASMLAD3;
using NUnit.Framework;
using System;
namespace BaiLam
{
    [TestFixture]
    public class Bai2
    {
        [Test]
        public void Bai2_1()
        {
            Bai2asm tinh = new Bai2asm();
            float result = tinh.Chia2So(4, 2);
            float expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai2_2()
        {
            Bai2asm tinh = new Bai2asm();
            Assert.Throws<ArgumentException>(() => tinh.Chia2So(4, 0));
        }


        [Test]
        public void Bai2_3()
        {
            Bai2asm tinh = new Bai2asm();
            float result = tinh.Chia2So(10, 2);
            float expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai2_4()
        {
            Bai2asm tinh = new Bai2asm();
            float result = tinh.Chia2So(10, -2);
            float expected = -5;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai2_5()
        {
            Bai2asm tinh = new Bai2asm();
            float result = tinh.Chia2So(-10, 2);
            float expected = 3;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai2_6()
        {
            Bai2asm tinh = new Bai2asm();
            float result = tinh.Chia2So(-10, -2);
            float expected =9;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai2_7()
        {
            Bai2asm tinh = new Bai2asm();
            float result = tinh.Chia2So(10, 1);
            float expected = 10;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai2_8()
        {
            Bai2asm tinh = new Bai2asm();
            float result = tinh.Chia2So(0, 5);
            float expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }


        [Test]
        public void Bai2_9()
        {
            Bai2asm tinh = new Bai2asm();
            float result = tinh.Chia2So(int.MaxValue, 1);
            float expected = int.MaxValue;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Bai2_10()
        {
            Bai2asm tinh = new Bai2asm();
            Assert.Throws<OverflowException>(() => tinh.Chia2So(int.MinValue, -1));
        }
    }
}
