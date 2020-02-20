using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MySwitch.Core.Models;
using MySwitch.Data.Repositories;

namespace MySwitch.Controllers
{
    public class FeeController:Controller
    {
        FeeRepository Repo = new FeeRepository();

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Fee model)
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

            Fee channels = _context.Fees.Find(id);
            if (channels == null)
            {
                return HttpNotFound();
            }

            return View(channels);


        }

        [HttpPost]
        public ActionResult Edit(Fee model)
        {
            var _context = new ApplicationDbContext();
            Repo.Update(model);

            return View();
        }

        public ActionResult Index()
        {
            var getList = Repo.GetAll();
            return View(getList == null ? new List<Fee>() : getList);
        }
    }
}
   