using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MySwitch.Core.Models;
using MySwitch.Data.Repositories;

namespace MySwitch.Controllers
{
    public class SinkNodeController:Controller
    {
        SinkNodeRepository Repo = new SinkNodeRepository();


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(SinkNode model)
        {
            Repo.Save(model);

            return View();
        }
        public ActionResult Edit(int? id)
        {
            var _context = new ApplicationDbContext();
            if (id == null)
            {
                return HttpNotFound();
            }

            SinkNode channels = _context.SinkNodes.Find(id);
            if (channels == null)
            {
                return HttpNotFound();
            }

            return View(channels);


        }

        [HttpPost]
        public ActionResult Edit(SinkNode model)
        {
            var _context = new ApplicationDbContext();
            Repo.Update(model);

            return View();
        }

        public ActionResult Index()
        {
            var getList = Repo.GetAll();
            return View(getList == null ? new List<SinkNode>() : getList);
        }
    }
}