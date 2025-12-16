using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using System;

public class Player : MonoBehaviour
{
    public Deck deckobj;
    public List<Card> deck = new List<Card>();
    public List<Card> hand = new List<Card>();

    public int maxHandSize = 7;
    public void SetupDeck()
    {
        deck = new List<Card>(deckobj.deck);
    }

    public void Shuffle()
    {
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = UnityEngine.Random.Range(0, n + 1);

            Card value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }
    }

    public void DrawCard()
    {
        if (deck.Count > 0 && hand.Count < maxHandSize)
        {
            Card drawnCard = deck[0];
            deck.RemoveAt(0);
            hand.Add(drawnCard);

        }
        else 
        { 
            //hand break logic here
        }
    }
}