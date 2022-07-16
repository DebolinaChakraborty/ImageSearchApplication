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
    public class MultiplyTest
    {
        [Test]
        public void TestOperate()
        {
            IOperate operate = new Multiply();
            Assert.AreEqual(operate.PerformOperation(3, 6), 18);
        }
    }
}
