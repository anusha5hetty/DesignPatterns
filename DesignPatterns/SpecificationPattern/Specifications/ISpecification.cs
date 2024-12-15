using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SpecificationPattern.Specifications
{
    public interface ISpecification<Tentity>
    {
        bool IsSatisfiedBy(Tentity entity);
        ISpecification<Tentity> And(ISpecification<Tentity> other);
        ISpecification<Tentity> Or(ISpecification<Tentity> other);
    }
}
