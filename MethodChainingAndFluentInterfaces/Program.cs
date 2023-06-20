using MethodChainingAndFluentInterfaces;
using System.Text;

//====================== StringBuilder ======================
string sb = new StringBuilder()
    .Append("Hello")
    .Append(" ")
    .Append("World")
    .Append("!")
    .ToString();

Console.WriteLine(sb);



//====================== LINQ Queries ======================
var car = new List<Car>()
{
    new()
    {
        Mileage = 100, Model = 2000, Color = "Red"
    },
    new()
    {
        Mileage = 200, Model = 2010, Color = "Black"
    },
    new()
    {
        Mileage = 300, Model = 2008, Color = "Blue"
    },
    new()
    {
        Mileage = 300, Model = 2009, Color = "Gray"
    }
};

var newsCars = car
    //.Where(c=>c is { Mileage: <= 200, Model: >= 2005 })
    .Where(c=>c.Mileage <= 200 && c.Model >= 2005)
    .ToList();



//====================== Person Class ======================
//1) Method chaining
Person person = new Person()
    .SetFirstName("John")
    .SetLastName("Doe");

//2) Without Method Chaining:
Person person2 = new Person();
person2.SetFirstName("John");
person2.SetLastName("Doe");



//====================== Calculator Class ======================
//1) Method chaining
int calculatorResult = new Calculator()
    .Add(5)
    .Subtract(3)
    .Add(10)
    .GetResult();

//2) Without Method Chaining:
Calculator calculator = new Calculator();
calculator.Add(5);
calculator.Subtract(3);
calculator.Add(10);
int result = calculator.GetResult();



//====================== EmailBuilder Class ======================
//1) Method chaining
new EmailBuilder()
    .SetSender("sender@example.com")
    .SetRecipient("recipient@example.com")
    .SetSubject("Hello, World!")
    .SetBody("This is the body of the email.")
    .Send();

//2) Without Method Chaining:
EmailBuilder email = new EmailBuilder();
email.SetSender("sender@example.com");
email.SetRecipient("recipient@example.com");
email.SetSubject("Hello, World!");
email.SetBody("This is the body of the email.");
email.Send();



//====================== PizzaBuilder Class ======================
//Use Fluent Interface design
Pizza pizza = new PizzaBuilder()
    .WithCrust("Thin Crust")
    .WithSauce("Tomato")
    .WithToppings("Cheese", "Pepperoni", "Mushrooms")
    .Build();
