using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Library;
using NUnit.Framework;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [TestFixture]
    internal class TestKundeAddAusgelhiehen
    {
        [Test]
        public void TestausleihenPreis1()
        {
            Medium b1 = new Buch("TestBuch", 1, 2019, 263, "action", 13);
            Kunde k1 = new Kunde("Aurel", "Bieri", 16, 1);
            List<Medium> mediumlist = new List<Medium>();

            k1.addAusgelhiehen(b1, 16);
            mediumlist = k1.getAusgeliehen();

            string result = mediumlist[0].getName();

            Assert.That(result, Is.EqualTo("TestBuch"));
        }   
    }
}
