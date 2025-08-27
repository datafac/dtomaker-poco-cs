using DTOMaker.SrcGen.Core;
using Microsoft.CodeAnalysis;

namespace DTOMaker.SrcGen.JsonNewtonSoft
{
    internal sealed class JsonNSEntity : TargetEntity
    {
        public JsonNSEntity(TargetDomain domain, TypeFullName entityName, Location location)
            : base(domain, entityName, location) { }
    }
}
