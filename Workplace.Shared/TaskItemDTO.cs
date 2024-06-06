using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.Shared
{
    public class TaskItemDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Требуется указать название")]
        [Display(Name="Наименование")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Требуется дать описание")]
        [Display(Name = "Описание")]
        public string? Description { get; set; }
    }
}
