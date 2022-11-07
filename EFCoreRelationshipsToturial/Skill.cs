using System.Text.Json.Serialization;

namespace EFCoreRelationshipsToturial
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }=String.Empty;
        public int Damage { get; set; } = 100;
        [JsonIgnore]
        public List<Character> Characters { get; set; } = new List<Character>();

    }
}
