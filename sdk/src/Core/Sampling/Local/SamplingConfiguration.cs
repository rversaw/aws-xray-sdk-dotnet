﻿//-----------------------------------------------------------------------------
// <copyright file="SamplingConfiguration.cs" company="Amazon.com">
//      Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//
//      Licensed under the Apache License, Version 2.0 (the "License").
//      You may not use this file except in compliance with the License.
//      A copy of the License is located at
//
//      http://aws.amazon.com/apache2.0
//
//      or in the "license" file accompanying this file. This file is distributed
//      on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
//      express or implied. See the License for the specific language governing
//      permissions and limitations under the License.
// </copyright>
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace Amazon.XRay.Recorder.Core.Sampling.Local
{
    /// <summary>
    /// Manifest of the sampling Rules in config file
    /// </summary>
    public class SamplingConfiguration
    {
        /// <summary>
        /// Gets or sets the version of sampling configuration.
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Gets or sets the default sampling rule.
        /// </summary>
        public SamplingRule Default { get; set; }

        /// <summary>
        /// Gets or sets the sampling Rules
        /// </summary>
        public List<SamplingRule> Rules { get; set; }
    }
}
