using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwitch.Core.Models;

namespace MySwitch.Data.Repositories
{
    public class TransactionTypeRepository
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public BaseRepository<TransactionType> Repo = new BaseRepository<TransactionType>(new ApplicationDbContext());

        public TransactionType Get(int? id)
        {
            return Repo.Get(id);
        }
        public IEnumerable<TransactionType> GetByName(string Name)
        {
            return _context.TransactionTypes.Where(c => c.Name == Name);
        }
        public IEnumerable<TransactionType> GetAll()
        {
            return _context.TransactionTypes.ToList();
        }
        public void Update(TransactionType channel)
        {
            Repo.Update(channel);
        }

        public void Save(TransactionType channel)
        {
            Repo.Save(channel);
        }
    }
}
