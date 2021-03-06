﻿namespace Telnyx
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CallControlForkStartService
    /// </summary>
    public class CallControlForkStartService : Service<CallAnswerResponse>,
        INestedCreatableWithIdInMid<CallAnswerResponse, CallControlForkStartCreateOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallControlForkStartService"/> class.
        /// </summary>
        public CallControlForkStartService()
        : base(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallControlForkStartService"/> class.
        /// /</summary>
        /// <param name="apiKey">api key</param>
        public CallControlForkStartService(string apiKey)
            : base(apiKey)
        {
        }

        /// <inheritdoc/>
        public override string BasePath => "/calls";

        /// <inheritdoc/>
        public virtual CallAnswerResponse Create(string id, CallControlForkStartCreateOptions options, string postFix = "actions/fork_start", RequestOptions requestOptions = null)
        {
            return this.CreateEntity(id, postFix, options, requestOptions);
        }

        /// <inheritdoc/>
        public async Task<CallAnswerResponse> CreateAsync(string parentId, CallControlForkStartCreateOptions createOptions, string postFix = "actions/fork_start", RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await this.CreateEntityAsync(parentId, postFix, createOptions, requestOptions, cancellationToken);
        }
    }
}