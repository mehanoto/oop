using solitare;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSolitare
{
    
    
    /// <summary>
    ///This is a test class for DeckTest and is intended
    ///to contain all DeckTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DeckTest
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
        ///A test for RemoveCard
        ///</summary>
        [TestMethod()]
        public void RemoveCardTest()
        {
            Deck target = new Deck(); // TODO: Initialize to an appropriate value
            Card cToRemove = new Card(2, 2); // TODO: Initialize to an appropriate value

            Assert.AreEqual(52, target.NumberOfCards);

            bool actual = target.RemoveCard(cToRemove);
            Assert.AreEqual(true, actual);
            Assert.AreEqual(51, target.NumberOfCards);

            actual = target.RemoveCard(cToRemove);
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        ///A test for RemoveCard
        ///</summary>
        [TestMethod()]
        public void RemoveImaginaryCardTest()
        {
            Deck deck = new Deck();
            Card fakeCard = new Card(20, 2); // Създаваме несъществуваща карта

            Assert.AreEqual(52, deck.NumberOfCards);
            Assert.AreEqual(false, deck.RemoveCard(fakeCard));
            Assert.AreEqual(52, deck.NumberOfCards);
        }

        /// <summary>
        ///A test for GetNextCard.
        ///Симулираме дали след извъртане на цялото тесте отново стигаме до първата изтеглена карта
        ///</summary>
        [TestMethod()]
        public void GetNextCardTest()
        {
            Deck deck = new Deck(); 
            Card firstCard = deck.GetNextCard(); 

            for (int i = 1; i < deck.NumberOfCards; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(firstCard, deck.GetNextCard());

        }
    }
}
