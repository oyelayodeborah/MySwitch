using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using MySwitch.Core.Models;
using MySwitch.Data.Repositories;

namespace MySwitch.Controllers
{
    public class ChannelController : Controller
    {
        ChannelRepository Repo = new ChannelRepository();


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Channel model)
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

            Channel channels = _context.Channels.Find(id);
            if (channels == null)
            {
                return HttpNotFound();
            }

            return View(channels);


        }
        
        [HttpPost]
        public ActionResult Edit(Channel model)
        {
            var _context = new ApplicationDbContext();
            Repo.Update(model);

            return View();
        }

        public ActionResult Index()
        {
            var getList = Repo.GetAll();
            return View(getList == null ? new List<Channel>() : getList);
        }
    }
}