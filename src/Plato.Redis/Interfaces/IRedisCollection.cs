﻿// Plato.Core
// Copyright (c) 2020 ReflectSoftware Inc.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using StackExchange.Redis;

namespace Plato.Redis.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRedisCollection
    {
        IDatabase RedisDb { get; }
        RedisKey RedisKey { get; }
    }
}
