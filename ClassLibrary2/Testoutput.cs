using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using NUnit.Framework;
using System.Xml.Linq;

namespace ClassLibrary2
{
	[TestFixture]
	internal class Testoutput
	{
		[Test]
		public void OutputBuchTest1()
		{
            Medium D1 = new DVD("TestBuch Version 2", 6, 2021, 120, "HD", "action", 54);
            string result = D1.Output();
            Assert.That(result, Is.EqualTo("DVD: Name: TestBuch Version 2 with the Id 6 has a duration of 120 Minutes. With a resolution of HD. Genre: action It was released in 2021 Costs: 54"));
        }

        [Test]
        public void OutputBuchTest2()
        {
            Medium b1 = new Buch("TestBuch", 1, 2019, 263, "action", 13);
            string result = b1.Output();
            Assert.That(result, Is.EqualTo("Book: Name: TestBuch with the Id 1 has 263 Pages. Genre: action It was released in 2019 Costs: 13"));
        }

        [Test]
        public void OutputBuchTest3()
        {
            Medium m1 = new Musik("GUTS", 17, 2023, 39, 30, "Olivia Rodrigo", "Pop");
            string result = m1.Output();
            Assert.That(result, Is.EqualTo("Musik: Name: GUTS with the Id 17 has a duration of 39 Minutes. It was released in 2023 Costs: 30 Singer: Olivia Rodrigo Style of music: Pop"));
        }

    }
}
