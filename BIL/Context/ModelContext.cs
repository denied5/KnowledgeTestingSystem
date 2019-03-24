namespace BIL
{
    using BIL.Entitys;
    using BIL.Interfaces;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBContext : DbContext, IContext
    {
        public DBContext()
            : base("DbConnection")
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Test> Tests  { get; set; }
    }
}