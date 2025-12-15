using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Game State")]
    public bool playerXturn = true;
    public Card selectedActiveCard; // The special card the player chose from hand
    public Card defaultMoveCard;    // THE CARD USED FOR NORMAL X/O PLACEMENT

    [Header("References")]
    public XOPlacement XOPlacement;
    public Player playerX;
    public Player playerO;
    public HandUI handUI;

    [Header("UI")]
    public GameObject winUI;
    public TMP_Text winnerText;
    public TMP_Text turnText;

    void Start()
    {
        // Initial setup
        UpdateTurnUI();
    }

    // Called when a card is clicked in the hand
    public void SelectCardToPlay(Card card)
    {
        Player activePlayer = playerXturn ? playerX : playerO;
        if (!activePlayer.hand.Contains(card)) return; // Safety check

        if (card.requiresTarget)
        {
            selectedActiveCard = card;
            turnText.text = $"Targeting with: {card.m_cardName}";
        }
        else
        {
            // Card does not require a target (e.g. Draw Card)
            if (card.effect.Activate(this, -1))
            {
                // If immediate effect succeeded, consume the card
                activePlayer.hand.Remove(card);
                selectedActiveCard = null;
                // Immediate effects usually don't end the turn, but depend on your rules.
                // If it ends the turn: PassTurn();
                handUI.UpdateHandVisuals(activePlayer);
            }
        }
    }

    // Called by SlotButton when any card (default or special) successfully activated
    public void OnCardPlayedSuccess()
    {
        CheckForWin();
        PassTurn();
    }

    public void PassTurn()
    {
        playerXturn = !playerXturn;
        selectedActiveCard = null; // Clear special selection

        Player nextPlayer = playerXturn ? playerX : playerO;
        nextPlayer.DrawCard();

        UpdateTurnUI();
    }

    void UpdateTurnUI()
    {
        Player activePlayer = playerXturn ? playerX : playerO;
        handUI.UpdateHandVisuals(activePlayer);
        turnText.text = playerXturn ? "X's Turn: Place or Play Card" : "O's Turn: Place or Play Card";
    }

    void Win(bool playerXWinner)
    {
        
        winUI.SetActive(true);

        if (playerXWinner) winnerText.text = "Winner is: x"; 
        else winnerText.text = "Winner is: o"; 



    }

    public void CheckForWin()
    {
        //top row x
        if (XOPlacement.ownedSlots[0] == 1 && XOPlacement.ownedSlots[1] == 1 && XOPlacement.ownedSlots[2] == 1) Win(true);
        //middle row x
        if (XOPlacement.ownedSlots[3] == 1 && XOPlacement.ownedSlots[4] == 1 && XOPlacement.ownedSlots[5] == 1) Win(true);
        //bottom row x
        if (XOPlacement.ownedSlots[6] == 1 && XOPlacement.ownedSlots[7] == 1 && XOPlacement.ownedSlots[8] == 1) Win(true);
        //left collum x
        if (XOPlacement.ownedSlots[0] == 1 && XOPlacement.ownedSlots[3] == 1 && XOPlacement.ownedSlots[6] == 1) Win(true);
        //middle collum x
        if (XOPlacement.ownedSlots[1] == 1 && XOPlacement.ownedSlots[4] == 1 && XOPlacement.ownedSlots[7] == 1) Win(true);
        //right collum x
        if (XOPlacement.ownedSlots[2] == 1 && XOPlacement.ownedSlots[5] == 1 && XOPlacement.ownedSlots[8] == 1) Win(true);
        //left to right diagonal x
        if (XOPlacement.ownedSlots[6] == 1 && XOPlacement.ownedSlots[4] == 1 && XOPlacement.ownedSlots[2] == 1) Win(true);
        //right to left diagonal x
        if (XOPlacement.ownedSlots[0] == 1 && XOPlacement.ownedSlots[4] == 1 && XOPlacement.ownedSlots[8] == 1) Win(true);


        //top row o
        if (XOPlacement.ownedSlots[0] == 0 && XOPlacement.ownedSlots[1] == 0 && XOPlacement.ownedSlots[2] == 0) Win(false);
        //middle row o
        if (XOPlacement.ownedSlots[3] == 0 && XOPlacement.ownedSlots[4] == 0 && XOPlacement.ownedSlots[5] == 0) Win(false);
        //bottom row o
        if (XOPlacement.ownedSlots[6] == 0 && XOPlacement.ownedSlots[7] == 0 && XOPlacement.ownedSlots[8] == 0) Win(false);
        //left collum o
        if (XOPlacement.ownedSlots[0] == 0 && XOPlacement.ownedSlots[3] == 0 && XOPlacement.ownedSlots[6] == 0) Win(false);
        //middle collum o
        if (XOPlacement.ownedSlots[1] == 0 && XOPlacement.ownedSlots[4] == 0 && XOPlacement.ownedSlots[7] == 0) Win(false);
        //right collum o
        if (XOPlacement.ownedSlots[2] == 0 && XOPlacement.ownedSlots[5] == 0 && XOPlacement.ownedSlots[8] == 0) Win(false);
        //left to right diagonal o
        if (XOPlacement.ownedSlots[6] == 0 && XOPlacement.ownedSlots[4] == 0 && XOPlacement.ownedSlots[2] == 0) Win(false);
        //right to left diagonal o
        if (XOPlacement.ownedSlots[0] == 0 && XOPlacement.ownedSlots[4] == 0 && XOPlacement.ownedSlots[8] == 0) Win(false);

    }


}
