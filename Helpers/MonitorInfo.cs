﻿#region Copyright
//=======================================================================================
// Microsoft Azure Customer Advisory Team 
//
// This sample is supplemental to the technical guidance published on my personal
// blog at http://blogs.msdn.com/b/paolos/. 
// 
// Author: Paolo Salvatori
//=======================================================================================
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// LICENSED UNDER THE APACHE LICENSE, VERSION 2.0 (THE "LICENSE"); YOU MAY NOT USE THESE 
// FILES EXCEPT IN COMPLIANCE WITH THE LICENSE. YOU MAY OBTAIN A COPY OF THE LICENSE AT 
// http://www.apache.org/licenses/LICENSE-2.0
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE DISTRIBUTED UNDER THE 
// LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY 
// KIND, EITHER EXPRESS OR IMPLIED. SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING 
// PERMISSIONS AND LIMITATIONS UNDER THE LICENSE.
//=======================================================================================
#endregion

#region Using Directives
using System.ComponentModel;
#endregion

namespace Microsoft.WindowsAzure.CAT.ServiceBusExplorer
{
    public class MonitorInfo
    {
        #region Static Constructor
        static MonitorInfo()
        {
            MonitorInfos = new BindingList<MonitorInfo> 
            {
                new MonitorInfo {DisplayName = "Active Message Count", Name="ActiveMessageCount", Unit="Messages"},
                new MonitorInfo {DisplayName = "Deadletter Message Count", Name="DeadletterMessageCount", Unit="Messages"},
                new MonitorInfo {DisplayName = "Size in KB", Name="SizeInKB", Unit = "KB"}
            };
            MonitorInfos.AllowEdit = true;
            MonitorInfos.AllowNew = true;
            MonitorInfos.AllowRemove = true;
        }          
        #endregion

        #region Public Instance Properties
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        #endregion

        #region Public Static Properties
        public static BindingList<MonitorInfo> MonitorInfos { get; private set; }
        #endregion
    }
}
