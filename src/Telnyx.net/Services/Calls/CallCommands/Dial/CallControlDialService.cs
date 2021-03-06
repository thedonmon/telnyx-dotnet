﻿namespace Telnyx
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Call control dial service
    /// </summary>
    public class CallControlDialService : Service<CallDialResponse>,
        ICreatable<CallDialResponse, CallControlDialCreateOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallControlDialService"/> class.
        /// </summary>
        public CallControlDialService()
        : base(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallControlDialService"/> class.
        /// </summary>
        /// <param name="apiKey">api key</param>
        public CallControlDialService(string apiKey)
            : base(apiKey)
        {
        }

        /// <inheritdoc/>
        public override string BasePath => "/calls";

        /// <inheritdoc/>
        public virtual CallDialResponse Create(CallControlDialCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        /// <inheritdoc/>
        public async Task<CallDialResponse> CreateAsync(CallControlDialCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await this.CreateEntityAsync(createOptions, requestOptions, cancellationToken);
        }
    }
}