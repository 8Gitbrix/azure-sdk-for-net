// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Details of CRR Job to be fetched. </summary>
    public partial class CrossRegionRestoreJobContent
    {
        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreJobContent"/>. </summary>
        /// <param name="sourceRegion"></param>
        /// <param name="sourceBackupVaultId"></param>
        /// <param name="jobId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceBackupVaultId"/> is null. </exception>
        public CrossRegionRestoreJobContent(AzureLocation sourceRegion, ResourceIdentifier sourceBackupVaultId, Guid jobId)
        {
            Argument.AssertNotNull(sourceBackupVaultId, nameof(sourceBackupVaultId));

            SourceRegion = sourceRegion;
            SourceBackupVaultId = sourceBackupVaultId;
            JobId = jobId;
        }

        /// <summary> Gets the source region. </summary>
        public AzureLocation SourceRegion { get; }
        /// <summary> Gets the source backup vault id. </summary>
        public ResourceIdentifier SourceBackupVaultId { get; }
        /// <summary> Gets the job id. </summary>
        public Guid JobId { get; }
    }
}
