using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MySwitch.Core.Models;
using MySwitch.Data.Repositories;

namespace MySwitch.Controllers
{
    public class SourceNodeController:Controller
    {
        SourceNodeRepository Repo = new SourceNodeRepository();


        public ActionResult Add()
        {
            var _context = new ApplicationDbContext();
            SourceNode model = new SourceNode();
            model.Schemes = _context.Schemes.ToList();
            if (model.Schemes.Count()==0)
            {
                model.Schemes = new List<Scheme>();
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(SourceNode model)
        {
            var _context = new ApplicationDbContext();
            model.Schemes = _context.Schemes.ToList();
            if (model.Schemes.Count() == 0)
            {
                model.Schemes = new List<Scheme>();
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

            SourceNode model = _context.SourceNodes.Find(id);
            model.Schemes = _context.Schemes.ToList();
            if (model.Schemes.Count() == 0)
            {
                model.Schemes = new List<Scheme>();
            }
            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);


        }

        [HttpPost]
        public ActionResult Edit(SourceNode model)
        {
            var _context = new ApplicationDbContext();
            model.Schemes = _context.Schemes.ToList();
            if (model.Schemes.Count() == 0)
            {
                model.Schemes = new List<Scheme>();
            }
            Repo.Update(model);

            return Redirect("Index");
        }

        public ActionResult Index()
        {
            var getList = Repo.GetAll();
            return View(getList==null? new List<SourceNode>():getList);
        }
    }
}