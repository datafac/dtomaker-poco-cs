using DTOMaker.SrcGen.Core;

namespace DTOMaker.SrcGen.CSPoco
{
    public sealed class CSPocoModelScopeEntity : ModelScopeEntity
    {
        public CSPocoModelScopeEntity(IModelScope parent, IScopeFactory factory, ILanguage language, TargetEntity entity)
            : base(parent, factory, language, entity)
        {
        }
    }
}
