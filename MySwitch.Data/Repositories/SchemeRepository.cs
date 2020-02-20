using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwitch.Core.Models;

namespace MySwitch.Data.Repositories
{
    public class SchemeRepository
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public BaseRepository<Scheme> Repo = new BaseRepository<Scheme>(new ApplicationDbContext());

        public Scheme Get(int? id)
        {
            return Repo.Get(id);
        }
        public IEnumerable<Scheme> GetByRouteId(Route RouteId)
        {
            return _context.Schemes.Where(c => c.RouteId == RouteId);
        }
        public IEnumerable<Scheme> GetAll()
        {
            return _context.Schemes.ToList();
        }
        public void Update(Scheme channel)
        {
            Repo.Update(channel);
        }

        public void Save(Scheme channel)
        {
            Repo.Save(channel);
        }
    }
}
