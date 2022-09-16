namespace Assignment2.Tests;
public class LibraryTest
{

    [Fact]
    public void Check_if_student_who_started_in_2019_and_graduate_in_2023_should_be_active()
    {
        // Given
        var stud = new Library.Student(id: 1, givenName: "Ole", surname: "Hansen", Status: Status.Active, startDate: new DateTime(2019, 03, 01), endDate: new DateTime(2023, 08, 01), graduationDate: new DateTime(2023, 07, 01));
        var shouldBe = Status.Active;
        // When
        var result = stud.GetStatus(DateTime.Now);

        // Then
        Assert.Equal(shouldBe, result);
    }

    [Fact]
    public void Check_if_toString_works_correctly_and_nice()
    {
        // Given
        var stud = new Library.Student(id: 1, givenName: "Ole", surname: "Hansen", Status: Status.Active, startDate: new DateTime(2019, 03, 01), endDate: new DateTime(2023, 08, 01), graduationDate: new DateTime(2023, 07, 01));
        var shouldBe = "Student Id: 1, Name: Ole Hansen, Status: Active, Start Date: 1/3/2019, End Date: 1/8/2023, Graduates: 1/7/2023";
        // When
        string result = stud.ToString();

        // Then
        Assert.Equal(shouldBe, result);
    }





}