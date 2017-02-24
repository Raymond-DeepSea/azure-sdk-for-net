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
using Hyak.Common;
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the list credential operation.
    /// </summary>
    public partial class CredentialListResponse : OperationResponseWithSkipToken
    {
        private IList<Credential> _credentials;
        
        /// <summary>
        /// Optional. Gets or sets a list of credentials.
        /// </summary>
        public IList<Credential> Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CredentialListResponse class.
        /// </summary>
        public CredentialListResponse()
        {
            this.Credentials = new LazyList<Credential>();
        }
    }
}