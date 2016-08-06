using HomeWork.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HomeWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly SkillTreeHomeworkEntities _db = new SkillTreeHomeworkEntities();

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult FinancialTranscation()
        {
            var model = GetFakeFinancialTranscationData();

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

        private List<FinancialTranscation> GetFakeFinancialTranscationData()
        {
            var financialTranscations = _db.AccountBook
                .Select(a => new FinancialTranscation
                {
                     Amount = a.Amounttt,
                     Category = a.Categoryyy,
                     Date = a.Dateee,
                     Guid = a.Id,
                     Remark = a.Remarkkk
                }).ToList();
                
            return financialTranscations;
        }
    }
}