using CSM_Database_Testing.Abstractions.Bases;

using CSM_System_Database_Core;

namespace Integration_Tests;

/// <summary>
///     Integration tests class for <see cref="SystemDatabase"/>
/// </summary>
public class SystemDatabaseTests
    : DatabaseIntegrationTestsBase<SystemDatabase> {


    /// <summary>
    ///     Creates a new instance.
    /// </summary>
    public SystemDatabaseTests()
        : base() {
    }
}
