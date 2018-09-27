using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace HelloWorld
{
    [Database]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<Expense> Expenses => Db.SQL<Expense>(
            $"SELECT e FROM {typeof(Expense)} e WHERE e.{nameof(Expense.Spender)} = ?", this);

        public decimal CurrentBalance => Db.SQL<Expense>(
            $"SELECT e FROM {typeof(Expense)} e WHERE e.{nameof(Expense.Spender)} = ?", this)
            .Sum(e => e.Amount);
    }
}
