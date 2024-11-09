using BepInEx;
using DiceAddon.Effects;

namespace DiceAddon
{
    [BepInPlugin("Slayer6409.DiceAddon", "DiceAddon", "0.0.1")]
    [BepInDependency("Theronguard.EmergencyDice")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            MysteryDice.MysteryDice.RegisterNewEffect(new Lasso(), false);
            Logger.LogInfo($"Plugin DiceAddon is loaded!");
        }
    }
}