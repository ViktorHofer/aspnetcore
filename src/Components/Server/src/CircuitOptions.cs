// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Components.Server
{
    /// <summary>
    /// Options to configure ASP.NET Core Components.
    /// </summary>
    public class CircuitOptions
    {
        /// <summary>
        /// Gets or sets a value that determines the maximum number of disconnected circuit state details
        /// are retained by the server.
        /// <para>
        /// When a client disconnects, ASP.NET Core Components attempts to retain state on the server for an
        /// interval. This allows the client to re-establish a connection to the existing circuit on the server
        /// without losing any state in the event of transient connection issues.
        /// </para>
        /// <para>
        /// This value determines the maximium number of circuit states retained by the server.
        /// <seealso cref="DisconnectedCircuitRetentionPeriod"/>
        /// </para>
        /// </summary>
        /// <value>
        /// Defaults to <c>100</c>.
        /// </value>
        public int MaxRetainedDisconnectedCircuits { get; set; } = 100;

        /// <summary>
        /// Gets or sets a value that determines the maximum duration state for a disconnected circuit is
        /// retained on the server.
        /// <para>
        /// When a client disconnects, ASP.NET Core Components attempts to retain state on the server for an
        /// interval. This allows the client to re-establish a connection to the existing circuit on the server
        /// without losing any state in the event of transient connection issues.
        /// </para>
        /// <para>
        /// This value determines the maximium duration circuit state is retained by the server before being evicted.
        /// <seealso cref="MaxRetainedDisconnectedCircuits"/>
        /// </para>
        /// </summary>
        /// <value>
        /// Defaults to <c>3 minutes</c>.
        /// </value>
        public TimeSpan DisconnectedCircuitRetentionPeriod { get; set; } = TimeSpan.FromMinutes(3);

        /// <summary>
        /// Gets or sets a value that determines whether or not to send detailed exception messages to JavaScript when an unhandled exception
        /// happens on the circuit or when a .NET method invocation through JS interop results in an exception.
        /// </summary>
        /// <remarks>
        /// This value should only be turned on in development scenarios as turning it on in production might result in the leak of
        /// sensitive information to untrusted parties.
        /// </remarks>
        /// <value>Defaults to <c>false</c>.</value>
        public bool DetailedErrors { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates how long the server will wait before timing out an asynchronous JavaScript function invocation.
        /// </summary>
        /// <value>
        /// Defaults to <c>1 minute</c>.
        /// </value>
        public TimeSpan JSInteropDefaultCallTimeout { get; set; } = TimeSpan.FromMinutes(1);
    }
}