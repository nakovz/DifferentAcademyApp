using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {

    public class Course {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }
    }

    public class Author {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }

    public class Tag {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
    public enum CourseLevel {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }

    public class PlutoContext : DbContext {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public PlutoContext() : base("DefaultConnection") {

        }
    }

    class Program {
        static void Main(string[] args) {
            //var myStore = new Store { Name = "Different Academy" };
            //myStore.WellcomeScreen();

            //MainMenu.MenuWithDetailPage("Different Academy", "G", MainMenu.Init().ToArray());

            ////exercise with using interfaces
            //List<IItemsForSale> menuList = MainMenu.Init();
            //MainMenu.MenuWithDetailPage("Different Academy", "G", menuList.ToArray());

            //This is my one-line comment (: 

            var context = new DmsEntities();
            var address = new Address {
                Street = "Test Street",
                Number = "Test Number",
                PostalCode = "Test PostalCode",
                City = "Test City",
                State = "Test State",
                Province = "Test Province",
                Country = "Test Country",
                IsActive = 1,
                IsDeleted = 0
            };
            context.Addresses.Add(address);
            context.SaveChanges();
        }
    }
}
