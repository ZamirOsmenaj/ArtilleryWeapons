using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryWeapons {

    // Class implementing IWeaponBlueprint interface
    public class WeaponBlueprint : IWeaponBlueprint {

        // Properties for various blueprint components
        public IMetalCasingBlueprint CasingBlueprint { get; set; }
        public IExplosiveBlueprint ExplosiveBlueprint { get; set; }
        public IDetonationBlueprint DetonationBlueprint { get; set; }
        public IGuidanceKitBlueprint GuidanceKitBlueprint { get; set; }
        public ILauncherBlueprint LauncherBlueprint { get; set; }

        // Property for the version of the weapon, indicating the variant of the weapon family
        public uint WeaponVersion { get; set; }

        // Properties for weapon statistics
        public uint BlueprintSerial { get; set; }
        public WeaponFamilies WeaponFamily { get; set; }
        public string WeaponName { get; set; }
        public uint CostKEUR { get; set; }
        // Property for the damage radius of the weapon in meters
        public uint DamageRadiusM { get; set; }
        // Property for the cruise speed of the weapon
        public VelocityType CruiseSpeed { get; set; }
        // Property for the type of weapon
        public WeaponType WeaponType { get; set; }

        // Method to clone the weapon blueprint
        public IWeaponBlueprint Clone() {
            return (IWeaponBlueprint)MemberwiseClone();
        }
    }
}
