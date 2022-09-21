namespace Assignment2.Tests;



public class ExtensionsTests
{
    [Fact]
    public void xs_Flatten_streams_1_2_and_3_4_and_5_6_return_stream_1_2_3_4()
    {
        // Given
        var stream1 = new int[] { 1, 2 };
        var stream2 = new int[] { 3, 4 };
        var stream3 = new int[] { 5, 6 };
        IEnumerable<int>[] xs = new int[][] { stream1, stream2, stream3 };
        // When
        var flattenStream = xs.SelectMany(xs => xs);

        // Then
        Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6 }, flattenStream);
    }

    [Fact]
    public void ys_filter_numbers_only_divisible_by_7_and_greater_than_42()
    {
        //Given
        var ys = new int[100];
        for (int i = 0; i < ys.Length; i++)
        {
            ys[i] = i;
        }
        var shouldBe = new int[] { 42, 49, 56, 63, 70, 77, 84, 91, 98 };

        // When
        var filteredYs = ys.Where(y => y % 7 == 0 && y >= 42).ToArray();

        //Then
        Assert.Equal(shouldBe, filteredYs);
    }


    [Fact]
    public void ys_filter_number_from_1900_to_2022_that_are_leap_year()
    {
        //Given
        var ys = new int[123];
        int i = 0;
        for (int j = 1900; j < 2023; j++)
        {
            ys[i++] = j;
        }
        var shouldBe = new int[] { 1904, 1908, 1912, 1916, 1920, 1924, 1928, 1932, 1936, 1940, 1944, 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980, 1984, 1988, 1992, 1996, 2000, 2004, 2008, 2012, 2016, 2020 };

        // When
        var filteredYs = ys.Where(y => DateTime.IsLeapYear(y)).ToArray();

        //Then
        Assert.Equal(shouldBe, filteredYs);

    }



    [Fact]
    public void check_if_url_is_secure_should_be_true()
    {
        //Given

        Uri url = new Uri("https://www.google.dk/");
        bool shouldBe = true;

        //When
        bool result = url.isSecure();


        //Then

        Assert.Equal(shouldBe, result);
    }

    [Fact]
    public void check_how_many_words_in_string_should_return_5()
    {
        // Given
        string countMe = "Hej med dig  din      flotte";
        int shouldBe = 5;
        // When

        int result = countMe.wordCount();
        // Then
        Assert.Equal(shouldBe, result);
    }



}
