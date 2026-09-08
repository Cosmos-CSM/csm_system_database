using CSM_Database_Core;
using CSM_System_Database_Core.Abstractions.Interfaces;

namespace CSM_System_Database_Core.Abstractions.Bases
{
    /// <summary>
    /// Represents a state entity base class that extends EntityBase and adds a State property.
    /// </summary>
    public abstract class StateEntityBase
     : EntityBase, IStateReference
    {
        /// <inheritdoc/>
        public long State { get; set; }
    }

}
