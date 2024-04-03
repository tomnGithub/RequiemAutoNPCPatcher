using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this namespace
using Mutagen.Bethesda.Plugins;

namespace RequiemAutoNPCPatcher
{
    public record Settings
    {
        public List<ModKey> TargetMods = new List<ModKey>();
        

        [Display(Name = "Warrior & Battlemage Health Per Level (Default:5.5):")] // Use Display attribute for user-friendly name
        public double WarriorHealthPerLevel { get; set; } = 5.5; // Property remains DefaultValue for internal use

        [Display(Name = $"Warrior & Battlemage Stamina Per Level (Default:8.5):")] // Use Display attribute for user-friendly name
        public double StaminaPerLevel { get; set; } = 8.5; // Property remains DefaultValue for internal use

        [Display(Name = $"Pure Mage Health Per Level (Default:3):")] // Use Display attribute for user-friendly name
        public double PureMageHealthPerLevel { get; set; } = 3; // Property remains DefaultValue for internal use

        [Display(Name = $"Mage Magicka Per Level (Default:8.5):")] // Use Display attribute for user-friendly name
        public double MagickaPerLevel { get; set; } = 8.5; // Property remains DefaultValue for internal use

    }


}
