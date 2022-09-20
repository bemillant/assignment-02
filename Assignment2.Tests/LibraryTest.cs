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

    //  ImmutableStudent:

    [Fact]
    public void Check_if_two_students_with_same_name_have_the_same_name()
    {

        // Given
        var student = new Library.ImmutableStudent(id: 1, givenName: "Ole", surname: "Hansen", Status: Status.Active, startDate: new DateTime(2019, 03, 01), endDate: new DateTime(2023, 08, 01), graduationDate: new DateTime(2023, 07, 01));
        var student2 = new Library.ImmutableStudent(id: 2, givenName: "Ole", surname: "Larsen", Status: Status.Active, startDate: new DateTime(2019, 03, 01), endDate: new DateTime(2023, 08, 01), graduationDate: new DateTime(2023, 07, 01));

        // When
        var result = student2.givenName;


        // Then
        student.givenName.Should().BeEquivalentTo(result);
    }

    [Fact]
    public void Check_if_two_students_with_same_givenName_have_different_ids_should_return_true()
    {

        // Given
        var student = new Library.ImmutableStudent(id: 1, givenName: "Ole", surname: "Hansen", Status: Status.Active, startDate: new DateTime(2019, 03, 01), endDate: new DateTime(2023, 08, 01), graduationDate: new DateTime(2023, 07, 01));
        var student2 = new Library.ImmutableStudent(id: 1, givenName: "Ole", surname: "Larsen", Status: Status.Active, startDate: new DateTime(2019, 03, 01), endDate: new DateTime(2023, 08, 01), graduationDate: new DateTime(2023, 07, 01));

        // When
        var result = student2.id;


        // Then
        student.id.Should().Be(result);
    }

    [Fact]
    public void Check_if_student_givenName_toString_works_should_be_Ole()
    {

        // Given
        var student = new Library.ImmutableStudent(id: 1, givenName: "Ole", surname: "Hansen", Status: Status.Active, startDate: new DateTime(2019, 03, 01), endDate: new DateTime(2023, 08, 01), graduationDate: new DateTime(2023, 07, 01));

        // When
        var result = student.givenName.ToString();


        // Then
        student.givenName.Should().BeEquivalentTo(result);
    }

    [Fact]
    public void Check_if_student_is_active_should_be_active()
    {

        // Given
        var student = new Library.ImmutableStudent(id: 1, givenName: "Ole", surname: "Hansen", Status: Status.Active, startDate: new DateTime(2019, 03, 01), endDate: new DateTime(2023, 08, 01), graduationDate: new DateTime(2023, 07, 01));
        // When
        var result = student.GetStatus(DateTime.Now);


        // Then
        student.status.Should().Be(result);
    }
}



