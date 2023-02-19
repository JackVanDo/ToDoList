using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Enum

    /// Описание:
    /// Приоритет задачи
    /// 


{
    public enum Priority
    {
        [Display(Name = "Простая")]
        Easy = 0,
        [Display(Name = "Важная")]
        Medium = 1,
        [Display(Name = "Критичная")]
        High = 2
    }
}
