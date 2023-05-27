using App_HoaDon_HaiHau.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HoaDon_HaiHau
{
    public class DbContextSql :DbContext
    {

        public DbContextSql(DbContextOptions<DbContextSql> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<CongTy> CongTy { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlite("Data Source=thuedb.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }

    //Muốn DI được cần khai báo cái này mặc dù bên host đã services.DBContext rồi(winform 5.0 thôi)
    //public class DbContextSqlFactory : IDesignTimeDbContextFactory<DbContextSql>
    //{
    //    public AppContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<DbContextSql>();
    //        optionsBuilder.UseSqlite("Data Source=.\\blog.db");

    //        return new DbContextSql(optionsBuilder.Options);
    //    }
    //}
}
