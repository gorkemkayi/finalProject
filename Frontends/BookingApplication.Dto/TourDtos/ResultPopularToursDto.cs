using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Dto.TourDtos
{
    public class ResultPopularToursDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public int Stars { get; set; }
        public int Rating { get; set; }
        public int TourAdultPrice { get; set; }
        public int TourChildPrice { get; set; }
        public string Description { get; set; }
        public string Policy { get; set; }
        public string Location { get; set; }
        public int TourTypeId { get; set; }
        public string TourTypeName { get; set; }
        public string Image { get; set; }
    }
}
