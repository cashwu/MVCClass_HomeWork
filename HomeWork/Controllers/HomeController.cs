using HomeWork.Enum;
using HomeWork.Models;
using HomeWork.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult FinancialTranscation()
        {
            var model = new FinancialTranscationViewModels
            {
                FinancialTranscations = GetFakeFinancialTranscationData()
            };

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

        private static List<FinancialTranscation> GetFakeFinancialTranscationData()
        {
            var financialTranscations = new List<FinancialTranscation>();

            for (int i = 1; i <= 10; i++)
            {
                financialTranscations.Add(new FinancialTranscation
                {
                    No = i,
                    Category = i % 2 == 0 ? CategoryEnum.支出 : CategoryEnum.收入,
                    Date = DateTime.Now.AddDays(i),
                    Amount = i % 2 == 0 ? 150 : 200,
                });
            }
            return financialTranscations;
        }
    }
}