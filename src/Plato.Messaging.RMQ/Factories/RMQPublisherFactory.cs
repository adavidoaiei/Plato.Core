﻿// Plato.Core
// Copyright (c) 2020 ReflectSoftware Inc.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using Plato.Messaging.RMQ.Interfaces;
using Plato.Messaging.RMQ.Settings;

namespace Plato.Messaging.RMQ.Factories
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Plato.Messaging.RMQ.Interfaces.IRMQPublisherFactory" />
    public class RMQPublisherFactory : IRMQPublisherFactory
    {
        private readonly IRMQConnectionFactory _connectionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="RMQProducerFactory"/> class.
        /// </summary>
        /// <param name="connectionFactory">The connection factory.</param>
        public RMQPublisherFactory(IRMQConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        /// <summary>
        /// Creates the byte.
        /// </summary>
        /// <param name="connectionSettings">The connection settings.</param>
        /// <param name="exchangeSettings">The exchange settings.</param>
        /// <returns></returns>
        public IRMQPublisherBytes CreateBytes(
            RMQConnectionSettings connectionSettings,
            RMQExchangeSettings exchangeSettings)
        {
            return new RMQPublisherByte(_connectionFactory, connectionSettings, exchangeSettings);
        }

        /// <summary>
        /// Creates the text.
        /// </summary>
        /// <param name="connectionSettings">The connection settings.</param>
        /// <param name="exchangeSettings">The exchange settings.</param>
        /// <returns></returns>
        public IRMQPublisherText CreateText(
            RMQConnectionSettings connectionSettings,
            RMQExchangeSettings exchangeSettings)
        {
            return new RMQPublisherText(_connectionFactory, connectionSettings, exchangeSettings);
        }
    }
}
