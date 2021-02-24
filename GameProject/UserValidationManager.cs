using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear== 2001 && gamer.FirstName== "Ahsen" && gamer.LastName=="Kıpçak" && gamer.IdentityNumber==1223333331);
            {
                return true;
            }          
                return false;
            

        }
    }
}
