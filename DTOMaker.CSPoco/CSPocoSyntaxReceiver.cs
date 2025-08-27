using DTOMaker.SrcGen.Core;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace DTOMaker.SrcGen.CSPoco
{
    internal class CSPocoSyntaxReceiver : SyntaxReceiverBase
    {
        protected override void OnProcessEntityAttributes(TargetEntity entity, Location location, ImmutableArray<AttributeData> entityAttributes) { }
        protected override void OnProcessMemberAttributes(TargetMember member, Location location, ImmutableArray<AttributeData> memberAttributes) { }
        public CSPocoSyntaxReceiver() : base(new CSPocoFactory()) { }
    }
}
