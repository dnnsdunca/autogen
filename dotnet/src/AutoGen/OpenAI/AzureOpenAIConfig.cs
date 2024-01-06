﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// AzureOpenAIConfig.cs

using Microsoft.SemanticKernel.ChatCompletion;

namespace AutoGen
{
    public class AzureOpenAIConfig : ILLMConfig
    {
        public AzureOpenAIConfig(string endpoint, string deploymentName, string apiKey, string? modelId = null)
        {
            this.Endpoint = endpoint;
            this.DeploymentName = deploymentName;
            this.ApiKey = apiKey;
            this.ModelId = modelId;
        }

        public string Endpoint { get; }

        public string DeploymentName { get; }

        public string ApiKey { get; }

        public string? ModelId { get; }

        public IChatCompletionService CreateChatCompletion()
        {
            throw new System.NotImplementedException();
        }
    }
}