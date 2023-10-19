using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace viewModelExample.Models.ViewModels
{
    public class PersonelCreateVM
    {
        //ViewModel'de sadece taşınacak verinin propertyleri temsil edilir
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
    }
}
