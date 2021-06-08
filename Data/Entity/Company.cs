using Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Data.Entity
{
    public class Company : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
