﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace System.Collections.Frozen
{
    internal sealed partial class OrdinalStringFrozenDictionary_LeftJustifiedSingleChar<TValue> : OrdinalStringFrozenDictionary<TValue>
    {
        internal OrdinalStringFrozenDictionary_LeftJustifiedSingleChar(
            string[] keys,
            TValue[] values,
            IEqualityComparer<string> comparer,
            int minimumLength,
            int maximumLengthDiff,
            int hashIndex)
            : base(keys, values, comparer, minimumLength, maximumLengthDiff, hashIndex, 1)
        {
        }

        // See comment in OrdinalStringFrozenDictionary for why these overrides exist. Do not remove.
        private protected override ref readonly TValue GetValueRefOrNullRefCore(string key) => ref base.GetValueRefOrNullRefCore(key);

        private protected override bool Equals(string? x, string? y) => string.Equals(x, y);
        private protected override bool Equals(ReadOnlySpan<char> x, string? y) => x.SequenceEqual(y.AsSpan());
        private protected override int GetHashCode(string s) => s[HashIndex];
        private protected override int GetHashCode(ReadOnlySpan<char> s) => s[HashIndex];
    }
}
