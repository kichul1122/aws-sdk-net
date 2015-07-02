#define AWSSDK_UNITY
//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

#if BCL
using System.Configuration;
#endif

using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon
{
    /// <summary>
    /// Represents configuration for Mobile Analytics.
    /// </summary>
    public static class AWSConfigsMobileAnalytics
    {
        private const string mobileAnalyticsKey = "mobileAnalytics";

        private const int defaultSessionTimeout = 5;
        private const int defaultMaxDBSize = 5242880;
        private const double defaultDBWarningThreashold = 0.9;
        private const int defaultMaxRequestSize = 102400;
        private const bool defaultAllowUseDataNetwork = false;
        private const int defaultBackgroundSubmissionWaitTime = 10;

        static AWSConfigsMobileAnalytics()
        {
            SessionTimeout = defaultSessionTimeout;
            MaxDBSize = defaultMaxDBSize;
            DBWarningThreshold = defaultDBWarningThreashold;
            MaxRequestSize = defaultMaxRequestSize;
            AllowUseDataNetwork = defaultAllowUseDataNetwork;
            BackgroundSubmissionWaitTime = defaultBackgroundSubmissionWaitTime;
        }


        /// <summary>
        /// If the app stays in background for a time greater than the SessionTimeout then Mobile Analytics client stops old session and 
        /// creates a new session once app comes back to foreground.
        /// We recommend using values ranging from 5 to 10, 
        /// </summary>
        /// <value>default 5 seconds</value>
        public static int SessionTimeout { get; set; }

        /// <summary>
        /// Gets the max size of the database used for local storage of events. Event Storage will ignore new 
        /// events if the size of database exceed this size. Value is in Bytes.
        /// We recommend using values ranging from 1MB to 10MB
        /// </summary>
        /// <value>Default 5MB</value>
        public static int MaxDBSize { get; set; }

        /// <summary>
        /// The Warning threshold. The values range between 0 - 1. If the values exceed beyond the threshold then the
        /// Warning logs will be generated.
        /// </summary>
        /// <value>Default 0.9</value>
        public static double DBWarningThreshold { get; set; }

        /// <summary>
        /// The maximum size of the requests that can be submitted in every service call. Value can range between
        /// 1-512KB (expressed in long). Value is in Bytes. Attention: Do not use value larger than 512KB. May cause
        /// service to reject your Http request.
        /// </summary>
        /// <value>Default 100KB</value>
        public static int MaxRequestSize { get; set; }


        /// <summary>
        /// A value indicating whether service call is allowed over data network
        /// Turn on this by caution. This may increase customer's data usage.
        /// </summary>
        /// <value>Default false</value>
        public static bool AllowUseDataNetwork { get; set; }

        /// <summary>
        /// Background thread wait time. Thread will sleep for the interval mention. Value is in Seconds.
        /// </summary>
        /// <value>Default 60 seconds</value>
        public static int BackgroundSubmissionWaitTime { get; set; }
    }

}