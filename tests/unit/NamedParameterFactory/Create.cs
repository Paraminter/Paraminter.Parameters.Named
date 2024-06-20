﻿namespace Paraminter.Parameters;

using System;

using Xunit;

public sealed class Create
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidName_ReturnsNamedParameter()
    {
        var result = Target(string.Empty);

        Assert.NotNull(result);
    }

    private INamedParameter Target(
        string name)
    {
        return Fixture.Sut.Create(name);
    }
}