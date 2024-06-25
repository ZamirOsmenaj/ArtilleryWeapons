using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryWeapons {

    // Interface for metal casing blueprint, inheriting from IPrototype with IMetalCasingBlueprint as the type.
    // This interface specifies the properties and method related to metal casing.
    public interface IMetalCasingBlueprint : IPrototype<IMetalCasingBlueprint> {
        // Property for the type of metal casing
        MetalCasingType MetalCasing { get; set; }
        // Property for the shape of the metal casing
        MetalCasingShape CasingShape { get; set; }
        // Property for the weight of the casing in kilograms
        double WeightKG { get; set; }
        // Property for the thickness of the casing in millimeters
        double ThicknessMM { get; set; }
    }

    // Interface for explosive blueprint, inheriting from IPrototype with IExplosiveBlueprint as the type.
    // This interface specifies the properties and method related to explosives.
    public interface IExplosiveBlueprint : IPrototype<IExplosiveBlueprint> {
        // Property for the type of explosive
        ExplosiveType ExplosiveType { get; set; }
        // Property for the weight of the explosive in kilograms
        double WeightKG { get; set; }
    }

    // Interface for guidance kit blueprint, inheriting from IPrototype with IGuidanceKitBlueprint as the type.
    // This interface specifies the properties and method related to guidance kits.
    public interface IGuidanceKitBlueprint : IPrototype<IGuidanceKitBlueprint> {
        // Property for the type of guidance system
        GuidanceType GuidanceType { get; set; }
        // Property for the sensitivity of the guidance system
        double Sensitivity { get; set; }
    }

    // Interface for detonation blueprint, inheriting from IPrototype with IDetonationBlueprint as the type.
    // This interface specifies the properties and method related to detonation systems.
    public interface IDetonationBlueprint : IPrototype<IDetonationBlueprint> {
        // Property for the type of detonation system
        DetonationType DetonationType { get; set; }
        // Property for the accuracy of the detonation system
        double Accuracy { get; set; }
    }

    // Interface for launcher blueprint, inheriting from IPrototype with ILauncherBlueprint as the type.
    // This interface specifies the properties and method related to launchers.
    public interface ILauncherBlueprint : IPrototype<ILauncherBlueprint> {
        // Property for the type of launcher
        LauncherType LauncherType { get; set; }
        // Property for the range of the launcher in kilometers
        double RangeKM { get; set; }
    }
}
