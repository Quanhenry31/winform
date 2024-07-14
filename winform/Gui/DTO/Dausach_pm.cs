using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dausach_pm
    {
        public string maDS { get; set; }

        public int Quantity { get; set; }



        public Dausach_pm() { }

        public Dausach_pm(string maDS, int Quantity)
        {
            this.maDS = maDS;
            this.Quantity = Quantity;
        }
    }
}
