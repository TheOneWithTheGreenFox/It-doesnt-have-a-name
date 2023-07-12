using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeckShuffleScript : MonoBehaviour
{
    //Shuffles any list you give it
    //I should probably put this in the card draw script so that I don't have to do 2 findobjectoftype's every time I shuffle a deck
    public List<CardObj> ShuffleDeck(List<CardObj> Deck)
    {
        List<CardObj> ShuffledDeck = Deck.OrderBy(x => Random.value).ToList();
        return ShuffledDeck;
    }
}
