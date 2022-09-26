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
    public Card GameHand { get; set; }
    public int HandSize { get; set; }
    public int CardsInHand { get; set; }


    #region Hand()
    /// <summary>
    /// Default Hand constructor sets the HandSize to 5 by default
    /// </summary>
    public Hand()
    {
        GameHand = new Card();
        HandSize = 5;
        CardsInHand = 0;
    }
    #endregion

    #region Hand(HandSize)
    /// <summary>
    /// 
    /// </summary>
    /// <param name="handSize"></param>
    public Hand(int handSize)
    {

    }
    #endregion

    #region Hand(existingHand)
    /// <summary>
    /// 
    /// </summary>
    /// <param name="existingHand"></param>
    public Hand(Hand existingHand)
    {

    }
    #endregion

    #region AddACard(Card)
    /// <summary>
    /// 
    /// </summary>
    /// <param name="card"></param>
    public void AddACard(Card card)
    { 
           
    }
    #endregion

    #region ToString()
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return base.ToString();
    }
    #endregion
}
