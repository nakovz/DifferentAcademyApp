using ConsoleGame;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    public class TestFirstCode {
        public int TestFirstCodeId { get; set; }
        public string TestFirstCodeName { get; set; }
        public DateTime DateOfCodeFirstMigrationCreated { get; set; }

    }
}
public class TestCodeFirstDbContext : DbContext {
    public DbSet<TestFirstCode> TestFirstCodes { get; set; }
}

