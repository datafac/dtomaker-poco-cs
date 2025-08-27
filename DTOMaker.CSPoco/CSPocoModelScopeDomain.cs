using DTOMaker.SrcGen.Core;

namespace DTOMaker.SrcGen.CSPoco
{
    public sealed class CSPocoModelScopeDomain : ModelScopeDomain
    {
        public CSPocoModelScopeDomain(IModelScope parent, IScopeFactory factory, ILanguage language, TargetDomain domain)
            : base(parent, factory, language, domain)
        {
        }
    }
}
