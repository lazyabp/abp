﻿using Microsoft.Extensions.DependencyInjection;

namespace Volo.Abp.Modularity
{
    public interface IPostConfigureServices
    {
        void PostConfigureServices(IServiceCollection services);
    }
}