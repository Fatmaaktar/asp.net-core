using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using viewModelExample.Models.ViewModels;

namespace viewModelExample.Models
{

    //Entity Model
    public class Personel
    {
        public int Id { get; set; }
        [Required] // veri girmek zorunludur
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required]
        [StringLength(13)]
        public string Position { get; set; }
        public int Wage { get; set; }
        [Required]
        public bool MaritalStatus { get; set; }

        #region implicit
        public static implicit operator PersonelCreateVM(Personel model)
        {
            return new PersonelCreateVM
            {
                Name=model.Name,
                Surname=model.Surname,
            };
        }
        public static implicit operator Personel(PersonelCreateVM model)
        {
            return new Personel
            {
                Name=model.Name,
                Surname=model.Surname,
            };
        }
        #endregion
    }
}
