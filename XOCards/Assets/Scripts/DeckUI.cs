using UnityEngine;

public class DeckUI : MonoBehaviour
{
    public Transform deckContainer;
    public GameObject cardPrefab;  

    public void UpdateDeckVisuals(Player player)
    {
        foreach (Transform child in deckContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (Card card in player.deck)
        {
            GameObject cardObj = Instantiate(cardPrefab, deckContainer);

            CardDisplayUI display = cardObj.GetComponent<CardDisplayUI>();
            if (display != null)
            {
                display.SetData(card);
            }

            CardSelect cardSelect = cardObj.GetComponent<CardSelect>();
            if (cardSelect != null)
            {
                cardSelect.SetCard(card);
            }
        }
    }
}
