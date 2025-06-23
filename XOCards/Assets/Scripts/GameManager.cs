using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool[,] boardSlotsTaken;

    public bool playerXturn = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boardSlotsTaken = new bool[,]
        {
            {false,false,false},
            {false,false,false},
            {false,false,false}
        };
        Debug.Log(boardSlotsTaken.Length);
    }
    
    public void PassTurn()
    {
        playerXturn = !playerXturn;
    }
}
