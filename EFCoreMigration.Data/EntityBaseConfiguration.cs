namespace EFCoreMigration.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public partial class EntityBaseConfiguration<T, TPrimaryKey> : IEntityTypeConfiguration<T>
        where T : EntityBase<TPrimaryKey>
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
        }
    }

    public partial class EntityBaseConfiguration<T> : IEntityTypeConfiguration<T>
        where T : EntityBase<int>
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
        }
    }
}
