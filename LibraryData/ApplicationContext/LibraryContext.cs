
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData.ApplicationDbContext
{
    public class LibraryContext : DbContext       
    {

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) 
        {

        }

        public DbSet<Patron> Patrons { get; set; }

        public DbSet<BranchHours> BranchHour { get; set; }

        public DbSet<LibraryBranch> LibraryBranches { get; set; }

        public DbSet<LibraryAsset> LibraryAssets{ get; set; }

        public DbSet<Holds> Holds{ get; set; }

        public DbSet<CheckoutHistory> checkoutHistories{ get; set; }

        public DbSet<LibraryCard> LibraryCards { get; set; }

        public DbSet<Video> Videos { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Checkout> Checkouts{ get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
