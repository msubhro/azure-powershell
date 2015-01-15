﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Compute
{
    using System.Management.Automation;
    using Azure.Management.Storage;
    using Azure.Management.Storage.Models;

    [Cmdlet(VerbsCommon.Get, StorageAccountNounStr), OutputType(typeof(StorageAccount))]
    public class GetAzureStorageAccountCommand : StorageAccountBaseCmdlet
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Storage Account Name.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Position = 1,
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Storage Account Name.")]
        [Alias(StorageAccountNameAlias, AccountNameAlias)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            if (string.IsNullOrEmpty(this.Name))
            {
                var storageAccounts = this.StorageAccountService.ListStorageAccounts(
                    base.SubscriptionId,
                    this.ResourceGroupName,
                    base.ApiVersion,
                    base.AuthorizationToken);

                WriteObject(storageAccounts.Value, true);
            }
            else
            {
                var storageAccount = this.StorageAccountService.GetStorageAccount(
                    base.SubscriptionId,
                    this.ResourceGroupName,
                    this.Name,
                    base.ApiVersion,
                    base.AuthorizationToken);

                WriteObject(storageAccount);
            }
        }
    }
}
