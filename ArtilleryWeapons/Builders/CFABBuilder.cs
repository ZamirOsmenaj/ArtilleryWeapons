using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtilleryWeapons.Weapons;

namespace ArtilleryWeapons.Builders {

    // Class inheriting the BaseWeaponBuilder interface to build a CFAB weapon
    public class CFABBuilder : BaseWeaponBuilder {

        public CFABBuilder(CFABFactory factory) : base(factory) { }

        // Method to retrieve the fully constructed weapon
        public override IWeapon GetWeapon() {
            return new CFABWeapon(_metalCasing, _explosive, _guidanceKit, _detonation, _launcher);
        }
    }
}
