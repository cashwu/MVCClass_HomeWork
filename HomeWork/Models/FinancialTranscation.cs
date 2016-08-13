using HomeWork.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace HomeWork.Models
{
    public class FinancialTranscation
    {
        public int No { get; set; }

        [Display(Name = "類別")]
        public CategoryEnum Category { get; set; }

        [Display(Name = "日期")]
        public DateTime Date { get; set; }

        [Display(Name = "金額")]
        public Decimal Amount { get; set; }

        public Guid Guid { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}