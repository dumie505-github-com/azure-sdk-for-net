// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Compute.Models
{
    /// <summary> The sku name. </summary>
    public readonly partial struct SnapshotStorageAccountTypes : IEquatable<SnapshotStorageAccountTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SnapshotStorageAccountTypes"/> values are the same. </summary>
        public SnapshotStorageAccountTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardLRSValue = "Standard_LRS";
        private const string PremiumLRSValue = "Premium_LRS";
        private const string StandardZRSValue = "Standard_ZRS";

        /// <summary> Standard HDD locally redundant storage. </summary>
        public static SnapshotStorageAccountTypes StandardLRS { get; } = new SnapshotStorageAccountTypes(StandardLRSValue);
        /// <summary> Premium SSD locally redundant storage. </summary>
        public static SnapshotStorageAccountTypes PremiumLRS { get; } = new SnapshotStorageAccountTypes(PremiumLRSValue);
        /// <summary> Standard zone redundant storage. </summary>
        public static SnapshotStorageAccountTypes StandardZRS { get; } = new SnapshotStorageAccountTypes(StandardZRSValue);
        /// <summary> Determines if two <see cref="SnapshotStorageAccountTypes"/> values are the same. </summary>
        public static bool operator ==(SnapshotStorageAccountTypes left, SnapshotStorageAccountTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SnapshotStorageAccountTypes"/> values are not the same. </summary>
        public static bool operator !=(SnapshotStorageAccountTypes left, SnapshotStorageAccountTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SnapshotStorageAccountTypes"/>. </summary>
        public static implicit operator SnapshotStorageAccountTypes(string value) => new SnapshotStorageAccountTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SnapshotStorageAccountTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SnapshotStorageAccountTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}