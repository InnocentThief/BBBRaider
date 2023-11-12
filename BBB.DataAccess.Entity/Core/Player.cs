using System.ComponentModel.DataAnnotations;

namespace BBB.DataAccess.Entity.Core
{
    internal sealed class Player
    {
        [Key]
        public Guid PlayerKey { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
