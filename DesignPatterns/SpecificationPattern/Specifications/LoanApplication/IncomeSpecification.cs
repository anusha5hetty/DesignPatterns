using Entity = DesignPatterns.SpecificationPattern;

namespace DesignPatterns.SpecificationPattern.Specifications.LoanApplication
{
  internal class IncomeSpecification : Specification<Entity.LoanApplication>
  {
    public override bool IsSatisfiedBy(Entity.LoanApplication entity) => entity.Income >= 50000;
  }
}