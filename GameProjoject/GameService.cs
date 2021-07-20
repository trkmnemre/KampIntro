using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjoject
{
    class GameService : IGamerService
    {
        IUserValidationService _userValidationService;

        public GameService(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarız. Kayıt Başarısız.");
            }
     
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }
    }
}
