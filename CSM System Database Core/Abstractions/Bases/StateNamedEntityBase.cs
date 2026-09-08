using CSM_Database_Core.Entities.Abstractions.Bases;
using CSM_System_Database_Core.Abstractions.Interfaces;

namespace CSM_System_Database_Core.Abstractions.Bases
{
    /// <summary>
    /// Represents a state entity base class that extends NamedEntityBase and adds a State property.
    /// </summary>
    public abstract class StateSystemNamedEntityBase
     : NamedEntityBase, IStateReference
    {
        /// <inheritdoc/>
        public long State { get; set; }
    }

}
