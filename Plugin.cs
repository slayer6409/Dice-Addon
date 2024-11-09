using BepInEx;
using DiceAddon.Effects;

namespace DiceAddon
{
    [BepInPlugin("Slayer6409.DiceAddon", "DiceAddon", "0.0.1")]
    [BepInDependency("Theronguard.EmergencyDice")] // This is the original author, I just kept it since certain mods depended on it and it would break those if I changed it
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            MysteryDice.MysteryDice.RegisterNewEffect(new Lasso(), false);
            Logger.LogInfo($"Plugin DiceAddon is loaded!");
        }
    }
}
