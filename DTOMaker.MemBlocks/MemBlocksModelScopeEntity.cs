using DTOMaker.SrcGen.Core;
using System;

namespace DTOMaker.SrcGen.MemBlocks
{
    internal sealed class MemBlocksModelScopeEntity : ModelScopeEntity
    {
        public MemBlocksModelScopeEntity(IModelScope parent, IScopeFactory factory, ILanguage language, TargetEntity baseEntity)
            : base(parent, factory, language, baseEntity)
        {
            MemBlockEntity entity = baseEntity as MemBlockEntity
                ?? throw new ArgumentException("Expected baseEntity to be a MemBlocksEntity", nameof(baseEntity));

            _tokens["EntityId"] = entity.EntityId;
            _tokens["BlockLength"] = entity.BlockLength;
            _tokens["BlockStructureCode"] = entity.BlockStructureCode; // todo format as hex eg. 0x0041L
        }
    }
}
