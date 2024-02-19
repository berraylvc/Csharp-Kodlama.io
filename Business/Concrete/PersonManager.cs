using Business.Abstract;
using Entities.Concrete;
using MernsiServiceReference;

namespace Business.Concrete
{
    //PARAMETRESİNİN PERSON CLASSI OLMASINA DİKKAT!
    //ENCAPSULATİON

    //çıplak class kalmasın
    //çıplak bırakmak inheritance veya implementasyon zaafiyeti demektir
    public class PersonManager : IApplicantServices
    {
        public void ApplyForMask (Person person)
        {
            
        }

        public List<Person> GetList()
        {
            return  null;
        }

        public bool CheckPerson(Person person)
        {
            MernsiServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody
                (person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirtYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
