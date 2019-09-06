// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.3.0

using Microsoft.Bot.Builder.Adapters.Webex;
using Microsoft.Extensions.Configuration;

namespace WebexAdapterBot
{
    public class ConfigurationWebexAdapterOptions : WebexAdapterOptions
    {
        public ConfigurationWebexAdapterOptions(IConfiguration configuration)
             : base(configuration["AccessToken"], configuration["PublicAddress"], configuration["Secret"], configuration["WebhookName"])
        {
        }
    }
}
