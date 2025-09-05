using UnityEngine;
using UnityEngine.UI;

public class XOPlacement : MonoBehaviour
{
    public GameObject[] slots;
    public int[] ownedSlots = new int[]
    {
        2,2,2,2,2,2,2,2,2 // "9"
    };
    private bool[] interactableSlots = new bool[]
    {
        true,true,true,true,true,true,true,true,true // "9"
    };

    public GameManager Manager;

    public Sprite XSprite;
    public Sprite OSprite;

    public void PlaceXO(int slotNr)
    {
        if (interactableSlots[slotNr]) 
        {
            if (Manager.playerXturn) ownedSlots[slotNr] = 1;
            else if (!Manager.playerXturn) ownedSlots[slotNr] = 0;


            if (Manager.playerXturn) slots[slotNr].GetComponent<Image>().sprite = XSprite;
            else if (!Manager.playerXturn) slots[slotNr].GetComponent<Image>().sprite = OSprite;

            interactableSlots[slotNr] = false;

            Manager.PassTurn();
            Manager.CheckForWin();
        }

    }
}
