namespace Mnager
{
    public class Student : Person
    {
        public int StudentCode { get; set; }
        public Grades Grade { get; set; }
        public string GetGrade { 
            get
            {
                switch (Grade)
                {
                    case Grades.Elementary:
                        return "ابتدایی";
                    case Grades.Guidance:
                        return "راهنمایی";
                    case Grades.Conservatory:
                        return "هنرستان";
                    default:
                        return "";
                }
            }
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Student Code: {StudentCode}";
        }
        override public bool Equals(object obj)
        {
            if (obj is Student otherStudent)
            {
                return StudentCode == otherStudent.StudentCode;
            }
            return false;
        }
        public override string GetFullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public static OperionResult IsValidinput(string firstName, string lastName,string nationalCode)
        {
            if (string.IsNullOrEmpty(firstName))
                return new OperionResult
                { 
                    IsSuccess = false,
                    Message = "کادر نام پر کنید"
                };
            else
            if (string.IsNullOrEmpty(lastName))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = "کادر نام خوانوادگی را پرکنید"
                };
            else
            if (string.IsNullOrEmpty(nationalCode))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = "کادر کد ملی را پرکنید"
                };
            return new OperionResult
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد"
            };
        }
    }
}
