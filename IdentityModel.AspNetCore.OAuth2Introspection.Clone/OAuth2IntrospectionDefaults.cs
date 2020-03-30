﻿// Copyright (c) Dominick Baier & Brock Allen. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace IdentityModel.AspNetCore.OAuth2Introspection
{
    /// <summary>
    /// Defaults for OAuth 2.0 introspection authentication
    /// </summary>
    public class OAuth2IntrospectionDefaults
    {
        /// <summary>
        /// The default authentication scheme.
        /// </summary>
        public const string AuthenticationScheme = "Bearer";

        /// <summary>
        /// The name of the HttpClient that will be resolved from the HttpClientFactory
        /// </summary>
        public const string BackChannelHttpClientName = "IdentityModel.AspNetCore.OAuth2Introspection.BackChannelHttpClientName";
    }
}