using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjoject
{
    class UserValidation : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1985 && gamer.FirstName=="Emre"&& gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
