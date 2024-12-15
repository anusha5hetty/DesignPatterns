using Entity = DesignPatterns.SpecificationPattern;

namespace DesignPatterns.SpecificationPattern.Specifications.LoanApplication
{
    internal class AgeSpecification: Specification<Entity.LoanApplication>
    {
      public override bool IsSatisfiedBy(Entity.LoanApplication entity) => entity.Age >= 21 && entity.Age <= 65;
  }
}
