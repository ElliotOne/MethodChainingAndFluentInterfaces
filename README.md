# Method Chaining and Fluent Interfaces

This console application demonstrates the concept of method chaining and fluent interfaces in C#. It includes examples using various classes such as `Calculator`, `Car`, `EmailBuilder`, `Person`, `Pizza`, and `PizzaBuilder`.

## Table of Contents

- [Calculator](#calculator)
- [Car](#car)
- [EmailBuilder](#emailbuilder)
- [Person](#person)
- [Pizza](#pizza)
- [PizzaBuilder](#pizzabuilder)
- [StringBuilder](#stringbuilder)

## Calculator

The `Calculator` class showcases method chaining for arithmetic operations.

```csharp
int result = new Calculator()
    .Add(5)
    .Subtract(3)
    .Add(10)
    .GetResult();
```

## Car

The `Car` class is a simple representation of a car with properties like Mileage, Model, and Color.

```csharp
var newCars = car
    .Where(c => c.Mileage <= 200 && c.Model >= 2005)
    .ToList();
```

## EmailBuilder

The `EmailBuilder` class demonstrates method chaining for building and sending emails.

```csharp
new EmailBuilder()
    .SetSender("sender@example.com")
    .SetRecipient("recipient@example.com")
    .SetSubject("Hello, World!")
    .SetBody("This is the body of the email.")
    .Send();
```

## Person

The `Person` class showcases method chaining for setting first and last names.

```csharp
Person person = new Person()
    .SetFirstName("John")
    .SetLastName("Doe");
```

## Pizza

The `Pizza` class represents a pizza with properties like Crust, Sauce, and Toppings.

## PizzaBuilder

The `PizzaBuilder` class demonstrates a fluent interface for building pizzas.

```csharp
Pizza pizza = new PizzaBuilder()
    .WithCrust("Thin Crust")
    .WithSauce("Tomato")
    .WithToppings("Cheese", "Pepperoni", "Mushrooms")
    .Build();
```

## StringBuilder

The provided code also includes examples of method chaining using `StringBuilder` and LINQ queries.

```csharp
string sb = new StringBuilder()
    .Append("Hello")
    .Append(" ")
    .Append("World")
    .Append("!")
    .ToString();
```

Feel free to explore and adapt the examples to understand the power of method chaining and fluent interfaces in your C# projects.
