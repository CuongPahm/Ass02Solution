using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02Solution.Business_Layer
{
    public class Order
    {
        public int OrderId { get; set; }

        public int MemberId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDare { get; set; }

        public DateTime ShippedDate { get; set; }

        public decimal Freight { get; set; }
    }
}
