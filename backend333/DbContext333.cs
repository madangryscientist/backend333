using backend333.Migrations;
using backend333.RequestModels;
using Microsoft.EntityFrameworkCore;

namespace backend333;

public class DbContext333 : DbContext
{
    public DbContext333(DbContextOptions<DbContext333> options)
        : base(options)
    {
    }
    public DbSet<ContactUs> ContactUs { get; set; }
    public DbSet<Faq> Faqs { get; set; }
    public DbSet<Store> Store { get; set; }
    public DbSet<Community> Community { get; set; }
    public DbSet<Tracks> Track { get; set; }
    
    public DbSet<CommunityComment> CommunityComment { get; set; }

}