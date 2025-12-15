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
        // Clear existing UI
        foreach (Transform child in handContainer)
        {
            Destroy(child.gameObject);
        }

        // Recreate UI for cards in the hand
        foreach (Card card in player.hand)
        {
            GameObject cardObj = Instantiate(cardPrefab, handContainer);

            cardObj.GetComponentInChildren<TMP_Text>().text = card.m_cardName;
            cardObj.GetComponent<Image>().sprite = card.m_sprite;

            // Set the listener to tell the GameManager which card was clicked
            cardObj.GetComponent<Button>().onClick.AddListener(() => manager.SelectCardToPlay(card));
        }
    }
}