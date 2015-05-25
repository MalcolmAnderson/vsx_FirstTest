using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using FirstTest;

namespace FirstTest
{
    [TestClass]
    public class MyThingTests
    {
        [TestMethod]
        public void MyThingShouldInstantiate()
        {
            FirstTest.MyThing o = new FirstTest.MyThing();
            Assert.AreEqual(o.GetType().ToString(), "FirstTest.MyThing"); 
            //adding a comment to force a synch
        }
    }
}
