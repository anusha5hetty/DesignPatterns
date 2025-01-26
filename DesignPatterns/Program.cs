// See https://aka.ms/new-console-template for more information
using DesignPatterns.FactoryPattern;
using DesignPatterns.FactoryPattern.Pizzas;
using DesignPatterns.SingletonPattern;
using DesignPatterns.SpecificationPattern;
using DesignPatterns.StrategyPattern;

Console.WriteLine("Hello, World!");

// Specification Pattern
//var loanApplication = new LoanApplication
//{
//  CreditScore = 750,
//  Age = 30,
//  Income = 60000.00
//};

//var loanService = new LoanService();
//loanService.ApproveLoan(loanApplication);

//// Strategy Pattern
//var mallardDuck = new MallardDuck();
//mallardDuck.Quack();
//mallardDuck.Fly();
//mallardDuck.Swim();

//var rubberDuck = new RubberDuck();
//rubberDuck.Quack();
//rubberDuck.Fly();
//rubberDuck.Swim();

// Singleton Pattern
//var x = LoggerDetails.LazyAutoLockInstance;
//Console.WriteLine("First Name with LazyAutoLockInstance: " + x.Name);

//x = LoggerDetails.Lazy1Instance;
//Console.WriteLine("First Name with Lazy1Instance: " + x.Name);

//x = LoggerDetails.Instance;
//Console.WriteLine("First Name with Instance: " + x.Name);

//x = LoggerDetails.ThreadSafeInstance;
//Console.WriteLine("First Name with ThreadSafeInstance: " + x.Name);

// Factory Pattern
var ny = new NyPizzaStore();
ny.OrderPizza("Cheeze");

var chicago = new ChicagioPizzaStore();
chicago.OrderPizza("Pepperoni");
