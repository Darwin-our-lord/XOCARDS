using UnityEngine;

public class ActiveEffectsUI : MonoBehaviour
{
    public Transform activeEffectsContainer;
    public GameObject cardPrefab;
    public GameManager manager;

    public void UpdateActiveEffectsVisuals()
    {
        foreach (Transform child in activeEffectsContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (Card card in manager.activeCards)
        {
            GameObject cardObj = Instantiate(cardPrefab, activeEffectsContainer);

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
