using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwitch.Core.Models;

namespace MySwitch.Data.Repositories
{
    public class SinkNodeRepository
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public BaseRepository<SinkNode> Repo = new BaseRepository<SinkNode>(new ApplicationDbContext());

        public SinkNode Get(int? id)
        {
            return Repo.Get(id);
        }
        public IEnumerable<SinkNode> GetByStatus(Status Status)
        {
            return _context.SinkNodes.Where(c => c.Status == Status);
        }
        public IEnumerable<SinkNode> GetByName(string Name)
        {
            return _context.SinkNodes.Where(c => c.Name == Name);
        }
        public IEnumerable<SinkNode> GetAll()
        {
            return _context.SinkNodes.ToList();
        }
        public void Update(SinkNode channel)
        {
            Repo.Update(channel);
        }

        public void Save(SinkNode channel)
        {
            Repo.Save(channel);
        }
    }
}
