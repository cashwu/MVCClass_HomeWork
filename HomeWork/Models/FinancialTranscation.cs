using HomeWork.Enum;
using HomeWork.Filter;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ValidateSample.Filters;

namespace HomeWork.Models
{
    public class FinancialTranscation
    {
        public int No { get; set; }

        [Display(Name = "類別")]
        [Required]
        public CategoryEnum Category { get; set; }

        [Display(Name = "日期")]
        [Required]
        [UIHint("Date")]
        [Day]
        public DateTime Date { get; set; }

        [Display(Name = "金額")]
        [Required]
        [Range(0, int.MaxValue)]
        public decimal Amount { get; set; }

        public Guid Guid { get; set; }

        [Display(Name = "備註")]
        [Required]
        [RemoteDoublePlus("String100", "Valid", AreaReference.UseCurrent)]
        public string Remark { get; set; }
    }
}