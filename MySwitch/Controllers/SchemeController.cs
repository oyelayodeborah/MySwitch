using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MySwitch.Core.Models;
using MySwitch.Data.Repositories;
namespace MySwitch.Controllers
{
    public class SchemeController:Controller
    {
        SchemeRepository Repo = new SchemeRepository();

        public ActionResult Add()
        {
            var _context = new ApplicationDbContext();
            Scheme model = new Scheme();
            model.Routes = _context.Routes.ToList();
            if (model.Routes.Count() == 0)
            {
                model.Routes =  new List<Route>();;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Scheme model)
        {
            var _context = new ApplicationDbContext();
            model.Routes = _context.Routes.ToList();
            
            if (model.Routes.Count() == 0)
            {
                model.Routes =  new List<Route>();;
            }
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

            Scheme model = _context.Schemes.Find(id);
            model.Routes = _context.Routes.ToList();
            if (model.Routes.Count() == 0)
            {
                model.Routes =  new List<Route>();;
            }
            if (model ==  null)
            {
                return HttpNotFound();
            }

            return View(model);


        }

        [HttpPost]
        public ActionResult Edit(Scheme model)
        {
            var _context = new ApplicationDbContext();
            model.Routes = _context.Routes.ToList();
            if (model.Routes.Count() == 0)
            {
                model.Routes =  new List<Route>();;
            }
            Repo.Update(model);

            return View();
        }

        public ActionResult Index()
        {
            var getList = Repo.GetAll();
            return View(getList ==  null ? new List<Scheme>() : getList);
        }
    }
}


