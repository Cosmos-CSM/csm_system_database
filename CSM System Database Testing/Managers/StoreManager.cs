using CSM_Database_Testing.Managers;
using CSM_System_Database_Core.Entities;
using CSM_System_Database_Testing.Utils;

namespace CSM_System_Database_Testing.Managers;

/// <summary>
///     Represents a test data storing handler for <see cref="CSM_Security_Database_Core.SecurityDatabase"/> entities.
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

    public async Task<EntityState> StoreEntityState(EntityState? @ref = null) {
        EntityState entityState = DraftUtils.EntityState(@ref);
        return await _storeManager.Store(entityState);
    }
}
