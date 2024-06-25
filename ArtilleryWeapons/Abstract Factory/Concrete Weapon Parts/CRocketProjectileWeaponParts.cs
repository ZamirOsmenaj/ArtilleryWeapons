using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryWeapons {

    // Class implementing IMetalCasingBlueprint interface
    public class CRocketProjectileMetalCasingBlueprint : IMetalCasingBlueprint {

        // Properties for metal casing characteristics
        public MetalCasingType MetalCasing { get; set; }
        public MetalCasingShape CasingShape { get; set; }
        public double WeightKG { get; set; }
        public double ThicknessMM { get; set; }

        // Constructor to initialize the properties
        public CRocketProjectileMetalCasingBlueprint(MetalCasingType metalCasing, MetalCasingShape metalCasingShape, double weightKG, double thicknessMM) {
            MetalCasing = metalCasing;
            CasingShape = metalCasingShape;
            WeightKG = weightKG;
            ThicknessMM = thicknessMM;
        }

        // Method to clone the blueprint
        public IMetalCasingBlueprint Clone() {
            return (IMetalCasingBlueprint)MemberwiseClone();
        }
    }

    // Class implementing IExplosiveBlueprint interface
    public class CRocketProjectileExplosiveBlueprint : IExplosiveBlueprint {

        // Properties for explosive characteristics
        public ExplosiveType ExplosiveType { get; set; }
        public double WeightKG { get; set; }

        // Constructor to initialize the properties
        public CRocketProjectileExplosiveBlueprint(ExplosiveType explosive, double weightKG) {
            ExplosiveType = explosive;
            WeightKG = weightKG;
        }

        // Method to clone the blueprint
        public IExplosiveBlueprint Clone() {
            return (IExplosiveBlueprint)MemberwiseClone();
        }
    }

    // Class implementing IGuidanceKitBlueprint interface
    public class CRocketProjectileGuidanceKitBlueprint : IGuidanceKitBlueprint {

        // Properties for guidance kit characteristics
        public GuidanceType GuidanceType { get; set; }
        public double Sensitivity { get; set; }

        // Constructor to initialize the properties
        public CRocketProjectileGuidanceKitBlueprint(GuidanceType guidance, double sensitivity) {
            GuidanceType = guidance;
            Sensitivity = sensitivity;
        }

        // Method to clone the blueprint
        public IGuidanceKitBlueprint Clone() {
            return (IGuidanceKitBlueprint)MemberwiseClone();
        }
    }

    // Class implementing IDetonationBlueprint interface
    public class CRocketProjectileDetonationBlueprint : IDetonationBlueprint {

        // Properties for detonation characteristics
        public DetonationType DetonationType { get; set; }
        public double Accuracy { get; set; }

        // Constructor to initialize the properties
        public CRocketProjectileDetonationBlueprint(DetonationType detonation, double accuracy) {
            DetonationType = detonation;
            Accuracy = accuracy;
        }

        // Method to clone the blueprint
        public IDetonationBlueprint Clone() {
            return (IDetonationBlueprint)MemberwiseClone();
        }
    }

    // Class implementing ILauncherBlueprint interface
    public class CRocketProjectileLauncherBlueprint : ILauncherBlueprint {

        // Properties for launcher characteristics
        public LauncherType LauncherType { get; set; }
        public double RangeKM { get; set; }

        // Constructor to initialize the properties
        public CRocketProjectileLauncherBlueprint(LauncherType launcher, double rangeKM) {
            LauncherType = launcher;
            RangeKM = rangeKM;
        }

        // Method to clone the blueprint
        public ILauncherBlueprint Clone() {
            return (ILauncherBlueprint)MemberwiseClone();
        }
    }
}
