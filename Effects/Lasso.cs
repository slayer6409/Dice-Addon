using MysteryDice.Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiceAddon.Effects
{
    internal class Lasso : IEffect
    {
        public string Name => "Lasso";
        public EffectType Outcome => EffectType.Mixed;
        public bool ShowDefaultTooltip => true;
        public string Tooltip => "Who are these men";

        public void Use()
        {

            int lassoSpawn = UnityEngine.Random.Range(5, 10);
            if (MysteryDice.Patches.GetEnemies.Lasso == null)
                return;
            MysteryDice.Misc.SpawnEnemyForced(MysteryDice.Patches.GetEnemies.Lasso, lassoSpawn, true);
            // You can do any logic here, I just decided to use my spawn enemy forced since it was easy lol
        
        }
    }
}
