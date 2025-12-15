using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Game State")]
    public bool playerXturn = true;
    public Card selectedActiveCard; 

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
        StartDraw();
        PassTurn();
        UpdateTurnUI();
    }

    public void SelectCardToPlay(Card card)
    {
        Player activePlayer = playerXturn ? playerX : playerO;
        if (!activePlayer.hand.Contains(card)) return; 

        if (card.requiresTarget)
        {
            selectedActiveCard = card;
            turnText.text = $"Targeting with: {card.m_cardName}";
        }
        else
        {
            if (card.effect.Activate(this, -1))
            {
                activePlayer.hand.Remove(card);
                selectedActiveCard = null;

                handUI.UpdateHandVisuals(activePlayer);
                OnCardPlayedSuccess();
            }
        }
    }

    public void OnCardPlayedSuccess()
    {
        CheckForWin();
        PassTurn();
    }

    public void PassTurn()
    {
        selectedActiveCard = null;
        playerXturn = !playerXturn;

        Player nextPlayer = playerXturn ? playerX : playerO;
        nextPlayer.DrawCard();

        UpdateTurnUI();
    }
    void StartDraw()
    {
        for (int i = 0; i < 2; i++)
        {
            playerO.DrawCard();
            playerX.DrawCard();
        }

    }
    void UpdateTurnUI()
    {
        Player activePlayer = playerXturn ? playerX : playerO;
        handUI.UpdateHandVisuals(activePlayer);
        turnText.text = playerXturn ? "Turn: X" : "Turn: O";
    }

    void Win(bool playerXWinner)
    {
        
        winUI.SetActive(true);

        if (playerXWinner) winnerText.text = "Winner is: X"; 
        else winnerText.text = "Winner is: O"; 



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
