using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryWeapons {
    
    // Singleton class to manage the repository of weapon blueprints
    public class BlueprintRepositoryRND {

        // List to store weapon blueprints
        private List<IWeaponBlueprint> _blueprintRegistry = new List<IWeaponBlueprint>();

        // Static instance of the BlueprintRepositoryRND
        private static BlueprintRepositoryRND _instance;

        // Private constructor to prevent instantiation from outside the class
        private BlueprintRepositoryRND() { }

        // Public property to access the singleton instance of the class
        public static BlueprintRepositoryRND Instance {
            get {
                // Create a new instance if it doesn't already exist
                if (_instance == null) {
                    _instance = new BlueprintRepositoryRND();
                }
                return _instance;
            }
        }

        // This method retrieves a blueprint based on the specified weapon family and version using LINQ to filter and select
        // the matching blueprint from _blueprintRegistry.
        public IWeaponBlueprint GetBlueprint(WeaponFamilies family, int version) {
            return _blueprintRegistry.FirstOrDefault(x => x.WeaponFamily == family && x.WeaponVersion == version);
        }

        // This method adds a new blueprint to the _blueprintRegistry list.
        public void RegisterBlueprint(IWeaponBlueprint blueprint) {
            _blueprintRegistry.Add(blueprint);
        }

        // This method iterates through all blueprints in _blueprintRegistry and yields those that implement IWeaponStats.
        public IEnumerable<IWeaponStats> Stats() {
            foreach (var stat in _blueprintRegistry) {
                if (stat is IWeaponStats weaponStat) {
                    yield return weaponStat;
                }
            }
        }
    }
}
