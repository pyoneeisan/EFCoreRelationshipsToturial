using System.Security.Principal;
using System.Text.Json.Serialization;

namespace EFCoreRelationshipsToturial
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public int Damage { get; set; } = 10;
        [JsonIgnore]
        public Character Character { get; set; }
        public int Characterid { get; set; }
    }
}
