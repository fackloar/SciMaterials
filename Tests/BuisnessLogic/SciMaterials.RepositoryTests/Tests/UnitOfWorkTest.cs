﻿using SciMaterials.DAL.Models;
using SciMaterials.RepositoryTests.Fixtures;

namespace SciMaterials.RepositoryTests.Tests;

public class UnitOfWorkTest : IClassFixture<UnitOfWorkFixture>
{
    private readonly UnitOfWorkFixture _fixture;

    public UnitOfWorkTest(UnitOfWorkFixture fixture)
    {
        _fixture = fixture;
    }


    [Fact]
    [Trait("UnitOfWorkTest", "UnderResting")]
    public void ItShould_UnitOfWork_instance_created()
    {
        //arrange
        var sut = _fixture.Create();

        //act

        //assert
        Assert.NotNull(sut);
    }

    [Fact]
    [Trait("UnitOfWorkTest", nameof(Category))]
    public void GetAll_AsNoTracking_ItShould_contains_category_1()
    {
        //arrange
        const int expected = 1;
        var sut = _fixture.Create();

        //act
        var actual = sut.GetRepository<Category>().GetAll().Count;

        //assert
        Assert.Equal(expected, actual);
    }
}