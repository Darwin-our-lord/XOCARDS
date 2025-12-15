using UnityEngine;

[CreateAssetMenu(menuName = "Card Effects/Draw Card")]
public class DrawCardEffect : CardEffect
{
    public override bool Activate(GameManager gm, int targetIndex)
    {
        if (gm.playerXturn)
        {
            gm.playerX.DrawCard();
        }
        else if (!gm.playerXturn)
        {
            gm.playerO.DrawCard();
        }
        else 
        {
            return false;
        }

        return true;
    }
}
