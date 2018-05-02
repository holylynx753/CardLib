using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ch10CardLib.Tests
{
    [TestFixture]
    public class DeckTests
    {
        [Test, Order(1)]
        public void getCard()
        {
            // Arrange
            Deck myDeck = new Deck();
            //myDeck.Shuffle();

            //Act
            Card tempCard = myDeck.GetCard(0);
            string cardNameActual = tempCard.ToString();

            Console.WriteLine(cardNameActual);

            //assert 
            Assert.That(cardNameActual, Is.EqualTo("The Ace of Club's"));
        }

        [Test, Order(2)]
        public void get52Card()
        {
            // Arrange
            Deck myDeck = new Deck();
            myDeck.Shuffle();

            //Act
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());
                if (i != 51)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }
        }

        [Test, Order(3)]
        public void AssertThrowsTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                new TestDelegate(MethodThatThrows)
            );
        }

        void MethodThatThrows()
        {
            // Arrange
            Deck myDeck = new Deck();
            myDeck.Shuffle();

            //Act
            Card tempCard = myDeck.GetCard(53);
            
        }

    }
}
