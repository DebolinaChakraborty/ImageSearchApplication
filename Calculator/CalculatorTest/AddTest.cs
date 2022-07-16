using Calculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    [TestFixture]
    public class AddTest
    {
        [Test]
        public void TestOperate()
        {
            IOperate operate = new Add();
            Assert.AreEqual(operate.PerformOperation(3, 6), 9);
        }
    }
}
