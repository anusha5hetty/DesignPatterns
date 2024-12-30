// See https://aka.ms/new-console-template for more information
using DesignPatterns.SpecificationPattern;
using DesignPatterns.StrategyPattern;

Console.WriteLine("Hello, World!");

// Specification Pattern
var loanApplication = new LoanApplication
{
  CreditScore = 750,
  Age = 30,
  Income = 60000.00
};

var loanService = new LoanService();
loanService.ApproveLoan(loanApplication);

// Strategy Pattern
var mallardDuck = new MallardDuck();
mallardDuck.Quack();
mallardDuck.Fly();
mallardDuck.Swim();

var rubberDuck = new RubberDuck();
rubberDuck.Quack();
rubberDuck.Fly();
rubberDuck.Swim();
