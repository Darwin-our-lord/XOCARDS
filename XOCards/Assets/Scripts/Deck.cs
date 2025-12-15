using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Deck", menuName = "DECK/Deck")]
public class Deck : ScriptableObject
{
    public List<Card> deck = new List<Card>();
}
