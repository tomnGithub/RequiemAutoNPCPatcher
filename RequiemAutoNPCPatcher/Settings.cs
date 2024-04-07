using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this namespace
using Mutagen.Bethesda.Plugins;
using System.ComponentModel;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Synthesis.Bethesda.Commands;

namespace RequiemAutoNPCPatcher
{
    public record Settings
    {
        public List<ModKey> TargetMods = new List<ModKey>();

        [SettingName("Warrior & Battlemage - Health Per Level (Default: 5.5):")]
        public double WarriorHealthPerLevel { get; set; } = 5.5;

        [SettingName("Warrior & Battlemage - Stamina Per Level (Default: 8.5):")]
        public double StaminaPerLevel { get; set; } = 8.5;

        [SettingName("Pure Mage - Health Per Level (Default: 3):")]
        public double PureMageHealthPerLevel { get; set; } = 3;

        [SettingName("Pure Mage & Battlemage - Magicka Per Level (Default: 8.5):")]
        public double MagickaPerLevel { get; set; } = 8.5;

        [SettingName("Make New Creatures Stronger than Playable Races (Recommended. Hover cursor here for more details.)"), 
            Tooltip("Many creature mods use copies of playable races for their new creatures." +
            "\nFor example, Mihail's Minatours, Gravelords, and Goblins are all copies of playable races but with custom models." +
            "\nWith this setting ENABLED, the patcher will rebalance races like these differently than how it handles playable races." +
            "\n\nHowever, some follower mods, like 'Arrisa', use a custom race in order give NPCs their own body (UNP, CBBE, etc.)." +
            "\nIf patching a follower with a custom body, this setting should be disabled." +
            "\n\nIf unsure, I recommended that you leave this setting ENABLED.\n" +
            "Even if a custom-body NPC is patched, they will only be a little stronger than they otherwise should be.")]
        public bool MakeNewRacesStronger { get; set; } = true; // Default is on




    }

    





}

