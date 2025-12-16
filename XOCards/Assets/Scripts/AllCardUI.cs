using UnityEngine;

public class AllCardUI : MonoBehaviour
{
    public Transform cardsContainer;
    public GameObject cardPrefab;
    public Deck allCards;

    public void UpdateAllCardDisplayVisuals()
    {
        foreach (Transform child in cardsContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (Card card in allCards.deck)
        {
            GameObject cardObj = Instantiate(cardPrefab, cardsContainer);

            CardDisplayUI display = cardObj.GetComponent<CardDisplayUI>();
            if (display != null)
            {
                display.SetData(card);
            }

            DeckCardPicker cardSelect = cardObj.GetComponent<DeckCardPicker>();
            if (cardSelect != null)
            {
                cardSelect.SetCard(card);
            }
        }
    }
}
