////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Project: Project 2 Hand-Deck-Cards
// File Name: Card.cs
// Description: Models one single card out of an entire deck
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Jason Self, selfj1@etsu.edu, East Tennessee State University
// Created: 9/21/2022
// Copyright: Jason Self, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace CardClass
{
    /// <summary>
    /// Creating the public class Card to use in DriverClass
    /// </summary>
    public class Card
    {
        //3 main components of an object class: attributes, constructors, methods
        /// <summary>
        /// Attributes - data that belongs to and describes an object of the class
        /// </summary>
        public Face Face { get; set; }
        public Suit Suit { get; set; }

        #region Card()
        /// <summary>
        /// default constructor: sets attributes to default values
        /// </summary>
        public Card()
        {
            Face = Face.Two;
            Suit = Suit.Diamonds;
        }
        #endregion

        #region CopyCard()
        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="existingCard">copies the existing card to Face and Suit</param>
        public Card(Card existingCard)
        {
            Face = existingCard.Face;
            Suit = existingCard.Suit;
        }
        #endregion

        #region Card(int)
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="n">number of cards in the deck</param>
        public Card(int n)
        {
            Face = (Face)Enum.GetValues(typeof(Face)).GetValue(n % 13);
            Suit = (Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4);
        }
        #endregion

        #region ToString()
        /// <summary>
        /// ToString method
        /// </summary>
        /// <returns>returns the ToString format for outputting a card</returns>
        public override string ToString()
        {
            string info = "";

            info = "the " + Face + " of " + Suit;

            return info;
        }
        #endregion
    }
}