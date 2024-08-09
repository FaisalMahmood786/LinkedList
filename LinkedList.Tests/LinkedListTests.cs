using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LinkedList.Tests
{
    [TestFixture]
    public class LinkedListTests
    {
        private LinkedList<int> list;

        [SetUp]
        public void Setup()
        {
            list = new LinkedList<int>();
        }

        [Test]
        public void Insert_AtHead_Position1()
        {
            list.Insert(1, 10);
            Assert.AreEqual("10", list.PrintList());
        }

        [Test]
        public void Insert_AtPosition2()
        {
            list.Insert(1, 10);
            list.Insert(2, 20);
            Assert.AreEqual("10 -> 20", list.PrintList());
        }

        [Test]
        public void Insert_InMiddle()
        {
            list.Insert(1, 10);
            list.Insert(2, 30);
            list.Insert(2, 20); 
            Assert.AreEqual("10 -> 20 -> 30", list.PrintList());
        }
    }
}
