using AuctionService.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;


public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {
    }

    protected AuctionDbContext()
    {
    }

    public DbSet<Auction> Auctions { get; set; }

    public static implicit operator ControllerContext(AuctionDbContext v)
    {
        throw new NotImplementedException();
    }
}