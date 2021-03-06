/*
 *  Copyright 2013 Monoscape
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 *  History: 
 *  2011/11/10 Imesh Gunaratne <imesh@monoscape.org> Created.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Monoscape.Common.Model
{
    /// <summary>
    /// Provides high level properties of an application http request.
    /// </summary>
    [DataContract]
    public class ApplicationHttpRequest
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime Time { get; set; }

        [DataMember]
        public string RawUrl { get; set;  }

        [DataMember]
        public string RequestType { get; set; }

        [DataMember]
        public Uri Url { get; set; }

        [DataMember]
        public string UserAgent { get; set; }

        [DataMember]
        public string UserHostAddress { get; set; }

        [DataMember]
        public string UserHostName { get; set; }

        [DataMember]
        public int NodeId { get; set; }

        [DataMember]
        public int ApplicationId { get; set; }

        [DataMember]
        public int InstanceId { get; set; }

        [DataMember]
        public int TenantId { get; set; }
    }
}
