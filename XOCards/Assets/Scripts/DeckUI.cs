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

        foreach (Card card in player.deckobj.deck)
        {
            GameObject cardObj = Instantiate(cardPrefab, deckContainer);

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
