﻿// <copyright file="CallControlGatherUsingAudioServiceTest.cs" company="Telnyx">
// Copyright (c) Telnyx. All rights reserved.
// </copyright>

namespace TelnyxTests.Services.Calls.CallCommands
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Telnyx;
    using Xunit;

    public class CallControlGatherUsingAudioServiceTest : BaseTelnyxTest
    {
        private const string CallControllId = "call_123";

        private readonly CallControlGatherUsingAudioService service;
        private readonly CallControlGatherUsingAudioCreateOptions createOptions;

        public CallControlGatherUsingAudioServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new CallControlGatherUsingAudioService();

            this.createOptions = new CallControlGatherUsingAudioCreateOptions()
            {
                ClientState = "aGF2ZSBhIG5pY2UgZGF5ID1d",
                CommandId = new System.Guid("891510ac-f3e4-11e8-af5b-de00688a4901"),
                InterDigitTimeoutMillis = 5000,
                TimeoutMillis = 60000,
                ValidDigits = "123",
                TerminatingDigit = "#",
                MaximumDigits = 10,
                MinimumDigits = 1,
                MaximumTries = 3,
                InvalidAudioUrl = "asdfasdf",
                AudioUrl = "afadsfasdf"
            };
        }

        [Fact]
        public void Create()
        {
            var message = this.service.Create(CallControllId, this.createOptions);
            //this.AssertRequest(HttpMethod.Post, $"/v2/calls/{CallControllId}/actions/gather_using_audio");
            Assert.NotNull(message);
            Assert.Equal("Telnyx.CallAnswerResponse", message.GetType().ToString());
        }

        [Fact]
        public async Task CreateAsync()
        {
            var message = await this.service.CreateAsync(CallControllId, this.createOptions);
            //this.AssertRequest(HttpMethod.Post, $"/v2/calls/{CallControllId}/actions/gather_using_audio");
            Assert.NotNull(message);
            Assert.Equal("Telnyx.CallAnswerResponse", message.GetType().ToString());
        }
    }
}
