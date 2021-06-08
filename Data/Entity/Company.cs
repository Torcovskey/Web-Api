using Data.Interfaces;

namespace Data.Entity
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
