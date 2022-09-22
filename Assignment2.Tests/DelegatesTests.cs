namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void String_input_should_be_put_in_reverse()
    {
        //Given
        var str = "Hej med dig hedder du kaj";
        var shouldBe = "jakudreddehgiddemjeH";
        Delegates.StringDel handler = Delegates.DeleReverseMethod;

        //When 
        var result = handler(str);

        //Then
        shouldBe.Should().BeEquivalentTo(result);

    }


    [Fact]
    public void adding_two_decimals_to_return_the_product()
    {
        // Given
        Decimal num1 = new decimal(0.3);
        Decimal num2 = new decimal(0.9);
        Decimal shouldBe = new decimal(0.27);
        Delegates.DecimalDel handler = Delegates.ProductCalc;

        // When
        var result = handler(num1, num2);

        // Then
        Assert.Equal(shouldBe, result);
    }

    [Fact]
    public void Is_the_int_42_the_same_as_the_string_0042_should_be_yes()
    {
        // Given
        string toTest = " 0042";
        int num = 42;
        var shouldBe = true;
        Delegates.BoolDel handler = Delegates.isStringSameAsNum;

        // When
        var result = handler(toTest, num);

        // Then
        Assert.Equal(shouldBe, result);
    }



}
