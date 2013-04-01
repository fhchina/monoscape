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
using System.Diagnostics;
using Monoscape.Common;
using System.Threading;
using Monoscape.Common.Model;
using Monoscape.NodeController.Runtime;
using System.Management;

namespace Monoscape.NodeController
{
    internal static class ControllerUtil
    {
        public static void TerminateWebServer(int processId)
        {
            try
            {
                Process p = Process.GetProcessById(processId);
                if (p != null)
                {
                    Log.Debug(typeof(ControllerUtil), "Terminating web server process: " + processId);
                    //try
                    //{
                    //    foreach (System.Diagnostics.ProcessThread th in p.Threads)
                    //        th.Dispose();
                    //}
                    //catch { }
                    ProcessManager.KillProcessAndChildren(p.Id);
                    //p.WaitForExit(1000 * 30); // With 30sec time out
                }
            }
            catch (Exception)
            {
                Log.Error(typeof(ControllerUtil), "Could not terminate process: " + processId);
            }
        }

        public static bool ApplicationExists(Application application)
        {
            foreach (Application app in Database.Applications)
            {
                if (application.Id == app.Id)
                    return true;
            }
            return false;
        }

        public static Tenant GetDefaultTenant()
        {
            Tenant tenant = new Tenant();
            tenant.Name = "Default";
            tenant.UpperScaleLimit = 1;
            return tenant;
        }
    }
}
