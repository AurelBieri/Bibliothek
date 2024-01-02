using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using NUnit.Framework;

namespace ClassLibrary2
{
    [TestFixture]
    public class TestAusleihen
    {
        [Test]
        public void TestausleihenPreis1()
        {
            DVD d1 = new DVD("TestBuch Version 2", 1, 2021, 120, "HD", "action", 20);
            Kunde k1 = new Kunde("Aurel", "Bieri", 16, 1);

            k1.addAusgelhiehen(d1, 15);

            double result = d1.ausleihenPreis();

            Assert.That(result, Is.EqualTo(1.5));
        }

        [Test]
        public void TestausleihenPreis2()
        {
            DVD d1 = new DVD("TestBuch Version 2", 1, 2021, 120, "HD", "action", 20);
            Kunde k1 = new Kunde("Aurel", "Bieri", 16, 1);

            k1.addAusgelhiehen(d1, 9);

            double result = d1.ausleihenPreis();

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void TestausleihenPreis3()
        {
            Buch b1 = new Buch("TestBuch Version 2", 2, 2021, 354, "action", 15);
            Kunde k1 = new Kunde("Aurel", "Bieri", 16, 1);

            k1.addAusgelhiehen(b1, 26);

            double result = b1.ausleihenPreis();

            Assert.That(result, Is.EqualTo(0.78));
        }
    }
}
