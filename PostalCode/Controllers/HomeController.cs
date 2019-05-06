using PostalCode.ViewModels;
using PostalCode.WorkerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostalCode.Controllers
{
    public class HomeController : Controller
    {
        // 処理クラスを取り込む
        private IHomeWorkerModel Worker;
        public HomeController() { Worker = new HomeWorkerModel(); }
        public HomeController(IHomeWorkerModel worker) { Worker = worker; }

        public ActionResult Index()
        {
            HomeView view = Worker.InitView();
            return View(view);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "BTNDummy")]HomeView inView)
        {
            if (inView.BTNDummy == null) { return RedirectToAction("Index", "Home"); }
            HomeView view = Worker.GetDummy(inView);
            return View(view);
        }
    }
}