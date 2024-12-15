// See https://aka.ms/new-console-template for more information
using DesignPatterns.SpecificationPattern;

Console.WriteLine("Hello, World!");

var loanApplication = new LoanApplication
{
  CreditScore = 750,
  Age = 30,
  Income = 60000.00
};

var loanService = new LoanService();
loanService.ApproveLoan(loanApplication);