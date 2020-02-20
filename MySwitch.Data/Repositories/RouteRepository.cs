using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwitch.Core.Models;

namespace MySwitch.Data.Repositories
{
    public class RouteRepository
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public BaseRepository<Route> Repo = new BaseRepository<Route>(new ApplicationDbContext());

        public Route Get(int? id)
        {
            return Repo.Get(id);
        }
        public IEnumerable<Route> GetByName(string Name)
        {
            return _context.Routes.Where(c => c.Name == Name);
        }
        public IEnumerable<Route> GetByCardPAN(string CardPan)
        {
            return _context.Routes.Where(c => c.CardPAN == CardPan);
        }
        public IEnumerable<Route> GetAll()
        {
            return _context.Routes.ToList();
        }
        public void Update(Route channel)
        {
            Repo.Update(channel);
        }

        public void Save(Route channel)
        {
            Repo.Save(channel);
        }
    }
}
