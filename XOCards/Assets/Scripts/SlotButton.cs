using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int slotIndex; 
    public GameManager manager;

    public void OnSlotClicked()
    {
        if (manager.selectedActiveCard != null)
        {
            manager.PlayCard(true, manager.selectedActiveCard, slotIndex);
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