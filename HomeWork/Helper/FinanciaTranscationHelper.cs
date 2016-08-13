using HomeWork.Enum;
using System.Web.Mvc;

namespace HomeWork.Helper
{
    public static class FinanciaTranscationHelper
    {
        public static string CategoryStyle(this HtmlHelper helper, CategoryEnum category)
        {
            return category == CategoryEnum.支出 
                ? "fontRed" 
                : (category == CategoryEnum.收入 ? "fontBlue" : null);
        }
    }
}