namespace DesignPatterns.SpecificationPattern.Specifications
{
    public abstract class Specification<Tentity> : ISpecification<Tentity>
    {
        public ISpecification<Tentity> And(ISpecification<Tentity> entity)
        {
            return new AndSpecification<Tentity>(this, entity);
        }
        public ISpecification<Tentity> Or(ISpecification<Tentity> entity)
        {
            return new OrSpecification<Tentity>(this, entity);
        }

        public abstract bool IsSatisfiedBy(Tentity entity);
    }
}
