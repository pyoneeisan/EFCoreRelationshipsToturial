﻿namespace EFCoreRelationshipsToturial
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }=String.Empty;
        public List<Character> Characters { get; set; }
    }
}
