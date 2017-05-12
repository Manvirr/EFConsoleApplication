using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                var count = context.Albums.Count();
                Console.WriteLine(count);

                context.Albums.Add(new Album() { Title= "Wish", Price=50  });
                context.SaveChanges();

                count = context.Albums.Count();
                Console.WriteLine(count);

                Console.ReadLine();
            }
        }
    }

    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    public class MusicContext: DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }


}
