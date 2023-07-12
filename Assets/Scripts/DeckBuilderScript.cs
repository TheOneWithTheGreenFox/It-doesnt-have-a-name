using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckBuilderScript : MonoBehaviour
{
    public List<CardObj> deck = new List<CardObj>();

    private void Start()
    {
        BuildDeck();
    }

    public void BuildDeck()
    {
        //Loops through suits and numbers making cards
        for (int i = 1; i < 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                CardObj newCard = new CardObj();
                newCard.number = i;
                newCard.suit = (Suit)j;
                deck.Add(newCard);
            }
        }
        //Adds Jokers
        CardObj joker1 = new CardObj();
        joker1.number = 0;
        joker1.suit = (Suit)0;
        deck.Add(joker1);

        CardObj joker2 = new CardObj();
        joker2.number = 0;
        joker2.suit = (Suit)2;
        deck.Add(joker2);

        //Calls the card draw script now that a deck has been built
        FindObjectOfType<CardDrawScript>().CallShuffle();
    }
}
