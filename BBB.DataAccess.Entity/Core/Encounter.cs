﻿using System.ComponentModel.DataAnnotations;

namespace BBB.DataAccess.Entity.Core
{
    internal sealed class Encounter
    {
        [Key]
        public Guid EncounterKey { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? Preparation {  get; set; }

        public string? Fight {  get; set; }

        public string? Danger {  get; set; }

        public int SortOrder { get; set; }

        public Guid RaidKey { get; set; }

        public Raid? Raid { get; set; }

        public List<EncounterPosition> Positions { get; set; } = new();
    }
}
