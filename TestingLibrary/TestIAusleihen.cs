using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Library;

namespace TestingLibrary
{
    [TestFixture]
    internal class TestIAusleihen
    {
        [Test]
        public void TestausleihenPreis()
        {
            DVD d1 = new DVD("TestBuch Version 2", 1, 2021, 120, "HD", "action", 20);
            Kunde k1 = new Kunde("Aurel", "Bieri", 16, 1);

            k1.addAusgelhiehen(d1, 15);

            float result = d1.ausleihenPreis();

            Assert.That(result, Is.EqualTo(1));
        }
    }
}