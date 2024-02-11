using Business.Abstracts;
using Entities.Concretes;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class PersonManager:IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }



        public async Task<bool> CheckPersonAsync(Person person)
        {
            using (KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
            {
                var result = await client.TCKimlikNoDogrulaAsync(
                    person.NationalIdentity,
                    person.FirstName,
                    person.LastName,
                    person.DateOfBirthYear);

                return result.Body.TCKimlikNoDogrulaResult;
            }
        }



    }
}
