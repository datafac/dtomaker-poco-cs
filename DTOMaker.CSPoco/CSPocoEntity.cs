using DTOMaker.SrcGen.Core;
using Microsoft.CodeAnalysis;

namespace DTOMaker.SrcGen.CSPoco
{
    internal sealed class CSPocoEntity : TargetEntity
    {
        public CSPocoEntity(TargetDomain domain, TypeFullName entityName, Location location)
            : base(domain, entityName, location) { }
    }
}
