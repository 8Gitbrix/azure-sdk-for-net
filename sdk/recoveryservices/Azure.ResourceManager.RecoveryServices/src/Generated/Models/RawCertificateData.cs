// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Raw certificate data. </summary>
    public partial class RawCertificateData
    {
        /// <summary> Initializes a new instance of <see cref="RawCertificateData"/>. </summary>
        public RawCertificateData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RawCertificateData"/>. </summary>
        /// <param name="authType"> Specifies the authentication type. </param>
        /// <param name="certificate"> The base64 encoded certificate raw data string. </param>
        internal RawCertificateData(RecoveryServicesAuthType? authType, byte[] certificate)
        {
            AuthType = authType;
            Certificate = certificate;
        }

        /// <summary> Specifies the authentication type. </summary>
        public RecoveryServicesAuthType? AuthType { get; set; }
        /// <summary> The base64 encoded certificate raw data string. </summary>
        public byte[] Certificate { get; set; }
    }
}
