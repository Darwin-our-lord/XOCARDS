using UnityEngine;

[CreateAssetMenu(menuName = "Card Effects/Destroy Target")]
public class DestroyEffect : CardEffect
{
    public override bool Activate(GameManager gm, int targetIndex)
    {

        if (gm.XOPlacement.ownedSlots[targetIndex] != 2)
        {

            gm.XOPlacement.ModifySlot(targetIndex, 2);
            return true;
        }
        return false;
    }
}