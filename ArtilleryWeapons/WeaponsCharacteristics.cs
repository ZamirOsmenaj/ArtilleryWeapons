using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryWeapons {
    public enum MetalCasingType { Steel, Titanium, Tungsten, DepletedUranium }
    public enum ExplosiveType { HighExplosive, Fragmentation, Incendiary, Cluster, Thermobaric }
    public enum GuidanceType { Laser, GPS, Inertial, Radar, TV, Ballistic }
    public enum DetonationType { Impact, Proximity, Timed, Remote, Command }
    public enum LauncherType { Mortar, Howitzer, Cannon, RocketLauncher, Aeroplane }
    public enum WeaponType { AntiPersonnel, AntiTank, AntiFortification, AntiInfrastructure }
    public enum VelocityType { Subsonic, Supersonic, Hypersonic }
    public enum WeaponFamilies { FAB, GuidedRocket, GuidedProjectile, Conventional }
    public enum MetalCasingShape { Cylindrical, Spherical, Conical, Cubic }
}
