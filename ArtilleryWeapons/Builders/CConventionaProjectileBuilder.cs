using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtilleryWeapons.Weapons;

namespace ArtilleryWeapons.Builders {

    // Class inheriting the BaseWeaponBuilder interface to build a CConventionalProjectile weapon
    public class CConventionalProjectileBuilder : BaseWeaponBuilder {

        public CConventionalProjectileBuilder(CConventionalProjectileFactory factory) : base(factory) { }

        // Method to retrieve the fully constructed weapon
        public override IWeapon GetWeapon() {
            return new CConventionalProjectileWeapon(_metalCasing, _explosive, _guidanceKit, _detonation, _launcher);
        }
    }
}
