using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameManager manager;

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Image>().color = Color.gray;

    }


    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Image>().color = Color.white;

    }
}