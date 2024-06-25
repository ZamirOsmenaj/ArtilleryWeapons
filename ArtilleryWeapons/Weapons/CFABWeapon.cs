using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryWeapons.Weapons {

    // Class representing a CFAB weapon, implementing the IWeapon interface
    public class CFABWeapon : IWeapon {

        // Fields to hold the blueprints for various parts of the weapon
        IMetalCasingBlueprint _metalCasing;
        IExplosiveBlueprint _explosive;
        IGuidanceKitBlueprint _guidanceKit;
        IDetonationBlueprint _detonation;
        ILauncherBlueprint _launcher;

        // Constructor to initialize the weapon with the specified blueprints
        public CFABWeapon(IMetalCasingBlueprint metalCasing,
                          IExplosiveBlueprint explosive,
                          IGuidanceKitBlueprint guidanceKit,
                          IDetonationBlueprint detonation,
                          ILauncherBlueprint launcher) {

            _metalCasing = metalCasing;
            _explosive = explosive;
            _guidanceKit = guidanceKit;
            _detonation = detonation;
            _launcher = launcher;
        }

        // Override of the ToString method to provide a string representation of the weapon
        public override string ToString() {
            return $"FABWeapon\n[\n MetalCasingType: {_metalCasing.MetalCasing},\n ExplosiveType: {_explosive.ExplosiveType},\n GuidanceType: {_guidanceKit.GuidanceType},\n DetonationType: {_detonation.DetonationType},\n LauncherType: {_launcher.LauncherType}\n]";
        }
    }
}
