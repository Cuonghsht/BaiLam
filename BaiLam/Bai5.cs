using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BailamASMLAD3.Bai5asm;

namespace BaiLam
{
    [TestFixture]
    public class Bai5
    {
        [Test]
        public void Bai5_1()
        {
            UserService service = new UserService();

            Assert.Throws<NullReferenceException>(() => service.GetName(null));
        }

        [Test]
        public void Bai5_2()
        {
            UserService service = new UserService();
            UserProfile profile = new UserProfile { Name = "Cuongmeme" };

            string result = service.GetName(profile);

            Assert.That( result, Is.EqualTo("Cuongmeme"));
        }
        [Test]
        public void Bai5_3()
        {
            UserService service = new UserService();
            UserProfile profile = new UserProfile { Name = "" };

            string result = service.GetName(profile);

            Assert.That(result, Is.EqualTo(""));
        }
    }
}
