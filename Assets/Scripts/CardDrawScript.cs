using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDrawScript : MonoBehaviour
{
    public GameObject card;
    public Image suit;
    public TextMeshProUGUI number;

    [SerializeField] private Sprite Heart;
    [SerializeField] private Sprite Diamonds;
    [SerializeField] private Sprite Spades;
    [SerializeField] private Sprite Clubs;

    public List<CardObj> Deck;
    public CardObj currentCard;

    public void CallShuffle()
    {
        //Puts the shuffled deck into a list the card draw script can access
        Deck = FindObjectOfType<DeckShuffleScript>().ShuffleDeck(FindObjectOfType<DeckBuilderScript>().deck);
    }
    public void DrawCard()
    {
        card.SetActive(true);

        //Gets the card on top of the deck
        currentCard = Deck[0];

        //Sets the suit image and text colour
        if (currentCard.suit == (Suit)0)
        {
            suit.sprite = Heart;
            number.color = Color.red;
        }
        else if (currentCard.suit == (Suit)1)
        {
            suit.sprite = Diamonds;
            number.color = Color.red;
        }
        else if (currentCard.suit == (Suit)2)
        {
            suit.sprite = Spades;
            number.color = Color.black;
        }
        else if (currentCard.suit == (Suit)3)
        {
            suit.sprite = Clubs;
            number.color = Color.black;
        }

        //Checks if the text needs to be set to something other than a number
        if (currentCard.number == 0)
        {
            suit.sprite = null;
            number.SetText("Joker");
        }
        else if (currentCard.number == 1)
        {
            number.SetText("Ace");
        }
        else if (currentCard.number < 11)
        {
            number.SetText(currentCard.number.ToString());
        }
        else if (currentCard.number == 11) 
        {
            number.SetText("Jack");
        }
        else if (currentCard.number == 12)
        {
            number.SetText("Queen");
        }
        else
        {
            number.SetText("King");
        }

        //Removes the top card - Eventually this will be sent to a discard pile instead
        Deck.Remove(Deck[0]);
    }
}
