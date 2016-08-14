using HomeWork.Models;
using HomeWork.Models.Service;
using HomeWork.Repositories;
using System;
using System.Net;
using System.Web.Mvc;

namespace HomeWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountBookService _accountBookService;

        public HomeController()
        {
            var unitOfWork = new EFUnitOfWork();
            _accountBookService = new AccountBookService(unitOfWork);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Category, Date, Amount, Remark")]FinancialTranscation model)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.ExpectationFailed);
            }

            var accountBook = new AccountBook
            {
                Id = Guid.NewGuid(),
                Amounttt = Convert.ToInt32(model.Amount),
                Categoryyy = model.Category,
                Dateee = model.Date,
                Remarkkk = model.Remark
            };

            _accountBookService.Create(accountBook);
            _accountBookService.Commit();

            return PartialView("FinancialTranscation", _accountBookService.Lookup());
        }

        [ChildActionOnly]
        public ActionResult FinancialTranscation()
        {
            var model = _accountBookService.Lookup();

            return PartialView(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}