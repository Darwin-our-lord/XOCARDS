using UnityEngine;

public enum CardType
{
    None,
    Table,
    Trigger,
    Flash,
    Delay
}
public enum TargetType
{
    None,
    slot,
    handCard,
    activeEffect,
    tableCard
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
    public TargetType targetType;

    public CardEffect effect;

    [Header("Trigger effect")]
    public int duration;

    [Header("Delay effect")]
    public int delay;



}
