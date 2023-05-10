using solitare;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestSolitare
{
    
    
    /// <summary>
    ///This is a test class for SolitareStackTest and is intended
    ///to contain all SolitareStackTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SolitareStackTest
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
        ///A test for CheckFeasible
        ///</summary>
        [TestMethod()]
        public void CheckFeasibleBasic()
        {
            SolitareStack target = new SolitareStack();
            target.AddToTop(new Card(3, 2));
            Card c = new Card(2, 3); 
            bool actual;
            actual = target.CheckFeasible(c);
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        ///A test for CheckFeasible
        ///</summary>
        [TestMethod()]
        public void CheckFeasibleSameColor()
        {
            SolitareStack target = new SolitareStack();
            target.AddToTop(new Card(3, 1));
            Card c = new Card(2, 3);
            bool actual;
            actual = target.CheckFeasible(c);
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        ///A test for CheckFeasible
        ///</summary>
        [TestMethod()]
        public void CheckFeasibleAnotherCard()
        {
            SolitareStack target = new SolitareStack();
            target.AddToTop(new Card(4, 1));
            Card c = new Card(2, 2);
            bool actual;
            actual = target.CheckFeasible(c);
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        ///A test for Slice
        ///</summary>
        [TestMethod()]
        public void SliceTest()
        {
            //1-пика, 2-купа, 3-спатия, 4-каро
            SolitareStack target = new SolitareStack();

            target.AddToTop(new Card(13, 1));
            target.AddToTop(new Card(12, 2));
            target.AddToTop(new Card(11, 3));
            target.AddToTop(new Card(10, 4));
            target.AddToTop(new Card(9, 1));

            target.Flip();
            target.Flip();
            target.Flip();

            List<Card> actual;
            actual = target.Slice(3);
            Assert.AreEqual(3, actual.Count);
            Card jackClubs = new Card(11, 3);
            Assert.AreEqual(jackClubs, actual[0]);
            Card tenDiamonds = new Card(10, 4);
            Assert.AreEqual(tenDiamonds, actual[1]);
            Card nineSpades = new Card(9, 1);
            Assert.AreEqual(nineSpades, actual[2]);

            Card queenHearts = new Card(12, 2);
            Assert.AreEqual(queenHearts, target.TopCard);
        }

        /// <summary>
        ///A test for Slice
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void SliceTestInsufficientVisibleCards()
        {
            //1-пика, 2-купа, 3-спатия, 4-каро
            SolitareStack target = new SolitareStack();
            target.AddToTop(new Card(13, 1));
            target.AddToTop(new Card(12, 2));

            target.Flip();
            target.Flip();

            target.Slice(3);

        }

        /// <summary>
        ///A test for Slice
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void SliceTestNoVisibleCards()
        {
            //1-пика, 2-купа, 3-спатия, 4-каро
            SolitareStack target = new SolitareStack();
            target.AddToTop(new Card(13, 1));
            target.AddToTop(new Card(12, 2));

            target.Slice(1);

        }


        /// <summary>
        ///A test for Flip
        ///</summary>
        [TestMethod()]
        public void FlipTest()
        {
            SolitareStack target = new SolitareStack(); // TODO: Initialize to an appropriate value
            target.AddToTop(new Card(13, 1));
            target.AddToTop(new Card(12, 2));
            target.Flip();

            Card kingOfSpades = new Card(13, 1);
            Assert.AreEqual(kingOfSpades, target.TopCard);
            Assert.AreEqual(1, target.VisibleCards);

            target.Flip();
            Assert.AreEqual(2, target.VisibleCards);
        }

        /// <summary>
        ///A test for AddToTop
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void AddToTopTest()
        {
            SolitareStack target = new SolitareStack(); // TODO: Initialize to an appropriate value
            target.AddToTop(new Card(13, 1));
            target.AddToTop(new Card(11, 1));
        }

        /// <summary>
        ///A test for IsEmpty
        ///</summary>
        [TestMethod()]
        public void IsEmptyTest()
        {
            SolitareStack target = new SolitareStack(); // TODO: Initialize to an appropriate value
            Assert.AreEqual(true, target.IsEmpty());
        }
    }
}
