using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HandUI : MonoBehaviour
{
    public Transform handContainer;
    public GameObject cardPrefab;   // Your UI Button Prefab for a card
    public GameManager manager;

    public void UpdateHandVisuals(Player player)
    {
        foreach (Transform child in handContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (Card card in player.hand)
        {
            GameObject cardObj = Instantiate(cardPrefab, handContainer);

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