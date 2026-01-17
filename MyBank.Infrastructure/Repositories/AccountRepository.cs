using MyBank.Domain.Model.Entities;
using MyBank.Domain.Services.Interfaces;
using MyBank.Infrastructure.Persistence;

namespace MyBank.Infrastructure.Repositories
{
    public class AccountRepository(BankDbContext db) : IAccountRepository
    {
        public Account? GetById(int id) => db.Accounts.Find(id);
        public IEnumerable<Account> GetAll() => db.Accounts.ToList();
        public void Add(Account acc) { db.Accounts.Add(acc); db.SaveChanges(); }
        public void Update(Account acc) { db.Update(acc); db.SaveChanges(); }
        public void Delete(int id)
        {
            var acc = GetById(id);
            if (acc != null) db.Accounts.Remove(acc);
            db.SaveChanges();
        }
    }
}
