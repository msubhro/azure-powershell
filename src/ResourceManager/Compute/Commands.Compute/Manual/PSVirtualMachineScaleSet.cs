// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System.Collections.Generic;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Commands.Compute.Automation.Models
{
    public partial class PSVirtualMachineScaleSet
    {
        // Gets or sets the FQDN.
        public string FullyQualifiedDomainName { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Location { get; set; }

        public IDictionary<string, string> Tags { get; set; }

        public Sku Sku { get; set; }

        public Plan Plan { get; set; }

        public UpgradePolicy UpgradePolicy { get; set; }

        public VirtualMachineScaleSetVMProfile VirtualMachineProfile { get; set; }

        public string ProvisioningState { get; set; }

        public bool? Overprovision { get; set; }

        public string UniqueId { get; set; }

        public bool? SinglePlacementGroup { get; set; }

        public bool? ZoneBalance { get; set; }

        public int? PlatformFaultDomainCount { get; set; }

        public IList<string> Zones { get; set; }

        public PSVirtualMachineScaleSetIdentity Identity { get; set; }

        public PSVirtualMachineScaleSet() { }
    }
}