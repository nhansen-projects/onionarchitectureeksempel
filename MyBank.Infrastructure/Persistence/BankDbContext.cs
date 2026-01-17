using Microsoft.EntityFrameworkCore;
using MyBank.Domain.Model.Entities;

namespace MyBank.Infrastructure.Persistence;

public class BankDbContext(DbContextOptions<BankDbContext> opt) : DbContext(opt)
{
    public DbSet<Account> Accounts { get; set; }
}