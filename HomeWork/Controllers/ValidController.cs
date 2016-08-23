using System.Web.Mvc;

namespace HomeWork.Controllers
{
    public class ValidController : Controller
    {
        public ActionResult String100(string remark)
        {
            var isValidate = remark.Length <= 100;
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}