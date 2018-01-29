using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stack;

namespace TestStack
{ 
    [TestFixture]
    class TestStacker
    {

        [Test]
        public void TestIsEmpty()
        {
            Stack.Stacker<String> s = new Stack.Stacker<String>();
            Assert.True(s.IsEmpty());
            s.Push("Object1");
            Assert.False(s.IsEmpty());
        }

    }
}
