using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardSelect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Card card;
    public GameManager manager;

    private void Awake()
    {
       manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void SetCard(Card card)
    {
        this.card = card;
    }
    public void CardPressed()
    { 
        manager.PlayCard(true,card);
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
