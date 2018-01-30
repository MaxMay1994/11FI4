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
            Stack.Stacker s = new Stack.Stacker();
            Assert.True(s.IsEmpty());
        }

        [Test]
        public void TestPush()
        {
            Stack.Stacker s = new Stack.Stacker();
            s.Push("Object1");
            Assert.False(s.IsEmpty());
        }

        [Test]
        public void TestPop()
        {
            Stack.Stacker s = new Stack.Stacker();
            s.Push("Object1");
            s.Pop();
            Assert.True(s.IsEmpty());
        }

        [Test]
        public void TestPopEqualsPush()
        {
            Stack.Stacker s = new Stack.Stacker();
            String line1 = "Object1";
            s.Push(line1);
            AssertionException.Equals(s.Pop(), line1);
        }

        [Test]
        public void TestPopEqualsPushThreeTimes()
        {
            Stack.Stacker s = new Stack.Stacker();
            String line1 = "Object1";
            String line2 = "Object2";
            String line3 = "Object3";
            s.Push(line1);
            s.Push(line1);
            s.Push(line1);
            AssertionException.Equals(s.Pop(), line3);
            AssertionException.Equals(s.Pop(), line2);
            AssertionException.Equals(s.Pop(), line1);
        }

        [Test]
        public void TestPopEmptyStack()
        {
            Stacker s = new Stacker();
            Assert.Null(s.Pop());
        }

        [Test]
        public void TestTop()
        {
            Stack.Stacker s = new Stack.Stacker();
            String line1 = "Object1";
            s.Push(line1);
            AssertionException.Equals(s.Top(), line1);
            Assert.False(s.IsEmpty());
        }

        [Test]
        public void TestPopEqualsTop()
        {
            Stack.Stacker s = new Stack.Stacker();
            String line1 = "Object1";
            s.Push(line1);
            AssertionException.Equals(s.Top(), line1);
        }

        [Test]
        public void TestTopOfEmptyStack()
        {
            Stack.Stacker s = new Stack.Stacker();
            Assert.Null(s.Top());
        }

        [Test]
        public void TestPushNull()
        {
            Stack.Stacker s = new Stack.Stacker();
            s.Push(null);
            Assert.False(s.IsEmpty());
        }

        [Test]
        public void TestPushNullEqualsPop()
        {
            Stack.Stacker s = new Stack.Stacker();
            s.Push(null);
            AssertionException.Equals(s.Pop(), null);
        }

        [Test]
        public void TestPushNullEqualsTop()
        {
            Stack.Stacker s = new Stack.Stacker();
            s.Push(null);
            AssertionException.Equals(s.Top(), null);
        }

        [Test]
        public void TestTopEqualsPushThreeTimes()
        {
            Stack.Stacker s = new Stack.Stacker();
            String line1 = "Object1";
            String line2 = "Object2";
            String line3 = "Object3";
            s.Push(line1);
            s.Push(line1);
            s.Push(line1);
            AssertionException.Equals(s.Top(), line3);
            AssertionException.Equals(s.Top(), line2);
            AssertionException.Equals(s.Top(), line1);
        }

        [Test]
        public void TestTopThreeTimesEqualsPush()
        {
            Stack.Stacker s = new Stack.Stacker();
            String line1 = "Object1";
            s.Push(line1);
            AssertionException.Equals(s.Top(), line1);
            AssertionException.Equals(s.Top(), line1);
            AssertionException.Equals(s.Top(), line1);
        }
    }
}
