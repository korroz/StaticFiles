// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Builder;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for adding directory browser services.
    /// </summary>
    public static class DirectoryBrowserServiceExtensions
    {
        /// <summary>
        /// Adds directory browser middleware services.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection" /> to add services to.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static IServiceCollection AddDirectoryBrowser(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddWebEncoders();
        }

        /// <summary>
        /// Adds directory browser middleware services.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection" /> to add services to.</param>
        /// <param name="configureOptions">
        /// An action delegate to configure the provided <see cref="DirectoryBrowserOptions"/>.
        /// </param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static IServiceCollection AddDirectoryBrowser(
            this IServiceCollection services,
            Action<DirectoryBrowserOptions> configureOptions)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (configureOptions == null)
            {
                throw new ArgumentNullException(nameof(configureOptions));
            }

            services.Configure(configureOptions);
            return services.AddDirectoryBrowser();
        }
    }
}