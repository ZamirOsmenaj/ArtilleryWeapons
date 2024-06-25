using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryWeapons {

    // Class to create various parts of the FAB weapon using a factory design pattern
    public class CFABFactory : IWeaponPartsFactory{

        // Private field to hold the weapon blueprint
        IWeaponBlueprint? blueprint;

        // Constructor to initialize the factory with a specific version of the FAB weapon
        public CFABFactory(int FABversion) {
            // Retrieve the blueprint for the specified version from the repository
            blueprint = BlueprintRepositoryRND.Instance.GetBlueprint(WeaponFamilies.FAB, FABversion);
        }

        // Method to create a metal casing blueprint using the details from the retrieved blueprint
        public IMetalCasingBlueprint CreateMetalCasing() {
            return new CFABMetalCasingBlueprint(
                blueprint.CasingBlueprint.MetalCasing,
                blueprint.CasingBlueprint.CasingShape,
                blueprint.CasingBlueprint.WeightKG,
                blueprint.CasingBlueprint.ThicknessMM);
        }

        // Method to create an explosive blueprint using the details from the retrieved blueprint
        public IExplosiveBlueprint CreateExplosive() {
            return new CFABExplosiveBlueprint(
                blueprint.ExplosiveBlueprint.ExplosiveType,
                blueprint.ExplosiveBlueprint.WeightKG);
        }

        // Method to create a guidance kit blueprint using the details from the retrieved blueprint
        public IGuidanceKitBlueprint CreateGuidance() {
            return new CFABGuidanceKitBlueprint(
                blueprint.GuidanceKitBlueprint.GuidanceType,
                blueprint.GuidanceKitBlueprint.Sensitivity);
        }

        // Method to create a detonation blueprint using the details from the retrieved blueprint
        public IDetonationBlueprint CreateDetonation() {
            return new CFABDetonationBlueprint(
                blueprint.DetonationBlueprint.DetonationType,
                blueprint.DetonationBlueprint.Accuracy);
        }

        // Method to create a launcher blueprint using the details from the retrieved blueprint
        public ILauncherBlueprint CreateLauncher() {
            return new CFABLauncherBlueprint(
                blueprint.LauncherBlueprint.LauncherType,
                blueprint.LauncherBlueprint.RangeKM);
        }
    }
}
