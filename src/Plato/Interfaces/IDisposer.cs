﻿// Plato.Core
// Copyright (c) 2020 ReflectSoftware Inc.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;

namespace Plato.Interfaces
{
    public interface IDisposer<T> : IDisposable where T : class
    {
        bool Disposed { get; }
        T Instance { get; }
    }

    public interface IDisposerFactory
    {
        IDisposer<T> Create<T>(T instance) where T : class;
    }
}
