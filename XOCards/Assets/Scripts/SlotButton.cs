using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int slotIndex; 
    public GameManager manager;

    public void OnSlotClicked()
    {
        Card cardToUse = manager.selectedActiveCard;
        if (cardToUse == null)
        {
            return;
        }

        if (!cardToUse.requiresTarget) return;

        Player activePlayer = manager.playerXturn ? manager.playerX : manager.playerO;

        bool success = cardToUse.effect.Activate(manager, slotIndex);

        if (success)
        {
            if (manager.selectedActiveCard != null)
            {
                activePlayer.hand.Remove(cardToUse);
            }

            manager.OnCardPlayedSuccess();
        }
        else
        {
            Debug.Log($"Invalid target for card: {cardToUse.m_cardName}. Try again.");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Image>().color = Color.gray;

    }


    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Image>().color = Color.white;

    }
}