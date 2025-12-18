
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnager
{
    public class Teacher : Person
    {
        public string PhonNumber { get; set; }
        public string Locatioan { get; set; }
        public Field_Of_Study Study { get; set; }
        public static OperionResult IsValidinput(string firstName, string lastName, string location, string phoneNumber, string nationalCode)
        {
            if (string.IsNullOrEmpty(firstName))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = "کادر نام پر کنید"
                };
            else if (string.IsNullOrEmpty(lastName))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = "کادر نام خوانوادگی را پرکنید"
                };
            else if (string.IsNullOrEmpty(location))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = "آدرس خود را درست وارد کنید"
                };
            else if (string.IsNullOrEmpty(nationalCode))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = "کد ملی خود را درست وارد کنید"
                };
            else if (string.IsNullOrEmpty(phoneNumber))
                return new OperionResult
                {
                    IsSuccess =false,
                    Message="شماره همراه خود را وارد کنید"
                };
            return new OperionResult
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد"
            };
        }
    }
}
