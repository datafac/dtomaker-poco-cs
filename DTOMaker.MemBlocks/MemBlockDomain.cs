using DTOMaker.SrcGen.Core;
using Microsoft.CodeAnalysis;

namespace DTOMaker.SrcGen.MemBlocks
{
    internal sealed class MemBlockDomain : TargetDomain
    {
        public MemBlockDomain(string name, Location location) : base(name, location) { }

        // no need yet to override OnGetValidationDiagnostics()
    }
}
