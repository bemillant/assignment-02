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
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            this.status = Status;
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;
        }

        public Status GetStatus(DateTime now)
        {
            if (DateTime.Compare(now, this.startDate) == 0)
            {
                return Status.New;
            }
            else if (DateTime.Compare(now, this.startDate) > 0 && DateTime.Compare(now, this.endDate) < 0 && !graduationDate.Equals(null))
            {
                return Status.Active;
            }
            else if (DateTime.Compare(now, this.graduationDate) > 0)
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
            var date1 = this.startDate.Day.ToString() + "/" + this.startDate.Month.ToString() + "/" + this.startDate.Year.ToString();
            var date2 = this.endDate.Day.ToString() + "/" + this.endDate.Month.ToString() + "/" + this.endDate.Year.ToString();
            var date3 = this.graduationDate.Day.ToString() + "/" + this.graduationDate.Month.ToString() + "/" + this.graduationDate.Year.ToString();

            return "Student Id: " + this.id + ", Name: " + this.givenName + " " + this.surname + ", Status: " + this.status + ", Start Date: " + date1 + ", End Date: " + date2 + ", Graduates: " + date3;

        }



        //Useing init instead of set in order to not be able to update the value.
        //Only able to set the ID when initialising
        public int id { get; init; }
        public string givenName { get; set; }
        public string surname { get; set; }
        public Status status { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime graduationDate { get; set; }
    }


    public record ImmutableStudent
    {
        public ImmutableStudent(int id, string givenName, string surname, Status Status, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            this.status = Status;
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;
        }

        public Status GetStatus(DateTime now)
        {
            if (DateTime.Compare(now, this.startDate) == 0)
            {
                return Status.New;
            }
            else if (DateTime.Compare(now, this.startDate) > 0 && DateTime.Compare(now, this.endDate) < 0 && !this.graduationDate.Equals(null))
            {
                return Status.Active;
            }
            else if (DateTime.Compare(now, this.graduationDate) > 0)
            {
                return Status.Graduated;
            }
            else
            {
                return Status.Dropout;
            }


        }

        // public override string ToString()
        // {
        //     var date1 = this.startDate.Day.ToString() + "/" + this.startDate.Month.ToString() + "/" + this.startDate.Year.ToString();
        //     var date2 = this.endDate.Day.ToString() + "/" + this.endDate.Month.ToString() + "/" + this.endDate.Year.ToString();
        //     var date3 = this.graduationDate.Day.ToString() + "/" + this.graduationDate.Month.ToString() + "/" + this.graduationDate.Year.ToString();

        //     return "Student Id: " + this.id + ", Name: " + this.givenName + " " + this.surname + ", Status: " + this.status + ", Start Date: " + date1 + ", End Date: " + date2 + ", Graduates: " + date3;

        // }
        public int id { get; init; }
        public string givenName { get; init; }
        public string surname { get; init; }
        public Status status { get; init; }
        public DateTime startDate { get; init; }
        public DateTime endDate { get; init; }
        public DateTime graduationDate { get; init; }
    }



}