﻿// Copyright (c) Microsoft. All rights reserved.

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.TypeChat.Tests;

public class MockLanguageModel : ILanguageModel
{
    ModelInfo _model;

    public MockLanguageModel()
    {
        _model = "Mock";
    }

    public ModelInfo ModelInfo => _model;

    public Task<string> CompleteAsync(Prompt prompt, TranslationSettings? settings, CancellationToken cancelToken)
    {
        return Task.FromResult("No comment");
    }
}
