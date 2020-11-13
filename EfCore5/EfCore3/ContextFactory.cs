using Microsoft.EntityFrameworkCore;

namespace EfCore3
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
