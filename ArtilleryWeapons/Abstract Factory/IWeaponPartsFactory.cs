using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryWeapons {

    // Interface for a factory to create various parts of a weapon
    public interface IWeaponPartsFactory {

        // Method to create a metal casing blueprint
        IMetalCasingBlueprint CreateMetalCasing();

        // Method to create an explosive blueprint
        IExplosiveBlueprint CreateExplosive();

        // Method to create a guidance kit blueprint
        IGuidanceKitBlueprint CreateGuidance();

        // Method to create a detonation blueprint
        IDetonationBlueprint CreateDetonation();

        // Method to create a launcher blueprint
        ILauncherBlueprint CreateLauncher();
    }
}
