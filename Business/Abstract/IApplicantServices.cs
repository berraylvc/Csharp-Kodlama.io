using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantServices
    {
        //publicleri sildik interace'de default public
        //süslü parantezler noktalı virgüle çevrildi
        //buna methodun imzası deniyor.

        //Interface'ler belli method imzalarını barındırırlar.
        //Birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlarlar.


        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}
