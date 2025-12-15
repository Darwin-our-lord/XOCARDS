using UnityEngine;

[CreateAssetMenu(menuName = "Card Effects/Draw Card")]
public class DrawCardEffect : CardEffect
{
    public override bool Activate(GameManager gm, int targetIndex)
    {
        if (gm.playerXturn)
        {
            gm.playerX.DrawCard();
            Debug.LogError("fail 1");
        }
        else if (!gm.playerXturn)
        {
            gm.playerO.DrawCard();
            Debug.LogError("fail 2 ");
        }
        else 
        {
            Debug.LogError("fail 3");
            return false;
        }

        return true;
    }
}
