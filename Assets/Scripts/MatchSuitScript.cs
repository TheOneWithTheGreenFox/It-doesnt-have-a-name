using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchSuitScript : MonoBehaviour
{
    private Image suit;
    [SerializeField] private Image suit2;

    //This script is bad, all it does is make one image the same as another, and it's running in update because I was lazy

    private void Start()
    {
        suit = GetComponent<Image>();
    }

    void Update()
    {
        suit2.sprite = suit.sprite;
    }
}
