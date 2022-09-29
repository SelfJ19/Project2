////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Project: Project 2 Hand-Deck-Cards
// File Name: Hand.cs
// Description: Models one single card out of an entire deck
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Jason Self, selfj1@etsu.edu, East Tennessee State University
// Created: 9/21/2022
// Copyright: Jason Self, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Xml;

namespace CardClass;

/// <summary>
/// creates the public class Hand
/// </summary>
public class Hand
{
    /// <summary>
    /// get and set attributes for public class Hand
    /// </summary>
    public Card[] GameHand { get; set; }
    public int HandSize { get; set; }
    public int CardsInHand { get; set; }

    #region Hand()
    /// <summary>
    /// Default Hand constructor sets the HandSize to 5 by default
    /// </summary>
    public Hand()
    {
        GameHand = new Card[52];
        HandSize = 5;
        CardsInHand = 0;
        // loop to make a new card using the size of the GameHand array
        for (int i = 0; i < GameHand.Length; i++)
        {
            GameHand[i] = new Card(i);
        }
    }
    #endregion

    #region Hand(HandSize)
    /// <summary>
    /// public Hand that accepts an integer handSize
    /// </summary>
    /// <param name="handSize">stores the user input for the size of their hand of cards</param>
    public Hand(int handSize)
    {
        HandSize = handSize;
    }
    #endregion

    #region Hand(existingHand)
    /// <summary>
    /// Creates a deep copy of the Hand constructor
    /// </summary>
    /// <param name="existingHand">copies the existing hand</param>
    public Hand(Hand existingHand)
    {
        GameHand = new Card[existingHand.GameHand.Length];
        // Loop that makes all cards at their repsective indexes in GameHand equal to the existing hand which makes an exact copy
        for (int i = 0; i < GameHand.Length; i++)
        {
            GameHand[i] = existingHand.GameHand[i];
        }
    }
    #endregion

    #region AddACard(Card)
    /// <summary>
    /// Creates the AddACard constructor that accepts a card of the Card class
    /// </summary>
    /// <param name="card">stores a card of the Card class when adding a card</param>
    public void AddACard(Card card)
    { 
        GameHand[CardsInHand] = card;
        CardsInHand++;           
    }
    #endregion

    #region ToString()
    /// <summary>
    /// ToString method that formats the return ToString
    /// </summary>
    /// <returns>the format wanted for displaying the hand of cards a player is dealt using the ToString from card</returns>
    public override string ToString()
    {
        string HandStrings = "";
        for (int i = 0; i < GameHand.Length; i++)
        {
            HandStrings += GameHand[i].ToString();
            HandStrings += "\n";
        }
        return HandStrings;
    }
    #endregion
}