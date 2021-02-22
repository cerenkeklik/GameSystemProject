using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        //Eğer bir manager sınıf içinde başka bir manager sınıf 
        //kullanacaksan asla onu newleme. Constr oluştur

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)) 
            {
                Console.WriteLine("Gamer added.");
            }
            else 
            {
                Console.WriteLine("User is not valid. Gamer not added.");
            }
            
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated.");
        }
    }
}
