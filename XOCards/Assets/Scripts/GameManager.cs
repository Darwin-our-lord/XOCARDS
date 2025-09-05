using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool playerXturn = true;
    public XOPlacement XOPlacement;

    public GameObject winUI;
    public TMP_Text winnerText;

    public void PassTurn()
    {
        playerXturn = !playerXturn;
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
