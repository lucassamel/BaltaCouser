using BaltaCourse.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaCourse.SubscriptionContext
{
    public class Plan: Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

    }
}
