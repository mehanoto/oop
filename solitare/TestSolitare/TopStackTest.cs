using solitare;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSolitare
{
    
    
    /// <summary>
    ///This is a test class for TopStackTest and is intended
    ///to contain all TopStackTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TopStackTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        /// Първата карта може да бъде само асак!
        ///</summary>
        [TestMethod()]
        public void CheckFeasibleFirstCardTest()
        {
            //асаците трябва да връщат true за първа карта
            TopStack stack = new TopStack();
            for (int col = 1; col <= 4; col++)
            {
                Card ace = new Card(1, col);
                Assert.AreEqual(true, stack.CheckFeasible(ace));
            }

            //всичко освен асак трябва да връща false за първа карта
            for (int num = 2; num <= 13; num++)
            {
                for (int col = 1; col <= 4; col++)
                {
                    Card c = new Card(num, col);
                    Assert.AreEqual(false, stack.CheckFeasible(c));
                }
            }
        }

        
        [TestMethod()]
        public void CheckFeasibleFirstCardTest()
        {
            TopStack stack = new TopStack();
            int colour = 1; //пика
            for (int num = 1; num < 13; num++)
            {
                Card c = new Card(num, colour);
                stack.Push(c);
                Assert.AreEqual(true, stack.CheckFeasible( new Card(num + 1, colour) ));
                
            }
            stack.Push(new Card(13, colour));//пълна колона с всички карти

            //пробваме с несъществуваща следваща карта
            Assert.AreEqual(false, stack.CheckFeasible(new Card(14, colour)));

        }


        /// <summary>
        ///A test for Push
        ///</summary>
        [TestMethod()]
        public void PushTest()
        {
            TopStack stack = new TopStack();
            Assert.AreEqual(0, stack.NumberOfCards);
            int colour = 1; //пика
            for (int num = 1; num <= 13; num++)
            {
                Card c = new Card(num, colour);
                stack.Push(c);
            }
            Assert.AreEqual(13, stack.NumberOfCards);
        }


    }
}
