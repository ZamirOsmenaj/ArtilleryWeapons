using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtilleryWeapons.Weapons;

namespace ArtilleryWeapons.Builders {

    // Class responsible for directing the construction of weapons
    public class Director {

        // Method to construct a weapon based on the specified family and version
        public IWeapon Construct(WeaponFamilies family, int version) {

            // Retrieve the builder and blueprint for the specified family and version
            var (_builder, _blueprint) = GetWeaponManufactures(family, version);

            // Build the various components of the weapon if their blueprints are not null
            if (_blueprint.CasingBlueprint != null) {
                _builder.BuildMetalCasing();
            }
            if (_blueprint.ExplosiveBlueprint != null) {
                _builder.BuildExplosives();
            }
            if (_blueprint.GuidanceKitBlueprint != null) {
                _builder.BuildGuidanceKit();
            }
            if (_blueprint.DetonationBlueprint != null) {
                _builder.BuildDetonation();
            }
            if (_blueprint.LauncherBlueprint != null) {
                _builder.BuildLauncher();
            }

            // Return the constructed weapon
            return _builder.GetWeapon();
        }

        // Private method to get the weapon builder and blueprint for the specified family and version
        private (BaseWeaponBuilder, IWeaponBlueprint) GetWeaponManufactures(WeaponFamilies family, int version) {

            // Retrieve the blueprint for the specified family and version from the repository
            IWeaponBlueprint blueprint = BlueprintRepositoryRND.Instance.GetBlueprint(family, version);

            // Throw an exception if the blueprint is invalid
            if (blueprint == null) {
                throw new ArgumentException("Invalid weapon version");
            }

            // Return the appropriate builder and blueprint based on the weapon family
            switch (family)
            {
                case WeaponFamilies.FAB:
                    // Create a factory for FAB weapon parts and return the builder and blueprint
                    CFABFactory fabFactory = new CFABFactory(version);
                    return (new CFABBuilder(fabFactory), blueprint);
                case WeaponFamilies.GuidedRocket:
                    // Create a factory for FAB weapon parts and return the builder and blueprint
                    CRocketProjectileFactory rocketProjectileFactory = new CRocketProjectileFactory(version);
                    return (new CRocketProjectileBuilder(rocketProjectileFactory), blueprint);
                case WeaponFamilies.GuidedProjectile:
                    // Create a factory for FAB weapon parts and return the builder and blueprint
                    CGuidedProjectileFactory guidedProjectileFactory = new CGuidedProjectileFactory(version);
                    return (new CGuidedProjectileBuilder(guidedProjectileFactory), blueprint);
                case WeaponFamilies.Conventional:
                    // Create a factory for FAB weapon parts and return the builder and blueprint
                    CConventionalProjectileFactory conventionalProjectileFactory = new CConventionalProjectileFactory(version);
                    return (new CConventionalProjectileBuilder(conventionalProjectileFactory), blueprint);
                default:
                    // Throw an exception if the weapon family is invalid
                    throw new ArgumentException("Invalid weapon family");
            }
        }
    }
}
