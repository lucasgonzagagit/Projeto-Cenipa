using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.Domain
{
    public class Region
    {
        public string City { get; set; }
        public string Uf { get; set; }
        public string Country { get; set; }

        public Region(string city, string uf, string country)
        {
            City = city;
            Uf = uf;
            Country = country;
        }
    }
}
