using System.Collections.Generic;
using System.Linq;

namespace HomeWork.Models.Service
{
    public class AccountBookService
    {
        private readonly SkillTreeHomeworkEntities _db;

        public AccountBookService()
        {
            _db = new SkillTreeHomeworkEntities();
        }

        public List<FinancialTranscation> Lookup()
        {
            var viewModel = _db.AccountBook
               .Select(a => new FinancialTranscation
               {
                   Amount = a.Amounttt,
                   Category = a.Categoryyy,
                   Date = a.Dateee,
                   Guid = a.Id,
                   Remark = a.Remarkkk
               }).ToList();

            return viewModel;
        }
    }
}