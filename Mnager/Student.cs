namespace Mnager
{
    public class Student : Person
    {
        public int StudentCode { get; set; }
        public string Grade { get; set; }
        private string GetInformatioanStudent()
        {
            string name = FirstName;
            string lastName = LastName;
            string studentCode = StudentCode.ToString();
            string grade = Grade;
            return $"Name: {name} {lastName}, Student Code: {studentCode}, Grade: {grade}";
        }
        public override string ToString()
        {
            return GetInformatioanStudent();
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
                return GetInformatioanStudent();
            }
        }
        public static OperionResult IsValidinput(string firstName, string lastName)
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
            return new OperionResult
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد"
            };
        }
    }
}
