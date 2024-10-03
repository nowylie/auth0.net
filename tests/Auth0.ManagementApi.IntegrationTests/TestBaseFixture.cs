﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Auth0.IntegrationTests.Shared;
using Auth0.IntegrationTests.Shared.CleanUp;
using Auth0.ManagementApi.IntegrationTests.Testing;
using Auth0.Tests.Shared;
using Xunit;

namespace Auth0.ManagementApi.IntegrationTests
{
    public class TestBaseFixture : IAsyncLifetime
    {
        public ManagementApiClient ApiClient { get; private set; }

        public Utils Utils { get; private set; }

        protected IDictionary<CleanUpType, IList<string>> identifiers = new Dictionary<CleanUpType, IList<string>>();

        public virtual async Task InitializeAsync()
        {
            string token = await TestBaseUtils.GenerateManagementApiToken();

            ApiClient = new ManagementApiClient(token, TestBaseUtils.GetVariable("AUTH0_MANAGEMENT_API_URL"), new HttpClientManagementConnection(options: new HttpClientManagementConnectionOptions { NumberOfHttpRetries = 9 }));
            
            Utils = new Utils(ApiClient);
        }

        public virtual async Task DisposeAsync()
        {
            await Task.CompletedTask;
        }

        public void TrackIdentifier(CleanUpType type, string identifier)
        {
            if (!identifiers.ContainsKey(type))
            {
                identifiers[type] = new List<string>();
            }

            identifiers[type].Add(identifier);
        }

        public void UnTrackIdentifier(CleanUpType type, string identifier)
        {
            if (!identifiers.ContainsKey(type))
            {
                return;
            }

            identifiers[type].Remove(identifier);
        }
    }
}
