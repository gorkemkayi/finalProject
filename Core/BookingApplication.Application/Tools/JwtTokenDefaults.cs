using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Tools
{
    public class JwtTokenDefaults
    {
        public const string ValidAudience = "https://localhost";
        //public const string ValidAudience = "https://www.finalproject.com.tr";
        public const string ValidIssuer = "https://localhost";
        //public const string ValidIssuer = "https://www.finalproject.com.tr";
        public const string Key = "bookingapplication+*application!!!heleee";
        public const int Expire = 3;
    }
}
