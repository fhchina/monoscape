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
using System.ServiceModel;
using Monoscape.CloudController.External.Api.Model;
using Monoscape.CloudController.External.Api.Services.ExternalSystem.Model;

namespace Monoscape.CloudController.External.Api.Services.ExternalSystem
{
    [ServiceContract]
    public interface IExternalSystemService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        AddApplicationResponse AddApplication(AddApplicationRequest request);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        StartApplicationResponse StartApplication(StartApplicationRequest request);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        StopApplicationResponse StopApplication(StopApplicationRequest request);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        ApplicationExistsResponse ApplicationExists(ApplicationExistsRequest request);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        UpdateTenantUpperScaleLimitResponse UpdateTenantUpperScaleLimit(UpdateTenantUpperScaleLimitRequest request);
    }
}
