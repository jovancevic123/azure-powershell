// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>
    /// Thumbprints are used by the service to validate the device permission when authentication is done using self signed certificate.
    /// </summary>
    public partial class ClientCertificateThumbprint :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateThumbprint,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateThumbprintInternal
    {

        /// <summary>Backing field for <see cref="Primary" /> property.</summary>
        private string _primary;

        /// <summary>The primary thumbprint used for validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string Primary { get => this._primary; set => this._primary = value; }

        /// <summary>Backing field for <see cref="Secondary" /> property.</summary>
        private string _secondary;

        /// <summary>The secondary thumbprint used for validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string Secondary { get => this._secondary; set => this._secondary = value; }

        /// <summary>Creates an new <see cref="ClientCertificateThumbprint" /> instance.</summary>
        public ClientCertificateThumbprint()
        {

        }
    }
    /// Thumbprints are used by the service to validate the device permission when authentication is done using self signed certificate.
    public partial interface IClientCertificateThumbprint :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>The primary thumbprint used for validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The primary thumbprint used for validation.",
        SerializedName = @"primary",
        PossibleTypes = new [] { typeof(string) })]
        string Primary { get; set; }
        /// <summary>The secondary thumbprint used for validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The secondary thumbprint used for validation.",
        SerializedName = @"secondary",
        PossibleTypes = new [] { typeof(string) })]
        string Secondary { get; set; }

    }
    /// Thumbprints are used by the service to validate the device permission when authentication is done using self signed certificate.
    internal partial interface IClientCertificateThumbprintInternal

    {
        /// <summary>The primary thumbprint used for validation.</summary>
        string Primary { get; set; }
        /// <summary>The secondary thumbprint used for validation.</summary>
        string Secondary { get; set; }

    }
}