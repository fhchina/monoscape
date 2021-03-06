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
using Monoscape.ApplicationGridController.Iaas.EC2;
using Monoscape.ApplicationGridController.Model;
using Monoscape.Common.Model;
using Monoscape.ApplicationGridController.Runtime;

namespace Monoscape.ApplicationGridController.Iaas
{
    public class MonoscapeIaasClientFactory
    {
        public static IMonoscapeIaasClient GetInstance(Object arguments)
        {
            if (Settings.IaasClientType == IaasClientType.EC2)
                return new MonoscapeEC2Client((MonoscapeIaasConfig)arguments);
            else
                return null;
        }
    }
}
