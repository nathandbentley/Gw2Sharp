using System;
using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.V2.Clients
{
    public class AccountWvwClient : BaseClient<AccountWvw>, IAccountWvwClient
    {
        public AccountWvwClient(IGw2ClientInternal connection) : base(connection)
        {
        }

        protected override string EndpointPath => "account/wvw";
    }
}
