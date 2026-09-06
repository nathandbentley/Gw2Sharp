using System;

namespace Gw2Sharp.WebApi.V2.Models
{
    /// <summary>
    /// Represents account WvW data.
    /// </summary>
    public class AccountWvw : IApiV2Object
    {
        /// <summary>
        /// The active WvW match team ID.
        /// </summary>
        public int Team { get; set; }

        /// <summary>
        /// The active WvW guild GUID.
        /// </summary>
        public Guid? Guild { get; set; }

        /// <inheritdoc />
        public ApiV2HttpResponseInfo? HttpResponseInfo { get; set; } = default!;
    }
}
