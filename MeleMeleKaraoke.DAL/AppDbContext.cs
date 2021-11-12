using Microsoft.EntityFrameworkCore;
using System;
using MeleMeleKarake.domain;
using MeleMeleKaraoke.domain;

namespace MeleMeleKaraoke.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Room> Room { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<CartPackageItem> CartPackageItem { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }
        public DbSet<ComboProduct> ComboProduct { get; set; }
        public DbSet<ComboRoomDetail> ComboRoomDetail { get; set; }
        public DbSet<Deserts> Deserts { get; set; }
        public DbSet<PackageDesert> PackageDesert { get; set; }
        public DbSet<RoomDetails> RoomDetails { get; set; }
        public DbSet<User> User { get; set; }
    }
}
