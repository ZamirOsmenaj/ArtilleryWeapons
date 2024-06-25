using System;
using System.Collections.Generic;
using ArtilleryWeapons.Builders;
using ArtilleryWeapons.Weapons;

namespace ArtilleryWeapons {
    public class Program {
        static void Main(string[] args) {
            // Create RND Repository which stores all the Blueprints
            var repository = BlueprintRepositoryRND.Instance;

            // Create and register weapon blueprints
            RegisterWeaponBlueprints(repository);

            // List all weapon stats in the repository
            ListAllWeaponStats(repository);

            // Create a Director (Οrchestrator)
            var director = new Director();

            // Construct and display weapons
            ConstructAndDisplayWeapon(director, repository, WeaponFamilies.FAB, 250);
            ConstructAndDisplayWeapon(director,repository, WeaponFamilies.GuidedRocket, 1000);
            ConstructAndDisplayWeapon(director, repository, WeaponFamilies.GuidedProjectile, 1000);
            ConstructAndDisplayWeapon(director, repository, WeaponFamilies.Conventional, 1000);

            // Demonstrate Prototype Design Pattern by cloning a blueprint
            DemonstratePrototypePattern(repository, WeaponFamilies.FAB, 250);
        }

        // Method to register all weapon blueprints in the repository
        private static void RegisterWeaponBlueprints(BlueprintRepositoryRND repository) {
            // List of weapon blueprints to register
            var blueprints = new List<WeaponBlueprint>
            {
                new WeaponBlueprint
                {
                    CasingBlueprint = new CFABMetalCasingBlueprint(
                        MetalCasingType.Steel, MetalCasingShape.Cylindrical, 100, 10),
                    ExplosiveBlueprint = new CFABExplosiveBlueprint(
                        ExplosiveType.HighExplosive, 50),
                    GuidanceKitBlueprint = new CFABGuidanceKitBlueprint(
                        GuidanceType.Ballistic, 99.9),
                    DetonationBlueprint = new CFABDetonationBlueprint(
                        DetonationType.Impact, 95.5),
                    LauncherBlueprint = new CFABLauncherBlueprint(
                        LauncherType.Aeroplane, 100),
                    WeaponVersion = 250,
                    WeaponFamily = WeaponFamilies.FAB,
                    WeaponName = "Thunderbolt",
                    CostKEUR = 1000,
                    DamageRadiusM = 300,
                    CruiseSpeed = VelocityType.Subsonic,
                    WeaponType = WeaponType.AntiPersonnel,
                },
                new WeaponBlueprint
                {
                    CasingBlueprint = new CRocketProjectileMetalCasingBlueprint(
                        MetalCasingType.Titanium, MetalCasingShape.Conical, 100, 10),
                    ExplosiveBlueprint = new CRocketProjectileExplosiveBlueprint(
                        ExplosiveType.Fragmentation, 50),
                    GuidanceKitBlueprint = new CRocketProjectileGuidanceKitBlueprint(
                        GuidanceType.Inertial, 99.9),
                    DetonationBlueprint = new CRocketProjectileDetonationBlueprint(
                        DetonationType.Proximity, 95.5),
                    LauncherBlueprint = new CRocketProjectileLauncherBlueprint(
                        LauncherType.RocketLauncher, 100),
                    WeaponVersion = 1000,
                    WeaponFamily = WeaponFamilies.GuidedRocket,
                    WeaponName = "McQueen",
                    CostKEUR = 1000,
                    DamageRadiusM = 300,
                    CruiseSpeed = VelocityType.Supersonic,
                    WeaponType = WeaponType.AntiTank,
                },
                new WeaponBlueprint
                {
                    CasingBlueprint = new CGuidedProjectileMetalCasingBlueprint(
                        MetalCasingType.Tungsten, MetalCasingShape.Conical, 100, 10),
                    ExplosiveBlueprint = new CGuidedProjectileExplosiveBlueprint(
                        ExplosiveType.Incendiary, 50),
                    GuidanceKitBlueprint = new CGuidedProjectileGuidanceKitBlueprint(
                        GuidanceType.GPS, 99.9),
                    DetonationBlueprint = new CGuidedProjectileDetonationBlueprint(
                        DetonationType.Remote, 95.5),
                    LauncherBlueprint = new CGuidedProjectileLauncherBlueprint(
                        LauncherType.Howitzer, 100),
                    WeaponVersion = 1000,
                    WeaponFamily = WeaponFamilies.GuidedProjectile,
                    WeaponName = "AlphaToOmega",
                    CostKEUR = 1000,
                    DamageRadiusM = 300,
                    CruiseSpeed = VelocityType.Hypersonic,
                    WeaponType = WeaponType.AntiFortification,
                },
                new WeaponBlueprint
                {
                    CasingBlueprint = new CConventionalProjectileMetalCasingBlueprint(
                        MetalCasingType.DepletedUranium, MetalCasingShape.Cylindrical, 100, 10),
                    ExplosiveBlueprint = new CConventionalProjectileExplosiveBlueprint(
                        ExplosiveType.Thermobaric, 50),
                    GuidanceKitBlueprint = new CConventionalProjectileGuidanceKitBlueprint(
                        GuidanceType.Ballistic, 99.9),
                    DetonationBlueprint = new CConventionalProjectileDetonationBlueprint(
                        DetonationType.Command, 95.5),
                    LauncherBlueprint = new CConventionalProjectileLauncherBlueprint(
                        LauncherType.Cannon, 100),
                    WeaponVersion = 1000,
                    WeaponFamily = WeaponFamilies.Conventional,
                    WeaponName = "BigBoom",
                    CostKEUR = 1000,
                    DamageRadiusM = 300,
                    CruiseSpeed = VelocityType.Supersonic,
                    WeaponType = WeaponType.AntiTank,
                }
            };

            // Register each blueprint in the repository
            foreach (var blueprint in blueprints) {
                repository.RegisterBlueprint(blueprint);
            }
        }

