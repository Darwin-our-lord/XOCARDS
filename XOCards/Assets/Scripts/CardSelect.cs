using UnityEngine;

public class CardSelect : MonoBehaviour
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
        manager.SelectCardToPlay(card);
    }
}
