using UnityEngine;

public class SlotButton : MonoBehaviour
{
    public int slotIndex; // Set this manually (0 through 8) in the Inspector
    public GameManager manager;

    public void OnSlotClicked()
    {
        // 1. Determine which card to use: Special or Default
        Card cardToUse = manager.selectedActiveCard != null ? manager.selectedActiveCard : manager.defaultMoveCard;

        // 2. Only cards that require a target should be processed here.
        if (!cardToUse.requiresTarget) return;

        // 3. Identify the active player
        Player activePlayer = manager.playerXturn ? manager.playerX : manager.playerO;

        // 4. Try to activate the card logic using this slot as the target
        bool success = cardToUse.effect.Activate(manager, slotIndex);

        // 5. If successful, handle cleanup and turn flow
        if (success)
        {
            // If we used a special card from the hand, remove it
            if (manager.selectedActiveCard != null)
            {
                activePlayer.hand.Remove(cardToUse);
            }

            // Tell the GameManager the move succeeded
            manager.OnCardPlayedSuccess();
        }
        else
        {
            Debug.Log($"Invalid target for card: {cardToUse.m_cardName}. Try again.");
        }
    }
}