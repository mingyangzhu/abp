﻿using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.Settings
{
    public class NullSettingStore : ISettingStore, ISingletonDependency
    {
        public ILogger<NullSettingStore> Logger { get; set; }

        public NullSettingStore()
        {
            Logger = NullLogger<NullSettingStore>.Instance;
        }

        public Task<string> GetOrNullAsync(string name, string providerName, string providerKey)
        {
            return Task.FromResult((string) null);
        }
    }
}