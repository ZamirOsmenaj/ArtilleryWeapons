using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryWeapons {

    // Generic interface IPrototype with covariant type parameter T.
    // This interface ensures that any implementing class can clone itself.
    public interface IPrototype<out T> {
        T Clone();
    }

    // Interface for weapon blueprint, inheriting from IPrototype with IWeaponBlueprint as the type 
    // and also from IWeaponStats.
    // This interface specifies the components and properties related to a weapon blueprint.
    public interface IWeaponBlueprint : IPrototype<IWeaponBlueprint>, IWeaponStats {

        // Property for the metal casing blueprint component
        IMetalCasingBlueprint CasingBlueprint { get; set; }
        // Property for the explosive blueprint component
        IExplosiveBlueprint ExplosiveBlueprint { get; set; }
        // Property for the detonation blueprint component
        IDetonationBlueprint DetonationBlueprint { get; set; }
        // Property for the guidance kit blueprint component
        IGuidanceKitBlueprint GuidanceKitBlueprint { get; set; }
        // Property for the launcher blueprint component
        ILauncherBlueprint LauncherBlueprint { get; set; }
        // Property for the version of the weapon, indicating the variant of the weapon family
        uint WeaponVersion { get; set; }
    }

    // Interface for weapon statistics, inheriting from IPrototype with IWeaponBlueprint as the type.
    // This interface specifies the properties related to weapon stats.
    public interface IWeaponStats : IPrototype<IWeaponBlueprint> {

        // Property for the serial number of the blueprint
        // uint BlueprintSerial { get; set; }

        // Property for the family to which the weapon belongs
        WeaponFamilies WeaponFamily { get; set; }
        // Property for the name of the weapon
        string WeaponName { get; set; }
        // Property for the cost of the weapon in thousand Euros
        uint CostKEUR { get; set; }
        // Property for the damage radius of the weapon in meters
        uint DamageRadiusM { get; set; }
        // Property for the cruise speed of the weapon
        VelocityType CruiseSpeed { get; set; }
        // Property for the type of weapon
        WeaponType WeaponType { get; set; }
    }
}
