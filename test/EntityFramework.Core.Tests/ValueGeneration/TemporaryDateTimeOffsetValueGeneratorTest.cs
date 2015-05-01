// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Data.Entity.ValueGeneration;
using Xunit;

namespace Microsoft.Data.Entity.Tests.ValueGeneration
{
    public class TemporaryDateTimeOffsetValueGeneratorTest
    {
        [Fact]
        public void Can_create_values_for_DateTime_types()
        {
            var generator = new TemporaryDateTimeOffsetValueGenerator();

            Assert.Equal(new DateTimeOffset(new DateTime(1)), generator.Next());
            Assert.Equal(new DateTimeOffset(new DateTime(2)), generator.Next());
        }

        [Fact]
        public void Generates_temporary_values()
        {
            Assert.True(new TemporaryDateTimeOffsetValueGenerator().GeneratesTemporaryValues);
        }
    }
}
