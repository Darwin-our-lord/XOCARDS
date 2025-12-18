using UnityEngine;

public enum CardType
{
    None,
    Table,
    Flash,
    Delay
}
[CreateAssetMenu(fileName = "new card", menuName = "Card")]
public class Card : ScriptableObject
{

    [Header("Variables")]
    public string m_cardName;
    [TextArea] public string m_description;
    public Sprite m_sprite;
    
    public CardType cardType;

    public bool requiresTarget = true;

    public CardEffect effect;

    [Header("Table effect")]
    public int duration;

    [Header("Timed effect")]
    public int delay;



}
