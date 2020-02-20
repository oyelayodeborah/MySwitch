using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MySwitch.Core.Models;
using MySwitch.Data.Repositories;

namespace MySwitch.Controllers
{
    public class RouteController:Controller
    {
        RouteRepository Repo = new RouteRepository();

        public ActionResult Add()
        {
            var _context = new ApplicationDbContext();
            Route model = new Route();
            model.SinkNodes = _context.SinkNodes.ToList();
            if (model.SinkNodes.Count() == 0)
            {
                model.SinkNodes =  new List<SinkNode>();
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Route model)
        {
            var _context = new ApplicationDbContext();
            model.SinkNodes = _context.SinkNodes.ToList();
            if (model.SinkNodes.Count() == 0)
            {
                model.SinkNodes =  new List<SinkNode>();
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
            
            Route model = _context.Routes.Find(id);
            model.SinkNodes = _context.SinkNodes.ToList();
            if (model.SinkNodes.Count() == 0)
            {
                model.SinkNodes = new List<SinkNode>();

            }

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);



        }

        [HttpPost]
        public ActionResult Edit(Route model)
        {
            var _context = new ApplicationDbContext();
            model.SinkNodes = _context.SinkNodes.ToList();
            if (model.SinkNodes.Count() == 0)
            {
                model.SinkNodes =  new List<SinkNode>();
            }

            Repo.Update(model);

            return View();
        }

        public ActionResult Index()
        {
            var getList = Repo.GetAll();
            return View(getList == null ? new List<Route>() : getList);
        }
    }
}

