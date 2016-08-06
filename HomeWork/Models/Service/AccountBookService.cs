using HomeWork.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork.Models.Service
{
    public class AccountBookService : Repository<AccountBook>
    {
        private readonly IRepository<AccountBook> _accountBookRepo;


        public AccountBookService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _accountBookRepo = new Repository<AccountBook>(unitOfWork);
        }

        public List<FinancialTranscation> Lookup()
        {
            var viewModel = _accountBookRepo.LookupAll()
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