
var student = new Library.ImmutableStudent(id: 1, givenName: "Ole", surname: "Hansen", Status: Status.Active, startDate: new DateTime(2019, 03, 01), endDate: new DateTime(2023, 08, 01), graduationDate: new DateTime(2023, 07, 01));

Console.WriteLine(student.ToString());

// foreach (var wizard in WizardCollection.Create())
// {
//     Console.WriteLine(wizard);
// }
