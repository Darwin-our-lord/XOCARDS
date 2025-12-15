using UnityEngine;

public class SlotButton : MonoBehaviour
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
}