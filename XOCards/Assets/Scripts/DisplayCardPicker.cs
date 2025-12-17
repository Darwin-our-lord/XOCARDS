using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DisplayCardPicker : MonoBehaviour
{
    public Card card;
    public MenuManager manager;
    public GameObject deckBuilderUI;

    private void Awake()
    {
        manager = GameObject.Find("Canvas").GetComponent<MenuManager>();
        deckBuilderUI = GameObject.Find("DeckBuilderUI");
    }
    public void SetCard(Card card)
    {
        this.card = card;
    }
    public void CardPressed()
    {
        if(manager.ActivePlayer != null)
        {
            manager.ActivePlayer.deckobj.deck.Add(card);
            deckBuilderUI.GetComponent<DeckUI>().UpdateDeckVisuals(manager.ActivePlayer);
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
