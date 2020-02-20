using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MySwitch.Core.Models;
using MySwitch.Data.Repositories;

namespace MySwitch.Controllers
{
    public class TransactionTypeController:Controller
    {
        TransactionTypeRepository Repo = new TransactionTypeRepository();

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(TransactionType model)
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

            TransactionType channels = _context.TransactionTypes.Find(id);
            if (channels == null)
            {
                return HttpNotFound();
            }

            return View(channels);


        }

        [HttpPost]
        public ActionResult Edit(TransactionType model)
        {
            var _context = new ApplicationDbContext();
            Repo.Update(model);

            return View();
        }

        public ActionResult Index()
        {
            var getList = Repo.GetAll();
            return View(getList == null ? new List<TransactionType>() : getList);
        }
    }
}