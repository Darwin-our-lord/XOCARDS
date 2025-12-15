using UnityEngine;
using UnityEngine.UI;

public class XOPlacement : MonoBehaviour
{
    public GameObject[] slots;

    public int[] ownedSlots = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 };

    public Sprite XSprite;
    public Sprite OSprite;
    public Sprite EmptySprite; 

    public void ModifySlot(int slotNr, int newOwner)
    {
        ownedSlots[slotNr] = newOwner;

        Image slotImage = slots[slotNr].GetComponent<Image>();

        if (newOwner == 1) slotImage.sprite = XSprite;
        else if (newOwner == 0) slotImage.sprite = OSprite;
        else slotImage.sprite = EmptySprite;
    }
}