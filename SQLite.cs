using System;

using Microsoft.EntityFrameworkCore;

namespace OneDriveSync.SQLite
{
    public enum ItemType
    {
        file,
        dir
    }

    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public string eTag { get; set; }
        public string cTag { get; set; }
        public DateTime ModifyTime { get; set; }
        public string ParentId { get; set; }
        public string CRC32 { get; set; }
    }

    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Items.db");
        }
    }
}