using ComicWorld.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Comic> Comics { get; set; }
        public DbSet<ComicTag> ComicTag { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ComicWorld.Domain.Model.Type> Types { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ComicTag>()
                .HasKey(it => new { it.ComicId, it.TagId });

            builder.Entity<ComicTag>()
                .HasOne<Comic>(it => it.Comic)
                .WithMany(i => i.ComicTags)
                .HasForeignKey(it => it.ComicId);

            builder.Entity<ComicTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(i => i.ComicTags)
                .HasForeignKey(it => it.TagId);

            
        }
    }
}
