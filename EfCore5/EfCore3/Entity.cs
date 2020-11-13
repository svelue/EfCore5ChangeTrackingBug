using System;

namespace EfCore3
{
    public class Entity
    {
        public Entity()
        {
            Times = new DateTime[3];
        }

        public int Id { get; set; }
        public int Count { get; set; }
        public DateTime[] Times { get; set; }
    }
}
