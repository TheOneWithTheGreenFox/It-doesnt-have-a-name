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
    }
}
