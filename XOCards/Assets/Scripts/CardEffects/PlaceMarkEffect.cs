using UnityEngine;

[CreateAssetMenu(menuName = "Card Effects/Place Mark")]
public class PlaceMarkEffect : CardEffect
{
    public override bool Activate(GameManager gm, int targetIndex)
    {
        if (gm.XOPlacement.ownedSlots[targetIndex] == 2)
        {
            int markToPlace = gm.playerXturn ? 1 : 0;

            gm.XOPlacement.ModifySlot(targetIndex, markToPlace);

            return true;
        }

        return false;
    }
}