// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> Specifies information about the gallery Application Version that you want to update. </summary>
    public partial class GalleryApplicationVersionUpdate : UpdateResourceDefinition
    {
        /// <summary> Initializes a new instance of GalleryApplicationVersionUpdate. </summary>
        public GalleryApplicationVersionUpdate()
        {
        }

        /// <summary> Initializes a new instance of GalleryApplicationVersionUpdate. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="publishingProfile"> The publishing profile of a gallery Image Version. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="replicationStatus"> This is the replication status of the gallery Image Version. </param>
        internal GalleryApplicationVersionUpdate(string id, string name, string type, IDictionary<string, string> tags, GalleryApplicationVersionPublishingProfile publishingProfile, GalleryApplicationVersionPropertiesProvisioningState? provisioningState, ReplicationStatus replicationStatus) : base(id, name, type, tags)
        {
            PublishingProfile = publishingProfile;
            ProvisioningState = provisioningState;
            ReplicationStatus = replicationStatus;
        }

        /// <summary> The publishing profile of a gallery Image Version. </summary>
        public GalleryApplicationVersionPublishingProfile PublishingProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryApplicationVersionPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> This is the replication status of the gallery Image Version. </summary>
        public ReplicationStatus ReplicationStatus { get; }
    }
}