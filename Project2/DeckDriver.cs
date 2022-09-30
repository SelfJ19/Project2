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
    /// The Main method that creates a new deck, copies it, and deals 2 hands of seven cards and players and cards for the players based on user input for playerSize and handSize
    /// </summary>
    public static void Main()
    {
        // creates a bool variable to set a validDeck to false at the beginning
        bool validDeck = false;
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
        Hand handSize1 = defaultDeck.DealAHand(7);

        // loop to print out a handSize of 7 cards for hand 1
        for (int i = 0; i < handSize1.CardsInHand; i++)
        {
            Console.WriteLine(handSize1.GameHand[i].ToString());
        }
        Console.WriteLine("\n");

        // loop to print out another handSize of 7 cards for hand 2
        Hand handSize2 = defaultDeck.DealAHand(7);
        for (int i = 0; i < handSize2.CardsInHand; i++)
        {
            Console.WriteLine(handSize2.GameHand[i].ToString());  
        }
        
        // creates a new default deck to be used for the users input that hasn't had cards removed from it like the original defaultDeck had doing the two hands of 7
        Deck defaultDeck2 = new Deck();

        // shuffles the new default deck
        defaultDeck2.Shuffle();

        // Do-while loop to iterate the error message until a validDeck size can be used while validDeck is false
        do
        {
            // asks the user how many cards are in each player's hand and stores it as handSize and subtracts one to set it equal to the correct number of cards in hand
            // and not the index size
            Console.WriteLine("\nHow many cards are in one hand? \n");
            int handSize = Int32.Parse(Console.ReadLine());

            // ask the user how many players are playing and stores it as playerSize
            Console.WriteLine("How many players are playing? \n");
            int playerSize = Int32.Parse(Console.ReadLine());

            // loop to check if the users input goes outside the bounds of the size of the Deck array
            // if it is bigger prints out the error message until they enter a valid deck size
            if ((playerSize * handSize) > defaultDeck2.DeckCards.Length)
            {
                Console.WriteLine($"Error: There are not enough cards in the deck to deal " + playerSize + " hands of " + handSize  + " cards. Try again. \n");
            }
            else
            {
                // changes the boolean value to true if it is a validDeck and does a loop to print the number of players based on user input for playerSize and
                // starts the player count at 1 not 0 for the index
                validDeck = true;
                for (int playerIndex = 0; playerIndex < playerSize; playerIndex++)
                { 
                    Console.WriteLine("\nPlayer " + (playerIndex + 1) + ":");
                    Hand playerHand = new Hand();
                    playerHand = defaultDeck2.DealAHand(handSize);
                    
                    // loop that uses the card ToString to print out the cards in hand based on users handSize
                    for(int i = 0; i < handSize; i++)
                    {
                        Console.WriteLine(playerHand.GameHand[i].ToString()); 
                    }
                }
            }
        } while (validDeck == false);
    }
}