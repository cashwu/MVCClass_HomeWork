using HomeWork.Enum;
using System;

namespace HomeWork.Models
{
    public class FinancialTranscation
    {
        public int No { get; set; }

        public CategoryEnum Category { get; set; }

        public DateTime Date { get; set; }

        public Decimal Amount { get; set; }
    }
}