using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreRelationshipsToturial
{
    public class CreateCharacterDto
    {
        public string Name { get; set; } = "Character";
        public string RgpClass { get; set; } = "Knight";
        public int UserId { get; set; } = 1;
    }
}
