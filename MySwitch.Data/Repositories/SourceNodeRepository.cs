﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwitch.Core.Models;

namespace MySwitch.Data.Repositories
{
    public class SourceNodeRepository
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public BaseRepository<SourceNode> Repo = new BaseRepository<SourceNode>(new ApplicationDbContext());

        public SourceNode Get(int? id)
        {
            return Repo.Get(id);
        }
        public IEnumerable<SourceNode> GetByName(string Name)
        {
            return _context.SourceNodes.Where(c => c.Name == Name);
        }
        public IEnumerable<SourceNode> GetByStatus(Status Status)
        {
            return _context.SourceNodes.Where(c => c.Status == Status);
        }
        public IEnumerable<SourceNode> GetAll()
        {
            return _context.SourceNodes.ToList();
        }
        public void Update(SourceNode channel)
        {
            Repo.Update(channel);
        }

        public void Save(SourceNode channel)
        {
            Repo.Save(channel);
        }
    }
}
