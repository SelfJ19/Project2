////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Project: Project 2 Hand-Deck-Cards
// File Name: Deck.cs
// Description: Models a deck of cards and then shuffles it and deals a hand
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Jason Self, selfj1@etsu.edu, East Tennessee State University
// Created: 9/21/2022
// Copyright: Jason Self, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace CardClass;

/// <summary>
/// creates the public class Deck
/// </summary>
public class Deck
{
    /// <summary>
    /// Attributes - data that belongs to and describes an object of the class
    /// </summary>
    public Card[] DeckCards { get; private set; }
    public int NextCard { get; private set; }

    #region Deck()
    /// <summary>
    /// Default Deck constructor
    /// </summary>
    public Deck()
    {
        DeckCards = new Card[52];
        NextCard = 0;
        // Loop that sets all indices in deck cards equal to a card value from the card class
        for (int i = 0; i < DeckCards.Length; i++)
        {
            DeckCards[i] = new Card(i);
        }
    }
    #endregion

    #region Copy()
    /// <summary>
    /// Deck copy constructor
    /// Deep Copy
    /// </summary>
    public Deck(Deck existing)
    {
        NextCard = 0;
        DeckCards = new Card[existing.DeckCards.Length];
        // Loop that makes all cards at their repsective indexes in DeckCards equal to the existing deck which makes an exact copy
        for (int i = 0; i < DeckCards.Length; i++)
        {
            DeckCards[i] = existing.DeckCards[i];
        }
    }
    #endregion

    #region Shuffle()
    /// <summary>
    /// shuffle constructor
    /// </summary>
    public void Shuffle()
    {
        NextCard = 0;
        Random random = new Random();
        // Loop that iterates through every card in the deck of cards and shuffles them
        for (int i = 0; i < DeckCards.Length; i++)
        {
            int newCard = random.Next(DeckCards.Length);
            Card temp = DeckCards[i];
            DeckCards[i] = DeckCards[newCard];
            DeckCards[newCard] = temp;
        }
    }
    #endregion

    #region DealACard()
    /// <summary>
    /// DealACard method
    /// </summary>
    /// <returns>returns the value stored in newCard</returns>
    public Card DealACard()
    {
        Card newCard = DeckCards[NextCard];
        NextCard++;
        return newCard;
    }
    #endregion

    #region DealAHand()
    /// <summary>
    /// DealAHand method
    /// </summary>
    /// <param name="handSize">handSize stores the handSize of the user in an int variable</param>
    /// <returns>returns the hand of cards based on users input for handSize</returns>
    public Hand DealAHand(int handSize)
     {
        Hand hand = new Hand();
        // Loop that deals one card using DealACard() at a time until it has dealt handSize number of cards
        for (int i = 0; i <= handSize; i++)
        {
            Card card = DealACard();
            hand.AddACard(card);
        }
        return hand;
    }
    #endregion

    #region ToString()
    /// <summary>
    /// ToString method that returns all cards once from the deck array
    /// </summary>
    /// <returns>returns the DeckString format for the entire deck using the ToString of Card</returns>
    public override string ToString()
    {
        string DeckStrings = "";
        for(int i = 0; i < DeckCards.Length; i++)
        {
            DeckStrings += DeckCards[i].ToString();
            DeckStrings += "\n";
        }  
        return DeckStrings;
    }
    #endregion
}