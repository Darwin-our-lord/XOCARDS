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
    #region ALLWAYS
    [Header("Variables")]
    public string m_cardName;
    public Sprite m_sprite;
    public CardType m_type;

    public CardEffect[] card_effect;

    [Header("Table effect")]
    int duration;

    [Header("Timed effect")]
    int delay;

    #endregion

}
