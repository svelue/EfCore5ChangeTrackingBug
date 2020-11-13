using System;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var context = new ContextFactory().Create())
            {
                var entity = new Entity();
                entity.Count = 1;
                entity.Times[0] = DateTime.Now;
                await context.Entities.AddAsync(entity);
                await context.SaveChangesAsync();
                Console.WriteLine($"Count: {entity.Count}, Times: {string.Join(", ", entity.Times)}");
            }

            for (int i = 1; i < 3; i++)
            {
                using (var context = new ContextFactory().Create())
                {
                    var dbEntity = context.Entities.First();
                    dbEntity.Count++;
                    dbEntity.Times[i] = DateTime.Now.AddSeconds(i);

                    //var newArray = new DateTime[3];
                    //dbEntity.Times.CopyTo(newArray, 0);
                    //newArray[i] = DateTime.Now.AddSeconds(1);
                    //dbEntity.Times = newArray;
                    
                    await context.SaveChangesAsync();
                    Console.WriteLine($"Count: {dbEntity.Count}, Times: {string.Join(", ", dbEntity.Times)}");
                }
            }
        }
    }
}
