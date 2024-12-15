using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.SpecificationPattern.Specifications;
using DesignPatterns.SpecificationPattern.Specifications.LoanApplication;


namespace DesignPatterns.SpecificationPattern
{
  internal class LoanService
  {
    public bool ApproveLoan(LoanApplication application)
    {
      var creditScoreSpec = new CreditScoreSpecification();
      var ageSpec = new AgeSpecification();
      var incomeSpec = new IncomeSpecification();

      var loanApprovalSpec = creditScoreSpec.And(ageSpec).And(incomeSpec);
      return loanApprovalSpec.IsSatisfiedBy(application);
    }
  }
}
