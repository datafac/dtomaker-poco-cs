using DTOMaker.SrcGen.Core;
using Microsoft.CodeAnalysis;

namespace DTOMaker.SrcGen.MessagePack
{
    internal sealed class MessagePackEntity : TargetEntity
    {
        public int MemberKeyOffset { get; set; }
        public MessagePackEntity(TargetDomain domain, TypeFullName entityName, Location location)
            : base(domain, entityName, location) { }
    }
}
