namespace Assignment2;

public enum Status
{
    New,
    Active,
    Dropout,
    Graduated

}
public class Library
{




    public class Student
    {
        public Student(int id, string givenName, string surname, Status Status, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            Id = id;
            GivenName = givenName;
            Surname = surname;
            this.Status = Status;
            StartDate = startDate;
            EndDate = endDate;
            GraduationDate = graduationDate;
        }

        public Status GetStatus(DateTime now)
        {
            if (DateTime.Compare(now, this.StartDate) == 0)
            {
                return Status.New;
            }
            else if (DateTime.Compare(now, this.StartDate) > 0 && DateTime.Compare(now, this.EndDate) < 0)
            {
                return Status.Active;
            }
            else if (DateTime.Compare(now, this.GraduationDate) > 0)
            {
                return Status.Graduated;
            }
            else
            {
                return Status.Dropout;
            }

        }

        public override string ToString()
        {
            var date1 = this.StartDate.Day.ToString() + "/" + this.StartDate.Month.ToString() + "/" + this.StartDate.Year.ToString();
            var date2 = this.EndDate.Day.ToString() + "/" + this.EndDate.Month.ToString() + "/" + this.EndDate.Year.ToString();
            var date3 = this.GraduationDate.Day.ToString() + "/" + this.GraduationDate.Month.ToString() + "/" + this.GraduationDate.Year.ToString();

            return "Student Id: " + this.Id + ", Name: " + this.GivenName + " " + this.Surname + ", Status: " + this.Status + ", Start Date: " + date1 + ", End Date: " + date2 + ", Graduates: " + date3;

        }



        //Useing init instead of set in order to not be able to update the value.
        //Only able to set the ID when initialising
        public int Id { get; init; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public Status Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }
    }

}