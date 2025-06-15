using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Propartys_Deneme_KırmızıSite
{
    public class UserOpen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Users(string Email,string password)
        {
            string VeritabanıEmail = "berkaktay56@gmail.com";
            string VeritabanıPassword = "berkaktay56";
            bool islem = false;

            if(Email == VeritabanıEmail && password == VeritabanıPassword)
            {
                islem = true;
            }
            return islem;
        }



    }
}
