////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Project: Project 2 Hand-Deck-Cards
// File Name: DeckDriver.cs
// Description: Models a deck of cards
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Jason Self, selfj1@etsu.edu, East Tennessee State University
// Created: 9/21/2022
// Copyright: Jason Self, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using CardClass;

namespace CardClass;

/// <summary>
/// Creates the public class deck to be used in the driver.
/// </summary>
public class DeckDriver
{
    /// <summary>
    /// The Main method that creates a new deck, copies it, and deals 2 hands of seven cards
    /// </summary>
    public static void Main()
    {
        // makes a new deck and prints it using the writeline
        Deck defaultDeck = new Deck();
        Console.WriteLine("The original deck of cards:\n");
        Console.WriteLine(defaultDeck);

        // takes the defaultDeck and shuffles it using the Shuffle method
        Console.WriteLine("\nThe original Deck of cards after shuffling:\n");
        defaultDeck.Shuffle();
        Console.WriteLine(defaultDeck);

        // prints 2 hands of seven cards using the DealAHand method
        Console.WriteLine("\nTwo hands of seven cards each from the copied deck:\n");
        defaultDeck.DealAHand(6);
        Console.WriteLine(defaultDeck.DealAHand(6));
        defaultDeck.DealAHand(6);
        Console.WriteLine(defaultDeck.DealAHand(6));

        Console.WriteLine("How many cards are in one hand? \n");

        Console.WriteLine("How many players are playing? \n");
    }
}