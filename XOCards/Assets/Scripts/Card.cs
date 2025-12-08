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
    public string m_cardName;
    public Sprite m_sprite;


}
