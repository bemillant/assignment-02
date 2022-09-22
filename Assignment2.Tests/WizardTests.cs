namespace Assignment2.Tests;

public class WizardTests
{
    [Fact]
    public void WizardCollection_contains_2_wizards()
    {
        var wizards = WizardCollection.Create();

        Assert.Equal(10, wizards.Count());
    }

    [Theory]
    [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
    [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
    public void Spot_check_wizards(string name, string medium, int year, string creator)
    {
        var wizards = WizardCollection.Create();

        Assert.Contains(wizards, w => w == new Wizard(name, medium, year, creator));
    }

    [Fact]
    public void AlbD_Vol_HarryP_is_the_only_wizards_from_Rowling_SQL()
    {
        // Given
        var wizards = WizardCollection.Create();
        var listOfRowlingNames = new string[] { "Albus Dumbledore", "Voldemort", "Harry Potter" };
        // When
        var result = Queries.getRowlingNamesSQL(wizards);

        // Then
        Assert.Equal(listOfRowlingNames, result);
    }
    [Fact]
    public void AlbD_Vol_HarryP_is_the_only_wizards_from_Rowling_EXT()
    {
        // Given
        var wizards = WizardCollection.Create();
        var listOfRowlingNames = new string[] { "Albus Dumbledore", "Voldemort", "Harry Potter" };
        // When
        var result = Queries.getRowlingNamesExt(wizards);

        // Then
        Assert.Equal(listOfRowlingNames, result);
    }

    [Fact]
    public void The_first_sith_lord_should_be_from_1977_SQL()
    {
        // Given
        var wizards = WizardCollection.Create();
        var shouldBe = 1977;

        // When
        var result = Queries.getFirstSithLordYearSQL(wizards);

        // Then
        Assert.Equal(shouldBe, result);
    }
    [Fact]
    public void The_first_sith_lord_should_be_from_1977_EXT()
    {
        // Given
        var wizards = WizardCollection.Create();
        var shouldBe = 1977;

        // When
        var result = Queries.getFirstSithLordYearEXT(wizards);

        // Then
        Assert.Equal(shouldBe, result);
    }

    [Fact]
    public void List_of_HP_wizards_names_and_year_SQL()
    {
        // Given
        var wizards = WizardCollection.Create();
        var shouldBe = new List<Tuple<string, int?>> {
            Tuple.Create<string, int?>("Albus Dumbledore", 2001),
            Tuple.Create<string, int?>("Voldemort", 2001),
            Tuple.Create<string, int?>("Harry Potter", 2001)
            };

        // When
        var result = Queries.getListOfWizardsAndYearSQL(wizards);

        // Then
        Assert.Equal(shouldBe, result);
    }
    [Fact]
    public void List_of_HP_wizards_names_and_year_EXT()
    {
        // Given
        var wizards = WizardCollection.Create();
        var shouldBe = new List<Tuple<string, int?>> {
            Tuple.Create<string, int?>("Albus Dumbledore", 2001),
            Tuple.Create<string, int?>("Voldemort", 2001),
            Tuple.Create<string, int?>("Harry Potter", 2001)
            };

        // When
        var result = Queries.getListOfWizardsAndYearEXT(wizards);

        // Then
        Assert.Equal(shouldBe, result);
    }





    [Fact]
    public void List_wiz_names_grouped_by_creator_in_reverse_then_wiz_name_SQL()
    {
        // Given
        var wizards = WizardCollection.Create();
        var shouldBe = new string[][]
        {
            new string[] { "Scarlet Witch"},
            new string[] { "Gandalf", "Sauron"},
            new string[] { "Albus Dumbledore", "Harry Potter", "Voldemort"},
            new string[] { "Darth Vader"},
            new string[] { "Jafar"},
            new string[] { "The White Witch"},
            new string[] { "Merlin"},
            };
        // When
        var result = Queries.grpAndSortWizSQL(wizards);

        // Then
        Assert.Equal(shouldBe, result);
    }


    [Fact]
    public void List_wiz_names_grouped_by_creator_in_reverse_then_wiz_name_EXT()
    {
        // Given
        var wizards = WizardCollection.Create();
        var shouldBe = new string[][]
        {
            new string[] { "Scarlet Witch"},
            new string[] { "Gandalf", "Sauron"},
            new string[] { "Albus Dumbledore", "Harry Potter", "Voldemort"},
            new string[] { "Darth Vader"},
            new string[] { "Jafar"},
            new string[] { "The White Witch"},
            new string[] { "Merlin"},
            };
        // When
        var result = Queries.grpAndSortWizEXT(wizards);

        // Then
        Assert.Equal(shouldBe, result);
    }









}

