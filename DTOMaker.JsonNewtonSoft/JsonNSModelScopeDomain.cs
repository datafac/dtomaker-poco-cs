using DTOMaker.SrcGen.Core;

namespace DTOMaker.SrcGen.JsonNewtonSoft
{
    public sealed class JsonNSModelScopeDomain : ModelScopeDomain
    {
        public JsonNSModelScopeDomain(IModelScope parent, IScopeFactory factory, ILanguage language, TargetDomain domain)
            : base(parent, factory, language, domain)
        {
        }
    }
}
