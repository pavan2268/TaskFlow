
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFlow.Domain.Common
{
    public abstract class BaseEntity // Public -  Means accessible from any assemly. Abstract - Cannot be instantiated directly, but can be inherited by other classes.
    {
        public Guid Id { get; protected set; } // Global Unique Identifier (GUID) - A unique identifier for each entity. Protected set - Can only be set within the class or by derived classes, ensuring controlled access to the Id property.
        public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow; // Date and time when the entity was created. Protected set - Can only be set within the class or by derived classes.

        public DateTime? UpdatedAt { get; protected set; } // Date and time when the entity was last updated. Nullable - ? indicates that the property can have a null value, which is useful for entities that have not been updated since creation. 
        public string CreatedBy { get; protected set; } = string.Empty;// Identifier of the user who created the entity. Protected set - Can only be set within the class or by derived classes.
        public bool IsDeleted { get; protected set; } = false; // IsDeleted - Soft delete  instead  of hard deleting the record from the database, we mark it as deleted. This allows us to retain the data for historical or auditing purposes while preventing it from being accessed in normal operations. 

        public void MarkAsUpdated()
        {
            UpdatedAt = DateTime.UtcNow; // Update the UpdatedAt property to the current UTC time when the entity is modified.

        }
        public void SoftDelete()
        {

            IsDeleted = true; // Mark the entity as deleted by setting IsDeleted to true. This allows us to retain the data while preventing it from being accessed in normal operations.
            MarkAsUpdated(); // method composition - one method calling another. this ensures UpdateAt is always set when soft deleting an entity, maintaining accurate tracking of when the entity was modified.}

        }


    }
}
