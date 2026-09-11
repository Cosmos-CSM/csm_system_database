using CSM_Database_Testing.Managers;
using CSM_System_Database_Core.Entities;
using CSM_System_Database_Testing.Utils;

namespace CSM_System_Database_Testing.Managers;

/// <summary>
///     Represents a test data storing handler for <see cref="CSM_System_Database_Core.SystemDatabase"/> entities.
/// </summary>
public class StoreManager {

    readonly TestingStoreManager _storeManager;

    /// <summary>
    ///     Creates a new instance
    /// </summary>
    /// <param name="storeManager">
    ///     Testing data store manager.
    /// </param>
    public StoreManager(TestingStoreManager storeManager) {
        _storeManager = storeManager;
    }

    /// <summary>
    /// Create and store a new <see cref="EntityState"/> entity in the database.
    /// </summary>
    /// <param name="ref"></param>
    /// <returns></returns>
    public async Task<EntityState> StoreEntityState(EntityState? @ref = null) {
        EntityState entityState = DraftUtils.EntityState(@ref);
        return await _storeManager.Store(entityState);
    }
}
