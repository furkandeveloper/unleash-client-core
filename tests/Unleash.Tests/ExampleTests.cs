﻿using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Unleash.Internal;

namespace Unleash.Tests
{

    public class ExampleTests : IDisposable
    {
        private readonly IUnleash unleash;

        public ExampleTests()
        {
            unleash = new DefaultUnleash(new MockedUnleashSettings());
        }

        [Test]
        public void UserAEnabled()
        {
            unleash.IsEnabled("one-enabled")
                .Should().BeTrue();
        }

        [Test]
        public void DisabledFeature()
        {
            unleash.IsEnabled("one-disabled")
                .Should().BeFalse();
        }

        public void Dispose()
        {
            unleash?.Dispose();
        }
    }
}