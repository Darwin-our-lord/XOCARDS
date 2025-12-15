using UnityEngine;

[CreateAssetMenu(fileName = "new CardEffect", menuName = "CardEffect")]
public abstract class CardEffect : ScriptableObject
{
    public abstract bool Activate(GameManager gm, int targetIndex = -1);
}
