using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using System;

public class Player : MonoBehaviour
{
    public Deck deck; 
    public List<Card> hand = new List<Card>();

    public int maxHandSize = 7;


    public void Shuffle()
    {
        int n = deck.deck.Count;
        while (n > 1)
        {
            n--;
            int k = UnityEngine.Random.Range(0, n + 1);

            Card value = deck.deck[k];
            deck.deck[k] = deck.deck[n];
            deck.deck[n] = value;
        }
    }

    public void DrawCard()
    {
        if (deck.deck.Count > 0 && hand.Count < maxHandSize)
        {
            Card drawnCard = deck.deck[0];
            deck.deck.RemoveAt(0);
            hand.Add(drawnCard);

        }
        else 
        { 
            //hand break logic here
        }
    }
}