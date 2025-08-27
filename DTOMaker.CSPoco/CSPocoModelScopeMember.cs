using DTOMaker.SrcGen.Core;

namespace DTOMaker.SrcGen.CSPoco
{
    public sealed class CSPocoModelScopeMember : ModelScopeMember
    {
        public CSPocoModelScopeMember(IModelScope parent, IScopeFactory factory, ILanguage language, TargetMember member)
            : base(parent, factory, language, member)
        {
        }
    }
}
