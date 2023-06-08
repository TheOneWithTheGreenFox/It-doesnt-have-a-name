using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardObj : ScriptableObject
{
    public Suit suit;
    [Range(0,13)]public int number;
}

public enum Suit
{
    HEARTS,
    DIAMONDS,
    SPADES,
    CLUBS
}