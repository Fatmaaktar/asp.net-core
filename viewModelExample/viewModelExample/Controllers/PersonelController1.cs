using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using viewModelExample.Business;
using viewModelExample.Models;
using viewModelExample.Models.ViewModels;

namespace viewModelExample.Controllers
{
    public class PersonelController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonelCreateVM personelCreateVM)
        {
            #region Anelaus(Manuel)
            //Personel p = new Personel()
            //{
            //    Name = personelCreateVM.Name,
            //    Surname = personelCreateVM.Surname,
            //};

            #endregion
            #region Implicit
            //Personel personel = personelCreateVM;
            //PersonelCreateVM vm = personel;
            #endregion
            #region Expilicit
            //Personel p =(Personel)personelCreateVM;
            //PersonelCreateVM p2 = (PersonelCreateVM)p;
            #endregion
            #region Reflection
           //Personel p= TypeConversion.Conversion<PersonelCreateVM, Personel>(personelCreateVM);
           // TypeConversion.Conversion<Personel, PersonelListVM>(new Personel { Name = "Fatma", Surname = "Aktar" });
            #endregion
            return View();
        }
        public IActionResult Listele()
        {
            List<PersonelListVM> personels = new List<Personel>
            {
                new Personel{Name="A",Surname="B"},
                new Personel{Name="A1",Surname="B1"},
                new Personel{Name="A2",Surname="B2"},
                new Personel{Name="A3",Surname="B3"},
                new Personel{Name="A4",Surname="B4"},
            }.Select(p=> new PersonelListVM { 
            Name=p.Name,
            Surname=p.Surname,
            Position=p.Position,
            }).ToList();
            return View(personels);
        }
        public IActionResult Get()
        {
            var nesne = (new Personel(), new Product(), new Customer());
            return View();
        }
    }
}
