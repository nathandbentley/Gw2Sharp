using System.Threading;
using System.Threading.Tasks;
using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 account WvW endpoint.
    /// </summary>
    public interface IAccountWvwClient
    {
        /// <summary>
        /// Request the account WvW details asynchronously.
        /// Requires scopes: account, wvw.
        /// </summary>
        /// <returns>The account WvW data.</returns>
        Task<AccountWvw> GetAsync();

        /// <summary>
        /// Request the account WvW details asynchronously with a cancellation token.
        /// Requires scopes: account, wvw.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The account WvW data.</returns>
        Task<AccountWvw> GetAsync(CancellationToken cancellationToken);
    }
}
