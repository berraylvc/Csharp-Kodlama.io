using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

// bir iş sınıfı başa bir iş sınıfını kullanıreken new'liyorsa ileriye dönük geliştirme talebi geldiğinde bu yazılım direnç gösterir
//onun yerine bir tasarım deseni kullanılır, dependency injection
//ptt manager'ın bagımlı oldugu sınıf yerine o sınıfların interface'i yazılır.
namespace Business.Concrete
{
    public class PttManager: ISupplierService
    {
        private IApplicantServices _applicantServices;
        //bunlar field, classların içinde alt çizgi ile yazılır.

        public PttManager(IApplicantServices applicantServices) //Constructor; pttManager new'lendiğinde ilk bu çalışır.
        {
            _applicantServices = applicantServices;
        }


        
        public void GiveMaks(Person person)
        {
            
            if (_applicantServices.CheckPerson(person)){
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi.");
            }
        }

        public void GiveMask(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