        // Method to list all weapon stats in the repository
        private static void ListAllWeaponStats(BlueprintRepositoryRND repository) {
            foreach (var stat in repository.Stats()) {
                Console.WriteLine(stat.WeaponName);
            }
        }

        // Method to construct and display a weapon
        private static void ConstructAndDisplayWeapon(Director director, BlueprintRepositoryRND repository, WeaponFamilies family, int version) {
            var weapon = director.Construct(family, version);

            Console.WriteLine();
            Console.WriteLine(weapon);
            Console.WriteLine();
        }

        // Method to demonstrate Prototype Design Pattern by cloning a blueprint
        private static void DemonstratePrototypePattern(BlueprintRepositoryRND repository, WeaponFamilies family, int version) {
            // Retrieve the original blueprint from the repository
            var originalBlueprint = repository.GetBlueprint(family, version);
            if (originalBlueprint == null) {
                Console.WriteLine("Original blueprint not found!");
                return;
            }

            // Clone the original blueprint
            var clonedBlueprint = originalBlueprint.Clone();
            if (clonedBlueprint != null) {
                Console.WriteLine("Cloned blueprint successfully!");
                // Display the details of the cloned blueprint
                DisplayBlueprintDetails(clonedBlueprint);
            }
        }

        // Method to display the details of a weapon blueprint
        private static void DisplayBlueprintDetails(IWeaponBlueprint blueprint) {
            Console.WriteLine("Blueprint Details:");
            Console.WriteLine($"Weapon Family: {blueprint.WeaponFamily}");
            Console.WriteLine($"Weapon Version: {blueprint.WeaponVersion}");
            Console.WriteLine($"Weapon Name: {blueprint.WeaponName}");
            Console.WriteLine($"Cost (KEUR): {blueprint.CostKEUR}");
            Console.WriteLine($"Damage Radius (M): {blueprint.DamageRadiusM}");
            Console.WriteLine($"Cruise Speed: {blueprint.CruiseSpeed}");
            Console.WriteLine($"Weapon Type: {blueprint.WeaponType}");
            Console.WriteLine();
        }
    }
}