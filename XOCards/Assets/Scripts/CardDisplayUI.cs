using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplayUI : MonoBehaviour
{
    // Assign these in the Inspector on the Card Prefab
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public Image cardImage;

    // Call this from HandUI.cs to set the data
    public void SetData(Card cardData)
    {
        nameText.text = cardData.m_cardName;
        descriptionText.text = cardData.m_description;
        cardImage.sprite = cardData.m_sprite;
    }
}