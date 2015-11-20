using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test
{[TestFixture]
    class TestCalculator
    {

    DemoTravisCI.Calculator c = new DemoTravisCI.Calculator();

    [TestCase(1,1,2)]
    [TestCase(2,2,3)]
    public void TestAdd(int a, int b, int kq)
    {
        Assert.AreEqual(c.Add(a, b), kq);
    }

    }
}
