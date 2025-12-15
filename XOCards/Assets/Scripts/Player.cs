using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public List<Card> deck = new List<Card>(); 
    public List<Card> hand = new List<Card>();

    public int maxHandSize = 7;

    public void DrawCard()
    {
        if (deck.Count > 0 && hand.Count < maxHandSize)
        {
            Card drawnCard = deck[0];
            deck.RemoveAt(0);
            hand.Add(drawnCard);

        }
    }
}