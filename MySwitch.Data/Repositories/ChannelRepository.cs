using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwitch.Core.Models;

namespace MySwitch.Data.Repositories
{
    public class ChannelRepository
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public BaseRepository<Channel> Repo = new BaseRepository<Channel>(new ApplicationDbContext());

        public Channel Get(int? id)
        {
            return Repo.Get(id);
        }
        public IEnumerable<Channel> GetByName(string Name)
        {
            return _context.Channels.Where(c => c.Name == Name);
        }
        public IEnumerable<Channel> GetAll()
        {
            return _context.Channels.ToList();
        }
        public void Update(Channel channel)
        {
            Repo.Update(channel);
        }

        public void Save(Channel channel)
        {
            Repo.Save(channel);
        }
    }
}
