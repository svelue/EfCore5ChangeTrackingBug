using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace EfCore5
{
    public class ContextFactory
    {
        private readonly DbContextOptions _options;

        public ContextFactory()
        {
            _options = new DbContextOptionsBuilder<ExampleDbContext>()
                .UseInMemoryDatabase("dbname")
                .Options;
        }

        public ExampleDbContext Create()
        {
            return new ExampleDbContext(_options);
        }
    }
}
