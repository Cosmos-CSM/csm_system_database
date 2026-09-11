using CSM_Database_Testing;
using CSM_System_Database_Core.Entities;

namespace CSM_System_Database_Testing.Utils;


/// <summary>
///     Handles [CSM System Database] objects drafting for testing purposes.
/// </summary>
static public class DraftUtils
{
    /// <summary>
    ///     Drafts a <see cref="EntityState"/> data.
    /// </summary>
    /// <param name="ref">
    ///     Default entity data.
    /// </param>
    /// <returns>
    ///     A drafted <see cref="EntityState"/>.
    /// </returns>
    static public EntityState EntityState(EntityState? @ref = null)
    {
        @ref = BaseDraftUtils.NamedEntity(@ref);
        return @ref;
    }
}
