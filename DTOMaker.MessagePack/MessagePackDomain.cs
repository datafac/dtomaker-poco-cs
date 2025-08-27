using DTOMaker.SrcGen.Core;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace DTOMaker.SrcGen.MessagePack
{
    internal sealed class MessagePackDomain : TargetDomain
    {
        public MessagePackDomain(string name, Location location) : base(name, location) { }

        protected override IEnumerable<SyntaxDiagnostic> OnGetValidationDiagnostics()
        {
            foreach (var diagnostic1 in base.OnGetValidationDiagnostics())
            {
                yield return diagnostic1;
            }

            //SyntaxDiagnostic? diagnostic2;
            //if ((diagnostic2 = CheckEntityKeys()) is not null) yield return diagnostic2;
        }
    }
}
