using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore5
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
