using Entity = DesignPatterns.SpecificationPattern;

namespace DesignPatterns.SpecificationPattern.Specifications.LoanApplication
{
    internal class CreditScoreSpecification : Specification<Entity.LoanApplication>
    {
        public override bool IsSatisfiedBy(Entity.LoanApplication entity)
        {
            return entity.CreditScore >= 700;
        }
    }
}
