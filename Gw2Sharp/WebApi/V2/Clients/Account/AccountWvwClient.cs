using System;
using System.Threading;
using System.Threading.Tasks;
using Gw2Sharp.WebApi;
using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.V2.Clients
{
    /// <summary>
    /// A client of the Guild Wars 2 API v2 account WvW endpoint.
    /// </summary>
    [EndpointPath("account/wvw")]
    public class AccountWvwClient : BaseEndpointBlobClient<AccountWvw>, IAccountWvwClient
    {
        /// <summary>
        /// Creates a new <see cref="AccountWvwClient"/> that is used for the API v2 account WvW endpoint.
        /// </summary>
        /// <param name="connection">The connection used to make requests, see <see cref="IConnection"/>.</param>
        /// <param name="gw2Client">The Guild Wars 2 client.</param>
        /// <exception cref="ArgumentNullException"><paramref name="connection"/> or <paramref name="gw2Client"/> is <see langword="null"/>.</exception>
        protected internal AccountWvwClient(IConnection connection, IGw2Client gw2Client) :
            base(connection, gw2Client)
        {
        }

        /// <inheritdoc />
        public  Task<AccountWvw> GetAsync() =>
            base.GetAsync();

        /// <inheritdoc />
        public override  Task<AccountWvw> GetAsync(CancellationToken cancellationToken) =>
            base.GetAsync(cancellationToken);
    }
}
