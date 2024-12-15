namespace DesignPatterns.SpecificationPattern.Specifications
{
    internal class AndSpecification<Tentity> : Specification<Tentity>
    {
        private readonly ISpecification<Tentity> _left;
        private readonly ISpecification<Tentity> _right;

    public AndSpecification(ISpecification<Tentity> left, ISpecification<Tentity> right)
        {
            _left = left;
            _right = right;
        }

    public override bool IsSatisfiedBy(Tentity entity) => _left.IsSatisfiedBy(entity) && _right.IsSatisfiedBy(entity);

    }
}
