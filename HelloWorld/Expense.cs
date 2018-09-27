using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace HelloWorld
{
    [Database]
    public class Expense
    {
        public Person Spender { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
