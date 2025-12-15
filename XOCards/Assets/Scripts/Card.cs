using UnityEngine;

public enum CardType
{
    None,
    Table,
    Flash,
    Timed
}
[CreateAssetMenu(fileName = "new card", menuName = "Card")]
public class Card : ScriptableObject
{

    [Header("Variables")]
    public string m_cardName;
    [TextArea] public string m_description;
    public Sprite m_sprite;

    public bool requiresTarget = true;

    public CardEffect effect;

    [Header("Table effect")]
    int duration;

    [Header("Timed effect")]
    int delay;



}
