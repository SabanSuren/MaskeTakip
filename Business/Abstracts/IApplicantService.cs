using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();


        
            Task<bool> CheckPersonAsync(Person person);
        

    }
}
