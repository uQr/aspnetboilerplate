using System;

namespace Abp.Domain.Entities.Auditing
{
    /// <summary>
    /// This class can be used to simplify implementing <see cref="ICreationAudited"/>.
    /// </summary>
    /// <typeparam name="TPrimaryKey">Type of the primary key of the entity</typeparam>
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, ICreationAudited
    {
        public virtual DateTime CreationTime { get; set; }

        public virtual long? CreatorUserId { get; set; }

        protected CreationAuditedEntity()
        {
            CreationTime = DateTime.Now; //TODO: UtcNow?
        }
    }
}