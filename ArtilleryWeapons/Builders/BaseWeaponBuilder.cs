using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtilleryWeapons.Weapons;

namespace ArtilleryWeapons.Builders {

    public abstract class BaseWeaponBuilder {

        // Fields to hold the blueprints for various parts of the weapon
        public IMetalCasingBlueprint _metalCasing;
        public IExplosiveBlueprint _explosive;
        public IGuidanceKitBlueprint _guidanceKit;
        public IDetonationBlueprint _detonation;
        public ILauncherBlueprint _launcher;

        // Protected field to hold the factory that creates weapon parts
        public IWeaponPartsFactory _weaponPartsFactory;

        // Constructor to initialize the builder with a specific factory
        public BaseWeaponBuilder(IWeaponPartsFactory factory) {
            _weaponPartsFactory = factory;
        }

        // Method to build the metal casing of the weapon
        public virtual void BuildMetalCasing() {
            _metalCasing = _weaponPartsFactory.CreateMetalCasing();
        }

        // Method to build the explosives of the weapon
        public virtual void BuildExplosives() {
            _explosive = _weaponPartsFactory.CreateExplosive();
        }

        // Method to build the guidance kit of the weapon
        public virtual void BuildGuidanceKit() {
            _guidanceKit = _weaponPartsFactory.CreateGuidance();
        }

        // Method to build the detonation mechanism of the weapon
        public virtual void BuildDetonation() {
            _detonation = _weaponPartsFactory.CreateDetonation();
        }

        // Method to build the launcher of the weapon
        public virtual void BuildLauncher() {
            _launcher = _weaponPartsFactory.CreateLauncher();
        }

        // Abstract method to retrieve the fully constructed weapon, to be implemented by subclasses
        public abstract IWeapon GetWeapon();
    }
}

