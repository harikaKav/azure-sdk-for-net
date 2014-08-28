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

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Upgrade Deployment operation.
    /// </summary>
    public partial class DeploymentUpgradeParameters
    {
        private string _configuration;
        
        /// <summary>
        /// Required. The service configuration file for the deployment.
        /// </summary>
        public string Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }
        
        private IDictionary<string, string> _extendedProperties;
        
        /// <summary>
        /// Optional. Represents the name of an extended deployment property.
        /// Each extended property must have a defined name and a value. You
        /// can have a maximum of 25 extended property name/value pairs. The
        /// maximum length of the name element is 64 characters, only
        /// alphanumeric characters and underscores are valid in the name, and
        /// the name must start with a letter. Attempting to use other
        /// characters, starting the name with a non-letter character, or
        /// entering a name that is identical to that of another extended
        /// property owned by the same hosted service will result in a status
        /// code 400 (Bad Request) error.
        /// </summary>
        public IDictionary<string, string> ExtendedProperties
        {
            get
            {
                if (this._extendedProperties == null)
                {
                    this._extendedProperties = new Dictionary<string, string>();
                }
                return this._extendedProperties;
            }
            set { this._extendedProperties = value; }
        }
        
        /// <summary>
        /// Optional. Represents the name of an extended deployment property.
        /// Each extended property must have a defined name and a value. You
        /// can have a maximum of 25 extended property name/value pairs. The
        /// maximum length of the name element is 64 characters, only
        /// alphanumeric characters and underscores are valid in the name, and
        /// the name must start with a letter. Attempting to use other
        /// characters, starting the name with a non-letter character, or
        /// entering a name that is identical to that of another extended
        /// property owned by the same hosted service will result in a status
        /// code 400 (Bad Request) error.
        /// </summary>
        public IDictionary<string, string> ExtendedPropertiesValue
        {
            get { return this._extendedProperties; }
            set { this._extendedProperties = value; }
        }
        
        private ExtensionConfiguration _extensionConfiguration;
        
        /// <summary>
        /// Optional. Represents an extension that is added to the cloud
        /// service. In Azure, a process can run as an extension of a cloud
        /// service. For example, Remote Desktop Access or the Azure
        /// Diagnostics Agent can run as extensions to the cloud service. You
        /// must add an extension to the cloud service by using Add Extension
        /// before it can be added to the deployment.
        /// </summary>
        public ExtensionConfiguration ExtensionConfiguration
        {
            get { return this._extensionConfiguration; }
            set { this._extensionConfiguration = value; }
        }
        
        private bool _force;
        
        /// <summary>
        /// Required. Specifies whether the rollback should proceed even when
        /// it will cause local data to be lost from some role instances.
        /// </summary>
        public bool Force
        {
            get { return this._force; }
            set { this._force = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Required. A name for the hosted service. The name can be up to 100
        /// characters in length. It is recommended that the label be unique
        /// within the subscription. The name can be used identify the hosted
        /// service for your tracking purposes.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private DeploymentUpgradeMode _mode;
        
        /// <summary>
        /// Required. The type of update to initiate. Role instances are
        /// allocated to update domains when the service is deployed. Updates
        /// can be initiated manually in each update domain or initiated
        /// automatically in all update domains. Possible values are Auto or
        /// Manual. If not specified, the default value is Auto. If set to
        /// Manual, WalkUpgradeDomain must be called to apply the update. If
        /// set to Auto, the update is automatically applied to each update
        /// domain in sequence.
        /// </summary>
        public DeploymentUpgradeMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }
        
        private Uri _packageUri;
        
        /// <summary>
        /// Required. A URL that refers to the location of the service package
        /// in the Blob service. The service package can be located either in
        /// a storage account beneath the same subscription or a Shared Access
        /// Signature (SAS) URI from any storage account. For more information
        /// about Shared Access Signatures, see Delegating Access with a
        /// Shared Access Signature (REST API) at
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee395415.aspx.
        /// </summary>
        public Uri PackageUri
        {
            get { return this._packageUri; }
            set { this._packageUri = value; }
        }
        
        private string _roleToUpgrade;
        
        /// <summary>
        /// Optional. The name of the specific role instance to update.
        /// </summary>
        public string RoleToUpgrade
        {
            get { return this._roleToUpgrade; }
            set { this._roleToUpgrade = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentUpgradeParameters class.
        /// </summary>
        public DeploymentUpgradeParameters()
        {
        }
    }
}
