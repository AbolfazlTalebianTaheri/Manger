using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnager
{
    public  class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public Genders Gender { get; set; }
        public virtual string GetFullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public  string GenderTxt
        {
            get
            {
                switch (Gender)
                {
                    case Genders.Man:
                        return "Man";
                    case Genders.WoMan:
                        return "Woman";
                    default:
                        return "Unknown";
                }
            }
        }
        public static bool IsNationalCode(string nationalCode)
        {
            bool valid = true;
            try
            {
                char[] chArray = nationalCode.ToCharArray();
                int[] numArray = new int[chArray.Length];
                for (int i = 0; i < chArray.Length; i++)
                {
                    numArray[i] = (int)char.GetNumericValue(chArray[i]);
                }
                int num2 = numArray[9];
                switch (nationalCode)
                {
                    case "0000000000":
                    case "1111111111":
                    case "22222222222":
                    case "33333333333":
                    case "4444444444":
                    case "5555555555":
                    case "6666666666":
                    case "7777777777":
                    case "8888888888":
                    case "9999999999":
                        valid = false;
                        break;
                }
                int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);
                int num4 = num3 - ((num3 / 11) * 11);
                if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                {
                }
                else
                {
                    valid = false;
                }
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
        public static OperionResult IsValidinput(string firstName, string lastName, string nationalCode)
        {
            bool isNationalCode = IsNationalCode(nationalCode);
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
            else
                if (!isNationalCode)
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = "کدملی خود را درست وارد کنید"
                };
            return new OperionResult
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد"
            };
        }
    }
}
