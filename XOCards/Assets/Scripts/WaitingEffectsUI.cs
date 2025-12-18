using UnityEngine;

public class WaitingEffectsUI : MonoBehaviour
{
    public Transform waitingEffectsContainer;
    public GameObject cardPrefab;
    public GameManager manager;

    public void UpdateWaitingEffectsVisuals()
    {
        foreach (Transform child in waitingEffectsContainer)
        {
            Destroy(child.gameObject);
        }

        foreach ((Card,int) card in manager.waitingCards)
        {
            GameObject cardObj = Instantiate(cardPrefab, waitingEffectsContainer);

            CardDisplayUI display = cardObj.GetComponent<CardDisplayUI>();
            if (display != null)
            {
                display.SetData(card.Item1);
            }

            CardSelect cardSelect = cardObj.GetComponent<CardSelect>();
            if (cardSelect != null)
            {
                cardSelect.SetCard(card.Item1);
            }
        }
    }
}
