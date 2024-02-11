using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class PttManager:ISupplierService
    {
      private  IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public async void GiveMask(Person person)
        {
            bool isPersonValid = await _applicantService.CheckPersonAsync(person);

            if (isPersonValid)
            {
                Console.WriteLine(person.FirstName + " İçin Maske Verildi:");
            }
            else
            {
                Console.WriteLine(person.FirstName + " İçin Maske Verilmedi:");
            }
        }

        //public void GiveMask(Person person)
        //{
        //    if (_applicantService.CheckPersonAsync(person)) 
        //    {
        //        Console.WriteLine(person.FirstName + "İçin Maske Verildi:");
        //    }
        //    else
        //    {
        //        Console.WriteLine(person.FirstName + "İçin Maske Verilmedi:");
        //    }

        //}
    }
}
