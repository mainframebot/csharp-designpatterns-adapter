using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPatternLesson;
using NUnit.Framework;

namespace AdapterPatternTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Testing()
        {
            var first = new Adaptee();
            var firstTest = first.SpecificRequest(5, 3);

            var second = new Adapter();
            var secondTest = second.Request(5);
        }
    }
}
