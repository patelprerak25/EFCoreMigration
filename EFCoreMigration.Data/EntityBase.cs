namespace EFCoreMigration.Data
{
    using System.Collections.Generic;

    public abstract class EntityBase : EntityBase<long>
    {
        protected EntityBase()
        {
        }

        protected EntityBase(long id)
            : base(id)
        {
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "Common type and generic type")]
    public abstract class EntityBase<TPrimaryKey>
    {
        protected EntityBase()
        {
        }

        protected EntityBase(TPrimaryKey id)
        {
            Id = id;
        }

        public virtual TPrimaryKey Id { get; protected set; }
    }
}
