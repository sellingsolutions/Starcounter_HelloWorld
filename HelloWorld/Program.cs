using System;
using Starcounter;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Db.Transact(() =>
            {
                var person = Db.SQL<Person>($"SELECT p FROM {nameof(Person)} p").FirstOrDefault();
                if (person == null)
                {
                    var spender = new Person
                    {
                        FirstName = "John",
                        LastName = "Doe"
                    };
                    new Expense
                    {
                        Description = "Bananas",
                        Amount = 100,
                        Spender = spender
                    };
                }
            });
            
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/HelloWorld", () =>
            {
                Session.Ensure();
                return Db.Scope(() =>
                {
                    Session.Ensure();
                    var person = Db.SQL<Person>($"SELECT p FROM {nameof(Person)} p")
                        .FirstOrDefault();
                    return new PersonJson { Data = person };
                });
            });
        }
    }
}