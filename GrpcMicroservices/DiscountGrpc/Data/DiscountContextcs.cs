using DiscountGrpc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountGrpc.Data
{
    public class DiscountContextcs
    {
        public static readonly List<Discount> Discounts = new List<Discount>
        {
            new Discount{DiscountId = 1, Code = "CODE_100", Amount = 100 },
            new Discount{DiscountId = 1, Code = "CODE_200", Amount = 200 },
            new Discount{DiscountId = 1, Code = "CODE_300", Amount = 300 }
        };
    }
}
